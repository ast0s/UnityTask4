using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class NestedScrollRect : ScrollRect
{
    [Header("Additional Fields")]
    [SerializeField]
    ScrollRect parentScrollRect;

    bool routeToParent = false;

    public override void OnInitializePotentialDrag(PointerEventData eventData)
    {
        if (parentScrollRect != null)
        {
            ((IInitializePotentialDragHandler)parentScrollRect).OnInitializePotentialDrag(eventData);
        }
        base.OnInitializePotentialDrag(eventData);
    }

    public override void OnDrag(PointerEventData eventData)
    {
        if (routeToParent)
        {
            if (parentScrollRect != null)
            {
                ((IDragHandler)parentScrollRect).OnDrag(eventData);
            }
        }
        else
        {
            base.OnDrag(eventData);
        }
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        if (!horizontal && Math.Abs(eventData.delta.x) > Math.Abs(eventData.delta.y))
        {
            routeToParent = true;
        }
        else if (!vertical && Math.Abs(eventData.delta.x) < Math.Abs(eventData.delta.y))
        {
            routeToParent = true;
        }
        else
        {
            routeToParent = false;
        }

        if (routeToParent)
        {
            if (parentScrollRect != null)
            {
                ((IBeginDragHandler)parentScrollRect).OnBeginDrag(eventData);
            }
        }
        else
        {
            base.OnBeginDrag(eventData);
        }
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        if (routeToParent)
        {
            if (parentScrollRect != null)
            {
                ((IEndDragHandler)parentScrollRect).OnEndDrag(eventData);
            }
        }
        else
        {
            base.OnEndDrag(eventData);
        }
        routeToParent = false;
    }
}
