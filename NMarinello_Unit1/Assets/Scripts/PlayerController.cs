using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        // Vector3.forward -- > (0, 0 ,1)
        // (0, 0, 1) * Time.deltaTime = (0, 0, .016) * = (0, 0, .16)
        transform.Translate(Vector3.forward * Time.deltaTime * 15);
    }
}
