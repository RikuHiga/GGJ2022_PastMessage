using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShardControl : MonoBehaviour
{
    Vector3 defaultSize = new Vector3(61.515f,61.515f,61.515f);
    public AnimationCurve curve;
    float timer = 0;
    bool trigger = false;
    public ParticleSystem particle;
    public GameObject hanabi;
    Light light;
    public GameObject lightObj;

    bool start = false;
    float startTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        light = lightObj.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 defaultPos = new Vector3(transform.position.x, 1.5f + Mathf.Sin(Time.time)*0.7f, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, defaultPos, Time.deltaTime);
        transform.Rotate(0, 0, 50*Time.deltaTime);
        if (trigger)
        {
            timer += Time.deltaTime*1.5f;
            transform.localScale = new Vector3(defaultSize.x * curve.Evaluate(timer), defaultSize.y * curve.Evaluate(timer), defaultSize.z * curve.Evaluate(timer));
            light.intensity = 1.54f * curve.Evaluate(timer);
            if (timer >= 10f)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        trigger = true;
        particle.Stop();
        Instantiate(hanabi, transform.position, Quaternion.identity);
    }
}
