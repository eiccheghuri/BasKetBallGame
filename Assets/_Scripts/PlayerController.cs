using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator _anim;
    [HideInInspector]
    public bool _playerMovement=false;
    [HideInInspector]
    public bool _isThrow;

    private Transform _StartPosition;
    
    

    private CameraController _cameraController;
    private BallController _ballController;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _cameraController = FindObjectOfType<CameraController>();
        _ballController = FindObjectOfType<BallController>();

        _StartPosition = transform;

    }

    private void Update()
    {

        //_anim.SetBool("IsMoving",_playerMovement);
        //if(_isThrow)
       // {
           // _anim.SetTrigger("Throw");
        //}


    }

    public void Throwing()
    {
        _ballController.Throwing();
    }


    public void ResetGame()
    {
        _isThrow = false;
       
        _anim.ResetTrigger("Throw");
        _ballController._isHolding = true;
       // _anim.Play("Goalkeeper Idle (1)");
        transform.position = _StartPosition.position;
        transform.rotation = _StartPosition.rotation;
        _cameraController.ResetGame();
        
        


    }


}
