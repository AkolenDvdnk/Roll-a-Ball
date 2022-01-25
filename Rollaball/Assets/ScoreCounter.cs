using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static int Score;

    public TextMeshProUGUI scoreUI;

    private void Update()
    {
        scoreUI.text = "Score: " + Score;
    }
}
