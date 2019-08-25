using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
	public void OnPlayButtonClicked()
    {
    	Application.LoadLevel("CombatTest");
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
