using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObsticle : MonoBehaviour
{
    public GameObject[] obsticle ;
    public Transform point1, point2;
    void Start()
    {
       
        InvokeRepeating("SpawnObs",2,3);
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    void SpawnObs() {
        if (FindObjectOfType<GameManager>().isGAmeStart == true)
        {
            int rand = Random.Range(1, 2);
            int obsRand = Random.Range(0, obsticle.Length);
            if (rand == 1)
            {

                Instantiate(obsticle[obsRand], point1.position, Quaternion.identity);
            }
            else
            {
                Instantiate(obsticle[obsRand], point2.position, Quaternion.identity);
            }
        }
       
        
        //newObsticle.transform.position += Vector3.up * Random.Range(.43f,1.39f);
    }
}
