using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_Enemy_Controller : MonoBehaviour
{
    public float Speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Speed * Time.deltaTime;
    }
}
