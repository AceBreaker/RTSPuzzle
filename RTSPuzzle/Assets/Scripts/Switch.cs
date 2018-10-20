using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    bool switchPressed = false;

    SwitchOwner owner = null;

	// Use this for initialization
	void Start () {
        owner = transform.root.GetComponent<SwitchOwner>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            switchPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            switchPressed = false;
        }
    }

    public bool GetSwitchPressed()
    {
        return switchPressed;
    }
}
