using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public PlayerStats player;
    public Text healthUI;

   
    // Update is called once per frame
    void Update()
    {
        healthUI.text = "HP: " + player.playerHealth.ToString();   
    }
}
