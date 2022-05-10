using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;

public class Achievement : MonoBehaviour
{
    public Text logText;

    public void ShowAchievements()
    {
        Social.ShowAchievementsUI();
    }

    public static void DoGrantAchievement(string _achievement)
    {
        Social.ReportProgress(_achievement, 100.0f, (bool success) =>
        {
        });
    }

   

    public static void DoIncrementalAchievement(string _achievement, int count)
    {
        PlayGamesPlatform platfrom = (PlayGamesPlatform)Social.Active;

        platfrom.IncrementAchievement(_achievement, count, (bool success) =>
        {
        });
    }

    public static void DoRevealAchievement(string _achievement)
    {
        Social.ReportProgress(_achievement, 0.0f, (bool success) =>
        {
        });
    }


    public static void GrantAchievementBtn()
    {
        DoGrantAchievement(GPGSIds.achievement_boss_builder);
    }


    public static void GrantHiddenIncBtn(int count)
    {
        DoIncrementalAchievement(GPGSIds.achievement_ready_for_revenue, count);
    }

    public static void RevealIncrementalBtn()
    {
        DoRevealAchievement(GPGSIds.achievement_ready_for_revenue);
    }

    /*    public void ListAchievements()
        {
            Social.LoadAchievements(achievements => {
                logText.text = "Loaded Achievements " + achievements.Length;
                foreach(IAchievement ach in achievements)
                {
                    logText.text += "\n" + ach.id + " " + ach.completed;
                }
            });
        }*/

    /*    public void ListDescriptions()
        {
            Social.LoadAchievementDescriptions(achievements => {
                logText.text = "Loaded Achievements " + achievements.Length;
                foreach (IAchievementDescription ach in achievements)
                {
                    logText.text += "\n" + ach.id + " " + ach.title;
                }
            });
        }*/


    /*    public void GrantIncrementalBtn()
        {
            DoIncrementalAchievement(GPGSIds.achievement_incremental_achievement);
        }*/

    /*public static void RevealAchievementBtn()
    {
        DoRevealAchievement(GPGSIds.achievement_hidden_unlock_achievement);
    }*/


    /* public void GrantHiddenAchBtn()
     {
         DoGrantAchievement(GPGSIds.achievement_hidden_unlock_achievement);
     }*/



}
