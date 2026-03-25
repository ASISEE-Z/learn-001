using Godot;
using System;

public partial class InputTest2 : Node
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		//按下键盘左键
		if (Input.IsActionJustPressed("左"))
		{
			//获取当前场景的根节点
			Node root = this.GetTree().CurrentScene;
			//去寻找test节点
			Node test = root.FindChild("Test");
			//尝试删除test
			// test.QueueFree();
			//要把Test节点从节点树中拿出来
			root.RemoveChild(test);
			//将孤立的Test添加到当前节点下：
			this.AddChild(test);
		}

		if (Input.IsActionJustPressed("右"))
		{
			//获取当前场景的根节点
			Node root = this.GetTree().CurrentScene;
			//创建一个新节点
			Node2D node2D = new Node2D();
			//改个名称
			node2D.Name = "new";
			//添加进来
			this.AddChild(node2D);
		}
	}
}
