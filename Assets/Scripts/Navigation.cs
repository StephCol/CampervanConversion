using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    static GameObject buildReq;
    static GameObject sqiReqs;
    static GameObject buildSup;
    static GameObject revReqs;
    static GameObject rewardConfirmation;

    void Start()
    {
        buildReq = GameObject.Find("c_buildReqs");
        sqiReqs = GameObject.Find("c_sqidir");
        sqiReqs.SetActive(false);

        buildSup = GameObject.Find("c_buildsup");
        buildSup.SetActive(false);

        revReqs = GameObject.Find("c_revReqs");
        revReqs.SetActive(false);

        rewardConfirmation = GameObject.Find("c_PopUp");
        rewardConfirmation.SetActive(false);
    }

    public void getBuildPanel()
    {
        buildReq.SetActive(true);
    }

    public void hideBuildPanel()
    {
        buildReq.SetActive(false);
    }

    public static void getSQIPanel()
    {
        sqiReqs.SetActive(true);
    }

    public void hideSQIPanel()
    {
        sqiReqs.SetActive(false);
    }

    public void getBuildSupPanel()
    {
        buildSup.SetActive(true);
    }

    public void hideBuildSupPanel()
    {
        buildSup.SetActive(false);
    }

    public void getRevReqPanel()
    {
        revReqs.SetActive(true);
    }

    public void hideRevReqPanel()
    {
        revReqs.SetActive(false);
    }

    public static void getRewardedConfirmation()
    {
        
        rewardConfirmation.SetActive(true);
    }

    public void hideBuildSupPanelConfirmation()
    {
        rewardConfirmation.SetActive(false);
    }


}
