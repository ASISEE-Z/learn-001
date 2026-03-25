using Godot;
using System;

public partial class Area2dTest : Area2D
{

	public override void _Ready()
	{
	}


	public override void _Process(double delta)
	{
	}

	public void OnAreaEnter(Area2D area)
	{
		GD.Print("我发生碰撞了，和" + area.GetParent().Name);
	}
}
