using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;
    public int clickForce = 7500;
    public float energy = GameObject.Find("Energy").GetComponent<EnergySlider>().energy_left;
    void FixedUpdate()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mouseDir = mousePos - gameObject.transform.position;
        mouseDir.z = 0.0f;
        mouseDir = mouseDir.normalized;

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            energy = GameObject.Find("Energy").GetComponent<EnergySlider>().energy_left;
            rb.AddForce(mouseDir * clickForce * energy);
        }
    }

}
