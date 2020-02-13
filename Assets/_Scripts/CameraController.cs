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

    public Transform _startTransform;

    [HideInInspector]
    public float _h, _v;
    public bool _spawnButtonClicked = true;

   

    private void Start()
    {
        _playerController = FindObjectOfType<PlayerController>();
        _currentCameraPosition = _mainCamera.transform.position;
        _startTransform = _mainCamera.transform;

    }

    private void Update()
    {
        if(_spawnButtonClicked==true)
        {
            KeyBoardInput();
        }
       

    }

    private void KeyBoardInput()
    {

       float _moveMentVertical=Input.GetAxis("Vertical");
        float _moveMentHorizontal = Input.GetAxis("Horizontal");
        //_mainCamera.transform.Translate(0,0,_moveMentVertical*_speed*time);
        _v += _moveMentVertical;
        _h += _moveMentHorizontal;

        _v= Mathf.Clamp(_v, -25f,5f);
        _h = Mathf.Clamp(_h, -8f, 8f);

        Vector3 _rotate = new Vector3(_v * _speed, _h * _speed, 0);

        _mainCamera.transform.localRotation = Quaternion.Euler(_rotate);

        



       // Debug.Log(_mainCamera.transform.localEulerAngles);

        // _mainCamera.transform.RotateAround(Vector3.zero,_rotate,70f);

        //_mainCamera.transform.Rotate(_rotate*Time.deltaTime);
        /*
        if (_playerController!=null)
        {
            if(_moveMentVertical!=0)
            {
                _playerController._playerMovement = true;
               
            }
            else
            {
                _playerController._playerMovement = false;
            }
        } */
    }

    public void ResetGame()
    {

       // Debug.Log(_mainCamera.transform.localEulerAngles);

        //_mainCamera.transform.eulerAngles = Quaternion.Euler(0, 0, 0);

        _mainCamera.transform.localRotation = Quaternion.Euler(new Vector3(0,0,0));
        _h = 0;
       _v = 0;
        _spawnButtonClicked = true;
    }

    



}


