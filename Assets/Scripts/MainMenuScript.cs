using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour 
{
    public string m_instructionText = "Instrução: \nPressione seta esquerda e direita para se mover. \nPressione tecla espaço para atirar.";
    private const int m_buttonWidth = 200;
    private const int m_buttonHeight = 50;
    public Texture m_backgroundTexture;

    // Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnGUI()
    {        
        GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),m_backgroundTexture);
        GUI.Label(new Rect(10, 10, 200, 200), m_instructionText);
        if  (Input.anyKeyDown)
        {
            Application.LoadLevel(1);
        }
    }
}
