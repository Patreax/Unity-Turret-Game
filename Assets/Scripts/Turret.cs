using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform player;
    public Transform cannon;
    public GameObject projectile;
    

    Vector3 headTargeting = new Vector3(0f, 0.6f, 0f);
    Vector3 offset = new Vector3(0f, 0f, 1f);

    public float shootForce = 50f;

    public float shootingRate = 2f;
    float countDown;

    public float health = 50f;

    // Start is called before the first frame update
    void Start()
    {
        countDown = Random.Range(0, 3) + Random.Range(-0.9f, 0.3f);
    }
    
    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = player.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //twransform.localRotation = Quaternion.Euler(0f, angle, 0f);
        
        countDown -= Time.deltaTime;
        if (countDown < 0)
        {
            Shoot();
            countDown = shootingRate;
        }

        transform.LookAt(player);
    }

    void Shoot()
    {
        GameObject currentBullet = Instantiate(projectile, cannon.position, Quaternion.identity);

        Vector3 projectileDirection = player.position - transform.position + headTargeting;
        currentBullet.GetComponent<Rigidbody>().AddForce(projectileDirection.normalized * shootForce, ForceMode.VelocityChange);

        //Destroy(currentBullet, shootingRate - 0.2f);
    }
    
    
}
