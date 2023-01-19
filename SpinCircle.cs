using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCircle : MonoBehaviour
{
    float speed = 100f;

    private void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * speed);
    }
}
