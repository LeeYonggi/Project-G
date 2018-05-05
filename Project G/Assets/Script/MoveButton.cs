using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour {

    public GameObject gObj;
    public Transform velocity;
    public float speed;
    
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() 
    {
        gObj.transform.position += new Vector3(-speed, 0, 0) * Time.fixedDeltaTime;
    }
}
