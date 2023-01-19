using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Dart : MonoBehaviour
{
    public Rigidbody2D rb;
    float speed = 10f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Fire()
    {
        rb.velocity = Vector3.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.collider.GetComponent<Dart>() != null) 
        {
            SceneManager.LoadScene(0);
        }

        transform.SetParent(collision.transform);
            rb.isKinematic = true;
            var score = FindObjectOfType<Score>();
            score.AddPoint();
        
    }
}

    
    
  
  


