using Godot;
using System;

public partial class Node2dTest : Node2D
{
	AudioStreamPlayer player;
	[Export]
	AudioStream bgm;
	public override void _Ready()
	{
		//实例化节点
		player = new AudioStreamPlayer();
		//加载到当前子节点
		this.AddChild(player);
		//加载音频
		player.Stream = bgm;
		//播放
		player.Play();
	}


	public override void _Process(double delta)
	{
	}
}
