using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Player player;

    private int weaponIndex = 0;
    private void Start()
    {
        player.SelectWeapon(weaponIndex);
    }

    private void Update()
    {
        WeaponSwitch();

        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        player.Move(inputH, inputV);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();
        }
        if (Input.GetMouseButtonDown(0))
        {
            player.Attack();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.Interact();
        }
    }
    private void WeaponSwitch()
    {
        int currentIndex = weaponIndex;
        // If Q is pressed && weaponIndex > 0
        if (Input.GetKeyDown(KeyCode.Q) && weaponIndex > 0)
        {
            //decrement current index
            currentIndex--;
        }
        // If E is pressed && weaponIndex <= length
        if (Input.GetKeyDown(KeyCode.E) && weaponIndex <= player.weapons.Length)
        {
            //Increase current index
            currentIndex++;
        }
        if (currentIndex != weaponIndex)
        {
            weaponIndex = currentIndex;
            player.SelectWeapon(weaponIndex);
        }
    }
}
