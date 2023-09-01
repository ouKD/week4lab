using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    // Start is called before the first frame update
    
    void Start()
    {
        Debug.Log(this.gameObject.name);
    }

    // Update is called once per frame
    int i = 3;
    void Update()
    {
        Debug.Log(i++);
    }
}
