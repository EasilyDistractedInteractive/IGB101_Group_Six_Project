using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpin : MonoBehaviour
{
    public int multiplier = 0;

    void Update ()
    {
        transform.Rotate (Vector3.up * 7.5f * multiplier * Time.deltaTime, Space.Self);
    }
}
