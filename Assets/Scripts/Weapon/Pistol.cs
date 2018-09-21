using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePlayerController;

public class Pistol : Weapon
{
    public KeyCode fireButton;

    public override void Attack()
    {
        GameObject clone = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
        Projectile newBullet = clone.GetComponent<Projectile>();
        newBullet.Fire(transform.forward);
    }
}
