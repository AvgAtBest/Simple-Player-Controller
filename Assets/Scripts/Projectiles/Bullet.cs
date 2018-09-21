using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePlayerController;

public class Bullet : Projectile
{

    // Use this for initialization

    public override void Fire(Vector3 direction)
    {
        base.Fire(direction);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy)
        {
            //enemy.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
