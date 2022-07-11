using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ramp : MonoBehaviour, IBeginDragHandler
{
    Vector2 mouse;
    public GameObject ramp1;

    private void Start()
    {
        mouse = Input.GetTouch(0).position;
    }

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).deltaPosition.x > 0)
            {
                ramp1.transform.Rotate(Vector3.right, (mouse.x - Input.GetTouch(0).position.x) * 0.01f * Time.fixedDeltaTime);
            }
            if (Input.touches[0].deltaPosition.x < 0)
            {
                ramp1.transform.Rotate(Vector3.right, (mouse.x + Input.GetTouch(0).position.x) * 0.01f * Time.fixedDeltaTime);
            }

            if (mouse.y > Input.touches[0].deltaPosition.y)
            {
                ramp1.transform.Rotate(Vector3.up, (mouse.y - Input.GetTouch(0).position.y) * 0.1f * Time.fixedDeltaTime);
            }
            if (mouse.y < Input.touches[0].deltaPosition.y)
            {
                ramp1.transform.Rotate(Vector3.up, (mouse.y + Input.GetTouch(0).position.y) * 0.1f * Time.fixedDeltaTime);
            }
        }

        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        mouse = Input.GetTouch(0).position;
    } 
}
