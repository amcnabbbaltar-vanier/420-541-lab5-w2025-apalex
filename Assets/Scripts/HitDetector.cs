using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HitDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyController enemyController = other.GetComponent<EnemyController>();
            if (enemyController != null)
            {
                Console.WriteLine(gameObject);
                enemyController.GotHit();
            }
        }
    }
}
