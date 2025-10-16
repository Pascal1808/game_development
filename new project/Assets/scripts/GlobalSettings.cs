using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GlobalSettings : MonoBehaviour
{
    public static GlobalSettings instance;

    public int coinsCollected = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        // Zonder Awake() of Start() om instance te vullen, blijft instance leeg.
        //Je gebruikt Awake() omdat dat garandeert dat er altijd één geldige instantie beschikbaar is zodra andere scripts hem nodig hebben.
       
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // blijft bestaan tussen scenes
        }
        else
        {
            Destroy(gameObject); // voorkom dubbele instances
        }
    }
}
