using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class typingeffect : MonoBehaviour
{
    public Text txt;
    private string m_text = "안녕! 나는 이번에 별빛 신사리 마을에 이사 오게 된 유감자라고 해";
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {
        //yield return new WaitForSeconds(2f);
        for(int i=0; i<= m_text.Length; i++)
        {
            txt.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.07f);
        }
    }
}
