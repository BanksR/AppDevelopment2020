using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject[] MenuPages;

    private void Awake()
    {
        // Here we call the function that hides all the game objects
        // in the gameobject array
        HideAllMenus();
        // Next we set active the required MenuPage using the correct
        // element index [0] in this case...
        MenuPages[0].SetActive(true);
    }

    public void OptionsButtonClicked()
    {
        // Here we call the function that hides all the game objects
        // in the gameobject array
        HideAllMenus();
        // Next we set active the required MenuPage using the correct
        // element index [0] in this case...
        MenuPages[1].SetActive(true);
    }

    public void CreditsButtonClicked()
    {
        // Here we call the function that hides all the game objects
        // in the gameobject array
        HideAllMenus();
        // Next we set active the required MenuPage using the correct
        // element index [0] in this case...
        MenuPages[2].SetActive(true);
    }

    public void StorePageClicked()
    {
        // Here we call the function that hides all the game objects
        // in the gameobject array
        HideAllMenus();
        // Next we set active the required MenuPage using the correct
        // element index [0] in this case...
        MenuPages[3].SetActive(true);
    }

    public void MainMenuButton()
    {
        // Here we call the function that hides all the game objects
        // in the gameobject array
        HideAllMenus();
        // Next we set active the required MenuPage using the correct
        // element index [0] in this case...
        MenuPages[0].SetActive(true);

    }

    private void HideAllMenus()
    {
        // This function hides all the menu pages
        foreach (GameObject g in MenuPages)
        {
            g.SetActive(false);
        }
    }

    public void StartGameButton()
    {
        HideAllMenus();
        MenuPages[4].SetActive(true);
    }

}
