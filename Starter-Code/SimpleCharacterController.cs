/*
*  Copyright (c) 2024 Erencan Pelin - All Rights Reserved
*  You may use, distribute and modify this code under
*  the terms of the MIT license.
*/

using UnityEngine;
using UnityEngine.InputSystem;

namespace TestingWorkshop.Runtime
{
  //very basic character controller using new Unity InputSystem, just so we can move the character with keyboard or gamepad or similar device
  [RequireComponent(typeof(PlayerInput))]
  [RequireComponent(typeof(Rigidbody2D))]
  [RequireComponent(typeof(CapsuleCollider2D))]
  public class SimpleCharacterController : MonoBehaviour
  {
    //fields
    [SerializeField] private float moveSpeed;
  
    //component refs
    private PlayerInput playerInput;
    private Transform _transform;
    private Rigidbody2D rigidbody;
  
    private Vector2 movement;
    
    private void Awake()
    {
      //get refs
      _transform = transform;
      playerInput = GetComponent<PlayerInput>();
      rigidbody = GetComponent<Rigidbody>();
    }
  
    private void Update()
    {
      //get input
      movement = playerInput.actions["Move"].readValue<Vector2>();
    }
    
    private void FixedUpdate()
    {
      //apply movement
      rigidbody.velocity = movement * moveSpeed;
    }
  }
}
