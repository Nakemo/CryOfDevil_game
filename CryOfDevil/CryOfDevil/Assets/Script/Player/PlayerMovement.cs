using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;
    private PlayerAnimationController _playerAnim;

    //-----Fixing Camera Rotation with player and flashlight----
    [SerializeField]
    private Camera playerCamera;
    private float sensitivityY = 2.5f;
    private float sensitivityX = 2.5f;
    
    private float rotationX = 0f;
    private float rotationY = 0f;

    private float angleYmin = -65;
    private float angleYmax = 70;
    //----------------------------------------------------------


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


    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _playerAnim = GetComponent<PlayerAnimationController>();

        //retirar o mouse da tela
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        //Camera Sensitivity
        float verticalDelta = Input.GetAxisRaw("Mouse Y") * sensitivityY;
        float horizontalDelta = Input.GetAxisRaw("Mouse X") * sensitivityX;         

        HandlePlaceMovements(horizontal, vertical);
        HandleCamera(verticalDelta, horizontalDelta);
        HandleGravity();        
    }

    void HandleCamera(float verticalDelta, float horizontalDelta) 
    {
        rotationX += horizontalDelta;
        rotationY += verticalDelta;
        
        rotationY = Mathf.Clamp(rotationY, angleYmin, angleYmax);
        playerCamera.transform.localRotation = Quaternion.Euler(-rotationY, rotationX, 0); 
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

