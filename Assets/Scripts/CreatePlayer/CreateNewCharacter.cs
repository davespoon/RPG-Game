using Assets.Scripts.CharacterClasses;
using Assets.Scripts.SavingAndLoading;
using UnityEngine;

namespace Assets.Scripts.CreatePlayer
{
    public class CreateNewCharacter : MonoBehaviour
    {
        private BasePlayer.BasePlayer _newPlayer;

        private bool _isMageClass;
        private bool _isWarrriorClass;
        private string _playerName = "Player-Bla-Bla";

        void Start()
        {
            _newPlayer = new BasePlayer.BasePlayer();
        }

        void Update()
        {
        }

        private void OnGUI()
        {
            _playerName = GUILayout.TextArea(_playerName);
            _isMageClass = GUILayout.Toggle(_isMageClass, "Mage Class");
            _isWarrriorClass = GUILayout.Toggle(_isWarrriorClass, "Warrior Class");

            if (GUILayout.Button("Create"))
            {
                if (_isMageClass)
                {
                    _newPlayer.PlayerClass = new BaseMageClass();
                }
                else if (_isWarrriorClass)
                {
                    _newPlayer.PlayerClass = new BaseWarriorClass();
                }
                _newPlayer.PlayerName = _playerName;
                _newPlayer.PlayerLevel = 1;
                _newPlayer.Stamina = _newPlayer.PlayerClass.Stamina;
                _newPlayer.Dexterity = _newPlayer.PlayerClass.Dexterity;
                _newPlayer.Intellect = _newPlayer.PlayerClass.Intellect;
                _newPlayer.Strenght = _newPlayer.PlayerClass.Strength;

                SaveInformation.SaveAllInformation();

                Debug.Log("Player Name: " + _newPlayer.PlayerName);
                Debug.Log("Player class: " + _newPlayer.PlayerClass.CharacterClassName);
                Debug.Log("Player level: " + _newPlayer.PlayerLevel);
            }
        }
    }
}