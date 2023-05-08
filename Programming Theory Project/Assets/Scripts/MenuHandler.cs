using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    [Header("Script References")]
    [SerializeField] Weapon weapon;
    [SerializeField] Armor armor;

    [Header("Text References")]
    [SerializeField] TMP_Text armorNameText;
    [SerializeField] TMP_Text armorValueText;
    [SerializeField] TMP_Text weaponNameText;
    [SerializeField] TMP_Text weaponValueText;

    [Header("Bullet GameObject References")]
    [SerializeField] GameObject bulletOne;
    [SerializeField] GameObject bulletTwo;

    private int currentSelection = 0;
    private bool isBusy;

    void Start()
    {
        //ABSTRACTION
        SetupItemTexts(); 
        UpdateSelectionAction(currentSelection);
    }

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && !isBusy)
		{
            //ABSTRACTION
            HandleSelectionAction();
		}
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && !isBusy)
        {
            //ABSTRACTION
            HandleSelectionAction();
        }

        //Quit Game
        if (Input.GetKeyDown(KeyCode.Q) && !isBusy)
		{
            //ABSTRACTION
            QuitGame();
		}
    }

    private void HandleSelectionAction()
	{
        isBusy = true;

        currentSelection++;
        currentSelection %= 2;
        //ABSTRACTION
        UpdateSelectionAction(currentSelection);         

        isBusy = false;
    }

    private void UpdateSelectionAction(int currentSelection)
	{
        if (currentSelection == 0)
        {
            //ABSTRACTION
            EnabledBullet(bulletOne, true);
            //ABSTRACTION
            EnabledBullet(bulletTwo, false);
            //ABSTRACTION
            weapon.Description();
        }
        else if (currentSelection == 1)
		{
            //ABSTRACTION
            EnabledBullet(bulletOne, false);
            //ABSTRACTION
            EnabledBullet(bulletTwo, true);
            //ABSTRACTION
            armor.Description();
        }
	}

	private void EnabledBullet (GameObject bullet, bool enable)
	{
        bullet.SetActive(enable);
	}

    private void SetupItemTexts()
	{
        armorNameText.text = armor.GetName;
        armorValueText.text = armor.GetValue;
        weaponNameText.text = weapon.GetName;
        weaponValueText.text = weapon.GetValue;
	}

    private void QuitGame()
	{
        Application.Quit();
	}
}
