using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float minY_estrellas;
    public float minY;
    public Transform SeguirRocket1;
    public Transform SeguirRocket2;
    public Transform Estrellas;
   
    void Start()
    {
        this.transform.position = new Vector3(this.transform.position.x , minY , this.transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(SeguirRocket1.position.y > minY){
            if(this.transform.position.y>=minY){
                this.transform.position = new Vector3(this.transform.position.x , SeguirRocket1.position.y  , this.transform.position.z);

                if( SeguirRocket1.position.y >= Estrellas.position.y  )
                    Estrellas.position = new Vector2(this.transform.position.x , SeguirRocket1.position.y );
                    
                if(SeguirRocket1.position.y < Estrellas.position.y && Estrellas.position.y>minY_estrellas)
                    Estrellas.position = new Vector2(this.transform.position.x , SeguirRocket1.position.y );
            }       
        }    
        if(SeguirRocket2.position.y > minY){
            if(this.transform.position.y>=minY){
                this.transform.position = new Vector3(this.transform.position.x , SeguirRocket2.position.y  , this.transform.position.z);

                if( SeguirRocket2.position.y >= Estrellas.position.y  )
                    Estrellas.position = new Vector2(this.transform.position.x , SeguirRocket2.position.y );
                    
                if(SeguirRocket2.position.y < Estrellas.position.y && Estrellas.position.y>minY_estrellas)
                    Estrellas.position = new Vector2(this.transform.position.x , SeguirRocket2.position.y );
            }       
        }   
        
    }
}
