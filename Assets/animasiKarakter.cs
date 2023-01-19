using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasiKarakter : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public Rigidbody rb;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
