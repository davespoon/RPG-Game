using UnityEngine;


public class TurnBasedCombat : MonoBehaviour
{
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
        _currentState = BattleStates.Start;
    }

    void Update()
    {
        Debug.Log(_currentState);
        switch (_currentState)
        {
            case BattleStates.Start:
                //setup battle function
                break;
            case BattleStates.PlayerChoice:
                break;
            case BattleStates.EnemyChoice:
                break;
            case BattleStates.Lose:
                break;
            case BattleStates.Win:
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