using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luminosity.IO;


public class Volar : MonoBehaviour
{
    public float FuerzaVuelo;
    public bool Mobile;
        
    private Rigidbody2D Rb2D;
    private Animator _animator;
    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        Rb2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

   
    void FixedUpdate() {
        
        velocity = new Vector2(0f ,1f*FuerzaVuelo);
        if(!Mobile && InputManager.PlayerOneControlScheme.Name == "ControlPC"){
            //Interacción desde Teclado
            if( InputManager.GetAxisRaw("Action") > 0f  ){
                _animator.SetBool("Ignition", true);
                Rb2D.MovePosition( Rb2D.position + velocity * Time.fixedDeltaTime);
            }else{
                _animator.SetBool("Ignition", false);
            }
        }
        if(Mobile && InputManager.PlayerOneControlScheme.Name == "ControlMobile"){
            //Interacción desde Teclado
            if( InputManager.GetButton("Action")  ){
                _animator.SetBool("Ignition", true);
                Rb2D.MovePosition( Rb2D.position + velocity * Time.fixedDeltaTime);
            }else{
                _animator.SetBool("Ignition", false);
            }
        }
    }

    
}
