using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float initHealth;
    [SerializeField] private float currentHealth;
    public static GameObject hand;
    [SerializeField] private DamageEvent OnDamage;



    private void OnEnable()
    {
        currentHealth = initHealth;
    }

    private void Start()
    {
        if(hand == null)
        {
            hand = GameObject.FindWithTag("enemy");
        }
    }

    public void TakeDamage(float damageAmount)
    {

        Debug.Log(currentHealth);
        Debug.Log("take damage");

        currentHealth -= damageAmount;
        OnDamage?.Invoke(damageAmount);
        Debug.Log(damageAmount + " + " + currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(hand);
        }

    }
   
}
