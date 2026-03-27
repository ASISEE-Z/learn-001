using Godot;
using System;

public partial class TextureButtonTest : TextureButton
{

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}

	public void ButtonClick()
	{
		GD.Print("点击");
	}

}
