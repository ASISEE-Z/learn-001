using Godot;
using System;
using System.ComponentModel;

public partial class CharacterBody2dPlayer : CharacterBody2D
{
	NavigationAgent2D nav;

    public override void _Ready()
    {
        base._Ready();
		//获取agent节点
		nav = GetNode<NavigationAgent2D>("NavigationAgent2D");
	}

	public override void _PhysicsProcess(double delta)
	{
		//设置鼠标位置为导航点
		nav.TargetPosition = GetGlobalMousePosition();
		//朝向该方向移动
		Vector2 dir = (nav.GetNextPathPosition() - this.Position).Normalized();
		//朝向该方向移动
		Velocity = dir * 300;

		MoveAndSlide();
	}
}
