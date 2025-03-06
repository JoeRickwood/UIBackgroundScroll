using UnityEngine;

public class SinRotate : MonoBehaviour
{
    public float frequency;
    public float amplitude;

    float time;

    private void Update()
    {
        time += Time.deltaTime;

        transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Sin(time * frequency) * amplitude);
    }
}
