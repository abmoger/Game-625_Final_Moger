using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    ObjectPooler objectPooler;
    
    void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        objectPooler.SpawnFromPool("NPC", transform.position);
    }
}
