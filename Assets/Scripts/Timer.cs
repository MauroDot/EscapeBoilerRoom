using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float _timeRemaining = 10;

    private bool _timerIsRunning;

    [SerializeField]
    public TMP_Text timeText;

    [SerializeField]
    private GameObject _gameOverScreen;

    [SerializeField]
    private GameObject _leftController;
    [SerializeField]
    private GameObject _rightController;

    [SerializeField]
    UnityEvent _onCheck;

    void Start()
    {
        _timerIsRunning = true;
    }

    void Update()
    {
        RunningTimer();
    }

    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    private void RunningTimer()
    {
        if (_timerIsRunning == true)
        {
            if (_timeRemaining > 0)
            {
                _timeRemaining -= Time.deltaTime;

                DisplayTime(_timeRemaining);
            }
            else
            {
                _timeRemaining = 0;
                _timerIsRunning = false;

                if (_timeRemaining == 0)
                {
                    _gameOverScreen.SetActive(true);

                    _onCheck.Invoke();
                }
            }
        }
    }
}
