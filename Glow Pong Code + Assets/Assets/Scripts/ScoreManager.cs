using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreToReach;

    private int player1score = 0;
    private int player2score = 0;

    public Text player1ScoreText;
    public Text player2ScoreText;

    public void Player1Goal()
    {
        player1score++;
        player1ScoreText.text = player1score.ToString();
        CheckScore();
    }

    public void Player2Goal()
    {
        player2score++;
        player2ScoreText.text = player2score.ToString();
        CheckScore();
    }

    private void CheckScore()
    {
        if(player1score == scoreToReach || player2score == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }

}
