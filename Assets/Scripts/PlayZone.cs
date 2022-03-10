using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayZone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        DragAndDrop obj = eventData.pointerDrag.GetComponent<DragAndDrop>();
        Card card = obj.GetComponent<Card>();
        if (obj != null && card.cardData.cost < 4 && GameController.instance.manaAmount > 0) 
        {
            obj.originalPosition = this.transform;
            GameController.instance.manaAmount -= card.cardData.cost;
        }
        else
        {
            obj.transform.SetParent(obj.originalPosition);
        }
        Debug.Log("Play Zone");
    }
}