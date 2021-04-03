using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingeffect3 : MonoBehaviour
{
    public Text txt;
    private string m_text = "둘러보기 전에 먼저 일정을 확인하고 움직이자.";
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
