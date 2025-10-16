using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public float rotationspeed = 20.0f;
    // Start is called oncf before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotationspeed);
    }
}
