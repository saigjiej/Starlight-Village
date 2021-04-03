using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingStart : MonoBehaviour
{
    public Text txt;
    private string m_text = "안녕 ? 나는 유감자라고 해. 여기 별빛 신사리 마을은 신림역을 본떠서 만든 마을이라고 하는데 나와 같이 구경해볼래?";
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
