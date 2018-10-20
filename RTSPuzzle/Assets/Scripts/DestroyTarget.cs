using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour {

    [SerializeField]
    GameObject destroyTarget = null;

    public void BeginDestroy()
    {
        Destroy(destroyTarget);
    }
}
