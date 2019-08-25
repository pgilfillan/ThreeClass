using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("CombatTest");
    }

	public void OnOptionButtonClicked()
    {
    	Debug.Log("Load options menu");
    }

    public void OnQuitButtonClicked()
    {
    	Application.Quit();
    }
}
