using UnityEngine;

public class SemiAutomaticShootingPattern : ShootingPattern
{
    public SemiAutomaticShootingPattern(int numberOfBulletsPerShot, int bulletsAmount)
    {
        NumberOfBulletsPerShot = numberOfBulletsPerShot;
        BulletsAmount = bulletsAmount;
    }

    public override void Shoot(Transform bulletSpawnPoint, BulletGenerator bulletGenerator)
    {
        if (BulletsAmount >= NumberOfBulletsPerShot)
        {
            Fire(NumberOfBulletsPerShot, bulletGenerator, bulletSpawnPoint, false);
        }
        else if (BulletsAmount < NumberOfBulletsPerShot && BulletsAmount > 0)
        {
            Fire(BulletsAmount, bulletGenerator, bulletSpawnPoint, false);
        }
    }
}
