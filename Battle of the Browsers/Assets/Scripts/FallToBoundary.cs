using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallToBoundary : MonoBehaviour {

	void Start () {

        transform.Translate(0, 0, -1 * Time.deltaTime);

	}
	
	void Update () {
		

	}
}
