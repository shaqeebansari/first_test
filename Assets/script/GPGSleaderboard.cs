using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPGSleaderboard : MonoBehaviour
{
    public void open_leaderboard_UI()
    {
        Social.ShowLeaderboardUI();
    }

    public void Updateleaderboard_score()
    {
        if(PlayerPrefs.GetInt("scoretoupdate" , 0) == 0)
        {
            return;
        }

        Social.ReportScore(PlayerPrefs.GetInt("scoretoupdate", 1), GPGSIds.leaderboard_high_score, (bool success) =>
        {
            if (success)
            {
                PlayerPrefs.SetInt("scoretoupdate", 0);
            }

        });
    }
}
