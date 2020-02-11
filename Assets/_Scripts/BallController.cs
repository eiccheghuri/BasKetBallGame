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
   

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;

    }

    private void LateUpdate()
    {

        _ballDirection = _basket.position- transform.position;
        if(_isHolding)
        {
            transform.position = _ballPosition.position;
        }
      

    }


    public void ThrowButtonClicked()
    {

        _isHolding = false;
        _rigidbody.useGravity = true;
        _rigidbody.AddForce(_ballDirection*_throwForce);

    }






}
