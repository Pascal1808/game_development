using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public TextMeshProUGUI feedbackText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis is een functie van Unity waarmee je invoer van de speler ophaalt.
        //Het geeft een float-waarde tussen -1 en 1 terug, afhankelijk van welke toets of controller gebruikt wordt.

        float moveX = Input.GetAxis("Horizontal"); // A/D of pijltjes links/rechts
        float moveY = Input.GetAxis("Vertical");   // W/S of pijltjes omhoog/omlaag

        // gebruik y als je omhoog/beneden wilt, z voor/achter
        Vector3 movement = new Vector3(moveX, 0f, moveY);
        transform.Translate(movement * speed * Time.deltaTime);

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        //feedbackText.text = "Hey, ik bots tegen de " + collision.gameObject.name;
    }
}
