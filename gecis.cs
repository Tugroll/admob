using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class gecis : MonoBehaviour
{
    private InterstitialAd interad;
    string adinter = "ca-app-pub-3940256099942544/1033173712";

    void request()
    {
        interad = new InterstitialAd(adinter);
        AdRequest request = new AdRequest.Builder().Build();
        interad.LoadAd(request);
    }

    void GameOver()
    {
        if (interad.IsLoaded())
        {
            interad.Show();
        }
        else
        {
            request();
        }
    }
    void Start()
    {
        request();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
