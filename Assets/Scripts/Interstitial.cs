using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interstitial : MonoBehaviour
{
    private InterstitialAd interstitial;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void RequestInterstitial()
    {

        string adUnitId = "ca-app-pub-3940256099942544/1033173712";

        interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);

        interstitial.OnAdLoaded += HandleOnAdLoaded;
        interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        interstitial.OnAdOpening += HandleOnAdOpening;
        interstitial.OnAdClosed += HandleOnAdClosed;

        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
        else
            RequestInterstitial();

    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.ToString());
    }

    public void HandleOnAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpening event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject AdMobInterstitial = GameObject.Find("768x1024(Clone)");
        GameObject mainC = GameObject.Find("MainCanvas");
        AdMobInterstitial.transform.SetParent(mainC.transform);
    }
}
