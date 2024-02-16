using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int theScore;
    public int theMaxScore;

   private void update()
    {
        ShowScore();
        
    }
    public void AddScore()
    {
        theScore += 100;
        if (theScore >= 200)
        {
            AchievementManager.instance.Unlock("firstKill");
        }
       
        ShowScore();
        if(theScore >= theMaxScore)
        {
            AchievementManager.instance.Unlock("lvl2");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void ShowScore()
    {
        scoreText.text = "Score: " + theScore.ToString("0");
    }
}
