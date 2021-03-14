using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class objmovimiento : MonoBehaviour
{
    public float speed;

    public List<Transform> Path = new List<Transform>();
    public int currentpoint;
    public int nextpoint;
    // Start is called before the first frame update
    void Start()
    {
        nextpoint = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,Path[currentpoint].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, Path[currentpoint].position) < 0.05f)
        {
            NextPoint();
        }
    }

    void NextPoint()
    {
        currentpoint++;
        if ( currentpoint >= Path.Count )
        {
            currentpoint = 0;
        }

    }
}
