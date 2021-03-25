using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponInfo info;

    [SerializeField] int fireRate;
    [SerializeField] int damage;
    [SerializeField] int startingAmmo;
    [SerializeField] string nameOfWeapon;
    [SerializeField] AmmoType ammoType;
    // Start is called before the first frame update
    public virtual void Start()
    {
        fireRate = info._fireRate;
        damage = info._damage;
        startingAmmo = info._damage;
        nameOfWeapon = info._weaponName;
        ammoType = info.ammoType;
    }
}
