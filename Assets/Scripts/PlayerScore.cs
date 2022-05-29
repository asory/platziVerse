using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class PlayerScore : MonoBehaviour
{
    public static PlayerScore instance;
    [SerializeField] Text poinstText;

    // Text timing
//    private float TextTimer = 1f;
  //  private float DissapearingTime;

    public int score ;
    int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
    }

    void Awake()
    {
        instance = this;
    }


    public void AddPoints(int points) {
        score = score + points;

        updateScore(score);
    }



    public void updateScore(int points)
    {
            //sum score
        poinstText.color = Color.black;
        poinstText.text = points.ToString();
        saveHighScore();

    }


    private void saveHighScore()
    {
        Debug.Log("saveHighScore:  " + score);

        if (highScore < score)
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }
}
