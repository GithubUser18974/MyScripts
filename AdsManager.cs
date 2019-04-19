using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class AdsManager : MonoBehaviour {

    public static AdsManager Instance { set; get; }
    [SerializeField]
    private  static string mBanner = "ca-app-pub-9336535284372672/8083502172";
    [SerializeField]
    private static string mVedio =   "ca-app-pub-9336535284372672/6144251464";
    [SerializeField]
    private static string mAppId =   "ca-app-pub-9336535284372672~3377970400";
    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);


        Admob.Instance().initAdmob(mBanner, mVedio);
        Admob.Instance().setTesting(true);
        Admob.Instance().loadInterstitial();
    }
    public void ShowBanner() {

        Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.BOTTOM_CENTER,5);

    }
    public void ShowVedio() {

        if (Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") + 5);

        }

    }
}
