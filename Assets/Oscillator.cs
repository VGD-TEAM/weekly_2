using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public float frequency = 1f; // תדירות (כמה מהר זה זז)
    public float amplitude = 3f; // משרעת (כמה רחוק זה זז מנקודת המרכז)
    private Vector3 startPosition; // מיקום התחלתי

    void Start()
    {
        // שמור את המיקום ההתחלתי של האובייקט
        startPosition = transform.position;
    }

    void Update()
    {
        // חשב תנועה מחזורית לפי סינוס
        float offset = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = startPosition + new Vector3(offset, 0, 0);
    }
}
