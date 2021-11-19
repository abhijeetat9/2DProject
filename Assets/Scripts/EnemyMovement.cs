using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float enemySpeed = 1f;
    [SerializeField] int health = 100;
    Rigidbody2D enemyRigidbody;
    BoxCollider2D bodyCollider;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
        bodyCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            enemyRigidbody.velocity = new Vector2(enemySpeed, 0);
        }
        else
        {
            enemyRigidbody.velocity = new Vector2(-enemySpeed, 0);
        }
    }

    bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(enemyRigidbody.velocity.x)), 1f);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health<=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
