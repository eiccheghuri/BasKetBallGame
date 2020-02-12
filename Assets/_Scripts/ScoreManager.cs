using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance;
    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }




    [SerializeField]
    private TextMeshProUGUI _scoreText;
    [HideInInspector]
    public int _score;
    [SerializeField]
    private int _scoreToIncrease=1;

    [SerializeField]
    private TextMeshProUGUI _ballMissText;

    [SerializeField]
    private TextMeshProUGUI _finalScoreText;

    
    private int _ballRemaining = 3;

    private UiManager _uimanager;

    [HideInInspector]
    public bool ScoreTriggered;





    private void Start()
    {
        _scoreText.text = "Score: " + _score;
        _ballMissText.text = "Ball: " + _ballRemaining;
        _uimanager = FindObjectOfType<UiManager>();
    }


    public void IncreaseScore()
    {
        _score += _scoreToIncrease;
        _scoreText.text = "Score: " + _score;

    }

    public void CountingMissingBall()
    {
       

        if(ScoreTriggered==false)
        {
            _ballRemaining--;
            _ballMissText.text = "Ball: " + _ballRemaining;

            if(_ballRemaining<=0)
            {
                _uimanager.GameOver();
                _finalScoreText.text = "SCORE: " + _score;
            }
            
            

        }
        ScoreTriggered = false;
    }






}
