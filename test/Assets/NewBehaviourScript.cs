using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float coffee_tempeture = 87.0f;
    float hot_lim = 60.0f;
    float cold_lim = 10.0f;

    void Awake()
    {
        Debug.Log("Awake called.");
    }
    // Use this for initialization
    void Start () {
        Debug.Log("HELLO");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey ("w"))
            GameObject.Find("spere").transform.position += new Vector3(0, 0, 0.5f);
        if (Input.GetKey ("s"))
            GameObject.Find("spere").transform.position += new Vector3(0, 0, -0.5f);

    }
    void test()
    {
        if (coffee_tempeture >= hot_lim)
            Debug.Log("HOT");
        else if (coffee_tempeture < cold_lim)
            Debug.Log("COLD");
        else
            Debug.Log("NICE");
    }
}
