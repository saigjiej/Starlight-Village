using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingNo2 : MonoBehaviour
{
    public Text txt;
    private string m_text = "이사 온 첫날 이기도 하고 다음주에는 학교도 가니까! 이 곳을 둘러보려고 하는데 어때, 같이 가볼래?";
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
