using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyIncreaser : MonoBehaviour
{





    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0, 0.1F, 0);
    }
}
