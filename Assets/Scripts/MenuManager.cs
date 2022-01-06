using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    [SerializeField] TMP_InputField namePlayer;
    [SerializeField] TextMeshProUGUI errorTxt;

    private void Awake()
    {        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void StartGame()
    {   
        
        if (namePlayer.text == "")
        {            
            errorTxt.gameObject.SetActive(true);
            return;
        }

        errorTxt.gameObject.SetActive(false);
        SceneManager.LoadScene(1);       
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
