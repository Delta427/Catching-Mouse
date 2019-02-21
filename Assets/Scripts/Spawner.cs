using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cube;
    public int numberOfCubes;
    public int min, max;

    private void Start()
    {
        PlaceCubes();
    }

    void PlaceCubes()
    {
        for(int i = 0; i < numberOfCubes;i++)
        {
            Instantiate(cube, GeneratedPosition(), Quaternion.identity);
        }
    }

    Vector3 GeneratedPosition()
    {
        int x, y, z;
        x = Random.Range(min, max);
        y = Random.Range(min, max);
        z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
}
