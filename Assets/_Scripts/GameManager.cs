using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public PlayerController _playerController;
    [SerializeField]
    private Transform _cameraPosition;

    private void Start()
    {
        _playerController = FindObjectOfType<PlayerController>();
       
    }


    public void SpawnButtonClicked()
    {
        _playerController.ResetGame();
        


    }



}
