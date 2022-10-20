using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public Animator EnemyAnimator;
    public GameObject EnemyObject;
    public Collider2D DisableEnemyCollider;
    bool IsDying = false;

    public void Awake()
    {
        EnemyAnimator = EnemyObject.GetComponent<Animator>();
        DisableEnemyCollider = EnemyObject.GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Doesn't work
            //DisableEnemyCollider.enabled = false;
            //GetComponent<Collider2D>().enabled = false;
            //DisableEnemyCollider.enabled = false;

            //GetComponent<Animator>().SetBool("IsDying", true);
            //EnemyAnimator.SetBool("IsDying", true);

            // Works
            Destroy(collision.gameObject);
        }
    }
}