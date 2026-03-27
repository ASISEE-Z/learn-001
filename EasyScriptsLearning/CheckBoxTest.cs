using Godot;
using System;

public partial class CheckBoxTest : CheckBox
{

	public override void _Ready()
	{
	}


	public override void _Process(double delta)
	{
	}

	public void toggleChanged(bool on)
	{
		GD.Print(on);
	}
}
