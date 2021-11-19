using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] int damage = 40;
    Rigidbody2D rb;
    Player player;
    float xSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
        rb.velocity = transform.right * speed;
        xSpeed = player.transform.localScale.x * speed;
    }

    private void Update()
    {
        rb.velocity = new Vector2(xSpeed, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyMovement enemy = collision.GetComponent<EnemyMovement>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
