using Godot;
using System;

public partial class Button1 : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//按钮信号动态连接
		this.Connect("pressed", new Callable(this, "buttonClick"));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void buttonClick()
	{
		//找到精灵路径并删除
		Node2D node = GetNode<Node2D>("/root/Node2D/Sprite2D");
		node.QueueFree();
	}
}
