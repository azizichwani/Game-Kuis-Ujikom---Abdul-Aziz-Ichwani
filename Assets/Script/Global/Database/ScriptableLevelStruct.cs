using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quiz.Global.Database{
    [CreateAssetMenu]
    public class ScriptableLevelStruct : ScriptableObject
    {
        [SerializeField] private LevelStruct[] _levelStructs;

        public LevelStruct[] levelStructs => _levelStructs;
    }
}
