using UnityEngine;

public class WalkCycle : MonoBehaviour
{

    public Transform pointA;
    public Transform pointB;

    public float walkingSpeed;
    private bool facingRight = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.PingPong(Time.time * walkingSpeed, 1f);
        transform.position = Vector3.Lerp(pointA.position, pointB.position, t);

        if (t >= 0.99f && facingRight || t <= 0.01f && !facingRight)
        {
            facingRight = !facingRight;
            // 180 graden draaien rond de Y-as
            transform.Rotate(0f, 180f, 0f);
        }
    }
}
