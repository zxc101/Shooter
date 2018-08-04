using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;

namespace FlashLight
{
    public class FlashLightUse : BaseObjectScene, IPowerEnergy
    {
        public float MaxPower;
        public float Stap;
        public float SmoothTransition;

        [HideInInspector]
        public Light Flash;
        private float powerEnergy;

        [HideInInspector]
        public float PowerEnergy
        {
            get { return powerEnergy; }
            set { powerEnergy = value; }
        }

        private void Start()
        {
            powerEnergy = MaxPower;
            Flash = GetComponent<Light>();
        }
    }
}