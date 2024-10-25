using UnityEngine;
using TMPro;

public class SimpleTimerUI : MonoBehaviour
{
    private float timer = 0f;
    public TextMeshProUGUI timerText;

    void Start()
    {
        timerText.text = "Timer : 0.00s";
    }

    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = "Timer : " + timer.ToString("F2") + "s";
    }
}
