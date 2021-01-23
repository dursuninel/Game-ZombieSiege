using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Transform shotPoint;
    public GameObject bullet;
    public AudioClip gun;

    private void Start()
    {
        speed = 0;
    }
    private void Update()
    {
        //float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //Vector3 mov = new Vector3(x, y, 0);

        //transform.position += mov;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 1 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -1 * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, shotPoint.position, shotPoint.rotation);
            GetComponent<AudioSource>().PlayOneShot(gun);
        }

            transform.Rotate(0, 0, 1 * speed * Time.deltaTime);  

    }
    public void sagClick()
    {
        speed = -110f;
    }
    public void solClick()
    {
        speed = 110f;
    }
    public void dur()
    {
        speed = 0;
    }
    public void fire()
    {
        Instantiate(bullet, shotPoint.position, shotPoint.rotation);
        GetComponent<AudioSource>().PlayOneShot(gun);
    }   
}
