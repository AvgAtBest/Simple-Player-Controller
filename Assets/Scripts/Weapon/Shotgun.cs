using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePlayerController;

public class Shotgun : Weapon
{
    public int pellets = 420;
	public override void Attack()
    {
        for (int i = 0; i < pellets; i++)
        {
            //store forward direction of player
            Vector3 direction = transform.forward;
            //calculate offset by using spread
            Vector3 spread = Vector3.zero;
            //offset on local Y
            spread += transform.up * Random.Range(-accuracy, accuracy);
            //offset on local X
            spread += transform.right * Random.Range(-accuracy, accuracy);
            //Instantiate a new bullet from bullet prefab
            GameObject clone = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            //gets the clone of the new bullet prefab and applies the bullet script
            Bullet newBullet = clone.GetComponent<Bullet>();
            //sends the new bullet forward upon firing
            newBullet.Fire(direction + spread);
        } 
    }
    public override void Reload()
    {
        {
            float timer = 4f;
            while (currentAmmo < ammo)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    currentAmmo += 1;
                    timer = 4f;
                }
            }

        }
    }
}
