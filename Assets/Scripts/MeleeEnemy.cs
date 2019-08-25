using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public float speed;
    public int health;
    public int damage;
    public float damangeRadius;
    public Transform playerTransform;

    void Update()
    {
        Vector3 toPlayer = playerTransform.position - transform.position;
        transform.Translate(toPlayer.normalized * speed * Time.deltaTime);

        if (toPlayer.magnitude <= damangeRadius)
        {
            Debug.Log("Doing " + damage + " damage");
        }
    }

    public void receiveDamage(int receivedDamage)
    {
        health = Mathf.Max(health - receivedDamage, 0);

        if (health == 0)
        {
            Debug.Log("Enemy died");
        }
    }
}
