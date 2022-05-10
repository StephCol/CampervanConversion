using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewarded : MonoBehaviour
{

    private RewardedAd rewardedAd;

    // Start is called before the first frame update
    void Start()
    {
        string adUnitId = "ca-app-pub-3940256099942544/5224354917 ";
        this.rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
       // rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        AdRequest req = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(req);
    }

    public void RequestRewarded()
    {
        
       //if (this.rewardedAd.IsLoaded())
            this.rewardedAd.Show();

        AdRequest req = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(req);
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: ");
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    [Obsolete]
    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {/*
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);*/

        Navigation nav = new Navigation();
        nav.getBuildSupPanelConfirmation();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject AdMobInterstitial = GameObject.Find("768x1024(Clone)");
        GameObject mainC = GameObject.Find("MainCanvas");
        AdMobInterstitial.transform.SetParent(mainC.transform);
    }
}
