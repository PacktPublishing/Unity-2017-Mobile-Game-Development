using System; // DateTime
using UnityEngine;

#if UNITY_ADS // Can only compile ad code on support platforms 

using UnityEngine.Advertisements; // Advertisement 

#endif

public class UnityAdController : MonoBehaviour
{
    // If we should show ads or not
    public static bool showAds = true;

    // Nullable type 
    public static DateTime? nextRewardTime = null;


    public static void ShowAd()
    {

#if UNITY_ADS

        // Set options for our advertisement 
        ShowOptions options = new ShowOptions();
        options.resultCallback = Unpause;

        if (Advertisement.IsReady())
        {
            Advertisement.Show(options);
        }

        // Pause game while ad is shown 
        PauseScreenBehaviour.paused = true;
        Time.timeScale = 0f;

#endif

    }

#if UNITY_ADS

    public static void Unpause(ShowResult result)
    {
        // Unpause when ad is over 
        PauseScreenBehaviour.paused = false;
        Time.timeScale = 1f;
    }

#endif


    public static void ShowRewardAd()
    {
#if UNITY_ADS

        nextRewardTime = DateTime.Now.AddSeconds(15);

        if (Advertisement.IsReady())
        {
            // Pause game while ad is shown 
            PauseScreenBehaviour.paused = true;
            Time.timeScale = 0f;

            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show(options);
        }

#endif
    }

    // For holding the obstacle for continuing the game 
    public static ObstacleBehaviour obstacle;

    private static void HandleShowResult(ShowResult result)
    {
#if UNITY_ADS

        switch (result)
        {
            case ShowResult.Finished:
                // Successfully shown, can continue game 
                obstacle.Continue();
                break;
            case ShowResult.Skipped:
                Debug.Log("Ad skipped, do nothing");
                break;
            case ShowResult.Failed:
                Debug.LogError("Ad failed to show, do nothing");
                break;
        }

#endif
        // Unpause when ad is over or when called
        PauseScreenBehaviour.paused = false;
        Time.timeScale = 1f;

    }

}