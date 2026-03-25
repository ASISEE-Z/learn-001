using Godot;
using System;

public partial class Sprite2dTest2 : Sprite2D
{
	[Export]
	public Texture2D newTexture;

	//计时器
	double timer = 0;
	public override void _Ready()
	{
		//加载纹理
		// this.Texture = GD.Load<Texture2D>("res://icon.svg"); //方法1
		this.Texture = newTexture; //方法2
		//中心点是否为左上角
		this.Centered = false;
		//偏移
		this.Offset = new Vector2(0,0);
		//翻转
		this.FlipH = false;
		this.FlipV = false;

		//帧动画切分
		this.Hframes = 2;
		this.Vframes = 2;
		//初始帧
		this.Frame = 0;
	}

	public override void _Process(double delta)
	{
		//计时
		//此方法麻烦
		timer += delta;
		//当超过1秒就切换下一个图像
		if(timer > 1)
		{
			//计时器重置
			timer = 0;
			//获取下一帧
			int index = this.Frame + 1;
			if(index > 3) index = 0;
			//让精灵加载下一帧
			this.Frame = index;
		}
	}
}
