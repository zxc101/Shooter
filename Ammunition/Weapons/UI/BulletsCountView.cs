using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsCountView : MonoBehaviour {

    private Text Text;
    
	void Start () {
        Text = GetComponent<Text>();
    }

	public void SetBulletstCountText(int _bulletstCount) {
        Text.text = string.Format("Количество потронов: {0}", _bulletstCount);
    }
}
