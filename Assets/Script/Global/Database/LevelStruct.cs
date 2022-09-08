using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quiz.Global.Database{
    [System.Serializable]
    public struct LevelStruct
    {
        public string levelID;
        public string packID;
        public string question;
        //public string hint;
        public string[] choice;
        public int answer;
    }
}
