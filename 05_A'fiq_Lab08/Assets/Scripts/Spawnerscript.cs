using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] prefabs;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnObjects", 1, 1);
       
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        int prefeb_num = Random.Range(0, prefabs.Length);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(prefabs[prefeb_num], transform.position, transform.rotation);
    }
}
