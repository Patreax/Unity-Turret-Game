using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public Spawner spawner;
    
    Turret turretScript;
    public GameObject explosion;


    private void Start()
    {
        turretScript = GetComponent<Turret>();

        spawner = FindObjectOfType<Spawner>();
    }

    public void TakeDamage(float amount)
    {
        turretScript.health -= amount;
        if (turretScript.health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        GameObject explosionGo = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(explosionGo, 3f);
        Destroy(gameObject);

        // Decrease numberOfTurrets
        spawner.numberOfTurrets--;
    }

}
