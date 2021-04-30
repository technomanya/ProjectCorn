using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CornAll : MonoBehaviour
{
    public Rigidbody[] rigs;
    public List<Vector3> rigPosList;

    public float expForce;
    // Start is called before the first frame update
    void Start()
    {
        rigs = GetComponentsInChildren<Rigidbody>();
        
        foreach (var rig in rigs)
        {
            rig.isKinematic = true;
            rigPosList.Add(rig.transform.localPosition);
        }
    }

    public void Explode()
    {
        foreach (var rig in rigs)
        {
            rig.isKinematic = false;
            var rigTransform = rig.transform;
            rigTransform.parent = null;
            var dir = rigTransform.position - transform.position;
            
            rig.AddForce((rigTransform.forward-rigTransform.up)*expForce);
        }
    }

    public void ResetCorn()
    {
        var i = 0;
        foreach (var rig in rigs)
        {
            rig.isKinematic = true;
            var rigTransform = rig.transform;
            rigTransform.parent = transform;
            rigTransform.localPosition = rigPosList[i];
            i++;
        }
    }
}
