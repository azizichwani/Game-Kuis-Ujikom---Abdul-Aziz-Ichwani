using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Quiz.Level.LevelScene;
using Quiz.Global.Database;
using Quiz.Global.SaveData;

namespace Quiz.Level.LevelData{
    public class LevelDataController : MonoBehaviour
    {
        [SerializeField] private Text[] _levelNameLabel;
        [SerializeField] private Button[] _selectButton;
        [SerializeField] private Image[] _completeImage;
        [SerializeField] private LevelView _levelview;

        private string[] _listLevel;
        private LevelDataModel[] _levels;

        private void Awake() {
            LoadLevelList();
            _levels = GetLevelList();
            InitLevelList(_levels);
        }

        private void LoadLevelList(){
            _listLevel = DatabaseController.dataInstance.GetLevelList(SaveDataController.saveInstance._selectedLevel);
        }

        private LevelDataModel[] GetLevelList(){
            LevelDataModel[] setLevel = new LevelDataModel[_listLevel.Length];
            for (int i = 0; i <setLevel.Length; i++)
            {
                setLevel[i].levelID = _listLevel[i];
                setLevel[i].levelName = setLevel[i].levelID;
                for (int j = 0; j < SaveDataController.saveInstance.completedLevel.Length; j++)
                {
                    if (setLevel[i].levelID == SaveDataController.saveInstance.completedLevel[j])
                    {
                        setLevel[i].IsCompleted = true;
                    }
                }
            }
            return setLevel;
        }

        private void InitLevelList(LevelDataModel[] levels)
        {
            for (int i = 0; i<levels.Length; i++)
            {
                int setLevelIndex = i;
                _levelNameLabel[i].text = levels[i].levelName;
                _selectButton[i].onClick.AddListener(()=> _levelview.SelectLevel(levels[setLevelIndex].levelID));
            }
        }
        
    }
}


