using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform characterBody;
    public Transform characterHead;
    public Transform characterLight;
    

    public float sensitivityY = 2.5f;
    public float sensitivityX = 2.5f;

    // aumenta ou diminui o angulo de rotação; que deve acumular a nossa variavel a cada frame.
    float rotationX = 0;
    float rotationY = 0;

    float angleYmin = -65;
    float angleYmax = 70;        

    void Start()
    {
        // pra tirar o mouse da tela
        Cursor.visible = false; 
        // que o mouse nao saia do centro quando movimentado dentro da aplicação em exe.
        Cursor.lockState = CursorLockMode.Locked;        
    }

    // método que faz um objeto ser acompanhado com uma atualização de posição "tempo real"
    private void LateUpdate()
    {
        transform.position = characterHead.position;     
    }


    void Update()
    {
        // Duas variaveis que armazenam o deslocamento do mouse na movimentação.
        //float verticalDelta = Input.GetAxisRaw("Mouse Y") * sensitivityY;
        float horizontalDelta = Input.GetAxisRaw("Mouse X") * sensitivityX;

        rotationX += horizontalDelta;
        //rotationY += verticalDelta;

        //limitador de rotação de camera
        rotationY = Mathf.Clamp(rotationY, angleYmin, angleYmax);

        //fazer o player se movimantar na mesma diração que a camera aponta
        characterBody.localEulerAngles = new Vector3(0, rotationX, 0);        

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);      
    }
}