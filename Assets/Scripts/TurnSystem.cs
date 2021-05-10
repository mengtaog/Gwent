using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    public static TurnSystem Instance;




    public bool isYourTurn;
    public GameObject yourTurnIndicator;
    public GameObject enemyTurnIndicator;

    private void Awake()
    {
        Instance = this;

        //
        EndEnemyTurn();

    }

    public void EndCurrentTurn()
    {
        if (isYourTurn)
        {
            EndYourTurn();
        }
        else
        {
            EndEnemyTurn();
        }
    }

    private void EndYourTurn()
    {
        isYourTurn = false;
        yourTurnIndicator.SetActive(false);
        enemyTurnIndicator.SetActive(true);
    }

    private void EndEnemyTurn()
    {
        isYourTurn = true;
        yourTurnIndicator.SetActive(true);
        enemyTurnIndicator.SetActive(false);
    }
}
