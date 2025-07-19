using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    private MovementManager movementManager;
    //private PlayerAnimation playerAnimation;


    [SerializeField] private InputActionReference movement, pointerPosition;

    private Vector2 movementInput, pointerInput;
    public Vector2 PointerInput => pointerInput;

    private WeaponParent weaponParent;

    public void Awake()
    {
        movementManager = GetComponent<MovementManager>();
        weaponParent = GetComponentInChildren<WeaponParent>();
        //playerAnimation = GetComponentInChildren<PlayerAnimation>();
    }

    //private void AnimateCharacter()
    //{
    //    Vector2 lookDirection = pointerInput - (Vector2)transform.position;
    //    playerAnimation.RotateToPointer(lookDirection);
    //    playerAnimation.PlayAnimation(movementInput);
    //}

    private void Update()
    {
        pointerInput = GetPointerInput();
        weaponParent.PointerPosition = pointerInput;

        movementInput = movement.action.ReadValue<Vector2>().normalized;
        movementManager.MovementInput = movementInput;

        //AnimateCharacter();
    }

    private Vector2 GetPointerInput()
    {
        Vector3 mousePos = pointerPosition.action.ReadValue<Vector2>();
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
