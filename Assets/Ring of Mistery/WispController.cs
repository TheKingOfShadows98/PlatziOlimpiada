using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispController : MonoBehaviour
{

    public int layerAffected;

    public bool ignore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log($"{LayerMask.LayerToName(layerAffected)} |{layerAffected} ");
            Physics2D.IgnoreLayerCollision(0, layerAffected, ignore);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Physics2D.IgnoreLayerCollision(0, layerAffected, !ignore);
        }
    }
}
