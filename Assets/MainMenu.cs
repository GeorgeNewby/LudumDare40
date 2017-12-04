using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Text text;
    public Slider slider;
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        if(!PlayerPrefs.HasKey("Sensitivity"))
        {
            PlayerPrefs.SetFloat("Sensitivity", 2f);
        }
        else
        {
            slider.value = PlayerPrefs.GetFloat("Sensitivity");
        }

        if (PlayerPrefs.HasKey("Score"))
        {
            text.text = string.Format("Score: {0}", PlayerPrefs.GetFloat("Score"));
            PlayerPrefs.DeleteKey("Score");
        }
        else
        {
            text.text = string.Format("Score: {0}", 0f);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeSensitivity()
    {
        if (!PlayerPrefs.HasKey("Sensitivity"))
        {
            PlayerPrefs.SetFloat("Sensitivity", 2f);
        }
        else
        {
            PlayerPrefs.SetFloat("Sensitivity", slider.value);
        }
    }
}
