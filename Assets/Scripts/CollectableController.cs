using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour {

    public float respawnTime = 10f;
    public float nextRespawn = 0f;
    GameObject []test;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if (gameObject.activeSelf)

            print("Updating");
        if (Time.time > nextRespawn + respawnTime)
        {
            print(10);
            nextRespawn = Time.time;
            gameObject.SetActive(true);
        }


    }
}
