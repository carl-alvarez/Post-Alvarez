using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{
    //comment
    public float moveSpeed = 10f;
    public float rotateSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        CheckRotation();
    }

    void CheckMovement()
    {
        var xMove = transform.right * (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);
        var zMove = transform.forward * (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);
        var move = xMove + zMove;

        transform.position += move;
    }

    void CheckRotation()
    {
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime * 500;

        transform.Rotate(0f, rotation, 0f);
    }
}
