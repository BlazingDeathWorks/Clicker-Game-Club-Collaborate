using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    float score = 0;
    [SerializeField] int incrementAmount = 1;
    [SerializeField] float incrementMultiplier = 1;

    private void Awake()
    {
        scoreText.text = ((int)score).ToString();
    }

    // Increment the `counter` variable
    public void Increment()
    {
        score += incrementAmount * incrementMultiplier;
        scoreText.text = ((int)score).ToString();
    }
    public void IncreaseIA(int num)
    {
        incrementAmount += num;
    }
    public void IncreaseIM(float mult)
    {
        incrementMultiplier += mult;
    }
    public void DecreaseScore(int num)
    {
        score -= num;
    }

}
