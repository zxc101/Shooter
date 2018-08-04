using Player;
using System;
using UnityEngine;

namespace Helpers
{
    public class Main : MonoBehaviour
    {
        private GameObject _allControllers;
        private InputController _inputController;

        public static Main Instance { get; private set; }
        public PowerEnergyController PowerEnergyController { get; private set; }
        public Ammunition.WeaponController WeaponController { get; private set; }
        public Ammunition.BulletController BulletController { get; private set; }
        //public WeaponController WeaponController { get; private set; }
        //public ObjectManager ObjectManager { get; private set; }
        //public ResourcesMainCharacters ResourcesMainCharacters { get; private set; }

        private void Awake()
        {
            Instance = this;
            _allControllers = new GameObject("All Controllers");
            _inputController = _allControllers.AddComponent<InputController>();
            PowerEnergyController = _allControllers.AddComponent<PowerEnergyController>();
            WeaponController = _allControllers.AddComponent<Ammunition.WeaponController>();
            BulletController = _allControllers.AddComponent<Ammunition.BulletController>();
            //WeaponController = _allControllers.AddComponent<WeaponController>();
            //ObjectManager = _allControllers.AddComponent<ObjectManager>();
            //ResourcesMainCharacters = _allControllers.AddComponent<ResourcesMainCharacters>();
        }
    }
}
