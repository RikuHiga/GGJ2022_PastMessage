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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50*Time.deltaTime);
        if (trigger)
        {
            timer += Time.deltaTime*1.5f;
            transform.localScale = new Vector3(defaultSize.x * curve.Evaluate(timer), defaultSize.y * curve.Evaluate(timer), defaultSize.z * curve.Evaluate(timer));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        trigger = true;
        particle.Stop();
    }
}
