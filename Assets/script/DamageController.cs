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

        Debug.Log("damage card");

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("input key");
            enemyController.TakeDamage(damage);
        }
         
    }

}
