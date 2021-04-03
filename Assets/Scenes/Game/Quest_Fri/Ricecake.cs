using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ricecake : MonoBehaviour
{
    public bool check = true;
    int i = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && check)
        {
            check = false;
            print("Inside" + i++);
            StartCoroutine(WaitForIt());
            SceneManager.LoadScene("1Game");
        }
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(1.0f);
        check = true;
        
    }
    
}