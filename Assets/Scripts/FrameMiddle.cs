using System.Collections.Generic;
using UnityEngine;

public class FrameMiddle : MonoBehaviour
{
    private SpriteRenderer spriteR;
    Color currentColor;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColorPeriodically();
    }

    void ChangeColorPeriodically()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();

        var lerpedColor = Color.Lerp(Color.white, Color.green, Mathf.PingPong(Time.time, 1));

        spriteR.color = lerpedColor;
    }

}