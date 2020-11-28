using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwpandora : MonoBehaviour

{
    private Rigidbody misha;
    public float thrust = 1;
    public GameObject box;
    private Vector3 boxposition;
    private Quaternion rotation;
    
    private void Awake()
    {
        misha = GetComponent<Rigidbody>();
        boxposition = transform.position;
        rotation = transform.rotation; 
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            misha.AddForce(transform.forward * thrust);
            misha.useGravity = true;
            
            
            

        } 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            misha = Instantiate(box.GetComponent<Rigidbody>(), boxposition, rotation);
            
        }
    }
}
