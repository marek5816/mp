using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class myColiderController : MonoBehaviour
{
    void Start() {}
    void Update() {}
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "hand") {
            Color c = GetComponent<Renderer>().material.color;
            if (c == Color.red)
                GetComponent<Renderer>().material.color = Color.blue;
            else
                GetComponent<Renderer>().material.color = Color.red;
        }
    }   
}
