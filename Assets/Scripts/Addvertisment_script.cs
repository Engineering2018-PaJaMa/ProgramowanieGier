using System;
using UnityEngine;
using UnityEngine.Advertisements;

public class Addvertisment_script : MonoBehaviour
{
    void Start()
    { 
        Advertisement.Initialize("2951672", true);
        Debug.Log("Inicjalizacja reklam");
    }

    public void ShowRewardedAd()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);
            Debug.Log("Reklama jest wyświetlana");
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                DataController.premiumMoney += 10;
                Debug.Log("Added 10 money");
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }
}