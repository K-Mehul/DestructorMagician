using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Ads : MonoBehaviour
{
    public static Ads instance;

    string AppId = "ca-app-pub-9219030304999385~5526974527";

    InterstitialAd FullScreenAd;
    string FullScreenAdID = "ca-app-pub-3940256099942544/1033173712";

    private void Awake() {
        if(instance == null) {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start() {
        MobileAds.Initialize(AppId);
        RequestFullScreenAd();
    }

    public void RequestFullScreenAd() {

        FullScreenAd = new InterstitialAd(FullScreenAdID);
        AdRequest request = new AdRequest.Builder().Build();
        FullScreenAd.LoadAd(request);
    }

    public void ShowFullScreenAd() {
        if(FullScreenAd.IsLoaded()) {
            FullScreenAd.Show();
        }
        else
        {
            Debug.Log("Ad not Loaded");
        }
    }
}
