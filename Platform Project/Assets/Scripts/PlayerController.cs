using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if a the space bar is pressed then fire
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //go through all children with cannon tag
            CannonController[] cannons = GetComponentsInChildren<CannonController>();
            foreach(CannonController cannon in cannons)
            {
                //fire the cannon
                cannon.Fire(1);
                Debug.Log("Fire was pressed");
            }

            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        //check to see if we are colliding with an enemy
        
    }
}
