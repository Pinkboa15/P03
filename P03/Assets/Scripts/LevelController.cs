using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject craft;
    [SerializeField] AudioClip _BackgroundMusic;

     void Start()
    {
        AudioHelper.PlayClip2D(_BackgroundMusic, 0.5f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            menu.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            craft.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
