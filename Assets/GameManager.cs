using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerStats playerStats;

    public GameObject playerHealthUI;
    public GameObject gameOverUI;

    // Update is called once per frame
    void Update()
    {
        if(playerStats.playerHealth <= 0)
        {
            StartCoroutine(RestartLevel());  
        }
    }

    IEnumerator RestartLevel()
    {
        playerHealthUI.SetActive(false);
        gameOverUI.SetActive(true);
        

        yield return new WaitForSeconds(3f);

        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
