using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public bool _isHolding = true;
    public float _throwForce = 100f;

    

    private Rigidbody _rigidbody;

    private Vector3 _ballDirection;

    [SerializeField]
    private Transform _ballPosition;

    private PlayerController _playerController;
    private ScoreManager _scoreManager;

    [SerializeField]
    private Button _throwButton;
    [SerializeField]
    private Transform _mainCamera;
    [SerializeField]
    private GameObject _player;

    private CameraController _cameraController;
   

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
        _playerController = FindObjectOfType<PlayerController>();
        _scoreManager = FindObjectOfType<ScoreManager>();
        _cameraController = FindObjectOfType<CameraController>();

    }

    private void LateUpdate()
    {

       
        if(_isHolding)
        {
            _rigidbody.useGravity = false;
            transform.position = _ballPosition.position;
        }


       // Debug.Log(_mainCamera.transform.position);
      //  Debug.Log(_mainCamera.transform.name);


    }


    public void ThrowButtonClicked()
    {

        if (_playerController != null)
        {
            _cameraController._spawnButtonClicked = false;
            _playerController._isThrow = true;
           
            _throwButton.interactable = false;
            Throwing();
            StartCoroutine(CallingMissingBall());
        }

        

    }

    public void Throwing()
    {
        _isHolding = false;
        _rigidbody.useGravity = true;
        
        _rigidbody.velocity = Vector3.zero;
        // _rigidbody.AddForce(_mainCamera.transform.forward * _throwForce,ForceMode.Impulse);

        Vector3 throwDirection = _mainCamera.forward;

        _rigidbody.AddForce(throwDirection*_throwForce);

    }

    IEnumerator CallingMissingBall()
    {
        yield return new WaitForSeconds(8f);
       
        _scoreManager.CountingMissingBall();
        _throwButton.interactable = true;
    }





   





}
