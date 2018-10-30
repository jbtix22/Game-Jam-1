using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUScript : MonoBehaviour {

    public Rigidbody rbCPU;
    public int clickForceCPU = 500;
    public Vector3 playerPos;
    public Vector3 playerDir;
    public float energyCPU;

	// Update is called once per frame
	void FixedUpdate () {
        playerPos = GameObject.Find("Player").transform.position;
        playerDir = playerPos - gameObject.transform.position;
        playerDir.x += Random.Range(-0.7f, 0.7f);
        playerDir.y += Random.Range(-0.7f, 0.7f);
        playerDir.z = 0.0f;
        playerDir = playerDir.normalized;

    }
    float timeLeft = 1.0f;

    void Update()
    {
        energyCPU += .0075f;
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            rbCPU.velocity = Vector3.zero;
            rbCPU.angularVelocity = Vector3.zero;
            rbCPU.AddForce(playerDir * clickForceCPU * energyCPU);
            Debug.Log(playerDir);
            timeLeft = Random.Range(0.2f, 2f);
            energyCPU = 0;
        }
    }
}
