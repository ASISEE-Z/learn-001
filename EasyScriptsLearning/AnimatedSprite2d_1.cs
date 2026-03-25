using Godot;
using System;

public partial class AnimatedSprite2d_1 : AnimatedSprite2D
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("左"))
		{
			this.Play("Idle");//播放
			//this.Pause //暂停
			//this.Stop //停止
			//this.IsPlaying //是否在播放
		}
		if (Input.IsActionJustPressed("右"))
		{
			this.Play("attack");
		}
	}
}
