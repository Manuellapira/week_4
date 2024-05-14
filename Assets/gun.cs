using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{

    public GameObject bullets;
    public Transform bulletSpawnPoint;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullets();
        }
    }
    public void SpawnBullets()
    { 
GameObject _bullet = Instantiate(bullets,bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody rb = _bullet.GetComponent<Rigidbody>();
            rb.velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
}
