using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] AmmoSlot[] ammoSlot;

    [System.Serializable]
    private class AmmoSlot
    {
        public AmmoType ammoType;
        public int currentAmmo;
    }
    public int GetCurrentAmmo(AmmoType ammo)
    {
        return GetAmmoSlot(ammo).currentAmmo;
    }
    public int ReduceCurrentAmmo(AmmoType ammo)
    {
        return GetAmmoSlot(ammo).currentAmmo--;
    }

    private AmmoSlot GetAmmoSlot(AmmoType ammo)
    {
        foreach(AmmoSlot slots in ammoSlot)
        {
            if(slots.ammoType == ammo)
            {
                return slots;
            }
        }
        return null;
    }
}
