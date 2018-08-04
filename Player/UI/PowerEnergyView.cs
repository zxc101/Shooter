using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PowerEnergyView : MonoBehaviour {

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    public void SetText(float PowerEnergy)
    {
        text.text = string.Format("Заряд аккумулятора: {0}", PowerEnergy);
    }
}
