using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

	[SerializeField] Menu[] menus;

	public void Open(Menu menu)
	{

		for (int i = 0; i < menus.Length; i++)
		{

			if (menus[i].active)
			{

				Close(menus[i]);

			}

		}

		menu.Open();

	}

	public void Close(Menu menu)
	{

		menu.Close();

	}
}
