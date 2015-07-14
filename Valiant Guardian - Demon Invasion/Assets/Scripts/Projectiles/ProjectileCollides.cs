﻿using UnityEngine;
using System.Collections;

public class ProjectileCollides : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Projectile hit enemy
            disableProjectileVisulization();
            other.gameObject.GetComponent<MeleeImp>().Attacked();
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