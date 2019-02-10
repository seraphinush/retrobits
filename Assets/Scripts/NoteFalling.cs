using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFalling : MonoBehaviour
{
    Transform objectPosition;
    // Start is called before the first frame update
    void Start()
    {
        objectPosition = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        objectPosition.Translate(new Vector3(0.0f, -0.1f, 0.0f));
    }
}
