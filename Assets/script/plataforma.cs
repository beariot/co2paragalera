using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
     public float tempoQueda;
    private TargetJoint2D target;
    private BoxCollider2D boxcollider;

    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxcollider = GetComponent<BoxCollider2D>();

    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
        
        Invoke("falling", tempoQueda);
        
        }
      
      if(collision.gameObject.layer == 8)
      
        {
            Destroy(gameObject);
        }    
    }
    
    void falling()
    {

     target.enabled = false;
    boxcollider.isTrigger = true;

    }

    // void onTriggerEnter2D(Collider2D collider){
    // if(collider.gameObject.layer == 9){
    // Destroy(gameObject);
    // }


}