using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMoveUp : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
    }
}
