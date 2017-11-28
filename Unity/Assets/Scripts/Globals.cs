﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour {

	//CONSTANST
	public static int HEALTH = 100;//change if needed
	public const int TIME_PER_TURN = 10;
	//Pistol
	public const int PISTOL_DAMAGE = 50;
	public const int PISTOL_AMMO = 10; //If limitedAmmo is true
	public static int SHOTS_PER_TURN = 2;
	//Pickaxe
	public const int PICKAXE_DAMAGE = 100;
	//STATIC
	public static int numChickens = 2; //initial chickens to gameplay
	public static int numFlags = 2; //initial chickens to gameplay
	public static bool limitedAmmo = true;
	public static int MAX_POINTS = 500; //points to win
	internal static readonly int MAXTEAMS = 2;

	internal static bool changeTurn = false;
	internal static bool finishTurn = false;
	internal static int accPoints = 0;

}
