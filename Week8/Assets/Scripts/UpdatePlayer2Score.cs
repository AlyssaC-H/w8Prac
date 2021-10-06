using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePlayer2Score : MonoBehaviour
{
    [SerializeField]

    public Text score2Text;
    private float coin2Score;

    public void IncreaseScore(float amount)
    {
        coin2Score += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        score2Text.text = coin2Score.ToString();
    }
}
