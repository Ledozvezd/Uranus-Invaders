using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 0.3f;
    [SerializeField] private Rigidbody2D _rb;

    private Vector2 movement;
    private void FixedUpdate()
    {
        movement = Vector2.right;
        _rb.velocity = movement * _speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Border"))
        {
            Vector3 positionEnemy = transform.position;
            
            if (_speed > 0)
            {
                transform.position = new Vector3(-1f, -0.5f, 0) + positionEnemy;
                _speed *= -1;
            }
            else
            {
                transform.position = new Vector3(1f, -0.5f, 0) + positionEnemy;
                _speed *= -1;
            }
            
            //transform.position = new Vector3(0, -0.5f, 0) + positionEnemy;
        }
    }
}
