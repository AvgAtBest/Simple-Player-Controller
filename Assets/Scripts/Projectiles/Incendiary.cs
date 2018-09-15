using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incendiary : Projectile
{
    public float damagePerTic = 2f;

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
