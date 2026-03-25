using Godot;
using System;

public partial class Player : Sprite2D
{

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("右"))
		{
			//获取分组中的节点
			var enemys = this.GetTree().GetNodesInGroup("敌人");
			//遍历敌人
			foreach(Node enemy in enemys)
			{
				//销毁
				enemy.QueueFree();
			}
		}
		if (Input.IsActionJustPressed("左"))
		{
			//调用一个分组中的节点的test方法
			this.GetTree().CallGroup("敌人","test");
		}
		if (Input.IsActionJustPressed("上"))
		{
			//将当前节点添加到敌人分组
			this.AddToGroup("敌人");
		}
	}
}
