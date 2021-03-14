using UnityEngine;
using System.Collections;

public class movetoPosition: MonoBehaviour
{

    public Transform altern;
    float max_distance;
    public Vector3 target;
    public float speed;
    Vector3 normal;
    float realSpeed;
    HoverMecanics hover;
    // Use this for initialization
    void Start()
    {
        normal = transform.position;
        max_distance = Vector3.Distance(normal, altern.position);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(hover)
        {
            target = altern.position;
        }
        else
        {
            target = normal;
        }*/
        float distancia = Vector3.Distance(transform.position, target);
        if(distancia > 0.05f)
        {
            realSpeed = (distancia / max_distance) * speed;
            Vector3.MoveTowards(transform.position, target,realSpeed * Time.deltaTime);
        }
    }
}
