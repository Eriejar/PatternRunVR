using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        Player thingWithSide = other.gameObject.GetComponent<Player>();
        if(thingWithSide.currentSide == 3)
        {
            Debug.Log("Current Side 3 Teleport");
            other.gameObject.transform.position = new Vector3(-3.87f, 0.13f, 3.21f);
            thingWithSide.SetSide(2);
            return;
        }
        if (thingWithSide.currentSide == 2)
        {
            Debug.Log("Current Side 2 Teleport");
            other.gameObject.transform.position = new Vector3(-2.74f, 0.13f, 2.09f);
            thingWithSide.SetSide(3);
            return;
        }
    }
}

//leftside starting position
//x = -2.74
//y = 0.096
//z = -1.46

//teleport to backside
//x = -5.137
//y = 0.94
//z = 1.95

//teleport to leftside
//x = -4.46
//y = 0.94
//z = 0.98
