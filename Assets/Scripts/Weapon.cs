using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _bulletSpawnPoint;
    [SerializeField] private BulletGenerator _bulletGenerator;
    [SerializeField] private ShootingPattern _shootingPattern;

    private int _currentShootingTypeIndex = 0;
    private ShootingPattern _currentShootingType;
    private List<ShootingPattern> _shootingTypes;

    private void Awake()
    {
        _shootingTypes = new List<ShootingPattern>();
        GenerateShootingTypes();
        _currentShootingType = _shootingTypes[_currentShootingTypeIndex];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _currentShootingType != null)
            _currentShootingType.Shoot(_bulletSpawnPoint, _bulletGenerator);

        if (Input.GetKeyDown(KeyCode.E))
            SetWeapon();
    }

    private void GenerateShootingTypes()
    {
        _shootingTypes.Add(new SemiAutomaticShootingPattern(2, 10));
        _shootingTypes.Add(new InfinityBulletShootingPattern());
        _shootingTypes.Add(new FiniteShootingPattern(20));
    }

    private void SetWeapon()
    {
        _currentShootingTypeIndex++;

        if (_currentShootingTypeIndex >= _shootingTypes.Count)
        {
            _currentShootingTypeIndex = 0;
        }

        _currentShootingType = _shootingTypes[_currentShootingTypeIndex];
    }
}
