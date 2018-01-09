using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {
    public GameObject projectile;

    public void Fire(float speed = 10.0f)
    {
        //fire a projectile if one is defined
        if (projectile != null)
        {
            projectile.GetComponent<LaserController>().SetSpeed(speed);
            Instantiate(projectile,transform.position,transform.rotation);
        }
    }

}
