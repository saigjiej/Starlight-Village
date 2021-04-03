using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ending1()
    {
        SceneManager.LoadScene("Ending2");
    }
    public void Ending2()
    {
        SceneManager.LoadScene("Ending3");
    }
    public void Ending3()
    {
        SceneManager.LoadScene("Ending4");
    }
    public void Ending4()
    {
        SceneManager.LoadScene("Ending5");
    }
    public void Ending5()
    {
        SceneManager.LoadScene("Ending6");
    }
    public void Ending6()
    {
        SceneManager.LoadScene("Ending6-1");
    }
    public void Ending6_1()
    {
        SceneManager.LoadScene("Ending7");
    }
    public void Ending7()
    {
        SceneManager.LoadScene("Ending8");
    }
    
    public void Ending8()
    {
        SceneManager.LoadScene("Ending10");
    }
    public void Ending10()
    {
        //SceneManager.LoadScene(""); 이전 위치로 이동
    }
}
