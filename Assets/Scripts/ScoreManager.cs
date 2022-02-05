using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    float _score = 0;
    [SerializeField] int _incrementAmount = 1;
    [SerializeField] float _incrementMultiplier = 1;

    private void Awake()
    {
        UpdateScore();
    }

    private void UpdateScore()
    {
        _scoreText.text = ((int)_score).ToString();
    }

    // Increment the `counter` variable
    public void Increment()
    {
        _score += _incrementAmount * _incrementMultiplier;
        UpdateScore();
    }

    public void IncreaseIA(int num)
    {
        _incrementAmount += num;
    }

    public void IncreaseIM(float mult)
    {
        _incrementMultiplier += mult;
    }

    public void DecreaseScore(int num)
    {
        _score -= num;
        UpdateScore();
    }

    public void ResetScore()
    {
        _score = 0;
        _scoreText.text = ((int)_score).ToString();
    }

}
