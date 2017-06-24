using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour
{
    private BasePlayer _newPlayer;

    private bool _isMageClass;
    private bool _isWarrriorClass;
    private string _playerName = "EnterName";

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

            CreateNewPlayer();
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            /*Debug.Log("Player Name: " + _newPlayer.PlayerName);
            Debug.Log("Player class: " + _newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player level: " + _newPlayer.PlayerLevel);*/
        }

        if (GUILayout.Button("Load"))
        {
            //LoadInformation.LoadAllInformation();
            SceneManager.LoadScene("TestLoading");
        }
    }

    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = _newPlayer.PlayerName;
        GameInformation.PlayerLevel = _newPlayer.PlayerLevel;
        GameInformation.Vitality = _newPlayer.Vitality;
        GameInformation.Intellect = _newPlayer.Intellect;
        GameInformation.Resistance = _newPlayer.Resistance;
        GameInformation.Dexterity = _newPlayer.Dexterity;
        GameInformation.Strength = _newPlayer.Strength;
<<<<<<< HEAD
        GameInformation.Gold = _newPlayer.Gold;

        
=======
>>>>>>> a493d3558f59f88378597c03a3572a5b1bf9c9be
    }

    private void CreateNewPlayer()
    {
        _newPlayer.PlayerName = _playerName;
        _newPlayer.PlayerLevel = 1;
        _newPlayer.Vitality = _newPlayer.PlayerClass.Vitality;
        _newPlayer.Intellect = _newPlayer.PlayerClass.Intellect;
        _newPlayer.Resistance = _newPlayer.PlayerClass.Resitance;
        _newPlayer.Dexterity = _newPlayer.PlayerClass.Dexterity;
        _newPlayer.Strength = _newPlayer.PlayerClass.Strength;
        _newPlayer.Gold = 100;
<<<<<<< HEAD

        Debug.Log("Player name is: " + _newPlayer.PlayerName);
        Debug.Log("Player level is : " + _newPlayer.PlayerLevel);
        Debug.Log("Player dexterity is : " + _newPlayer.Dexterity);
        Debug.Log("Player intellect is : " + _newPlayer.Intellect);
        Debug.Log("Player resistance is : " + _newPlayer.Resistance);
        Debug.Log("Player strength is : " + _newPlayer.Strength);
        Debug.Log("Player gold is : " + _newPlayer.Gold);
=======
>>>>>>> a493d3558f59f88378597c03a3572a5b1bf9c9be
    }
}