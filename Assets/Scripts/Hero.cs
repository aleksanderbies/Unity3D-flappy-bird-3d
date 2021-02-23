using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed; 
    public float jumpHigh;
    Rigidbody heroRigidbody;
    private void Start()
    {
        heroRigidbody = GetComponent<Rigidbody>();
    }
    private void Update(){
        heroRigidbody.velocity = new Vector3(speed,heroRigidbody.velocity.y,heroRigidbody.velocity.z); 

        if (Input.GetKeyDown(KeyCode.Space)){
            heroRigidbody.velocity = new Vector3(heroRigidbody.velocity.x,heroRigidbody.velocity.y+jumpHigh,heroRigidbody.velocity.z); 
        }
        if(transform.position.y > 4){
            ChangeGravity(4);
        }else if(transform.position.y < -4){
            ChangeGravity(-4);
        }
    }
    private void ChangeGravity(int gravity)
    {
        transform.position = new Vector3(transform.position.x, gravity, transform.position.z);
        heroRigidbody.velocity = new Vector3(heroRigidbody.velocity.x, 0, 0);
    }
}
