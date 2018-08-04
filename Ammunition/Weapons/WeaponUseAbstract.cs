using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;

namespace Ammunition {
    public abstract class WeaponUseAbstract : BaseObjectScene
    {
        [SerializeField] private Transform mazzle;
        [SerializeField] private GameObject bullet;
        [SerializeField] private int countBullets;
        [SerializeField] private float force;

        private int maxCountBullets;

        public Transform Mazzle { get { return mazzle; } private set { mazzle = value; } }
        public GameObject Bullet { get { return bullet; } private set { bullet = value; } }
        public int CountBullets { get { return countBullets; } set { countBullets = value; } }
        public int MaxCountBullets { get { return maxCountBullets; } set { maxCountBullets = value; } }
        public float Force { get { return force; } private set { force = value; } }

        protected virtual void Awake()
        {
            IsVisible = false;
        }
    }
}