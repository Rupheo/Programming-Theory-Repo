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
        SetupItemTexts(); 
        UpdateSelectionAction(currentSelection);
    }

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && !isBusy)
		{
            HandleSelectionAction();
		}
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && !isBusy)
        {
            HandleSelectionAction();
        }

        //Quit Game
        if (Input.GetKeyDown(KeyCode.Q) && !isBusy)
		{
            QuitGame();
		}
    }

    private void HandleSelectionAction()
	{
        isBusy = true;

        currentSelection++;
        currentSelection %= 2;
        UpdateSelectionAction(currentSelection);         

        isBusy = false;
    }

    private void UpdateSelectionAction(int currentSelection)
	{
        if (currentSelection == 0)
        {
            EnabledBullet(bulletOne, true);
            EnabledBullet(bulletTwo, false);
            weapon.Description();
        }
        else if (currentSelection == 1)
		{
            EnabledBullet(bulletOne, false);
            EnabledBullet(bulletTwo, true);
            armor.Description();
        }
	}

	private void EnabledBullet (GameObject bullet, bool enable)
	{
        bullet.SetActive(enable);
	}

    private void SetupItemTexts()
	{
        armorNameText.text = armor.GetItemName;
        armorValueText.text = armor.GetItemValue;
        weaponNameText.text = weapon.GetItemName;
        weaponValueText.text = weapon.GetItemValue;
	}

    private void QuitGame()
	{
        Application.Quit();
	}
}
