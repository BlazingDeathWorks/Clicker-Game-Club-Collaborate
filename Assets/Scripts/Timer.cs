using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        [SerializeField] Text timerText;
        float timeLeft = 60;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = $"Time Left: {(int)Math.Round(timeLeft, 0)}";
    }
}
