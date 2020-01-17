using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {   if(Input.GetButtonDown("Jump"))
        {
            var position = new Vector2(transform.position.x + 2, transform.position.y);
            var projectile = Instantiate(projectilePrefab,
            position,
            projectilePrefab.transform.rotation);
        }
    }
}
