using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingeffect2 : MonoBehaviour
{
    public Text txt;
    private string m_text = "혹시 별빛 신사리 마을에 대해 들어본 적 있어?";
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
