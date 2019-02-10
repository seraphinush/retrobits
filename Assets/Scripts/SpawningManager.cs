using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

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
    private int counterr = 0;

    int[][] song = new int[][]
    {
        new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},

        new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {4},new int[1] {3},new int[1] {4},new int[1] {3},new int[1] {2},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {3},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {2},new int[1] {6},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {6},new int[1] {0},new int[1] {0},new int[1] {2},new int[1] {6},new int[1] {2},new int[1] {5},new int[1] {3},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {3},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {5},new int[1] {0},
        new int[2] {1,3},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {2},new int[1] {4},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[1] {3},new int[1] {2},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[2] {1,3},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {2},new int[1] {4},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[1] {3},new int[1] {2},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},

        new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {4},new int[1] {3},new int[1] {4},new int[1] {3},new int[1] {2},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {3},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {2},new int[1] {6},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {4},new int[1] {0},new int[1] {0},new int[1] {5},new int[1] {3},new int[1] {4},new int[1] {6},new int[1] {4},new int[1] {2},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {6},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {3},new int[1] {0},
        new int[2] {2,3},new int[1] {0},new int[2] {4,5},new int[1] {0},new int[2] {4,5},new int[1] {0},new int[3] {3,4,6},new int[1] {2},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {6},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {3},new int[1] {0},
        new int[2] {1,3},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {2},new int[1] {4},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[1] {3},new int[1] {2},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},

        new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {4},new int[1] {3},new int[1] {4},new int[1] {3},new int[1] {2},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {3},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {2},new int[1] {6},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {6},new int[1] {0},new int[1] {0},new int[1] {2},new int[1] {6},new int[1] {2},new int[1] {5},new int[1] {3},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {3},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {5},new int[1] {0},
        new int[2] {1,3},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {2},new int[1] {4},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[1] {3},new int[1] {2},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[2] {1,3},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {2},new int[1] {4},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[1] {3},new int[1] {2},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},

        new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {4},new int[1] {3},new int[1] {4},new int[1] {3},new int[1] {2},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {3},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {2},new int[1] {6},new int[1] {1},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {4},new int[1] {0},new int[1] {0},new int[1] {5},new int[1] {3},new int[1] {4},new int[1] {6},new int[1] {4},new int[1] {2},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {6},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {3},new int[1] {0},
        new int[2] {2,3},new int[1] {0},new int[2] {4,5},new int[1] {0},new int[2] {4,5},new int[1] {0},new int[3] {3,4,6},new int[1] {2},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {6},new int[1] {0},new int[1] {1},new int[1] {0},new int[1] {1},new int[1] {2},new int[1] {3},new int[1] {0},new int[1] {0},new int[1] {0},new int[1] {3},new int[1] {0},
        new int[2] {1,3},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {6},new int[1] {0},new int[1] {2},new int[1] {4},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0},
        new int[1] {2},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[2] {4,6},new int[1] {0},new int[1] {3},new int[1] {2},new int[1] {5},new int[1] {0},new int[1] {0},new int[1] {0}
    };

    // Start is called before the first frame update
    void Start()
    {
        spawners[0] = ks1Object.GetComponent<KeySpawner>();
        spawners[1] = ks2Object.GetComponent<KeySpawner>();
        spawners[2] = ks3Object.GetComponent<KeySpawner>();
        spawners[3] = ks4Object.GetComponent<KeySpawner>();
        spawners[4] = ks5Object.GetComponent<KeySpawner>();
        spawners[5] = ks6Object.GetComponent<KeySpawner>();

        foreach (KeySpawner ks in spawners)
        {
            ks.setNoteObject(notePrefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (counterr > 10)
        {
            if (counter < song.Length)
            {
                int[] temp = song[counter];
                if (temp[0] != 0)
                {
                    spawners[temp[0]].spawnNote();
                }
                counter++;
            }
            counterr = 0;
        } else
        {
            counterr++;
        }
    }
}

