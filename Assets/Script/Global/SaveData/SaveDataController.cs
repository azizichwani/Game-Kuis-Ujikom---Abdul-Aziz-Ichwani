using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quiz.Global.SaveData{
    public class SaveDataController : MonoBehaviour
    {
        public static SaveDataController saveInstance;

        private const string _prefsKey = "SaveData";

        public int coin;
        public string[] unlockedPack;
        public string[] completedPack;
        public string[] completedLevel;

        [HideInInspector]
        public string _selectedPack;
        [HideInInspector]
        public string _selectedLevel;

        private void Awake()
        {
            if (saveInstance != null && saveInstance != this)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                saveInstance = this;
            }
            DontDestroyOnLoad(gameObject);
        }

        private void Save()
        {
            string json = JsonUtility.ToJson(this);
            PlayerPrefs.SetString(_prefsKey, json);
            Debug.Log(json);
        }

        private void Load()
        {
            if(PlayerPrefs.HasKey(_prefsKey)){
                string json = PlayerPrefs.GetString(_prefsKey);
                JsonUtility.FromJsonOverwrite(json, this);
            }
            else{
                Save();
            }
        }

        public void OnSelectedPack(string packID)
        {
            _selectedPack = packID;
        }

        public void OnSelectedLevel(string levelID)
        {
            _selectedLevel = levelID;
        }
    }
}

