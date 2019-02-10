using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    private GameObject spawnObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNoteObject(GameObject note)
    {
        spawnObject = note;
    } 

    public void spawnNote()
    {
        Instantiate(spawnObject, transform);
    }
}
