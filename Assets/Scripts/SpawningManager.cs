using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SpawningManager : MonoBehaviour
{
    public GameObject ks1Object;
    public GameObject ks2Object;
    public GameObject ks3Object;
    public GameObject ks4Object;
    public GameObject ks5Object;
    public GameObject ks6Object;
    private KeySpawner[] spawners = new KeySpawner[6];
    public GameObject notePrefab;

    private int counter = 0;
    private string songName = "..\\Songs\\lostWoods.json";
    private int[][] song;

    //public string SongPath { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        spawners[0] = ks1Object.GetComponent<KeySpawner>();
        spawners[1] = ks2Object.GetComponent<KeySpawner>();
        spawners[2] = ks3Object.GetComponent<KeySpawner>();
        spawners[3] = ks4Object.GetComponent<KeySpawner>();
        spawners[4] = ks5Object.GetComponent<KeySpawner>();
        spawners[5] = ks6Object.GetComponent<KeySpawner>();

        LoadJson();
        
        foreach (KeySpawner ks in spawners)
        {
            ks.setNoteObject(notePrefab);
            ks.spawnNote();
        }
    }

    // Load song data as json
    void LoadJson()
    {
        /*using (StreamReader sr = new StreamReader(songName))
        {
            string json = sr.ReadToEnd();
            //SongData data = JsonUtility.FromJson<SongData>(json);

            //song = data.songObject;
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        /*if (counter < song.Length)
        {
            int[] temp = song[counter];
            for (int i = 0; i < temp.Length; i++)
            {
                //spawners[temp[i]].spawn();
            }
            counter++;
        }*/
    }
}

