using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed; 
    public float jumpHigh;
    public bool wereCollision = false;
    float timer = 0;
    Rigidbody heroRigidbody;

    private void Start()
    {
        heroRigidbody = GetComponent<Rigidbody>();
    }

    private void Update(){
        timer += Time.deltaTime;
        heroRigidbody.velocity = new Vector3(speed + (timer / 3), heroRigidbody.velocity.y, heroRigidbody.velocity.z); 

        if (Input.GetKeyDown(KeyCode.Space)){
            heroRigidbody.velocity = new Vector3(heroRigidbody.velocity.x, heroRigidbody.velocity.y+jumpHigh, heroRigidbody.velocity.z); 
        }
        if(transform.position.y > 6){
            ChangeGravity(6);
        }else if(transform.position.y < -6){
            ChangeGravity(-6);
        }
        transform.rotation = Quaternion.Euler((heroRigidbody.velocity.y * 2) - 60, -90, -90);
    }
    private void ChangeGravity(int gravity)
    {
        transform.position = new Vector3(transform.position.x, gravity, transform.position.z);
        heroRigidbody.velocity = new Vector3(heroRigidbody.velocity.x, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        wereCollision = true;
    }
}
