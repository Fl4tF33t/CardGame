using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalPosition = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = this.transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!GameController.instance.isPlayable)
            return;
        this.transform.position += (Vector3)eventData.delta;
        Card card = GetComponent<Card>();

        foreach(GameObject hover in eventData.hovered)
        {
            BurnZone burnZone = hover.GetComponent<BurnZone>();
            if (burnZone != null)
            {
                card.burnImage.gameObject.SetActive(true);
            }
            else
            {
                card.burnImage.gameObject.SetActive(false);

            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent (originalPosition);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
}
