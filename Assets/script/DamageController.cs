using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    private EnemyController enemyController = new EnemyController();
    [SerializeField] float damage;


    private void Update()
    {
        DamageCard();
    }
    

    private void DamageCard()
    {

        Debug.Log("damage card");

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("input key");
            enemyController.TakeDamage(damage);
        }
         
    }

}
