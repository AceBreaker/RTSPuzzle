using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOwner : MonoBehaviour {

    List<Switch> switchesList = new List<Switch>();

    DestroyTarget dt = null;

	// Use this for initialization
	void Start () {
        foreach(Transform child in transform)
        {
            switchesList.Add(child.GetComponent<Switch>());
        }
        dt = GetComponent<DestroyTarget>();
	}
	
	// Update is called once per frame
	void Update () {
        CheckIfAllSwitchesPressed();
	}

    void CheckIfAllSwitchesPressed()
    {
        foreach (Switch s in switchesList)
        {
            if (!s.GetSwitchPressed())
            {
                return;
            }
        }

        dt.BeginDestroy();
    }
}
