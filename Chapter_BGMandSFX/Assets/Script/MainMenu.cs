using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;
    void Start()
    {
        _startButton.onClick.AddListener(delegate { StartButtonClick(_startButton); });
        _optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        _exitButton.onClick.AddListener(delegate { ExitButtonClick(_exitButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButtonClick(Button button)
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void OptionsButtonClick(Button button)
    {
        if (!SingletonGameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("Option", LoadSceneMode.Additive);
            SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }
    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }

}
