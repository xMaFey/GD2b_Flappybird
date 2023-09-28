using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject starButton;
    public Player player;
    public TMP_Text gameover;
    public TMP_Text gameOverCountdown;
    public float countTimer = 5;
    // Start is called before the first frame update
    void Start()
    {
        gameOverCountdown.GameObject.SetActive(false);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.isDead){
            gameOverCountdown.GameObject.SetActive(true);
            countTimer -= countTimer.unscaleDeltaTime;
        }

        gameOverCountdown.text = "Restarting in " + (countTimer).ToString("0");
        if(countTimer<0){
            RestartGame();
        }

        public void StartGame(){
            starButton.SetActive(false);
            Time.timeScale = 1;
        }

        public void GameOver(){
            Time.timeScale = 1;
        }
    }
}
