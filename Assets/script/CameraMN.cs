using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMN : MonoBehaviour
{
    private float _speed = 10f;
    Camera _camera;

     void Start()
    {
        _camera = this.gameObject.GetComponent<Camera>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right * _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            transform.position += transform.up * _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.up * _speed * Time.deltaTime;

        CameraZoom();
    }

    void CameraZoom()
    {
        float wh = Input.GetAxis("Mouse ScrollWheel");
        _camera.orthographicSize = _camera.orthographicSize -= wh*4;
    }
}
