using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class Adss_Manger : MonoBehaviour {

    float e;
    private BannerView bannerView;
    void Start () {

        showBannerAd();

    }

    private void showBannerAd()
    {
        string adID = "ca-app-pub-8812320259916523/5749978106";

//        //***For Testing in the Device***
//        AdRequest request = new AdRequest.Builder()
//            .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
//            .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
//            .Build();

        //***For Production When Submit App***
        AdRequest request = new AdRequest.Builder().Build();

        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Top);
        bannerAd.LoadAd(request);
    }

	void Update () {

        e += Time.deltaTime;
        if (e >= 12f)
        {
            e = e % 12f;
            OutPutTime();
            Debug.Log("Ads  ready for default placement");


        }


	}
    private void OutPutTime()
    {
        showBannerAd();
       // this.RequestBanner();
      
    }

}
