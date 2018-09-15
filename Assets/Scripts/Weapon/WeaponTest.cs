using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTest : MonoBehaviour
{
    public int magCap = 30;
    public int curAmmo;
    public Animator reloadAnimation;
    public float damage;
    public GameObject bullet;
    public float rof = 10f;
    public float bulletCount = 1f;
    public bool canFire;

	void Start ()
    {
        curAmmo = magCap;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (canFire)
        {
            Fire();
        }
	}
    void Fire()
    {
        // Fire button pressed
        if (Input.GetMouseButtonDown(0))
        {
            //If curAmmo <= 0
            //  Reload
            //else
            //  Shoot bullet
        }

        // Reload button pressed
        if (Input.GetKey(KeyCode.R) && curAmmo >= 0 && curAmmo != 30)
        {
            // Reloads the weapon
            Reload();
        }

    }
    void Reload()
    {
        reloadAnimation.SetTrigger("Reload");
        curAmmo = magCap;
        
    }
}
