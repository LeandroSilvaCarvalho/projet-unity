using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float health;

    public void TakeDamage(float damageAmount)
    {

        Debug.Log("take damage");

        health -= damageAmount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
   
}
