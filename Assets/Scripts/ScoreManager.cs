using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    float counter = 0;
    int currentScore = 0;

    // Increment the `counter` variable
    public void Count()
    {
        counter += 1;
        currentScore = (int)counter;
    }
    
}
