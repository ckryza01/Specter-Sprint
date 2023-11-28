using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

	public bool active;

	public void Open()
	{

		active = true;
		gameObject.SetActive(true);

	}

	public void Close()
	{

		active = false;
		gameObject.SetActive(false);

	}
}