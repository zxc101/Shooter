using Helpers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class InputController : MonoBehaviour
    {
        private InputButton inputButton;

        private void Start()
        {
            inputButton = new InputButton();
        }
        void Update()
        {
            if (Input.GetKeyDown(inputButton.Flash))
            {
                Main.Instance.PowerEnergyController.FlashTumbler();
            }

            if (Input.GetKeyDown(inputButton.Weapon1))
            {
                Main.Instance.WeaponController.Put();
                Main.Instance.WeaponController.Take(Main.Instance.WeaponController.GetWeapon(0));
            }

            if (Input.GetKeyDown(inputButton.Weapon2))
            {
                Main.Instance.WeaponController.Put();
                Main.Instance.WeaponController.Take(Main.Instance.WeaponController.GetWeapon(1));
            }

            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Debug.Log("Mouse: Up");
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Debug.Log("Mouse: Down");
            }

            if (Input.GetMouseButtonDown(inputButton.Attack))
            {
                Main.Instance.WeaponController.Attack();
            }

            if (Input.GetKeyDown(inputButton.Recharge))
            {
                Main.Instance.WeaponController.Recharge();
            }
        }
    }
}