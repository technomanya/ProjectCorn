using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CornPipe : MonoBehaviour
{
    public GameObject cornAllPrefab;
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
        }
    }
}
