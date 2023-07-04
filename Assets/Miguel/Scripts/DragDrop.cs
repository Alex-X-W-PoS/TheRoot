using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [HideInInspector] public RectTransform rt;
    private RectTransform parent_rt;
    private Vector2 middlePoint = new Vector2(547.5f, 310f);

    private void Start()
    {
        rt = gameObject.GetComponent<RectTransform>();
        //canvas = rt.parent.GetComponent<Canvas>();

    }


    public void OnBeginDrag(PointerEventData EventData)
    {

    }

    public void OnDrag(PointerEventData EventData) 
    {
        if (rt.anchoredPosition.x > 0f + rt.sizeDelta.x / 2 && rt.anchoredPosition.x < 1090f - rt.sizeDelta.x / 2 &&
            rt.anchoredPosition.y > 0f + rt.sizeDelta.y / 2 && rt.anchoredPosition.y < 620f - rt.sizeDelta.y / 2)
        { 
            rt.anchoredPosition += EventData.delta;
            transform.SetAsLastSibling();
        }
        else
        {
            float despX = ((rt.anchoredPosition.x - middlePoint.x) <= 0f) ? 1f : -1f;
            float despY = ((rt.anchoredPosition.y - middlePoint.y) <= 0f) ? 1f : -1f;
            rt.anchoredPosition += new Vector2(despX, despY);
        }
        
    }

    public void OnEndDrag(PointerEventData EventData) 
    { 

    }

    public void OnPointerDown(PointerEventData EventData)
    {

    }
}
