using UnityEngine;

public abstract class ShootingPattern
{
    protected int BulletsAmount = 1;
    protected int NumberOfBulletsPerShot = 1;
    public abstract void Shoot(Transform bulletSpawnPoint, BulletGenerator bulletGenerator);

    protected void Fire(int bulletsAmount, BulletGenerator bulletGenerator, Transform bulletSpawnPoint, bool isInfinity)
    {
        for (int i = 0; i < bulletsAmount; i++)
        {
            Bullet bullet = bulletGenerator.SpawnBullet();
            bullet.transform.position = bulletSpawnPoint.position;
            bullet.Fire(bulletSpawnPoint.forward);

            if (isInfinity == false)
                BulletsAmount--;
        }
    }
}
