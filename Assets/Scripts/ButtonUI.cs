using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string ProcessPage = "ProcessPage";
    [SerializeField] private string Process = "Process";
    [SerializeField] private string CreditsPage = "CreditsPage";

    public void ProcessButton()
    {
        SceneManager.LoadScene(ProcessPage);
    }
    public void SimulationButton()
    {
        SceneManager.LoadScene(Process);
        PlayerPrefs.SetInt("refreshed", 0);
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene(CreditsPage);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
