using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Driver  {

	public Driver()
    {
        CurrentLvl = 0;
        LongestTime = 0f;
        PlayerLives = 3;
    }

    public Driver(int currentLvl, float longestTime, int playerLives)
    {
        CurrentLvl = currentLvl;
        LongestTime = longestTime;
        PlayerLives = playerLives;   

    }

    static public void levelLoad()
    {
        switch (CurrentLvl)
        {
            case 0: SheepCount = 4;
                SceneManager.LoadScene("Level0");
                break;
            case 1:SheepCount = 6;
                SceneManager.LoadScene("Level1");
                break;
            case 2:SheepCount = 8;
                SceneManager.LoadScene("Level2");
                break;
            default: SceneManager.LoadScene("Level0");
                break;
        }
    }
    static public void GameOver (int tryAgain)
    {
        switch (tryAgain){
            case 0: Application.Quit();
                break;
            case 1: SceneManager.LoadScene("Menu");
                break;
            default: return;

        }
        
    }

    static public void playerDied()
    {
        PlayerLives--;
        if (PlayerLives <= 0)
        {
            GameObject.FindGameObjectWithTag("GameOver").SetActive(true);
        }
        levelLoad();
    }
    static public void levelBeat()
    {
        CurrentLvl++;
        levelLoad();
    }
    
    static public int CurrentLvl { get; set; }
    static float LongestTime { get; set; }
    static int PlayerLives { get; set; }

    static public GameObject CurrentPlatform { get; set; }
    static public GameObject Player { get; set; }
    static public float Timer { get; set; }
    static public int SheepCount { get; set; }
}