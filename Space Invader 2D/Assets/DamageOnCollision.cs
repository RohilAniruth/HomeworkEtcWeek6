using UnityEngine;
using System.Collections;

public class DamageOnCollision : MonoBehaviour
{

     GameObject scoreUITextGO; 

    int health = 1;

    void Start () {
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreTextTag");

    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

        health--;
        if (health <= 0)
        {
            Die();
        }

        scoreUITextGO.GetComponent<GameScore>().Score += 100;

    }

    void Die()
    {
        Destroy(gameObject);
    }
}