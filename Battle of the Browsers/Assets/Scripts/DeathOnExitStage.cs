using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnExitStage : MonoBehaviour {

  
    void Start () {

        

	}
	
	void Update () {
	


	}

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {

            Destroy(col.gameObject);
        }

        Debug.Log("Collision has been Detected");

    }

}
