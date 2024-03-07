using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    public float speed;
    private float x;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        logPosition();
        checkMove();
        checkScale();
        checkRotation();
    }

    private void checkMove()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position += Vector3.back;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += Vector3.forward;
        }
    }

    private void checkScale()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.transform.localScale += Vector3.up * speed;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.localScale += Vector3.down * speed;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            this.transform.localScale += Vector3.right * speed;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            this.transform.localScale += Vector3.left * speed;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            this.transform.localScale += Vector3.back * speed;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            this.transform.localScale += Vector3.forward * speed;
        }
    }
    private void checkRotation()
    {
        x += Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(x,0,0);
    }
    private void logPosition()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Position: " + gameObject.transform.position);
            Debug.Log("Rotation: " + gameObject.transform.rotation);
            Debug.Log("Scale: " + gameObject.transform.localScale);
        }
        
    }
}
