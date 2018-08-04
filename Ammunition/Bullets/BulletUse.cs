using Helpers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;

public class BulletUse : BaseObjectScene {

    //private float speed;

    //public float Speed { get { return speed; } private set { speed = value; } }

    void Start()
    {
        Invoke(this.GetName(Dest), 0.1f);
    }

    private void Dest()
    {
        Destroy(gameObject);
    }

}
