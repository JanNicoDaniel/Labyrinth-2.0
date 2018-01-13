using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthBehaviour : MonoBehaviour {
    //
    void turn()
    {
        transform.Rotate(Vector3.up * 90);
    }

	// Use this for initialization
	void Start () {
        turn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
