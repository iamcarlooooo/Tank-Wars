using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.tag == "Terrain")
        {
            Destroy(gameObject);

        }


    }
}
    