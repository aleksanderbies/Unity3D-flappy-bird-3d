using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Hero heroCharacter;
    private void Start()
    {
        heroCharacter = FindObjectOfType<Hero>();
    }
    void Update()
    {
        transform.position = new Vector3(heroCharacter.transform.position.x, transform.position.y, transform.position.z); 
    }
}
