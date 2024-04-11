using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagelMover : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 direction = Vector3.right;
    public float distanceToTravel = 50f;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (Vector3.Distance(startPosition, transform.position) >= distanceToTravel)
        {
            Destroy(gameObject);
        }
    }
}
