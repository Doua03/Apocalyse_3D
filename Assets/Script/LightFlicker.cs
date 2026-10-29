using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light streetLight;
    public float minIntensity = 0f;
    public float maxIntensity = 3f;

    [Header("Flicker Timing")]
    public float minOnTime = 0.05f;
    public float maxOnTime = 0.5f;
    public float minOffTime = 0.05f;
    public float maxOffTime = 0.3f;

    private float timer = 0f;
    private bool isOn = true;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            isOn = !isOn;

            if (isOn)
            {
                streetLight.intensity = Random.Range(minIntensity, maxIntensity);
                timer = Random.Range(minOnTime, maxOnTime);
            }
            else
            {
                streetLight.intensity = 0f;
                timer = Random.Range(minOffTime, maxOffTime);
            }
        }
    }
}