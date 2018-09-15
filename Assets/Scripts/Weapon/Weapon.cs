using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int damage;
    public float accuracy;
    public float range;
    public float rateOfFire;
    public GameObject projectile;
    protected int currentAmmo;
    public Transform spawnPoint;
    public int ammo;
    
    public abstract void Attack();

    public void Reload()
    {
        currentAmmo = ammo;
    }
}
