using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] Transform weaponSpawnPoint;

    [SerializeField] WeaponInfo m4Info;
    [SerializeField] WeaponInfo pistolInfo;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pistolInfo.weaponModel, weaponSpawnPoint).SetActive(true);
        Instantiate(m4Info.weaponModel, weaponSpawnPoint).SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
