using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quiz.Global.Database{
    public class DatabaseController : MonoBehaviour
    {
        public static DatabaseController dataInstance;

        [SerializeField] private ScriptableLevelStruct[] _levelDatabase;

        public ScriptableLevelStruct[] levelDatabase => _levelDatabase;

        private void Awake()
        {
            if (dataInstance != null && dataInstance != this)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                dataInstance = this;
            }
            DontDestroyOnLoad(gameObject);
        }

        public string[] GetPackList()
        {
            List<string> listpack = new List<string>();
            for(int i = 0; i < _levelDatabase.Length; i++)
            {
                for(int j = 0; j < listpack.Count; j++)
                {
                    if(_levelDatabase[i].levelStructs[i].packID == listpack[j])
                    {
                        listpack.Add(_levelDatabase[i].levelStructs[i].packID);
                    }
                }
            }
            return listpack.ToArray();
        }

        public string[] GetLevelList(string packID)
        {
            List<string> listlevel = new List<string>();
            for (int i = 0; i < _levelDatabase.Length; i++)
            {
                if(packID == _levelDatabase[i].levelStructs[i].packID)
                {
                    listlevel.Add(_levelDatabase[i].levelStructs[i].levelID);
                }
            }
            return listlevel.ToArray();
        }

        public ScriptableLevelStruct GetLevelData(string LevelID)
        {
            for(int i = 0; i<_levelDatabase.Length; i++)
            {
                if(LevelID == _levelDatabase[i].levelStructs[i].levelID)
                {
                    return _levelDatabase[i];
                }
            }
            return null;
        }
    }
}

