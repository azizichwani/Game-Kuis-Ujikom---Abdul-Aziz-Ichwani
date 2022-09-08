using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeView : MonoBehaviour
{
    [SerializeField]
    private Button _playButton;

    // Start is called before the first frame update
    private void Awake()
    {
        _playButton.onClick.AddListener(StartGame);
    }

    private void StartGame(){
        SceneManager.LoadScene("Pack");
    }
}
