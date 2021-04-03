using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoardGamedata : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //프롤로그씬이동
    public void b1()
    {
        SceneManager.LoadScene("Boardgame5-2");
    }
    public void b2()
    {
        SceneManager.LoadScene("Boardgame5-3");
    }
    public void b3()
    {
        SceneManager.LoadScene("Boardgame5-4");
    }
    public void b4()
    {
        SceneManager.LoadScene("Boardgame5-5");
    }
    public void b5()
    {
        SceneManager.LoadScene("Boardgame5-6");
    }
    public void b6()
    {
        SceneManager.LoadScene("Boardgame5-7");
    }
}
