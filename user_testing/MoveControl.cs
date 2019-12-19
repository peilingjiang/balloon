using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public float range = 5;
    // public GUIText textOutput;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        float xPos = h * range;
        //float yPos = v * range;
        transform.position = new Vector3(xPos, transform.position.y, 0);
    }
}
