using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 100, 0); // מהירות הסיבוב בצירים X, Y, Z

    void Update()
    {
        // סיבוב האובייקט סביב עצמו
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
