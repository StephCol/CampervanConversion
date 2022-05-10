using System;
using UnityEngine;
using UnityEngine.UI;

public class BuildReqs : MonoBehaviour
{
    GameObject[] buildToggles;

    public void getCompletion()
    {
        int count = 0;
        print(count);

        buildToggles = new GameObject[4];

        for (int i = 0; i < 4; i++)
        {
            buildToggles[i] = GameObject.Find("chk_build" + (i+1));
            if (buildToggles[i].GetComponent<Toggle>().isOn)
                count++;
        }

        print(count);

        GameObject slider = GameObject.Find("Slider");
        Slider s = slider.GetComponent<Slider>();
        s.value = count;

        GameObject txt = GameObject.Find("txt_complete");
        Text t = txt.GetComponent<Text>();
        t.text = (count*25) + "% Complete";

        getAchievement(count);
        postScoreToLeaderBoard(30);
     }

    private void postScoreToLeaderBoard(int score)
    {
        Leaderboard.PostScoreToLeaderboard(score);
    }

    public void getAchievement(int count)
    {
        if (count == 4)
        {
            Achievement.GrantAchievementBtn();
            //Achievement.RevealAchievementBtn();
            Achievement.RevealIncrementalBtn();
        }
    }

}
