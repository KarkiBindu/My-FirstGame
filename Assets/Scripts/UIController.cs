using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    #region Singleton
    private static UIController _instance;

    public static UIController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIController>();
            }

            return _instance;
        }
    }
    #endregion

    #region Variable Declaration
    public Text countText;    
    public Text time;
    public Text winText;
    public Text level;
    #endregion

    private void Start()
    {       
        SetCountText();
        winText.text = string.Empty;
        level.text = string.Empty;
        time.text = string.Empty;
    }

    #region Set Level cont
    public void SetCountText()
    {
        countText.text = "Count : " + PlayerController.count.ToString();
        if (PlayerController.count < 15)
        {
            level.text = "Level : 1";
        }

        if (PlayerController.count >= 15)
        {
            level.text = "Level : 2";
        }
    }
    #endregion

    #region Exit Button Click
    public void Exit()
    {
        Application.Quit();
    }
    #endregion

    #region Restart Button Click
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    #endregion
}
