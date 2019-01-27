using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonCallbacks : MonoBehaviour
{
    Button play;
    Button settings;
    public GameObject closeSettings;

    public GameObject optionsPanel;

    // Start is called before the first frame update
    void Start()
    {
        play = GameObject.Find("Play").GetComponent<Button>();
        settings = GameObject.Find("Settings").GetComponent<Button>();

        play.onClick.AddListener(StartGame);
        settings.onClick.AddListener(ShowSettings);
        closeSettings.GetComponent<Button>().onClick.AddListener(CloseSettings);

        optionsPanel.SetActive(false);

    }

    void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ShowSettings()
    {
        optionsPanel.SetActive(true);

    }

    void CloseSettings()
    {
        optionsPanel.SetActive(false);

    }
}
