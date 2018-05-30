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
		if (Input.GetKeyDown(KeyCode.Space))
        {
            test();

        }
	}
    void test()
    {
        if()
    }
}
