using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Quiz.Global.SaveData;


namespace Quiz.Pack.PackScene{
    public class PackView : MonoBehaviour
    {
        [SerializeField] private Button _backButton;

        private SaveDataController _saveData;

        private void Awake() {
            _backButton.onClick.AddListener(GoBack);
        }

        public void GoBack(){
            SceneManager.LoadScene("Home");
        }

        public void SelectPack(string packID)
        {
            _saveData.OnSelectedPack(packID);
            SceneManager.LoadScene("Level");
        }
    }
}

