using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailScript : MonoBehaviour
{
    public float speed = 8.0f;
    public float distanceFromCamera = 5.0f;

    void Update()
    {
        Vector3 _mousePosition = Input.mousePosition;
        _mousePosition.z = distanceFromCamera;

        Vector3 _mouseScreenToWorld = Camera.main.ScreenToWorldPoint(_mousePosition);

        Vector3 _position = Vector3.Lerp(transform.position, _mouseScreenToWorld, 1.0f - Mathf.Exp(-speed * Time.deltaTime));

        transform.position = _position;
    }
}
