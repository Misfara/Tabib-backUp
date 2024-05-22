using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider progressSlider;
    public GameObject MenuButton;
    public GameObject Option;
    public GameObject settingPanel;
    public GameObject instructionPanel;

        //START MENU//
    public void StartGame(int index)
    {
        StartCoroutine(LoadScene_Coroutine(index));
        SceneManager.LoadScene("SampleScene");
        AudioManager.Instance.musicSource.Stop();
        AudioManager.Instance.PlayMusic("Game");
        AudioManager.Instance.PlaySFX("Button");
    }

    public void LoadGame(){
        SceneManager.LoadScene("LoadGame");
        AudioManager.Instance.PlaySFX("Button");
    }

    public void OptionClicked()
    {
        if (Option.activeInHierarchy == false)
        {
            Option.SetActive(true);
            settingPanel.SetActive(true);
            MenuButton.SetActive(false);
            instructionPanel.SetActive(false);
            
            AudioManager.Instance.PlaySFX("Button");
        }
        else
        {
            Option.SetActive(false);
            MenuButton.SetActive(true);
            AudioManager.Instance.PlaySFX("Button");
        }
    }

    public void SettingClicked()
    {
        settingPanel.SetActive(true);
        instructionPanel.SetActive(false);
        AudioManager.Instance.PlaySFX("Button");
    }

    public void InstructionClicked()
    {
        instructionPanel.SetActive(true);
        settingPanel.SetActive(false);
        AudioManager.Instance.PlaySFX("Button");
    }

    public void QuitGame(){
        Application.Quit();
        AudioManager.Instance.PlaySFX("Button");
    }

    public IEnumerator LoadScene_Coroutine(int index)
    {
        progressSlider.value = 0;
        LoadingScreen.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSlider.value = progress;
            if (progress >=0.9f)
            {
                progressSlider.value = 1;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    
    //LOAD MENU//
    public void StartMenu(){
        SceneManager.LoadScene("StartScreen");
        AudioManager.Instance.PlaySFX("Button");
    }

    // public void SaveGameClicked()
    // {
    //     DataPersistenceManager.instance.SaveGame();
    // }
}
