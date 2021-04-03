using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SunQuest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Glasses
    public void g1()
    {
        SceneManager.LoadScene("Glasses7-2");
    }
    public void g2()
    {
        SceneManager.LoadScene("Glasses7-3");
    }
    public void g3()
    {
        SceneManager.LoadScene("Glasses7-4");
    }
    public void g4()
    {
        SceneManager.LoadScene("Glasses7-5");
    }
    public void g5()
    {
        SceneManager.LoadScene("Glasses7-6");
    }
    public void g6()
    {
        SceneManager.LoadScene("Glasses7-7");
    }
    public void g7()
    {
        SceneManager.LoadScene("Glasses7-8");
    }
    public void g8_1()
    {
        SceneManager.LoadScene("Glasses7-9");
    }
    public void g8_2()
    {
        SceneManager.LoadScene("Glasses7-9-2");
    }
    public void g8_3()
    {
        SceneManager.LoadScene("Glasses7-9-3");
    }
    public void success()
    {
        SceneManager.LoadScene("Glasses7-11");
    }
    public void g11()
    {
        SceneManager.LoadScene("FinishQuest");
    }
    public void fail()
    {
        SceneManager.LoadScene("Glasses7-10");
    }
    public void restart()
    {
        SceneManager.LoadScene("Glasses7-8");
    }
    public void finishQuest()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //Cafe
    public void c1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //Boardgame
    public void b1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //Stew
    public void st1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //ricecake
    public void ri1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //Spicyrips
    public void sp1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //ramen
    public void ra1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
}
