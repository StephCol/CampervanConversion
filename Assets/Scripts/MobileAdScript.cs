
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class MobileAdScript : MonoBehaviour
{

    private BannerAd banner = new BannerAd();
    private Interstitial interstitial = new Interstitial();
    private Rewarded rewarded = new Rewarded();

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        banner.RequestBanner();
        interstitial.RequestInterstitial();
        rewarded.RequestRewarded();
    }

}
