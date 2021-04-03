using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThuQuest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //맵당 퀘스트
    public void sp1()
    {
        SceneManager.LoadScene("Spicyrips4-2"); 
    }
    public void sp2()
    {
        SceneManager.LoadScene("Spicyrips4-3");
    }
    public void sp3()
    {
        SceneManager.LoadScene("Spicyrips4-4");
    }
    public void sp4()
    {
        SceneManager.LoadScene("Spicyrips4-5");
    }
    public void sp5()
    {
        SceneManager.LoadScene("Spicyrips4-6");
    }
    public void sp6()
    {
        SceneManager.LoadScene("Spicyrips4-7");
    }
    public void sp7()
    {
        SceneManager.LoadScene("Spicyrips4-8");
    }
    public void sp8()
    {
        SceneManager.LoadScene("Spicyrips4-9");
    }
    public void sp9_1()
    {
        SceneManager.LoadScene("Spicyrips4-10-1");
    }
    public void sp9_2()
    {
        SceneManager.LoadScene("Spicyrips4-10-2");
    }
    public void sp9_3()
    {
        SceneManager.LoadScene("Spicyrips4-10-2");
    }
    public void restart()
    {
        SceneManager.LoadScene("Spicyrips4-9");
    }
    public void sp10()
    {
        //SceneManager.LoadScene("");이전 위치로 이동
    }
}
