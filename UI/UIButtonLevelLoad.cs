using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIButtonLevelLoad : MonoBehaviour {
	
	
	public void loadLevel() {
        //Load the level from LevelToLoad
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("Level1");
        }
        else if (SceneManager.GetActiveScene().name=="Level2" )
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void loadLevel1()
    {
        //Load the level from LevelToLoad
       
            SceneManager.LoadScene("Level1");
      
    }
    public void loadLevel2()
    {
        //Load the level from LevelToLoad

        SceneManager.LoadScene("Level2");

    }
}
