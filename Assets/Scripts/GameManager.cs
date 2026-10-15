using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum PlayerType
{
    PlayerRight,
    PlayerLeft
}
public class GameManager : MonoBehaviour
{
    private int scorePlayerRight;
    private int scorePlayerLeft;

    public TextMeshProUGUI lblScore;
    public GameObject restartButton;
    public GameObject ball;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
        
        restartButton.SetActive(false);
    }

    public void UpdateScore()
    {
        lblScore.SetText(scorePlayerLeft + " - " + scorePlayerRight);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount, PlayerType type)
    {
        if (type == PlayerType.PlayerRight)
        {
            scorePlayerRight += amount;
        }
        else 
        {
            scorePlayerLeft += amount;
        }
        
        
        Debug.Log("Score Player Right: " + scorePlayerRight);
        Debug.Log("Score Player Left: " + scorePlayerLeft);
        UpdateScore();

        if (scorePlayerRight >= 3 || scorePlayerLeft >= 3)
        {
            restartButton.SetActive(true);
            Destroy(ball);
        }
            
    }


    public void RestartGame()
    {
        Debug.Log("hola mon");
        SceneManager.LoadScene(0);
    }
}
