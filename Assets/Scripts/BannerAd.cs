using GoogleMobileAds.Api;
using System;
using UnityEngine;

public class BannerAd : MonoBehaviour
{
    private BannerView bannerView;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void RequestBanner()
    {
        string adUnitId = "ca-app-pub-3940256099942544/6300978111";

        bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);

        bannerView.OnAdLoaded += HandleOnAdLoaded;
        bannerView.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        bannerView.OnAdOpening += HandleOnAdOpened;
        bannerView.OnAdClosed += HandleOnAdClosed;


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

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }

    // Update is called once per frame
    void Update()
    {

        GameObject AdMobbanner = GameObject.Find("SMART_BANNER(Clone)");
        GameObject mainC = GameObject.Find("MainCanvas");
        AdMobbanner.transform.SetParent(mainC.transform);
    }
}
