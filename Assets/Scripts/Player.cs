using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float sizeSpeed;
    public bool isControl;
    private void Update()
    {
        if (Input.GetMouseButton(0) && isControl)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0.5f, 1, 0.5f),Time.deltaTime*sizeSpeed);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, Time.deltaTime*sizeSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CornAll>())
        {
            other.GetComponent<CornAll>().Explode();
        }
        else if(other.CompareTag("Enemy"))
        {
            GameObject.FindWithTag("GameController").GetComponent<GameManager>().GameOver(false);
        }
    }
}
