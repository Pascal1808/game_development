using TMPro;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{

    public int health = 3;
    public Vector3 respawnPoint;

    public TextMeshProUGUI healthTextField;
    public TextMeshProUGUI feedbackTextField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillZone"))
        {
            LoseHealth();
        }
    }

    void LoseHealth()
    {
        health--;

        healthTextField.text = "x " + health;
        feedbackTextField.text = "Ouch! Health left: " + health;

        if (health < 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint;
    }


}
