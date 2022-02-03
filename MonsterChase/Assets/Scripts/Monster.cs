using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector] public float speed;
    private Rigidbody2D _rigidbody;


    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        speed = 7;
       
    }

     void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(speed, _rigidbody.velocity.y);

            
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
