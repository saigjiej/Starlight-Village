using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrologNo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void No()
    {
        SceneManager.LoadScene("PrologNo2");
    }
    public void No2()
    {
        SceneManager.LoadScene("Prolog3");
    }
}
