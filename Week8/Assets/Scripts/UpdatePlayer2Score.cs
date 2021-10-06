using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePlayer2Score : MonoBehaviour
{
    [SerializeField]

    public Text scoreText;
    private float coinScore;

    public void IncreaseScore(float amount)
    {
        coinScore += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = coinScore.ToString();
    }
}
