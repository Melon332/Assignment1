﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "ScriptableObjects/Weapons", order = 1)]

public class WeaponInfo : ScriptableObject

{
    public string weaponName;
    public GameObject weaponModel;

    public float fireRate;

    public int damage;
    public int startingAmmo;

    public AmmoType ammoType;
}
   public enum AmmoType { PISTOL, RIFLE, SHELLS };
