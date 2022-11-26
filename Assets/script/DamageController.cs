using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    private EnemyController enemyController;
    [SerializeField] float damage;


    private void Start()
    {
        DamageCard();
    }
    

    private void DamageCard()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            enemyController.TakeDamage(damage);
        }
         
    }

}
