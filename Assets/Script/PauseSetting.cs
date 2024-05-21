using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseSetting : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject Pause;
    public GameObject SoundPanel;

    public void PauseButton()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
        Pause.SetActive(true);
        AudioManager.Instance.PlaySFX("Button");
    }

    public void ResumeClicked()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
        AudioManager.Instance.PlaySFX("Button");
    }

    public void SettingClicked()
    {
        Pause.SetActive(false);
        SoundPanel.SetActive(true);
        AudioManager.Instance.PlaySFX("Button");
    }

    public void BackClicked()
    {
        Pause.SetActive(true);
        SoundPanel.SetActive(false);
        AudioManager.Instance.PlaySFX("Button");
    }

    public void QuitClicked()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScreen");
        AudioManager.Instance.musicSource.Stop();
        AudioManager.Instance.PlayMusic("Theme");
        AudioManager.Instance.PlaySFX("Button");
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("SampleScene");
        AudioManager.Instance.PlayMusic("Game");
        AudioManager.Instance.PlaySFX("Button");
    }


}
