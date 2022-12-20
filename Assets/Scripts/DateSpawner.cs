using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateSpawner : MonoBehaviour
{

    public GameObject datePrefab;
    public int spawnCount;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("spawnDates", 0f, 0.4f);
    }



    // Update is called once per frame
    void Update()
    {
   
    }

    void spawnDates()
    //Vector3 pos = new Vector3()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, Random.Range(transform.position.z-1, transform.position.z+1));
        Instantiate(datePrefab, pos, Quaternion.identity);
    }
}
