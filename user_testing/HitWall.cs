using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWall : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            GetComponent<Rigidbody>().useGravity = true;
       
            transform.position = new Vector3(0, 3, 0);
            Debug.Log("Player dead");
        }

        if (collision.gameObject.tag == "ground")
        {
            GetComponent<Rigidbody>().useGravity = false;
            Debug.Log("Player revive");
        }
    }
}
