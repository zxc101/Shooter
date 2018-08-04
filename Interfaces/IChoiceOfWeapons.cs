using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChoiceOfWeapons
{
    List<string> GetListWeapons();
    void ChoiceWeapon();
}
