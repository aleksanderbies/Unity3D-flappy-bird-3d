using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesGenerator : MonoBehaviour
{
    public GameObject pipe;
    public float distance = 10;

    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            CreateObstacle();
        }
    }

    public void CreateObstacle()
    {
        Instantiate(pipe, new Vector3(distance, Random.Range(-3f,3f), 9), Quaternion.Euler(0, 0, 0));
        distance += 10;
    }
}
