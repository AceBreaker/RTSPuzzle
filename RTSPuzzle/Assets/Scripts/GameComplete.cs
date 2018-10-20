using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour {

    [SerializeField]
    Text gameCompleteText = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameCompleteText.text = "Congratulations, you have completely completed a very simple level.";
        }
    }
}
