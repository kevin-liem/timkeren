﻿using UnityEngine;
using System.Collections;

public class ProjectileAttack : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name + "hit");
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy hit");
            //Projectile hit enemy
            disableProjectileVisulization();
            other.gameObject.GetComponent<Enemy>().Attacked();
            GetComponent<ProjectileSound>().hitTargetSound();
            float waitToDestroy = GetComponent<ProjectileSound>().getSoundClipLength();
            Destroy(gameObject, waitToDestroy);
        }
    }

    private void disableProjectileVisulization()
    {
        //disabling projectile existence to maintain hit sound
        //while the proectile didn't affect anything in game world
        Destroy(GetComponent<Rigidbody2D>());
        Destroy(GetComponent<BoxCollider2D>());
        Destroy(GetComponent<SpriteRenderer>());
    }
}