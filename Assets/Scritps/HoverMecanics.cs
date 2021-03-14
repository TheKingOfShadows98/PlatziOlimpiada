using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverMecanics : MonoBehaviour
{
    
    public float max_radius;
    
    public float min_radius;
    public bool hover;

    Vector3 mousePosition;

    public Animator anim;


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, max_radius);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, min_radius);
    }

    private void Awake()
    {
        transform.localScale = Vector3.one * min_radius;
    }

    void Update()
    {
        var radio = transform.localScale.x;
        #region MOUSE_HOVER
        mousePosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0f);
        if (Vector3.Distance(mousePosition, transform.position) <= transform.localScale.x)
        {
            hover = true;
        }
        else
        {
            hover = false;
        }
        #endregion
        if (hover)
        {
            transform.localScale = Vector3.one * Mathf.Lerp(radio, max_radius, 9f * Time.deltaTime);
        }
        else
        {
           
            transform.localScale = Vector3.one * Mathf.Lerp(radio, min_radius, 9f * Time.deltaTime);
        }


    }
}
