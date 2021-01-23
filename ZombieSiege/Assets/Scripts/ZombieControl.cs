using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{
    // Can
    float startHealth = 60;
    float currentHealth;

    // Karaktere bakma
    private Transform target;
    private Vector3 targetPos;
    private Vector3 thisPos;
    private float angle;

    // İlerleme
    public GameObject kalipZombie;
    public float speed = 1f;

    // Score
    private GameObject scoreObje;



    private void Awake()
    {
        currentHealth = startHealth;
    }
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        scoreObje = GameObject.FindGameObjectWithTag("Score");
    }
    void FixedUpdate()
    {
        // Rotation
        targetPos = target.position;
        thisPos = transform.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // İlerleme
        kalipZombie.transform.Translate(transform.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            scoreObje.GetComponent<Score>().onCharacterHealth();
            Destroy(kalipZombie);
        }
    }
    public void Health()
    {
        currentHealth -= 30;
        if (currentHealth <= 0)
        {
            GameObject.FindGameObjectWithTag("Score").GetComponent<Score>().killScore();
            Destroy(kalipZombie);
        }
    }
}
