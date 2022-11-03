using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UiDotween : MonoBehaviour
{
    public float fadeTime = 1f;
    public List<GameObject> buttons = new List<GameObject>();

   
    void Start()
    {
        StartCoroutine("CoButtonAnimation");
    }

    IEnumerator CoButtonAnimation()
    {
        Debug.Log("ButtonStart!");
    
        foreach(var button in buttons)
        {
            button.transform.localScale = Vector3.zero;

        }
        foreach(var button in buttons)
        {
            button.transform.DOScale(1f, fadeTime)
                .SetEase(Ease.OutBounce);

            yield return new WaitForSeconds(0.25f);
        }
    }
}
