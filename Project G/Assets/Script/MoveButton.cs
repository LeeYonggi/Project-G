using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour {

    public GameObject gObj;
    private Transform m_position;
    private BoxCollider2D m_bc2D;
    public float speed;
    
	// Use this for initialization
	void Start () {
        m_position = GetComponent<Transform>();
        m_bc2D = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void FixedUpdate() 
    {
        
    }

    private void MoveCharacter(float _speed)
    {
        gObj.transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;
    }

    private void OnMouseOver()
    {
        MoveCharacter(speed);
    }
}
