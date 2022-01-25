using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static int Score;
    public static bool Collected = false;

    public TextMeshProUGUI scoreUI;

    private int pickUpsCount;

    private void Start()
    {
        pickUpsCount = GameObject.FindGameObjectsWithTag("PickUp").Length;
    }
    private void Update()
    {
        UpdateScoreUI();
    }
    private void UpdateScoreUI()
    {
        if (Score < pickUpsCount)
        {
            scoreUI.text = $"1. Score: {Score} / {pickUpsCount}";
        }
        else 
        {
            Collected = true;
            scoreUI.text = $"<s>1. Score: {Score} / {pickUpsCount}<s>";
            scoreUI.color = new Color32(200, 200, 200, 255);
        }
    }
}
