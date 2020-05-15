using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;

public class GPGSachivement : MonoBehaviour
{
    public void show_achivementPanel_ui()
    {
        Social.ShowAchievementsUI();
    }

    public void UpdateIncremental()
    {
        PlayGamesPlatform.Instance.IncrementAchievement(GPGSIds.achievement_incremental, 1, null);
    }

    public void Unlock_regular()
    {
        Social.ReportProgress(GPGSIds.achievement_regular, 100f, null);
    }
}
