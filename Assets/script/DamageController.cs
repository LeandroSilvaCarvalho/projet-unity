using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private EnemyController enemyController;
    [SerializeField] float damage;

    private void Update()
    {
        DamageCard();
    }
    

    private void DamageCard()
    {

        Debug.Log("damage card");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("input key");
            enemyController.TakeDamage(damage);
        }
         
    }

}
