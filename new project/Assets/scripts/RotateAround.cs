using UnityEngine;

public class RotateAround : MonoBehaviour
{

    public Transform centerPoint;

    // snelheid graden
    public float orbitSpeed = 30f;

    // zodat we zeker weten wat er afstand is tussen object (boo) en center punt
    public float startOffsetX = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // zet start pos object (boo) 
        transform.position = centerPoint.position + new Vector3(startOffsetX, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        //roteren rond y as
        transform.RotateAround(centerPoint.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
