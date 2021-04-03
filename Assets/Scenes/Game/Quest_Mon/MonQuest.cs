using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonQuest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Cafe
    public void c1()
    {
        SceneManager.LoadScene("Cafe1-2");
    }
    public void c2()
    {
        SceneManager.LoadScene("Cafe1-3");
    }
    public void c3()
    {
        SceneManager.LoadScene("Cafe1-4");
    }
    public void c4()
    {
        SceneManager.LoadScene(""); //게임맵 전 화면으로 이동
    }

    //BoardGame
    public void b1()
    {
        SceneManager.LoadScene("BoardGame1-2");
    }
    public void b2()
    {
        SceneManager.LoadScene("");//게임맵 전 화면으로 이동
    }

    //Glasses
    public void g1()
    {
        SceneManager.LoadScene("Glasses1-2");
    }
    public void g2()
    {
        SceneManager.LoadScene("Glasses1-3");
    }
    public void g3()
    {
        SceneManager.LoadScene("Glasses1-4");
    }
    public void g4()
    {
        SceneManager.LoadScene("Glasses1-5");
    }
    public void g5()
    {
        SceneManager.LoadScene("");//게임맵 전 화면으로 이동
    }

    //Ramen
    public void ra1()
    {
        SceneManager.LoadScene("Ramen1-2");
    }
    public void ra2()
    {
        SceneManager.LoadScene("Ramen1-3");
    }
    public void ra3()
    {
        SceneManager.LoadScene("Ramen1-4");
    }
    public void ra4()
    {
        SceneManager.LoadScene("Ramen1-5");
    }
    public void ra5()
    {
        SceneManager.LoadScene("");//게임맵 전 화면으로 이동
    }

    //Ricecake
    public void ri1()
    {
        SceneManager.LoadScene("Ricecake1-2");
    }
    public void ri2()
    {
        SceneManager.LoadScene("");//게임맵 전 화면으로 이동
    }

    //Spicyrips
    public void sp1()
    {
        SceneManager.LoadScene("Spicyrips1-2");
    }
    public void sp2()
    {
        SceneManager.LoadScene("");//게임맵 전 화면으로 이동
    }

    //Stew
    public void st1()
    {
        SceneManager.LoadScene("");//게임맵 전 화면으로 이동
    }
}
