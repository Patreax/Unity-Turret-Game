using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int playerFullhealth = 3;
    public int playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = playerFullhealth; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
