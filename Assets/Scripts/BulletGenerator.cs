using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;

    public Bullet SpawnBullet()
    {
        return Instantiate(_bulletPrefab);
    }
}
