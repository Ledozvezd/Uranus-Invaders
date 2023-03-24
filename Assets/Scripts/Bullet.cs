using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Bullet : MonoBehaviour
{
    private float _speed = 125.0f;
    private ScoreManager _manager;

    [SerializeField] private Rigidbody2D _rb;

    private void Start()
    {
        _manager = FindObjectOfType<ScoreManager>();
    }
    private void FixedUpdate()
    {
        _rb.velocity = Vector2.up * _speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            _manager.Kill();
        }
        else 
        {
            Destroy(gameObject);
        }  
    }
}
