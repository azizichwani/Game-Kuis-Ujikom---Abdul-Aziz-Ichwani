using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Quiz.Global.Database;
using Quiz.Pack.PackScene;

namespace Quiz.Pack.PackData{
    public class PackDataController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI[] _packName;
        [SerializeField] private Button[] _selectButton;
        //[SerializeField] private Text _unlockCostLabel;
        //[SerializeField] private Button _unlockButton;
        //[SerializeField] private Image _completeImage;
        [SerializeField] private PackView _packView;

        private string[] _listPacks;
        private PackDataModel[] _packs;

        private void Awake(){
            LoadPackList();
            _packs = GetPackList();
            InitPackList(_packs);
        }



        public void LoadPackList()
        {
            _listPacks = DatabaseController.dataInstance.GetPackList();
        }

        public PackDataModel[] GetPackList()
        {
            PackDataModel[] setPacks = new PackDataModel[_listPacks.Length];
            for(int i = 0; i<setPacks.Length; i++)
            {
                setPacks[i].packID = _listPacks[i];
                setPacks[i].packName = setPacks[i].packID;
            }
            return setPacks;
        }

        public void InitPackList(PackDataModel[] packs)
        {
            for(int i = 0; i<packs.Length; i++)
            {
                int setPacksIndex = i;
                _packName[i].text = packs[i].packName;
                _selectButton[i].onClick.AddListener(()=> _packView.SelectPack(packs[setPacksIndex].packID));
                //_selectButton[i].gameObject.SetActive(true);
            }
            
        }
    }
}