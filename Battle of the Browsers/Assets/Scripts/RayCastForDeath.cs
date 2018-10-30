using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastForDeath : MonoBehaviour
{

    public GameObject Player;
    public GameObject DeathDetector;
    public float Distance_;
    void Start()
    {



    }

    void Update()
    {

        Distance_ = Vector3.Distance(Player.transform.position, DeathDetector.transform.position);


        if (Distance_ > 3.05) {

            Destroy(gameObject);
            Debug.Log("Player has Exited Stage");

        }
    }

}