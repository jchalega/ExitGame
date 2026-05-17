using UnityEngine;

public class PulseUI : MonoBehaviour
{
    [SerializeField] public float speed = 2f;
    [SerializeField] public float scaleAmount = 0.05f;

    private Vector3 startScale;

    void Start()
    {
        startScale = transform.localScale;
    }

    void Update()
    {
        float scale = 1 + Mathf.Sin(Time.time * speed) * scaleAmount;

        transform.localScale = startScale * scale;
    }
}