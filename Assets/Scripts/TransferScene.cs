using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferScene : MonoBehaviour
{
    public string transferMapName;

    private MovingObject thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<MovingObject>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            thePlayer.currentMapName = transferMapName;
            SceneManager.LoadScene(transferMapName);
        }
    }

}
