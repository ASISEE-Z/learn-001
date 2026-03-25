using Godot;
using System;

public partial class AudioStreamPlayerTest : AudioStreamPlayer
{

	public override void _Ready()
	{
	}


	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("左"))
		{
			//判断当前是否在播放
			if(this.Playing == false)
			{
				//播放
				this.Play();
			}
		}
		if (Input.IsActionJustPressed("右"))
		{
			//停止播放，之后按左键会重头播放
			this.StreamPaused = true;
		}
		if (Input.IsActionJustPressed("下"))
		{
			//停止播放，之后按左键会继续播放
			this.StreamPaused = false;
		}
	}
}
