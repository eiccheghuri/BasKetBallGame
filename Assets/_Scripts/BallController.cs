using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public bool _isHolding = true;
    public float _throwForce = 100f;

    public Transform _basket;

    private Rigidbody _rigidbody;

    private Vector3 _ballDirection;

    [SerializeField]
    private Transform _ballPosition;

    private PlayerController _playerController;
    private ScoreManager _scoreManager;

    [SerializeField]
    private Button _throwButton;
   

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
        _playerController = FindObjectOfType<PlayerController>();
        _scoreManager = FindObjectOfType<ScoreManager>();

    }

    private void LateUpdate()
    {

        _ballDirection = _basket.position- transform.position;
        if(_isHolding)
        {
            _rigidbody.useGravity = false;
            transform.position = _ballPosition.position;
        }
        
      

    }


    public void ThrowButtonClicked()
    {

        if (_playerController != null)
        {
            _playerController._isThrow = true;
           
            _throwButton.interactable = false;
            StartCoroutine(CallingMissingBall());
        }

        

    }

    public void Throwing()
    {
        _isHolding = false;
        _rigidbody.useGravity = true;
        _rigidbody.AddForce(_ballDirection * _throwForce);
        
    }

    IEnumerator CallingMissingBall()
    {
        yield return new WaitForSeconds(10f);
        _scoreManager.CountingMissingBall();
        _throwButton.interactable = true;
    }





   





}
