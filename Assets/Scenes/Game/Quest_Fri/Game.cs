using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //1단계 정답
    public void Yes1()
    {
        SceneManager.LoadScene("2Game");
    }
    //1단계 오답
    public void No1()
    {
        SceneManager.LoadScene("WrongGame");
    }
    //2단계 정답
    public void Yes2()
    {
        SceneManager.LoadScene("3Game");
    }
    //2단계 오답
    public void No2()
    {
        SceneManager.LoadScene("WrongGame");
    }
    //3단계 정답
    public void Yes3()
    {
        SceneManager.LoadScene("4Game");
    }
    //3단계 오답
    public void No3()
    {
        SceneManager.LoadScene("WrongGame");
    }
    //4단계 정답
    public void Yes4()
    {
        SceneManager.LoadScene("5Game");
    }
    //4단계 오답
    public void No4()
    {
        SceneManager.LoadScene("WrongGame");
    }
    //1단계로 돌아가기
    public void Back2()
    {
        SceneManager.LoadScene("1-1Game");
    }
    //2단계로 돌아가기
    public void Back3()
    {
        SceneManager.LoadScene("2Game");
    }
    //3단계로 돌아가기
    public void Back4()
    {
        SceneManager.LoadScene("3Game");
    }
    //4단계로 돌아가기
    public void Back5()
    {
        SceneManager.LoadScene("4Game");
    }
    //마지막 5단계 완성
    public void Yes5()
    {
        SceneManager.LoadScene("6Game");
    }
    //다음 게임으로 이동
    public void GoNext()
    {
        //SceneManager.LoadScene("4Game");
    }
}
