using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightControl : MonoBehaviour
{
    Light light;
    public AnimationCurve curve;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        light = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime/5;
        light.intensity = curve.Evaluate(time)*1;
    }
}
