﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifles : Weapon
{

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    public override void Shoot()
    {
        base.Shoot();
    }
}
