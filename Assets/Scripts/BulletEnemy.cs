using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    
    private Player _player;

    private float _speed = 125.0f;
    private void Start()
    {
        _player = FindFirstObjectByType<Player>();
    }
    private void FixedUpdate()
    {
        _rb.velocity = Vector2.down * _speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _player.Hit();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
