using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public KeyCode key;
    private bool active;
    private GameObject activeNote;
    public GameObject scoreBoard;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            print(key);
            AddScore();
            Destroy(activeNote);
        }
    }

    void OnTriggerEnter(Collider colKey)
    {
        active = true;
    }

    private void OnTriggerExit(Collider colKey)
    {
        active = false;
        activeNote = colKey.gameObject;
    }

    //Replace call after your Destroy
    //Also, right after you call AddScore(), write "active = flse" to deactivate AddScore() from bringing points just after a note is destroyed
    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 100);
    }
}