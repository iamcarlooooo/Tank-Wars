using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    public Transform player;
    public Vector2 target;
    public Vector2 beyondTargetFlight;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
 
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target * 100, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DestroyEnemyBullet();
        }
    }

    void DestroyEnemyBullet()
    {
        Destroy(gameObject);
    }
}
