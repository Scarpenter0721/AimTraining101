using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    timeKeeping time;
    public TextMeshProUGUI finalTimeText;
    public float finalTime;

    void start()
    {
        time = GameObject.Find("TimerTarget").GetComponent<timeKeeping>();
        finalTime = time.endTime();
        finalTimeText.text = finalTime.ToString("0.00");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void gameOver()
    {
        SceneManager.LoadScene(0);
    }
}
