using TMPro;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{
    // de waarde van deze string bepaald de start selectie
    public WeaponType selectedWeapon;
    public TextMeshProUGUI feedbackSelectedWeapon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = WeaponType.Sword;
            SelectWeapon(selectedWeapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedWeapon = WeaponType.Bow;
            SelectWeapon(selectedWeapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedWeapon = WeaponType.Magic;
            SelectWeapon(selectedWeapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            selectedWeapon = WeaponType.Hammer;
            SelectWeapon(selectedWeapon);
        }
    }

    // nieuwe functie voor het selecteren van weapons
    void SelectWeapon(WeaponType weapon)
    {
        switch (weapon)
        {
            case WeaponType.Sword:
                feedbackSelectedWeapon.text = "You selected the sword: strong and close range.";

                break;
            case WeaponType.Bow:
                feedbackSelectedWeapon.text = "You selected the bow: long range and fast.";
                break;
            case WeaponType.Magic:
                feedbackSelectedWeapon.text = "You selected the magic staff: powerful but uses mana";
                break;
            case WeaponType.Hammer:
                feedbackSelectedWeapon.text = "You selected the hammer: heavy, slow, but deals massive damage.";
                break;

            default:
                feedbackSelectedWeapon.text =  "Select weapon using 1-4 keys.";
                break;
        }
    }


    // Een enum (enumeration) is een lijst van vaste namen die horen bij een waarde.
    // Handig als je werkt met vaste keuzes zoals wapens, moeilijkheidsgraden of seizoenen.
    public enum WeaponType
    {
        Sword,
        Bow,
        Magic,
        Hammer
    }
}
