using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitController : MonoBehaviour {

    [SerializeField]
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {

        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void SetDestination(Vector3 destination)
    {
        agent.SetDestination(destination);
    }
}
