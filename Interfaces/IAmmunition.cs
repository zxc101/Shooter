using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAmmunition {
    void Take(Ammunition.WeaponUseAbstract _WeaponUse);
    void Put();
}
