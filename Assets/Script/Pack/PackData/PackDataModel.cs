using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quiz.Pack.PackData{
    public struct PackDataModel
    {
        public string packID;
        public string packName;
        public bool isCompleted;
        public bool isUnlocked;
        public int unlockCost;
    }
}
