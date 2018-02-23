using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuStart : MonoBehaviour {

    [SerializeField] Button playButton;
    [SerializeField] Button exitButton;

    void Start () {

        playButton.onClick.AddListener(delegate { Play(); });
        exitButton.onClick.AddListener(delegate { Exit(); });
    }

    private void Play()
    {
        SceneManager.LoadScene(1);
    }

    private void Exit()
    {
        Application.Quit();
    }
}
