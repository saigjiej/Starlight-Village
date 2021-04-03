using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TueQuest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //보드게임
    public void b1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //카페베네
    public void c1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //이태리안경
    public void g1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //틈새라면
    public void ra1()
    {
        SceneManager.LoadScene("Ramen2-2"); 
    }
    public void ra2()
    {
        SceneManager.LoadScene("Ramen2-3");
    }
    public void ra3()
    {
        SceneManager.LoadScene("Ramen2-4");
    }
    public void ra4()
    {
        SceneManager.LoadScene("Ramen2-5");
    }
    public void ra5()
    {
        SceneManager.LoadScene("Ramen2-6");
    }
    public void ra6()
    {
        SceneManager.LoadScene("Ramen2-7");
    }
    public void ra7()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //신사리떡볶이
    public void ri1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //맵당
    public void sp1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //부대찌개
    public void st1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }

    //돌발퀘스트
    public void surprise1()
    {
        SceneManager.LoadScene("Surprise2"); 
    }
    public void surprise2()
    {
        //SceneManager.LoadScene(""); 퀘스트 미션시작
    }
    public void FinishQuest()
    {
        //SceneManager.LoadScene(""); 이전 위치 혹은 집으로 이동
    }
}
