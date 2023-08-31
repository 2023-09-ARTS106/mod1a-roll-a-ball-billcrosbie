using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Vector3 rotAmount = new Vector3(15, 30, 45);


    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotAmount * Time.deltaTime);
    }
}
