using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

[RequireComponent(typeof(RectTransform))]
public class Joystick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    // the finger pointer, it usally is a circle image
    public RectTransform stick;
    // limit the drag range
    public float dragRadius = 65.0f;
    // the rate of rollback
    public float resetRate = 15.0f;
    // controll the alpha of canvas when pressed or released
    public JoystickAlphaControll canvasAlpha;

    public event Action<Joystick, Vector2> OnStartJoystickMovement;
    public event Action<Joystick, Vector2> OnJoystickMovement;
    public event Action<Joystick, Vector2> OnEndJoystickMovement;

    private bool isEnable;
    private bool isPressed;
    private bool shouldRollback;
    private Vector2 stickOffset;
    private Vector3 lastStickPositon;

    private RectTransform rootCanvas;
    private CanvasGroup canvasGroup;

    Vector2 JoystickCoordinates
    {
        get
        {
            if (stick.anchoredPosition.magnitude < dragRadius)
            {
                return stick.anchoredPosition / dragRadius;
            }
            else
            {
                return stick.anchoredPosition.normalized;
            }
        }
    }

    void Start () {
        isEnable = true;
        shouldRollback = false;
        // bind the stick and it's parent joystick
        stick.transform.SetParent(transform);
        rootCanvas = GetRootCanvas(transform);
        canvasGroup = GetComponent<CanvasGroup>();
        var touchZone = GetComponent<RectTransform>();
        touchZone.pivot = Vector2.one * 0.5f;
	}

    private RectTransform GetRootCanvas(Transform transform)
    {
        RectTransform rootCanvas = null;
        var curTransform = transform;
        do
        {
            // if the rect transform has a canvas component, it must be a canvas ui
            if (curTransform.GetComponent<Canvas>() != null)
            {
                rootCanvas = curTransform.GetComponent<RectTransform>();
                break;
            }

            // for checking the transform wheather it has a parent canvas or not.
            curTransform = transform.parent;
        }
        while (curTransform != null);
        return rootCanvas;
    }

    void FixedUpdate() {
        if (shouldRollback) // when release the finger from the window
        {
            if (stick.anchoredPosition.magnitude > Mathf.Epsilon) // the smallest distance of movement of finger
            {
                stick.anchoredPosition -= new Vector2(stick.anchoredPosition.x * resetRate, stick.anchoredPosition.y * resetRate) * Time.deltaTime;
            }
            //shouldRollback = false;
        }
        if (isEnable)
        {
            EnableJoystick();
        } else
        {
            DisableJoystick();
        }
    }
    
    private void EnableJoystick()
    {
        canvasGroup.alpha = isPressed ? canvasAlpha.pressedAlpha : canvasAlpha.idleAlpha;
        canvasGroup.interactable = canvasGroup.blocksRaycasts = true;
    }

    private void DisableJoystick()
    {
        canvasGroup.alpha = 0.0f;
        canvasGroup.interactable = canvasGroup.blocksRaycasts = false;
    }

    public Vector3 MoveInput()
    {
        return new Vector3(JoystickCoordinates.x, 0, JoystickCoordinates.y);
    }

    public void Rotate(Transform transformToRotate, float speed)
    {
        if (JoystickCoordinates != Vector2.zero)
            transformToRotate.rotation = Quaternion.Slerp(transformToRotate.rotation,
                                                          Quaternion.LookRotation(new Vector3(JoystickCoordinates.x, 0, JoystickCoordinates.y)),
                                                          speed * Time.deltaTime);
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        shouldRollback = false;
        stickOffset = CalJoystickOffset(eventData);
        stick.anchoredPosition = stickOffset;
        if (OnStartJoystickMovement != null)
        {
            OnStartJoystickMovement(this, JoystickCoordinates);
        }
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        stickOffset = CalJoystickOffset(eventData);
        stick.anchoredPosition = stickOffset;
        if (OnJoystickMovement != null)
        {
            OnJoystickMovement(this, JoystickCoordinates);
        }
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
        shouldRollback = true;
        if (OnEndJoystickMovement != null)
        {
            OnEndJoystickMovement(this, JoystickCoordinates);
        }
    }

    private Vector2 CalJoystickOffset(PointerEventData eventData)
    {
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rootCanvas, eventData.position, eventData.pressEventCamera, out lastStickPositon))
        {
            stick.position = lastStickPositon;
        }
        var handleOffset = stick.anchoredPosition;
        if (handleOffset.magnitude > dragRadius)
        {
            // reset the drag position in the drag radius range
            handleOffset = handleOffset.normalized * dragRadius;
        }
        return handleOffset;
    }
}

[Serializable]
public class JoystickAlphaControll
{
    public float idleAlpha = 0.5f;
    public float pressedAlpha = 1.0f;
}
