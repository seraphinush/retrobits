using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    public GameObject ks1Object;
    public GameObject ks2Object;
    public GameObject ks3Object;
    public GameObject ks4Object;
    public GameObject ks5Object;
    public GameObject ks6Object;
    private KeySpawner[] spawners = new KeySpawner[6];

    // Start is called before the first frame update
    void Start()
    {
        spawners[0] = ks1Object.GetComponent<KeySpawner>();
        spawners[1] = ks2Object.GetComponent<KeySpawner>();
        spawners[2] = ks3Object.GetComponent<KeySpawner>();
        spawners[3] = ks4Object.GetComponent<KeySpawner>();
        spawners[4] = ks5Object.GetComponent<KeySpawner>();
        spawners[5] = ks6Object.GetComponent<KeySpawner>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

