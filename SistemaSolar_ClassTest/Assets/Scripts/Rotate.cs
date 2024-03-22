using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotación : MonoBehaviour
{
    [SerializeField]
    float velRotacion, velOrbitacion;
    // Start is called before the first frame update
    void Start() { }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * velRotacion);
        //transform.RotateAround(Vector3.zero, Vector3.up,velOrbitacion * Time.deltaTime);
    }
}
