using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Retry()
    {
        RefreshVariables();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
    private void RefreshVariables()
    {
        MissionManager.goldCollected = false;
        MissionManager.rubyCollected = false;
        MissionManager.GoldScore = 0;
        MissionManager.RubyScore = 0;
        ButtonBox.buttonPressed = false;
    }
}
