using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

   

    [SerializeField]
    private Camera _mainCamera;


    private Vector3 _currentCameraPosition;
    [SerializeField]
    private float _speed=20f;

    private PlayerController _playerController;

   

    private void Start()
    {
        _playerController = FindObjectOfType<PlayerController>();
        _currentCameraPosition = _mainCamera.transform.position;

    }

    private void Update()
    {

        KeyBoardInput();

    }

    private void KeyBoardInput()
    {

       float _moveMent=Input.GetAxisRaw("Vertical");
      //  Debug.Log(_moveMent);
        _mainCamera.transform.Translate(0,0,_moveMent*_speed*Time.deltaTime);
        if(_playerController!=null)
        {
            if(_moveMent!=0)
            {
                _playerController._playerMovement = true;
                Debug.Log("i am here");
            }
            else
            {
                _playerController._playerMovement = false;
            }
        }
    }

    



}


