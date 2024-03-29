using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameplayHandler : MonoBehaviour
{

    int randomNumber;

    public InputHandler InputHandler;
    public Player player;

    public bool enemyHasShotThisTurn;

    // Start is called before the first frame update
    void Start()
    {
        enemyHasShotThisTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (InputHandler.PlayerTurn == false && enemyHasShotThisTurn == false)
        {
            //randomNumber = Random.Range(1, 6);
            //for (int i = 0; i < 1;)
            //{
                randomNumber = Random.Range(1, 6);
                if (randomNumber == 1 && player.partsArray[0].activeInHierarchy == true)
                {
                    player.PlayerTakeHeadDamage(2);
                    enemyHasShotThisTurn = true;
                    //i++;
                }
                if (randomNumber == 2 && player.partsArray[1].activeInHierarchy == true)
                {
                    player.PlayerTakeTorsoDamage(2);
                    enemyHasShotThisTurn = true;
                    //i++;
                }
                if (randomNumber == 3 && player.partsArray[2].activeInHierarchy == true)
                {
                    player.PlayerTakeLeftArmDamage(2);
                    enemyHasShotThisTurn = true;
                    //i++;
                }
                if (randomNumber == 4 && player.partsArray[3].activeInHierarchy == true)
                {
                    player.PlayerTakeRightArmDamage(2);
                    enemyHasShotThisTurn = true;
                    //i++;
                }
                if (randomNumber == 5 && player.partsArray[4].activeInHierarchy == true)
                {
                    player.PlayerTakeLeftLegDamage(2);
                    enemyHasShotThisTurn = true;
                    //i++;
                }
                if (randomNumber == 6 && player.partsArray[5].activeInHierarchy == true)
                {
                    player.PlayerTakeRightLegDamage(2);
                    enemyHasShotThisTurn = true;
                    //i++;
                }
            //}
        }
    }
}
