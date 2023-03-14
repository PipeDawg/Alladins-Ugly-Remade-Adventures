using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2D;
    [Space]
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float distanceToGround;
    [Space]
    [SerializeField] private LayerMask ground;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), distanceToGround, ground);
            if(hit == true){
                rb2D.AddForce(transform.TransformDirection(Vector2.up) * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
}