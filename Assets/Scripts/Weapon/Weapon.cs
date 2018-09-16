using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimplePlayerController
{
    public abstract class Weapon : MonoBehaviour
    {
        public int damage = 100;
        public float accuracy = 1f;
        public float range;
        public float rateOfFire = 5f;
        public GameObject projectile;
        protected int currentAmmo = 0;
        public Transform spawnPoint;
        public int ammo = 30;

        public abstract void Attack();

        public virtual void Reload()
        {
            currentAmmo = ammo;
        }
    }
}