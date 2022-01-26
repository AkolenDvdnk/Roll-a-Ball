using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static int GoldScore;
    public static bool goldCollected = false;
    public static bool rubyCollected = false;

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
        if (GoldScore < pickUpsCount)
        {
            scoreUI.text = $"1. Score: {GoldScore} / {pickUpsCount}";
        }
        else 
        {
            goldCollected = true;
            scoreUI.text = $"<s>1. Score: {GoldScore} / {pickUpsCount}<s>";
            scoreUI.color = new Color32(200, 200, 200, 255);
        }
    }
}
