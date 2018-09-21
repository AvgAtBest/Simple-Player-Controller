using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePlayerController;


public class Projectile : MonoBehaviour
{
    public int damage = 100;
    public float range = 50f;
    public float speed = 10f;
    public Rigidbody rigidBody;
    public GameObject spawnPoint;

    public virtual void Fire(Vector3 direction)
    {
        rigidBody.AddForce(direction * speed, ForceMode.Impulse);
    }
    public virtual void OnCollisionEnter(Collision collision)
    {

    }
}