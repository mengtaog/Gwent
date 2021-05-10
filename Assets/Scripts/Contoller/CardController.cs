using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class CardController : MonoBehaviour
{
    public int no;
    public Text cardName;
    public Text description;
    public GameObject cardBody;
    public GameObject cardEffect;



    public abstract void CardInit();
    public abstract void setCard(Card _card);
    public abstract void PlayCard();

    public void OnCardEnter()
    {
        transform.localScale = new Vector3(2f, 2f, 2f);
    }

    public void OnCardExit()
    {
        transform.localScale = Vector3.one;
    }

    public float getProperFontSize()
    {
        Rect rect = GetComponent<RectTransform>().rect;
        return (rect.width / 271) * 40f;  
    } 

    
    
}
