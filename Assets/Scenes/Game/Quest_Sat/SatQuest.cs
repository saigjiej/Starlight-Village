using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SatQuest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //부대찌개
    public void st1()
    {
        SceneManager.LoadScene("Stew6-2");
    }
    public void st2()
    {
        SceneManager.LoadScene("Stew6-3");
    }
    public void st3()
    {
        SceneManager.LoadScene("Stew6-4");
    }
    public void st4()
    {
        SceneManager.LoadScene("Stew6-5");
    }
    public void st5()
    {
        SceneManager.LoadScene("Stew6-6");
    }
    public void st6()
    {
        SceneManager.LoadScene("Stew6-7");
    }
    public void st7()
    {
        SceneManager.LoadScene("Stew6-8");
    }
    public void st8()
    {
        SceneManager.LoadScene("Stew6-9");
    }
    public void st9()
    {
        SceneManager.LoadScene("FinishQuest"); 
    }
    public void FinishQuest()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //맵당
    public void sp1()
    {
        SceneManager.LoadScene("Spicyrips6-2");
    }
    public void sp2()
    {
        SceneManager.LoadScene("Spicyrips6-3");
    }
    public void sp3()
    {
        SceneManager.LoadScene("Spicyrips6-4");
    }
    public void sp4()
    {
        SceneManager.LoadScene("Spicyrips6-5");
    }
    public void sp5()
    {
        SceneManager.LoadScene("ServeQuest");
    }

    //신사리떡볶이
    public void ri1()
    {
        SceneManager.LoadScene("Ricecake6-2");
    }
    public void ri2()
    {
        SceneManager.LoadScene("Ricecake6-3");
    }
    public void ri3()
    {
        SceneManager.LoadScene("Ricecake6-4");
    }
    public void ri4()
    {
        SceneManager.LoadScene("Ricecake6-5");
    }
    public void ri5()
    {
        SceneManager.LoadScene("Ricecake6-6");
    }
    public void ri6()
    {
        SceneManager.LoadScene("Ricecake6-7");
    }
    public void ri7()
    {
        SceneManager.LoadScene("ServeQuest");
    }
    //틈새라면
    public void ra1()
    {
        SceneManager.LoadScene("Ramen6-2");
    }
    public void ra2()
    {
        SceneManager.LoadScene("Ramen6-3");
    }
    public void ra3()
    {
        SceneManager.LoadScene("Ramen6-4");
    }
    public void ra4()
    {
        SceneManager.LoadScene("Ramen6-5");
    }
    public void ra5()
    {
        SceneManager.LoadScene("Ramen6-6");
    }
    public void ra6()
    {
        SceneManager.LoadScene("Ramen6-7");
    }
    public void ra7()
    {
        SceneManager.LoadScene("ServeQuest"); 
    }
    public void ServeQuest()
    {
        //SceneManager.LoadScene("");이전 위치로 이동
    }

    //카페베네
    public void c1()
    {
        SceneManager.LoadScene("Cafe6-2");
    }
    public void c2()
    {
        SceneManager.LoadScene("Cafe6-3");
    }
    public void c3()
    {
        SceneManager.LoadScene("Cafe6-4");
    }
    public void c4()
    {
        SceneManager.LoadScene("Cafe6-5");
    }
    public void c5_1()
    {
        SceneManager.LoadScene("Cafe6-6-1");
    }
    public void c5_2()
    {
        SceneManager.LoadScene("Cafe6-6-2");
    }
    public void c5_3()
    {
        SceneManager.LoadScene("Cafe6-6-3");
    }
    public void c5_4()
    {
        SceneManager.LoadScene("Cafe6-7");
    }
    public void c6()
    {
        SceneManager.LoadScene("Cafe6-5"); //다시 음료 선택
    }
    public void c7()
    {
        SceneManager.LoadScene("FinishQuest2");
    }
    public void FinishQuest2()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
}
