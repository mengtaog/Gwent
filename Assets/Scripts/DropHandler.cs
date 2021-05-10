using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public ZoneController zc;
    

    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject dragObj = eventData.pointerDrag;
        

        if (dragObj == null) return;
        DragHandler dh = eventData.pointerDrag.GetComponent<DragHandler>();
        MonsterCardController mcc = dragObj.GetComponent<MonsterCardController>();
        //SpellCard
        if (mcc == null) return;
        //if card's line property fits this row
        if (zc.isFitLine(mcc.card.line))
        {
            dh.PotentialParent = this.gameObject;
        } 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null) return;

        DragHandler dh = eventData.pointerDrag.GetComponent<DragHandler>();
        dh.PotentialParent = null;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null) return;

        DragHandler dh = eventData.pointerDrag.GetComponent<DragHandler>();
        if(dh.PotentialParent != null)
        {
            //Play Card
            zc.pc.PlayCard(eventData.pointerDrag, zc);
        }
        else 
        {
            //cancel
        }

    }
    
}
