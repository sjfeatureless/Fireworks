using UnityEngine;
using UnityEngine.VFX;

public class trail : MonoBehaviour

{
    public VisualEffect fireworksEffect;
    public TrailRenderer trailtest;

    void Update()
    {
        // Assuming the fireworks effect has a constant position, update the trail position
        trailtest.transform.position = fireworksEffect.transform.position;
    }
}