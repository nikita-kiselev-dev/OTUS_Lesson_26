using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] Animator animator;

    private void OnMove(InputValue value)
    {
        Vector2 v2 = value.Get<Vector2>();
        _rb.velocity = new Vector3(v2.x * _speed, _rb.velocity.y, v2.y * _speed);

    }
}
