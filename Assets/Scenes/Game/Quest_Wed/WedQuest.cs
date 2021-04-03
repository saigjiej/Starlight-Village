using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WedQuest : MonoBehaviour
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
    //카페
    public void c1()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
    //이태리안경 
    public void g1()
    {
        SceneManager.LoadScene("Glasses3-2"); 
    }
    public void g2()
    {
        SceneManager.LoadScene("Glasses3-3");
    }
    public void g3()
    {
        SceneManager.LoadScene("Glasses3-4");
    }
   //이태리 안경 -> 안경
   public void glasses1()
    {
        SceneManager.LoadScene("Glasses3-7-1");
    }
    public void glasses2()
    {
        SceneManager.LoadScene("Glasses3-8");
    }
    public void glasses3()
    {
        SceneManager.LoadScene("Glasses3-9");
    }
    public void glasses4()
    {
        SceneManager.LoadScene("Glasses3-10");
    }
    public void glasses5()
    {
        SceneManager.LoadScene("Glasses3-11");
    }
    public void glasses6()
    {
        SceneManager.LoadScene("Glasses3-12-1");
    }
    public void glasses7()
    {
        SceneManager.LoadScene("Glasses3-6-1");
    }
    //이태리안경 -> 블루라이트 차단안경
    public void blue1()
    {
        SceneManager.LoadScene("Glasses3-7-2");
    }
    public void blue2()
    {
        SceneManager.LoadScene("Glasses3-8-2");
    }
    public void blue3()
    {
        SceneManager.LoadScene("Glasses3-9-2");
    }
    public void blue4()
    {
        SceneManager.LoadScene("Glasses3-10-2");
    }
    public void blue5()
    {
        SceneManager.LoadScene("Glasses3-11-2");
    }
    public void blue6()
    {
        SceneManager.LoadScene("Glasses3-12-2");
    }
    public void blue7()
    {
        SceneManager.LoadScene("Glasses3-6-2");
    }
    public void sun1()
    {
        SceneManager.LoadScene("Glasses3-7-3");
    }
    public void sun2()
    {
        SceneManager.LoadScene("Glasses3-8-3");
    }
    public void sun3()
    {
        SceneManager.LoadScene("Glasses3-9-3");
    }
    public void sun4()
    {
        SceneManager.LoadScene("Glasses3-10-3");
    }
    public void sun5()
    {
        SceneManager.LoadScene("Glasses3-11-3");
    }
    public void sun6()
    {
        SceneManager.LoadScene("Glasses3-12-3");
    }
    public void sun7()
    {
        SceneManager.LoadScene("Glasses3-6-1");
    }
    //Glasses3-6-1 재시작
    public void glrestart()
    {
        SceneManager.LoadScene("Glasses3-4");
    }

}
