using System;
using System.Collections;
using System.Collections.Generic;
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

    private BattleStates currentState;

    void Start()
    {
        currentState = BattleStates.Start;
    }

    void Update()
    {
        Debug.Log(currentState);
        switch (currentState)
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
            switch (currentState)
            {
                case BattleStates.Start:
                    currentState = BattleStates.PlayerChoice;
                    break;
                case BattleStates.PlayerChoice:
                    currentState = BattleStates.EnemyChoice;
                    break;
                case BattleStates.EnemyChoice:
                    currentState = BattleStates.Lose;
                    break;
                case BattleStates.Lose:
                    currentState = BattleStates.Win;
                    break;
                case BattleStates.Win:
                    currentState = BattleStates.Start;
                    break;
            }
        }
    }
}