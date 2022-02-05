using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _timerText;
    [SerializeField] ScoreManager _scoreManager = 0;
    float _timeLeft = 60;

    void Validate()
    {
        if (_timeLeft <= 0) 
        {
            _timeLeft = 60;
            _scoreManager = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timeLeft -= Time.deltaTime;
        _timerText.text = $"Time Left: {(int)_timeLeft}";
        Validate();
    }
}
