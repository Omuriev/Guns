using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteShootingPattern : ShootingPattern
{
    public FiniteShootingPattern(int bulletsAmount)
    {
        BulletsAmount = bulletsAmount;
    }

    public override void Shoot(Transform bulletSpawnPoint, BulletGenerator bulletGenerator)
    {
        if (BulletsAmount > 0)
        {
            Fire(1, bulletGenerator, bulletSpawnPoint, false);
        }
    }
}
