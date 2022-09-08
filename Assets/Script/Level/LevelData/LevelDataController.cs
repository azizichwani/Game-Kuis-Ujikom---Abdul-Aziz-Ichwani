using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Quiz.Level.LevelScene;

namespace Quiz.Level.LevelData{
    public class LevelDataController : MonoBehaviour
    {
        [SerializeField] private Text[] _levelNameLabel;
        [SerializeField] private Button[] _selectButton;
        [SerializeField] private Image[] _completeImage;
        [SerializeField] private LevelView _levelview;

        private string[] _lisLevel;
        private LevelDataModel[] _levels;

        
        
    }
}


