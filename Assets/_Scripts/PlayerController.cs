using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator _anim;
    public bool _playerMovement=false;

    private CameraController _cameraController;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _cameraController = FindObjectOfType<CameraController>();

    }

    private void Update()
    {



        _anim.SetBool("IsMoving",_playerMovement);
       
       
           
      

    }


}
