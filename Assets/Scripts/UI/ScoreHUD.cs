using TMPro;
using UnityEngine;

public class ScoreHUD : MonoBehaviour
{
    public ScoreSystem scoreSystem;

    public TextMeshProUGUI scoreText;

    void Update()
    {
        
        scoreText.text = "Lanches: " + scoreSystem.hamburgers;
    }
}
