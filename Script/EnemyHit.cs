using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : Collidable
{
    //Damage
    public int damage = 1;
    public float pushForce = 2;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.tag == "Fighter" && coll.name == "Player")
        {
            //create a new damage obj, before sending it o the player
          Damage dmg = new Damage
          {  
            damageAmount = damage,
            origin = transform.position,
            pushForce = pushForce
          };
            
          coll.SendMessage("ReceiveDamage", dmg);                
        } 
    }
}

