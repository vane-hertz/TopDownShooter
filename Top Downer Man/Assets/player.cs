using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Vector3 lastPosition = Vector3.zero;
    private Vector3 velocib = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    void update_lastPosition()
    {
        lastPosition = transform.position;
    }

    void update_velocib()
    {
        velocib = transform.position - lastPosition;
        Debug.Log(lastPosition);
        Debug.Log(velocib);
    }

    // Update is called once per frame
    void Update()
    {
        update_lastPosition();
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
        update_velocib();
    }

    void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(10, 10, 1000, 20), "Velocity: " + velocib);
    }
}
