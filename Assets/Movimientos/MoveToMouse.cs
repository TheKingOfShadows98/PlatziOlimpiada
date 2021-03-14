using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    Vector3 mousePosition;
    public float t;


    void Update()
    {
        mousePosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0f);
        transform.position = Vector3.Lerp(transform.position, mousePosition, t * Time.deltaTime);
    }
}
