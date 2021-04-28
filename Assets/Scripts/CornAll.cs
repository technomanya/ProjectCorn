using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CornAll : MonoBehaviour
{
    public Rigidbody[] rigs;
    // Start is called before the first frame update
    void Start()
    {
        rigs = GetComponentsInChildren<Rigidbody>();
    }

    public void Explode()
    {
        foreach (var rig in rigs)
        {
            rig.isKinematic = false;
            rig.AddForce(transform.up*10,ForceMode.Impulse);
        }
    }
}
