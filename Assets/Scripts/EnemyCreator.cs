using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    [SerializeField] private EnemyShoot _enemyPrefab;
    [SerializeField] private float _enemyPosition = 10.5f;

    private EnemyShoot [,] enemyQuantity = new EnemyShoot[2,5];
    private Vector3 _creatorPosition;
    private float yPos = 0;
    private float xPos = 0;
    private readonly float Cooldown = 1f;
    private int _firstIndex;
    private int _lastIndex;

    public float AccumulatedTime { get; private set; }
    void Start()
    {
        for (int i = 1; i < 3; i++) 
        {
            for(int j = 1; j < 6; j++)
            {
                _creatorPosition = transform.position + new Vector3(j*_enemyPosition+xPos,yPos,0);
                EnemyShoot enemy = Instantiate(_enemyPrefab, _creatorPosition, Quaternion.identity);
                enemyQuantity[i-1, j-1] = enemy;
                enemy.transform.parent = gameObject.transform;
            }
            yPos -= 1.5f;
            xPos -= 0.5f;
        }
    }

    void Update()
    {
        for (int i = 0; i < Random.Range(1,3); i++)
        {
            Reload(Time.deltaTime);
        }
    }
    public void Reload(float deltaTime)
    {
        AccumulatedTime += deltaTime;
        _firstIndex = Random.Range(0, 2);
        _lastIndex = Random.Range(0, 5);

        if (AccumulatedTime >= Cooldown)
        {
            if (enemyQuantity[_firstIndex, _lastIndex] != null)
            {
                enemyQuantity[_firstIndex,_lastIndex].GunEnemy();
                AccumulatedTime = 0;
            }
            else
            {
                Reload(Time.deltaTime);
            }
        }
    }
}
