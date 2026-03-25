using Godot;
using System;

//生命周期方法：脚本从 生效 -> 销毁失效 的过程中，会自动调用的几个重要方法
public partial class MySprite : Sprite2D
{
	//倒计时，设定一个计时器
	float timer = 5;

	//节点添加到节点数中的时候调用
    public override void _EnterTree()
    {
        base._EnterTree();
		GD.Print("enterTree");
    }

	//节点加载完成，这里初始化
	public override void _Ready()
	{
		GD.Print("ready");		
	}

	//帧
	public override void _Process(double delta)
	{
		//游戏逻辑

		//计时器开始倒计时
		timer -= (float)delta;
		//判断有没有到时间
		if(timer <= 0)
		{
			timer = 100;
			//销毁节点
			this.QueueFree();
		}
	}

	//每次物理系统计算，会调用一次
    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
    }

	//节点离开节点树，销毁
    public override void _ExitTree()
    {
        base._ExitTree();
		GD.Print("exitTree");
    }

}
