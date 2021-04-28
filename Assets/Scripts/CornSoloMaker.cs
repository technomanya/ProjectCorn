using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornSoloMaker : MonoBehaviour
{
    public GameObject cornSolo;
    public List<GameObject> cornAll = new List<GameObject>();
    public float angleUpper;

    // Start is called before the first frame update
    void Start()
    {
        var cornTemp = new GameObject();
        for (int i = 0; i < 31; i++)
        {
            cornTemp = Instantiate(cornSolo, Vector3.zero, Quaternion.identity, gameObject.transform);
            cornTemp.transform.localPosition = Vector3.right;
            cornTemp.transform.localRotation = Quaternion.Euler(0,90,90);
            cornTemp.transform.localScale = Vector3.one ;
            gameObject.transform.Rotate(transform.forward,angleUpper);
            cornTemp.transform.parent = null;
            cornAll.Add(cornTemp);
        }
    }

}
