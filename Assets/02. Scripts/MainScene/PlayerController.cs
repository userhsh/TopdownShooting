using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput = null;

    Camera mainCamera = null;

    Vector3 shootPosition = Vector3.zero;
    Vector3 shootAimPosition = Vector3.zero;

    Animator animator = null;

    private void Awake()
    {
        PlayerControllerInit();
    }

    private void Update()
    {
        AimToMouse();   

        if (Input.GetMouseButtonDown(0)) 
        {
            Attack();
        }
    }

    private void PlayerControllerInit()
    {
        playerInput = GetComponent<PlayerInput>();
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        animator = GetComponent<Animator>();
    }

    private void Attack()
    {
        
    }

    private void AimToMouse()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) ) 
        {
            shootAimPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z) - this.transform.position;
            animator.transform.forward = shootAimPosition;
        }
    }
}