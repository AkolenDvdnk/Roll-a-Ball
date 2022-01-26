using UnityEngine;
using TMPro;

public class MissionManager : MonoBehaviour
{
    public static int GoldScore;
    public static int RubyScore;
    public static bool goldCollected = false;
    public static bool rubyCollected = false;

    public TextMeshProUGUI goldUI;
    public TextMeshProUGUI buttonUI;
    public TextMeshProUGUI rubyUI;

    private int goldCount;
    private int rubyCount;

    private void Start()
    {
        goldCount = GameObject.FindGameObjectsWithTag("Gold").Length;
        rubyCount = GameObject.FindGameObjectsWithTag("Ruby").Length;
    }
    private void Update()
    {
        UpdateScoreUI();
        UpdateButtonUI();
    }
    private void UpdateButtonUI()
    {
        if (ButtonBox.buttonPressed)
        {
            buttonUI.text = "<s>2. Press the Button<s>";
            buttonUI.color = new Color32(200, 200, 200, 255);
        }
    }
    private void UpdateScoreUI()
    {
        if (GoldScore < goldCount)
        {
            goldUI.text = $"1. Gold: {GoldScore} / {goldCount}";
        }
        else 
        {
            goldCollected = true;
            goldUI.text = $"<s>1. Gold: {GoldScore} / {goldCount}<s>";
            goldUI.color = new Color32(200, 200, 200, 255);
        }

        if (RubyScore < rubyCount)
        {
            rubyUI.text = $"3. Ruby: {RubyScore} / {rubyCount}";
        }
        else
        {
            rubyCollected = true;
            rubyUI.text = $"<s>3. Ruby: {RubyScore} / {rubyCount}<s>";
            rubyUI.color = new Color32(200, 200, 200, 255);
        }
    }
}