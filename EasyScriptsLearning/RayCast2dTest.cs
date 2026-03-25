using Godot;
using System;

public partial class RayCast2dTest : RayCast2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
		//按下键盘左键，拿到当前一次的射线检测结果
		if (Input.IsActionJustPressed("左"))
		{
			if (this.IsColliding())
			{
				//拿到碰撞的区域
				Area2D area2D = this.GetCollider() as Area2D;
				GD.Print("检测到了：" + area2D.GetParent().Name);
			}
			else
			{
				GD.Print("未检测到");
			}
		}
    }

}
