using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Camera mainCamera;
    public float sensitivity = 0.8f;



    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        mainCamera.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(10 * Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(10 * Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(10 * Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(10 * Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey("o"))
        {
            this.transform.Translate(10 * Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey("p"))
        {
            this.transform.Translate(10 * Vector3.down * Time.deltaTime);
        }
        if (Input.GetKey("r"))
        {
            this.transform.Rotate(0, sensitivity * -1, 0);
        }
        if (Input.GetKey("t"))
        {
            this.transform.Rotate(0, sensitivity * 1, 0);
        }
        if (Input.GetMouseButton(0))
        {
            this.transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
            //this.transform.Rotate(-Input.GetAxis("Mouse Y") * sensitivity, 0, 0);
        }
        mainCamera.transform.position = this.transform.position;
    }
}
