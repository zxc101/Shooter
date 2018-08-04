using Helpers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ammunition
{
    public class WeaponController : MonoBehaviour, IAmmunition
    {
        private WeaponUseAbstract WeaponUse;
        private BulletsCountView BulletsCountView;
        private List<WeaponUseAbstract> weapons;

        void Start()
        {
            weapons = FindObjectsOfType<WeaponUseAbstract>().ToList();
            BulletsCountView = FindObjectOfType<BulletsCountView>();

            foreach (WeaponUseAbstract weapon in weapons)
            {
                weapon.MaxCountBullets = weapon.CountBullets;
            }

            Take(weapons[0]);
            BulletsCountView.SetBulletstCountText(WeaponUse.CountBullets);
        }

        public WeaponUseAbstract GetWeapon(int pos)
        {
            return weapons[pos];
        }

        public void Take(WeaponUseAbstract _WeaponUse)
        {
            if (WeaponUse == _WeaponUse) return;
            WeaponUse = _WeaponUse;
            WeaponUse.IsVisible = true;
            BulletsCountView.SetBulletstCountText(WeaponUse.CountBullets);
        }

        public void Put()
        {
            if (!WeaponUse) return;
            WeaponUse.IsVisible = false;
            WeaponUse = null;
        }

        public void Attack()
        {
            if (WeaponUse.CountBullets == 0)
            {
                Recharge();
            }
            WeaponUse.CountBullets--;
            Transform shot = Instantiate(WeaponUse.Bullet, WeaponUse.Mazzle.position, Quaternion.identity).transform;
            shot.GetComponent<Rigidbody>().AddForce(WeaponUse.Mazzle.forward * WeaponUse.Force);

            BulletsCountView.SetBulletstCountText(WeaponUse.CountBullets);
        }

        public void Recharge()
        {
            WeaponUse.CountBullets = WeaponUse.MaxCountBullets;
            BulletsCountView.SetBulletstCountText(WeaponUse.CountBullets);
        }
    }
}