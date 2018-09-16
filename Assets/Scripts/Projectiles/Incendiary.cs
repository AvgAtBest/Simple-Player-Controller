using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePlayerController;

public class Incendiary : Projectile
{
    public float damagePerTic = 2f;

    public override void Fire(Vector3 direction)
    {
        base.Fire(direction);
    }
    public override void OnCollisionEnter(Collision col)
    {
        Enemy e = col.collider.GetComponent<Enemy>();
        if (e)
        {
            Burn(e);
        }
    }
    IEnumerator Burn (Enemy enemy)
    {
        yield return new WaitForSeconds(damagePerTic);
        enemy.DealDamage(damage);
        StartCoroutine(Burn(enemy));
    }
}
