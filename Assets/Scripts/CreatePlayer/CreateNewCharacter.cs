using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour
{
    private BasePlayer _newPlayer;

    private bool _isMageClass;
    private bool _isWarrriorClass;
    private string _playerName = "Enter Name";

    void Start()
    {
        _newPlayer = new BasePlayer();
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

            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            Debug.Log("Player Name: " + _newPlayer.PlayerName);
            Debug.Log("Player class: " + _newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player level: " + _newPlayer.PlayerLevel);
        }

        if (GUILayout.Button("Load"))
        {
            SceneManager.LoadScene("tSet");
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = _newPlayer.PlayerName;
        GameInformation.PlayerLevel = _newPlayer.PlayerLevel;
        GameInformation.Stamina = _newPlayer.Stamina;
        GameInformation.Dexterity = _newPlayer.Dexterity;
        GameInformation.Intellect = _newPlayer.Intellect;
        GameInformation.Strength = _newPlayer.Strenght;
    }
}