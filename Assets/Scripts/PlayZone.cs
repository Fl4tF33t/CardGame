using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayZone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        DragAndDrop obj = eventData.pointerDrag.GetComponent<DragAndDrop>();
        //Card card = obj.GetComponent<Card>();
        if (obj != null)
        {
            obj.originalPosition = this.transform;
        }
        Debug.Log("Play Zone");
    }
}