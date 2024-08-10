using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.TextCore;

public class enemymove : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    BoxCollider2D myBoxCollider;
    public float speed =3f;

   
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

         myBoxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if(IsFacingRight())
        {
            rb.velocity = new Vector2(speed,0f);
        }
        else
        {
            rb.velocity = new Vector2(-speed,0f);
        }
    }
    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);
    }
    
    
}
