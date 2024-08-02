using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private float moveInputX;
    private float moveInputY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(moveInputX, 0f, moveInputY);

        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    public void MoveX(InputAction.CallbackContext context)
    {
        moveInputX = context.ReadValue<float>();
    }

    public void MoveY(InputAction.CallbackContext context)
    {
        moveInputY = context.ReadValue<float>();
    }
}
