using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prolog2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        SceneManager.LoadScene("PrologYes");
    }
    public void Click2()
    {
        SceneManager.LoadScene("PrologNo");
    }
}
