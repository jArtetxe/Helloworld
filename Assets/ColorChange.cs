using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField]
    public Color color;

    [SerializeField]
    public bool checkByTag;

    [SerializeField]
    public string tag;

    public GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {   
        if(checkByTag){
            objetos = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject objecto in objetos)
            {
                objecto.GetComponent<MeshRenderer>().material.color = color;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
