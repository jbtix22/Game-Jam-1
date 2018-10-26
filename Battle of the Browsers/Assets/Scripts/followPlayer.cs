using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = GameObject.Find("Player").transform.position;
        var pos = transform.position;
        pos.z -= 1;
        transform.position = pos;
    }
}
