using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    Text scoreText;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        UpdateScoreBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateScoreBoard()
    {
        scoreText.text = score.ToString();
    }
    public void ScoreHit(int points)
    {
        score += points;
        UpdateScoreBoard();
    }
}
