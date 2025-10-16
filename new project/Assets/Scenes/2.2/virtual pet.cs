using UnityEngine;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public class virtualpet : MonoBehaviour
    {
        [Header("Pet Info")]
        public string petName = "doodle";
        public string petType = "Dog";
        public int petAge = 4;

        [Header("Pet Needs")]
        public int hunger = 50;      // 0-100
        public int happiness = 70;   // 0-100
        public int energy = 80;      // 0-100

        [Header("Pet Status")]
        public bool isSleeping = false;
        public bool isHungry = false;
        public string mood = "Happy";
        public int petweight = 12;
        public bool isSick = false;

        void Start()
        {
            Debug.Log("Meet your new pet: " + petName + " the " + petType);
            Debug.Log("Age: " + petAge + " years old");
            Debug.Log("Controls: F = Feed | P = Play | S = Sleep | I = Info | W = weight | V = make sick");
            ShowPetInfo();
        }

    void Update()
    {
        // Check pet status
        if (hunger < 30)
        {
            isHungry = true;
            mood = "Hungry";
        }
        else if (energy < 20)
        {
            mood = "Tired";
        }
        else if (happiness > 80)
        {
            mood = "Very Happy";
        }
        else
        {
            mood = "Happy";
            isHungry = false;
        }

        // Input controls
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Feed pet
            if (hunger < 100)
            {
                hunger += 25;
                happiness += 10;
                Debug.Log("Fed " + petName + "! Hunger is now: " + hunger);

                if (hunger > 100) hunger = 100;
                if (happiness > 100) happiness = 100;
            }
            else
            {
                Debug.Log(petName + " is already full!");
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // Play with pet
            if (!isSleeping && energy > 10)
            {
                happiness += 20;
                energy -= 15;
                hunger -= 10;
                Debug.Log("Played with " + petName + "! Happiness: " + happiness);

                if (happiness > 100) happiness = 100;
                if (energy < 0) energy = 0;
                if (hunger < 0) hunger = 0;
            }
            else if (isSleeping)
            {
                Debug.Log(petName + " is sleeping!");
            }
            else
            {
                Debug.Log(petName + " is too tired to play!");
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            // Toggle sleep
            isSleeping = !isSleeping;

            if (isSleeping)
            {
                Debug.Log(petName + " is now sleeping...");
                energy += 30;
                if (energy > 100) energy = 100;
            }
            else
            {
                Debug.Log(petName + " woke up!");
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            // Show pet info
            ShowPetInfo();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //show pet weight
            Debug.Log(petweight + "kg");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            // make pet sick
            isSick = !isSick;
            if (!isSick)
            {
                Debug.Log(petName + " is sick");
                energy -= 10;
                happiness -= 10;
                isSick = true;
                if (energy < 0) energy = 0;
                if (happiness < 0) happiness = 0;
            }
            else
            {
                Debug.Log(petName + " is healthy");
            }
        }
                
            
            
            
            
    }

        void ShowPetInfo()
        {
            Debug.Log("=== PET STATUS ===");
            Debug.Log("Name: " + petName);
            Debug.Log("Type: " + petType);
            Debug.Log("Age: " + petAge + " years");
            Debug.Log("Mood: " + mood);
            Debug.Log("Hunger: " + hunger + "/100");
            Debug.Log("Happiness: " + happiness + "/100");
            Debug.Log("Energy: " + energy + "/100");
            Debug.Log("Sleeping: " + isSleeping);
            Debug.Log("weight: " + petweight + "kg");
            Debug.Log("==================");
        }
    }
