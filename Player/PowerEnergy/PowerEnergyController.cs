using FlashLight;
using Helpers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PowerEnergyController : MonoBehaviour, IFlash
    {
        private FlashLightUse FLUse;
        private PowerEnergyView PowerEnergyView;

        private void Awake()
        {
            FLUse = FindObjectOfType<FlashLightUse>();
            PowerEnergyView = FindObjectOfType<PowerEnergyView>();
            InvokeRepeating(this.GetName(UpdatePowerEnergy), 0, PowerEnergyConstants.SEC / FLUse.SmoothTransition);
        }

        public void FlashTumbler()
        {
            FLUse.Flash.enabled = !FLUse.Flash.enabled;
        }

        private void UpdatePowerEnergy()
        {
            if (FLUse.Flash.enabled)
            {
                if (FLUse.PowerEnergy > PowerEnergyConstants.MIN_POWER)
                {
                    FLUse.PowerEnergy -= FLUse.Stap / FLUse.SmoothTransition;
                }
                else
                {
                    FlashTumbler();
                }
            }
            else if (!FLUse.Flash.enabled && FLUse.PowerEnergy < FLUse.MaxPower)
            {
                FLUse.PowerEnergy += FLUse.Stap / FLUse.SmoothTransition;
            }
            FLUse.Flash.intensity = FLUse.PowerEnergy;
            PowerEnergyView.SetText(this.ToPercentages(FLUse.MaxPower, FLUse.PowerEnergy));
        }
    }
}