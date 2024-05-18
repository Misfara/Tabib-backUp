using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour //, IDataPersistence
{
    public GameObject NameInput;
    public InputField textBox;

    public void clickSaveButton()
    {
        PlayerPrefs.SetString("name", textBox.text);
        Debug.Log("Your name is " + PlayerPrefs.GetString("name"));
        NameInput.SetActive(false);
    }

    // public void LoadData(GameData data)
    // {
    //     this.textBox = data.textBox;
    // }

    // public void SaveData(ref GameData data)
    // {
    //     data.textBox = this.textBox;
    // }
}
