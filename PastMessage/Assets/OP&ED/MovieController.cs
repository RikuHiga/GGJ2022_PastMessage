using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovieController : MonoBehaviour
{
    public GameObject ui;
    RawImage raw;
    public AnimationCurve curve;
    float time = 0;
    float alphaTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        raw = ui.GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 4f)
        {
            alphaTime += Time.deltaTime/2;
            raw.color = new Color(raw.color.r, raw.color.g, raw.color.b, curve.Evaluate(alphaTime));
        }
    }
}
