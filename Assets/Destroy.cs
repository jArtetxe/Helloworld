using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    Object[] objeto;
    int cont;
    // Start is called before the first frame update
    void Start()
    {
        objeto = GameObject.FindObjectsOfType(typeof(MonoBehaviour));
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Destroys();
    }

    private void Destroys()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(objeto[cont]);
            cont++;
        }
    }
}
