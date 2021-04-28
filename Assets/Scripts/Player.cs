using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    private void Update()
    {
        transform.Translate(-transform.forward*Time.deltaTime*10);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CornAll>())
        {
            other.GetComponent<CornAll>().Explode();
        }
    }
}
