using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timeKeeping : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;
    public GameObject timerTarget;
    private bool mainMenu;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(timerTarget);
        DontDestroyOnLoad(timerText);
    }

    // Update is called once per frame
    void Update()
    {
        reset();
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name != "GameOver")
        {
            currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        }
        else
        {
            ShowTime(currentTime);
            timerText.transform.position = new Vector3(1250, 450, 0);
        }
        timerText.text = currentTime.ToString("0.00");

        if (currentTime >= 10)
        {
            AchievementManager.instance.Unlock("timeExample");
        }
       
        
    }
   
    public float ShowTime(float currentTime)
    {
        return currentTime;
    }
    public float endTime()
    {
        return ShowTime(currentTime);
    }
    void reset()
    {
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name != "MainMenu")
        {
            DontDestroyOnLoad(timerTarget);
            DontDestroyOnLoad(timerText);
        }
        else
        {
            Destroy(timerTarget);
        }
    }
}
