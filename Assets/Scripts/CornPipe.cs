using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CornPipe : MonoBehaviour
{
    public float pipeSpeed;
    public GameObject cornAllPrefab;
    public List<CornAll> cornAlls; 
    public float forwardValue;
    public int cornLineCount;
    void Start()
    {
        var iniPos = cornAllPrefab.transform.position;
        var tempCornLine = new GameObject();
        iniPos = new Vector3(0,-0.2f,-5);
        for (int i = 0; i < cornLineCount; i++)
        {
            tempCornLine = Instantiate(cornAllPrefab, Vector3.zero, Quaternion.identity, transform);
            iniPos += Vector3.up * forwardValue;
            tempCornLine.transform.localPosition = iniPos ;
            tempCornLine.transform.localScale = new Vector3(1,1,0.1f) ;
            cornAlls.Add(tempCornLine.GetComponent<CornAll>());
        }
    }

    private void Update()
    {
        transform.Translate(transform.forward*pipeSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("ResetCol"))
        {
            foreach (var corAll in cornAlls)
            {
                corAll.ResetCorn();
            }

            transform.position = new Vector3(0, -5, 37.5f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("ResetCol"))
        {
            foreach (var corAll in cornAlls)
            {
                corAll.ResetCorn();
            }

            transform.position = new Vector3(0, -5, 37.5f);
        }
    }
}
