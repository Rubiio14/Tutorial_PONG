using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScoreUI : MonoBehaviour
{
    //goles del jugador 1
    int goalsPlayerOne;
    //goles del jugador 2
    int goalsPlayerTwo;

    public TextMeshProUGUI scoreText;
    //Resetear goles
    void ResetScore()
    {
        goalsPlayerOne = 0;
        goalsPlayerTwo = 0;
        UpdateScoreText();
    }
    //Añadir goles
    public void GoalPlayerOne()
    {
        goalsPlayerOne++;
        UpdateScoreText();
    }
    public void GoalPlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScoreText();
    }

    //Mostrar
    void UpdateScoreText()
    {
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;
    }

}
