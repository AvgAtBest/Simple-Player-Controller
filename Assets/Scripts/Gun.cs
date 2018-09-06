using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public KeyCode fireButton;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fireButton))
        {
            GameObject clone = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            Bullet newBullet = clone.GetComponent<Bullet>();
            newBullet.Fire(transform.forward);
        }
    }
}
