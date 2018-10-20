using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    GameObject[] units = null;

    List<GameObject> selectedUnits = null;

    [SerializeField]
    Camera cam = null;

	// Use this for initialization
	void Start () {
        selectedUnits = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        HandleMouseClick();
	}

    void HandleMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, LayerMask.GetMask("Player")))
            {
                switch(hit.collider.gameObject.tag)
                {
                    case "Player":
                        selectedUnits.Clear();
                        selectedUnits.Add(hit.collider.gameObject);
                        break;
                    default:
                        break;
                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit, 100.0f, 1 << LayerMask.NameToLayer("Ground")))
            {
                Debug.Log(hit.collider.name);
                switch (hit.collider.gameObject.tag)
                {
                    case "Ground":
                        Debug.Log("collided with ground");
                        foreach (GameObject go in selectedUnits)
                        {
                            go.GetComponent<UnitController>().SetDestination(hit.point);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
