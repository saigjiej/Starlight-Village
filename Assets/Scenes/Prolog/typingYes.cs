using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingYes : MonoBehaviour
{
    public Text txt;
    private string m_text = "오호 정말??? 난 처음인데 ㅠㅠ 그럼 혹시 이 곳을 함께 둘러봐줄 수 있어?";
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
