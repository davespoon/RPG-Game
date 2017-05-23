using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class TurnBasedCombatStateMachine : MonoBehaviour
{
    private bool _hasAddetXP = false;

    public enum BattleStates
    {
        Start,
        PlayerChoice,
        EnemyChoice,
        Lose,
        Win
    }

    private BattleStates _currentState;

    void Start()
    {
        _hasAddetXP = false;
        _currentState = BattleStates.Start;
    }

    void Update()
    {
        Debug.Log(_currentState);
        switch (_currentState)
        {
            case BattleStates.Start:
                //SETUP BATTLE FUNCTION
                break;
            case BattleStates.PlayerChoice:
                break;
            case BattleStates.EnemyChoice:
                break;
            case BattleStates.Lose:
                break;
            case BattleStates.Win:
                if (!_hasAddetXP)
                {
                    IncreaseExperience.AddExperience();
                    _hasAddetXP = true;
                }

                break;
        }
    }

    private void OnGUI()
    {
        if (GUILayout.Button("NEXT STATE"))
        {
            switch (_currentState)
            {
                case BattleStates.Start:
                    _currentState = BattleStates.PlayerChoice;
                    break;
                case BattleStates.PlayerChoice:
                    _currentState = BattleStates.EnemyChoice;
                    break;
                case BattleStates.EnemyChoice:
                    _currentState = BattleStates.Lose;
                    break;
                case BattleStates.Lose:
                    _currentState = BattleStates.Win;
                    break;
                case BattleStates.Win:
                    _currentState = BattleStates.Start;
                    break;
            }
        }
    }
}