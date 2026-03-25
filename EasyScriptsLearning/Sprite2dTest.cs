using Godot;
using System;

public partial class Sprite2dTest : Sprite2D
{
	public override void _Ready()
	{
		//CanvasItem常用属性
		//是否显示
		// this.Visible = true;

		//渲染顺序
		// this.ZIndex = 10;
		// this.ZAsRelative = false;

		//Node2D常用属性
		//位置
		// this.Position = new Vector2(500,300);
		//旋转
		// this.Rotation = 0.5f;
		// this.RotationDegrees = 30;
		//缩放
		// this.Scale = new Vector2(2,2);
		//倾斜
		// this.Skew = 30;

	}

	public override void _Process(double delta)
	{
		//获取鼠标位置
		// var pos = GetGlobalMousePosition();
		// GD.Print(pos);

		//看向某个点
		// LookAt(pos);
	}
}
