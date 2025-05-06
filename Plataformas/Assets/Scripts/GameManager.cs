using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance;
   private void Awake()
   {
       if (Instance ==  null)
       {
           Instance = this;
           DontDestroyOnLoad(gameObject);
       }
   
       else
       {
           Destroy(gameObject);
       }
   }
   
   public void LoadGameAndGUI()
   {
       SceneManager.LoadScene("Game");
       SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
   }
   
   private void Start()
   {
    LoadGameAndGUI();   
   }
   }


