using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int points;
    TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        textMesh = GameObject.Find("PointsDisplay").GetComponent<TextMeshProUGUI>();
    }

    void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag) {
            case "Spiders":
                points += 10; // Cambio a 10 puntos (antes 5)
                Destroy(other.gameObject);
                break;
        }

    }
    
    void Update() {
        textMesh.text = "Points: " + points.ToString();
    }
}
