using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;
    [SerializeField] private Rigidbody2D _rb;
    public void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput * _speed * Time.deltaTime, 0, 0);
    }
}
