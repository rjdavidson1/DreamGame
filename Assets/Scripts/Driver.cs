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

    public void levelLoad()
    {
        switch (CurrentLvl)
        {
            case 0: SceneManager.LoadScene("Level0");
                break;
            case 1: SceneManager.LoadScene("Level1");
                break;
            case 2: SceneManager.LoadScene("Level2");
                break;
            default: SceneManager.LoadScene("Level0");
                break;
        }
    }
    static public int CurrentLvl { get; set; }
    static public float LongestTime { get; set; }
    static public int PlayerLives { get; set; }

}
