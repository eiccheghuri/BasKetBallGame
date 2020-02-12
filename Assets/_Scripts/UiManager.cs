using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{


    
    public GameObject _gameOverPanel;
    [SerializeField]
    private TextMeshProUGUI _finalScore;

    private void Start()
    {
        _gameOverPanel.SetActive(false);
    }


    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameOver()
    {
        _gameOverPanel.SetActive(true);

    }




}
