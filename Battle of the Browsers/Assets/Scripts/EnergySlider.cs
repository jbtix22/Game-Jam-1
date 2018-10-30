using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergySlider : MonoBehaviour
{

    public Slider Energy;
    public float energy_left;
    public bool sendCallBack;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Energy.value += .0075F;
        energy_left = Energy.value;

    }

    //public void EnergyLeft(float energy_left, bool sendCallBack);
}
