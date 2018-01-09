using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour {
    const float MOVE_SPEED = 100f;
    public float MOVE_RANGE;
	
	// Update is called once per frame
	void Update () {
        if (MOVE_RANGE == float.MinValue)
            MOVE_RANGE = 20.0f;
        //move the player ship if it can be moved
        transform.Translate(new Vector3( (Input.GetKey("a")?(transform.position.x< MOVE_RANGE?MOVE_SPEED:0):Input.GetKey("d")?(transform.position.x > -MOVE_RANGE?-MOVE_SPEED:0):0)*Time.deltaTime,0, 0));

	}
}
