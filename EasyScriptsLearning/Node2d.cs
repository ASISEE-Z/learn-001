using Godot;
using System;

public partial class Node2d : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Node2D node = FindChild("Node2D5") as Node2D;
		//父节点
		//Node2D node = this.GetParent() as Node2D;
		//Node2D node = this.Parent<Node2D>();
		//子节点
		//Node2D node = GetNode<Node2D>("Node2D5"); //效果与第九行代码一样
		//Node2D node = GetNode<Node2D>("Node2D5/aaa/bbb/ccc"); //相对路径写法 
		//Node2D node = GetNode<Node2D>("/root/Node2D/Node2D2/Node2D6/Node2D7/Node2D5"); //绝对路径写法
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
