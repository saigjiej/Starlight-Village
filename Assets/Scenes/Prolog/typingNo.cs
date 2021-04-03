using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingNo : MonoBehaviour
{
    public Text txt;
    private string m_text = "나도 처음이야..! 내가 소문으로 듣기로는 인간 세상에 있는신림역을 본떠서 만들었대.신기하지?";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }
    IEnumerator _typing()
    {
        for (int i = 0; i <= m_text.Length; i++)
        {
            txt.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.07f);
        }
    }

    
}
