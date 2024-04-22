using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityBulletShootingPattern : ShootingPattern
{
    private int _bulletPerShoot = 1;

    public override void Shoot(Transform bulletSpawnPoint, BulletGenerator bulletGenerator)
    {
        Fire(_bulletPerShoot, bulletGenerator, bulletSpawnPoint, true);
    }

    
}
