using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "ScriptableObjects/Weapons", order = 1)]

public class WeaponInfo : ScriptableObject

{
    public string _weaponName;
    public GameObject _weaponModel;

    public int _fireRate;
    public int _damage;
    public int _startingAmmo;
    public AmmoType ammoType;
}
   public enum AmmoType { pistolAmmo, rifleAmmo, shells };
