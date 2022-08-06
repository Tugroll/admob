using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class reward : MonoBehaviour
{

    string rewardedid = "ca-app-pub-3940256099942544/5224354917";
    RewardedAd _adreward;
    
    void Request()
    {
        _adreward = new RewardedAd(rewardedid);

        _adreward.OnUserEarnedReward += DoesWin;
        AdRequest request = new AdRequest.Builder().Build();
        _adreward.LoadAd(request);
    }

    public void  DoesWin( object sender, Reward rew)
    {
        string tpye = rew.Type;
        double amount = rew.Amount;
    }

    void Start()
    {
        Request();
    }
    void ShowRewardAd()
    {
        if (_adreward.IsLoaded())
        {
            _adreward.Show();
        }
    }

    // Update is called once per frame
    
}
