using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    float score = 0;
    int incrementAmount = 1;
    float incrementMultiplier = 1;

    // Increment the `counter` variable
    public void Increment()
    {
        score += incrementAmount * incrementMultiplier;
    }
    public void IncreaseIA(int num)
    {
        incrementAmount += num;
    }
    public void IncreaseIM(float mult)
    {
        incrementMultiplier += mult;
    }
}
