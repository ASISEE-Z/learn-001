using Godot;
using System;

public partial class ProgressBarTest : ProgressBar
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.Right))
		{
			this.Value += 50 * delta;
		}
		if (Input.IsKeyPressed(Key.Left))
		{
			this.Value -= 50 * delta;
		}
	}

	public void onValueChnaged(float value)
	{
		GD.Print(value);
	}
}
