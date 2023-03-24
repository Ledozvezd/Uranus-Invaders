using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private float _bulletPosition = 0.5f;

    public float AccumulatedTime { get; private set; }
    public readonly float Cooldown = 1.5f; 
    private void Gun()
    {
        Vector2 startShoot = transform.position + new Vector3(0, _bulletPosition, 0);
        Bullet bullet = Instantiate(_bulletPrefab, startShoot, Quaternion.identity);
    }
    public void Reload(float deltaTime)
    {
        AccumulatedTime += deltaTime;

        if (AccumulatedTime >= Cooldown)
        {
            Gun();
            AccumulatedTime = 0;
        }
    }
    private void Update()
    {
        Reload(Time.deltaTime);
    }

}
