using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using GooglePlayGames;

public class Leaderboard : MonoBehaviour
{
    public void ShowLeaderboardUI()
    {
        Social.ShowLeaderboardUI();
    }

    public static void PostScoreToLeaderboard(int score)
    {
        Social.ReportScore(score, GPGSIds.leaderboard_committed_campervanners, (bool success) =>
        {

        });
    }
}
