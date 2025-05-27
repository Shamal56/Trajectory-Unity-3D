using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    public Vector3 launchVelocity = new Vector3(5f, 10f, 0f);
    public float restitution = 0.8f;
    private float velocityLimiter = 0.01f;

    private Vector3 velocity;
    private Vector3 gravity = new Vector3(0f, -9.81f, 0f);
    private bool isMoving = true;
    // Start is called before the first frame update
    void Start()
    {
        velocity = launchVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
            return;

        velocity += gravity * Time.deltaTime;

        transform.position += velocity * Time.deltaTime;

        if (transform.position.y <= 0.496f && velocity.y < 0f)
        {
           float y = velocity.y;
            velocity.y *= -restitution;
            Vector3 position = transform.position;
            position.y = 0.496f;
            transform.position = position;

            if (Mathf.Abs(velocity.y / y) < velocityLimiter)
            {
                isMoving = false;
                velocity = Vector3.zero;
            }
        }
    }
}
