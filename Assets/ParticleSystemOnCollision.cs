using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemOnCollision : MonoBehaviour
{
  
       public ParticleSystem Explosion;

  
    public void OnCollisionEnter(Collision Player)
    {
        if (Player.collider.tag == "Obstacle")
        {
            Debug.Log("collision!!");
            Explosion.Play();

        }
    }
}

