using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartMenu : UIManager
{
    //
    private GameObject skipText;
    private GameObject CG;
    private GameObject backGround;
    //
    private bool isPlayingCG;

    private void Awake()
    {
        Init();
    }

    //
    private void Update()
    {
        if (isPlayingCG)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(false == skipText.activeSelf)
                {
                    ShowUI(skipText);
                }
                else
                {
                    HideUI(skipText);
                    HideUI(CG);
                    isPlayingCG = false;
                    ShowUI(backGround);
                }
            }
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Init()
    {
        skipText = transform.DeepFind("SkipText").gameObject;
        CG = transform.DeepFind("OpeningCG").gameObject;
        backGround = transform.DeepFind("BackGround").gameObject;
        isPlayingCG = true;
        skipText.SetActive(false);
        backGround.SetActive(false);
        CG.SetActive(true);
    }
}
