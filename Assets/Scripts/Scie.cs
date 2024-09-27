using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scie : MonoBehaviour
{
    public int speed = 15;
    public void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime*speed);
        if (transform.position.x < -15)
        {
          Destroy(gameObject);
        }
    }
}
