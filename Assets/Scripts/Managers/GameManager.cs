﻿using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;

	void Awake()
	{
		instance = this;
	}
}