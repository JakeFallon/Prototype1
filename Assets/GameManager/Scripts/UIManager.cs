using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreValue;
    
    [SerializeField] private int pointvalue = 1;
    void Start()
    {
        UpdateScoreUI(0);
      

    }

    public void UpdateScoreUI(int value)
    {

        scoreValue.text = value.ToString("D7");
    }
    public void UpdateTimeUI(float time)
    {
        int seconds = (int)time;

        GameManager.IncrementScore(pointvalue * seconds);
    }


}
