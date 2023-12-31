using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBall : MonoBehaviour

{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = PointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position-transform.position;

        if( currentPoint == PointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);

        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);

        }
        if( Vector2.Distance(transform.position, currentPoint.position) < 1f && currentPoint == PointB.transform)
        {
            currentPoint = PointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 1f && currentPoint == PointA.transform)
        {
            currentPoint = PointB.transform;
        }
    }
}
