using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorVFX : MonoBehaviour
{
    public MeshRenderer myParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!myParent.enabled)
        {
            this.GetComponent<Renderer>().enabled = false;
        }
    }
}
