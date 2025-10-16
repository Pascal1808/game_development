using TMPro;
using UnityEngine;

public class CollectObject : MonoBehaviour
{

    public float respawnTime = 3f;
    public TextMeshProUGUI feedbackText;
    public TextMeshProUGUI coinsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // kijkt of de tag gelijk is aan "Player"
            feedbackText.text = "Hey, ik verzamelde een "+ gameObject.tag;
            // tel verzamelde coins en bewaar in variabel
            GlobalSettings.instance.coinsCollected++;
            // update textfield
            coinsText.text = "x "+GlobalSettings.instance.coinsCollected;
            gameObject.SetActive(false);
            // we willen de coin even onzichtbaar maken
            Invoke(nameof(Respawn), 3f);
        }
    }

    void Respawn()
    {
        // We maken het gameobject weer zichtbaar
        gameObject.SetActive(true);
    }
}
