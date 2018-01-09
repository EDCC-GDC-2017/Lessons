using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour {
    private float projectileSpeed;
    private const float DEFAULT_SPEED = 10.0f;
	// Use this for initialization
	void Start () {
        //set the defualt projectile speed
        projectileSpeed = DEFAULT_SPEED;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        //move the laser forward
        transform.Translate(new Vector3(0, 0, -projectileSpeed));

        //check to se if the laser is way out of the room
        if (transform.position.z < -500.0f)
            Destroy(gameObject);
   
    }


    private void OnCollisionEnter(Collision collision)
    {
        //if the collider is an enemy detroy it
        if(collision.gameObject.CompareTag("enemy"))
        {
            //destroy the object
            Destroy(collision.gameObject);

            //increase the score by the enemys worth
            GameObject.Find("GameController").GetComponent<GameController>().IncreaseScore(collision.gameObject.GetComponent<Enemy_Controller>().Worth);
            //destroy self
            Destroy(gameObject);
        }
    }

    public void SetSpeed(float speed = 10.0f)
    {
        projectileSpeed = speed;
    }
}
