using UnityEngine;

public class Pulsator : MonoBehaviour
{
    public float pulseSpeed = 2.0f; // מהירות הפעימות
    public float scaleMultiplier = 0.2f; // מידת הגדילה והקטנה
    private Vector3 originalScale; // גודל העצם המקורי

    void Start()
    {
        // שמירת הגודל המקורי של העצם
        originalScale = transform.localScale;
    }

    void Update()
    {
        // חישוב גודל חדש לפי סינוס
        float scaleOffset = Mathf.Sin(Time.time * pulseSpeed) * scaleMultiplier;
        transform.localScale = originalScale + new Vector3(scaleOffset, scaleOffset, scaleOffset);
    }
}
