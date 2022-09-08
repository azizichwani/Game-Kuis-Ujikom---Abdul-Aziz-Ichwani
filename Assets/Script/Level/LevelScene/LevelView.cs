using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Quiz.Global.SaveData;
using UnityEngine.SceneManagement;

namespace Quiz.Level.LevelScene{
    public class LevelView : MonoBehaviour
    {
        [SerializeField] private Button _backButton;

        private SaveDataController _saveData;

        private void Awake() {
            _backButton.onClick.AddListener(GoBack);
        }

        private void GoBack(){
            SceneManager.LoadScene("Pack");
        }

        public void SelectLevel(string levelID)
        {
            _saveData.OnSelectedLevel(levelID);
            SceneManager.LoadScene("Gameplay");
        }
    }
}
