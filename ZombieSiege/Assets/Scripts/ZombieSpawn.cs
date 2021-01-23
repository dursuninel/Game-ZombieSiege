using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public GameObject zombie;
    private void Start()
    {
        InvokeRepeating("InstantiateTop", 1, Random.Range(4, 7));
      //  InvokeRepeating("InstantiateBottom", 1, Random.Range(5, 7));
        InvokeRepeating("InstantiateLeft", 1, Random.Range(4, 7));
        InvokeRepeating("InstantiateRight", 1, Random.Range(4, 7));
    }

    void InstantiateTop()
    {
        // Top
        Instantiate(zombie, new Vector3(Random.Range(-10, 10), 6, 0), zombie.transform.rotation);
    }
    void InstantiateBottom()
    {
        // Bottom
        Instantiate(zombie, new Vector3(Random.Range(-10, 10), -6, 0), zombie.transform.rotation);
    }
    void InstantiateLeft()
    {
        //Left
        Instantiate(zombie, new Vector3(-10, Random.Range(-3, 6), 0), zombie.transform.rotation);
    }
    void InstantiateRight()
    {
        //Right
        Instantiate(zombie, new Vector3(10, Random.Range(-3, 6), 0), zombie.transform.rotation);
    }
}
