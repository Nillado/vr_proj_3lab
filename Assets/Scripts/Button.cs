using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public Transform player;
    public Transform cameraTransform;
    private float speed = 5f;
    private bool isPressed = false;

    void Update()
    {
        if (isPressed)
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        Vector3 forward = cameraTransform.forward;
        forward.y = 0f;
        forward.Normalize();

        player.Translate(forward * speed * Time.deltaTime, Space.World);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
   
}
