
using UnityEngine.EventSystems;

public class AttackEvent
{
    public PointerEventData eventData;

    public AttackEvent(PointerEventData eventData)
    {
        this.eventData = eventData;
    }
}