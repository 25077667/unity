using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(GameObject.Find("Sphere").transform.position.x <= 500 )
        if (Input.GetKey ("w"))
            GameObject.Find("Sphere").transform.position += new Vector3(0, 0, 5);
        if (Input.GetKey ("s"))
            GameObject.Find("Sphere").transform.position += new Vector3(0, 0, -5);
        if (Input.GetKey("a"))
            GameObject.Find("Sphere").transform.position += new Vector3(5, 0, 0);
        if (Input.GetKey("d"))
            GameObject.Find("Sphere").transform.position += new Vector3(-5, 0, 0);
    }
    
}
