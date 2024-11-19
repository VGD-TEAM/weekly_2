using UnityEngine;

public class HideAndShow : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.H; // המקש לשינוי מצב התצוגה (לדוגמה, H)
    private Renderer objectRenderer; // האובייקט שמציג את התצוגה

    void Start()
    {
        // קבלת הרכיב Renderer של האובייקט
        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer == null)
        {
            Debug.LogError("Renderer not found! Make sure the object has a Renderer component.");
        }
    }

    void Update()
    {
        // בדיקה אם המשתמש לחץ על המקש שנבחר
        if (Input.GetKeyDown(toggleKey) && objectRenderer != null)
        {
            // הפיכת מצב התצוגה (on/off)
            objectRenderer.enabled = !objectRenderer.enabled;
        }
    }
}
