using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static int Score = 0;
    public TextMeshProUGUI score_text;

    public void increment_score()
    {
        Score++;
        score_text.text = Score.ToString();

        PlayerPrefs.SetInt("scoretoupdate", PlayerPrefs.GetInt("scoretoupdate", 0) + 1);
    }
}
