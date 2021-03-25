using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] WeaponInfo info;

    [SerializeField] float fireRate;
    [SerializeField] float nextFire;

    [SerializeField] int damage;

    [SerializeField] string nameOfWeapon;
    [SerializeField] AmmoType ammoType;

    [SerializeField] Ammo ammo;
    // Start is called before the first frame update
    public virtual void Start()
    {
        fireRate = info.fireRate;
        nextFire = info.nextFire;
        damage = info.damage;
        nameOfWeapon = info.weaponName;
        ammoType = info.ammoType;
        ammo = GetComponentInParent<Ammo>();
    }
    public virtual void Shoot()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetMouseButton(0) && Time.time > nextFire)
        {
            if (ammo.GetCurrentAmmo(ammoType) > 0)
            {
                nextFire = Time.time + fireRate;
                Debug.Log("I have been shooting booutin " + ammoType);
                ammo.ReduceCurrentAmmo(ammoType);
            }
        }
    }
}
