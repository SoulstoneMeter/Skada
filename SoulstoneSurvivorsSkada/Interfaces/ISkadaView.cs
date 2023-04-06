﻿using UnityEngine;

namespace SoulstoneSurvivorsSkada.Interfaces;

/// <summary>
///  Interface for a Skada View to be used by the GUI
/// </summary>
public interface ISkadaView
{
	/// <summary>
	/// Position of the Scrollbar
	/// </summary>
	public int ScrollPosition { get; set; }
	
	/// <summary>
	/// Title of the View
	/// </summary>
	public string Title { get; set; }

	/// <summary>
	/// Called by the GUI
	/// </summary>
	/// <param name="windowRect">Rectangle of the Window</param>
	/// <param name="windowID">ID of the Window</param>
	public void OnGUI(ref Rect windowRect, int windowID);
	
	/// <summary>
	/// Called when the View is enabled
	/// </summary>
	public void OnEnable();
	
	/// <summary>
	/// Called when the View is disabled
	/// </summary>
	public void OnDisable();
}