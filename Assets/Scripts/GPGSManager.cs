using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

public class GPGSManager : MonoBehaviour
{
    private PlayGamesClientConfiguration clientConfiguration;
    public Text statusTxt;
    public Text descriptionTxt;
    public GameObject btn_Home;

    // Start is called before the first frame update
    void Start()
    {
        ConfigureGPGS();
    }

    internal void ConfigureGPGS()
    {
        clientConfiguration = new PlayGamesClientConfiguration.Builder().Build();
        SignIntoGPGS(SignInInteractivity.CanPromptOnce, clientConfiguration);

    }

    internal void SignIntoGPGS(SignInInteractivity intertactivity, PlayGamesClientConfiguration configuration)
    {
        configuration = clientConfiguration;
        PlayGamesPlatform.InitializeInstance(configuration);
        PlayGamesPlatform.Activate();

        PlayGamesPlatform.Instance.Authenticate(intertactivity, (code) =>
        {
            statusTxt.text = "Authenticating...";
            if(code == SignInStatus.Success)
            {
                statusTxt.text = "Successfully Authenticated";
                descriptionTxt.text = "Hello" + Social.localUser.userName + " You have and id of " + Social.localUser.id;
                btn_Home.SetActive(true);
            }
            else
            {
                statusTxt.text += "\n\nFailed to Authenticate";
                descriptionTxt.text = "Failed to Authenticate, reason for failure is " + code;

            }
        });
    }

    public void BasicSignInBtn()
    {
        SignIntoGPGS(SignInInteractivity.CanPromptAlways, clientConfiguration);
    }

    public void SignOutBtn()
    {
        PlayGamesPlatform.Instance.SignOut();
        statusTxt.text = "Sign in to access \nAchievements & Leaderboards";
        descriptionTxt.text = "";

        btn_Home.SetActive(true);
    }

  }
