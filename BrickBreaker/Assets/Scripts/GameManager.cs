using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public int lives;
    public Text livesText;
    public Text scoreText;
    public bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives : " + lives;
        scoreText.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Updatelives(int changeInLives)
    {
        lives += changeInLives;
        if(lives <1)
        {
            GameOver();
            lives = 0;
            
        }
        livesText.text = "Lives : " + lives;
    }

    public void Updatescore( int points)
    {
        score += points;
        scoreText.text = "Score : " + score;
    }

    void GameOver()
    {
        gameOver = true;
    }

}
