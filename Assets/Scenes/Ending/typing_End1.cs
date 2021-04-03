using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typing_End1 : MonoBehaviour
{
    public Text txt;
    private string m_text = "어느덧 시간이 흐르고 이제 새로운 이웃이 별빛 신사리 마을에도 이사왔다.";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {
        //yield return new WaitForSeconds(2f);
        for (int i = 0; i <= m_text.Length; i++)
        {
            txt.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.07f);
        }
    }
}
