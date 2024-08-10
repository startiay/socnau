using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{   
    public Point pcount;
    private Rigidbody2D rb;
    private Collider2D coll;
    public Vector3 moveInput;
    private float speed =10f;
    //private bool 


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.position += moveInput* speed * Time.deltaTime;

        if(moveInput.x !=0)
        {
            if(moveInput.x >0)
                transform.localScale = new Vector3(1,1,0);  
            else
                transform.localScale = new Vector3(-1,1,0);    
        }
        
    }

    private Point GetPcount()
    {
        return pcount;
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.gameObject.CompareTag("cherry"))
        {   
            
            Destroy(other.gameObject);
            pcount.Collectcherry();
           
        }
    }  

}   