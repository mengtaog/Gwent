using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public void HideUI(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void ShowUI(GameObject obj, float speed = 1f, float targetAlpha = 1.0f)
    {
        obj.SetActive(true);
        CanvasGroup canvasGroup = obj.GetComponent<CanvasGroup>();
        if (null != canvasGroup)
        {
            canvasGroup.alpha = 0;
            StartCoroutine(GraduallyRevealed(canvasGroup, speed, targetAlpha));
        }
        
    }

    IEnumerator GraduallyRevealed(CanvasGroup canvasGroup, float speed ,float targetAlhpa)
    {
        while(Mathf.Abs(canvasGroup.alpha - targetAlhpa) > 0.01f)
        {
            canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, targetAlhpa, Time.deltaTime * speed); 
            yield return 0;
        }
    } 
}
