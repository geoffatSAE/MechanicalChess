using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceLocationIndicator : MonoBehaviour
{
    public Renderer r;

    public Material red, transparent;

    // Start is called before the first frame update
    void Start()
    {
        //r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        r.material = red;
    }

    private void OnTriggerExit(Collider other)
    {
        //r.material.color = Color.grey;
        r.material = transparent;
    }
}
