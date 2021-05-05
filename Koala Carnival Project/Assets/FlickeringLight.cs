using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public float intensity = 0.2f;
    public float perSecond = 3.0f;
    public float speedRandomness = 1.0f;
        
    private float time;
    private float startIntensity;
    private Light light;

    void Start()
    {
        light = GetComponent<Light>();
        startIntensity = light.intensity;
    }

    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        light.intensity = startIntensity + Mathf.Sin(time * perSecond) * intensity;
    }
}
