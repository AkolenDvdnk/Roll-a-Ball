using UnityEngine;
using TMPro;

public class MissionManager : MonoBehaviour
{
    public static bool goldCollected = false;
    public static bool rubyCollected = false;

    public static int GoldScore;
    public static int RubyScore;

    public GameObject player;
    public GameObject endGameUI;
    public TextMeshProUGUI goldUI;
    public TextMeshProUGUI buttonUI;
    public TextMeshProUGUI rubyUI;
    public TextMeshProUGUI finalQuestUI;

    private int goldCount;
    private int rubyCount;

    private void Start()
    {
        goldCount = GameObject.FindGameObjectsWithTag("Gold").Length;
        rubyCount = GameObject.FindGameObjectsWithTag("Ruby").Length;
    }
    private void Update()
    {
        UpdateUI();
    }
    private void UpdateUI()
    {
        UpdateScoreUI();
        UpdateButtonUI();
        UpdateFinalQuestUI();
    }
    private void UpdateButtonUI()
    {
        if (ButtonBox.buttonPressed)
        {
            buttonUI.text = "<s>2. Activate the portal<s>";
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
    private void UpdateFinalQuestUI()
    {
        if (!player.activeInHierarchy)
        {
            finalQuestUI.text = "<s>4. Sacrifice yourself<s>";
            finalQuestUI.color = new Color32(200, 200, 200, 255);

            endGameUI.SetActive(true);
        }
    }
}