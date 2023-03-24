using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private BulletEnemy _bulletPrefab;
    [SerializeField] private float _bulletPosition = 0.5f;
    public void GunEnemy()
    {
        Vector2 startShoot = transform.position + new Vector3(0, _bulletPosition, 0);
        BulletEnemy bullet = Instantiate(_bulletPrefab, startShoot, Quaternion.identity);
    }
    
}