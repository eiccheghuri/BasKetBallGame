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





    private void Start()
    {
        _scoreText.text = "Score: " + _score;
    }


    public void IncreaseScore()
    {
        _score += _scoreToIncrease;
        _scoreText.text = "Score: " + _score;

    }





}
