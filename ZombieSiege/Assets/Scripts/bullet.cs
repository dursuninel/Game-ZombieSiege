using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject enemy;
    public float speed = 3f;
    public float lifeTime = 3f;

    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        lifeTime -= 1 * Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<ZombieControl>().Health();
            Destroy(gameObject);
        }
    }
}
