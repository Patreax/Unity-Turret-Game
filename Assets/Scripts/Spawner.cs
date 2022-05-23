using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawner;
    public GameObject turret;
    public Transform currentPlayer;

    public int freeSpaces = 2;
    public int numberOfTurrets;
    private int index;

    private void Awake()
    {
        for (int i = 0; i < spawner.Length - freeSpaces; i++)
        {
            // Instatiating turrets and asignign player Transform to them
            GameObject currentTurret = Instantiate(turret, spawner[i].position, Quaternion.identity);
            Turret turretScript = currentTurret.GetComponent<Turret>();
            turretScript.player = currentPlayer;

            numberOfTurrets = spawner.Length - freeSpaces;
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        if(numberOfTurrets < spawner.Length - freeSpaces)
        {
            index = Random.Range(0, spawner.Length);
            while(Physics.CheckSphere(spawner[index].position, 0.1f))
            {
                index = Random.Range(0, spawner.Length);
            }

            StartCoroutine(TurretSpawn(index));
        }
        
    }

    IEnumerator TurretSpawn(int i)
    {
        numberOfTurrets++;

        yield return new WaitForSeconds(2f);

        GameObject currentTurret = Instantiate(turret, spawner[i].position, Quaternion.identity);
        Turret turretScript = currentTurret.GetComponent<Turret>();
        turretScript.player = currentPlayer;
    }
}
