using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnExitStage : MonoBehaviour {

  
    void Start () {



	}
	
	void Update () {



        }

    private void OnCollisionEnter(Collision collision)
    {
        if (Physics.IgnoreCollision.gameObject.tag == "Player"){


        }
    }


    void OnCollisionExit(Collision collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "Player")
        {


            Destroy(collisionInfo.gameObject);
        }

        Debug.Log("Collision has been Detected");

    }

       

    }
