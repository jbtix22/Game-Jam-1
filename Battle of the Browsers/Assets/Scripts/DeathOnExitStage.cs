using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnExitStage : MonoBehaviour {

  
    void Start () {



	}

    void Update()
    {


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
