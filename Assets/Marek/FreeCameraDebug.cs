using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCameraDebug : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sensitivity = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Capture input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera based on mouse input
        transform.Rotate(Vector3.up * mouseX * sensitivity);
        transform.Rotate(Vector3.left * mouseY * sensitivity);

        // Translate the camera based on keyboard input
        Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);
    }
}
