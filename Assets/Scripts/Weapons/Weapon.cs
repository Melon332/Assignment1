using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] WeaponInfo info;

    [SerializeField] float fireRate;
    [SerializeField] int damage;
    [SerializeField] int startingAmmo;
    [SerializeField] string nameOfWeapon;
    [SerializeField] AmmoType ammoType;
    // Start is called before the first frame update
    public virtual void Start()
    {
        fireRate = info.fireRate;
        damage = info.damage;
        startingAmmo = info.startingAmmo;
        nameOfWeapon = info.weaponName;
        ammoType = info.ammoType;
    }
    public abstract void Shoot();
}
