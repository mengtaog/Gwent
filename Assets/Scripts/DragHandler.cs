using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

    public PlayerController pc;
    public RectTransform SourceLayout;
    public GameObject PotentialParent;



    public void OnBeginDrag(PointerEventData eventData)
    {
        //print(this);
        SourceLayout = transform.parent.GetComponent<RectTransform>();
        SetDraggedPosition(eventData);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        SetDraggedPosition(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        SetDraggedPosition(eventData);
        LayoutRebuilder.ForceRebuildLayoutImmediate(SourceLayout);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    private void SetDraggedPosition(PointerEventData eventData)
    {
        var rt = gameObject.GetComponent<RectTransform>();
        // transform the screen point to world point int rectangle
        Vector3 globalMousePos;
        //把屏幕坐标转换为UGUI对应的坐标
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, eventData.position, eventData.pressEventCamera, out globalMousePos)) rt.position = globalMousePos;
       
    }

    public void setNewParent()
    {
        if (PotentialParent == null) return;
        this.transform.SetParent(PotentialParent.transform);
    }
        
    
}

