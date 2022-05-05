using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;
    private PlayerAnimationController _playerAnim;


    //------RUNNING HANDLE VARIABLES---------
    [SerializeField]
    private float _Speed = 3f;
    [SerializeField]
    private float _maxSpeed = 3f;
    [SerializeField]
    private float _minSpeed = 3f;
    private float _accelerationSpeed = 3f;
    private float _decelerationSpeed = 3f;
    //---------------------------------------


    Vector3 forward;
    Vector3 strafe;
    Vector3 vertical;

    private float forwardSpeed_ = 3f;
    private float strafeSpeed_ = 3f;
        //controle de gravidade
    private float gravity = -4.5f;
    private Vector3 velocityY;


    void Start() //onde comeca tudo do game - starto o game tudo comeca junto 
    {
        _controller = GetComponent<CharacterController>();
        _playerAnim = GetComponent<PlayerAnimationController>();
    }

    void Update() //update do momento
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
             
        HandlePlaceMovements(horizontal, vertical);
        HandleGravity();
    }

    void HandlePlaceMovements(float horizontal, float vertical)
    {        
        forward = vertical * forwardSpeed_ * transform.forward;
        strafe = horizontal * strafeSpeed_ * transform.right;
                
        Vector3 finalVelocity = forward + strafe;

        WalkToRun();

        _controller.Move(finalVelocity * _Speed * Time.deltaTime);
    }

    void WalkToRun()
    {
        if (_playerAnim.IsRunning && _Speed < _maxSpeed) 
        {
            _Speed += _accelerationSpeed * Time.deltaTime;
        }

        if (!_playerAnim.IsRunning && _Speed > _minSpeed) 
        {
            if (_Speed < _minSpeed)
            {
                _Speed = _minSpeed;
            }
            else {
                _Speed -= _decelerationSpeed * Time.deltaTime;
            }
        }

    }

    void HandleGravity() 
    {
        if (!_controller.isGrounded) 
        {
            velocityY.y += gravity * Time.deltaTime;
            _controller.Move(velocityY);
        }
    }

}

