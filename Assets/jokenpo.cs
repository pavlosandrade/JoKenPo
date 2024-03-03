using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jokenpo : MonoBehaviour
{

    public InputField playerOneMove;
    public Text playerTwoMove;
    public Text result;
       
    public void Play()
    {
        string _playerOneMove = playerOneMove.text.ToLower();
        string _playerTwoMove = MovePLayerTwo();
        
        Winner(_playerOneMove, _playerTwoMove);
    }

    string MovePLayerTwo()
    {
        string move = Random.Range(0, 3).ToString();


        switch (move)
        {
            case "0":
                move = "pedra";
                playerTwoMove.text = move;
                break;
            case "1":
                move = "papel";
                playerTwoMove.text = move;
                break;
            case "2":
                move = "tesoura";
                playerTwoMove.text = move;
                break;
        }

        return move;
    }

    void Winner(string playerOneMove, string playerTwoMove)
    {

        if (playerOneMove == "")
        {
            result.text = "A CPU Venceu, você perdeu por que não jogou";
            return;
        }

        if (playerOneMove == playerTwoMove)
        {
            result.text = "EMPATE";
            return;
        }

        if ((playerOneMove == "pedra" && playerTwoMove == "tesoura") ||
            (playerOneMove == "papel" && playerTwoMove == "pedra") ||
            (playerOneMove == "tesoura" && playerTwoMove == "papel"))
        {
            result.text = "Você Venceu";
            return;
        }

        result.text = "A CPU Venceu, você perdeu";

    }
}
