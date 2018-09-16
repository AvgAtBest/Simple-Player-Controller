using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePlayerController;

public class Explosive : Projectile
{
    public float maxRadius = 5f;
    public float minRadius = 0.1f;
    public float armTime;
    public int radiusDamage;
    public float knockBack;
    public float explosionForce = 250f;

    public ParticleSystem explosionEffect;

    public override void Fire(Vector3 direction)
    {
        base.Fire(direction);
    }
    public override void OnCollisionEnter(Collision collision)
    {
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy)
        {
            Explode();
            ExplosionEffect();
        }
    }
    public void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, maxRadius);
        foreach (Collider nearbyObject in colliders)
        {

            Rigidbody rBody = nearbyObject.GetComponent<Rigidbody>();
            if (rBody != null)
            {
                rBody.AddExplosionForce(explosionForce, transform.position, maxRadius);
                Destroy(gameObject, 2);
                
            }
        }
    }
    public void ExplosionEffect()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(explosionEffect);
    }
}
