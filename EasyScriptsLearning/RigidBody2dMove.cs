using Godot;
using System;

public partial class RigidBody2dMove : RigidBody2D
{
	private bool isGround;

	public override void _Ready()
	{
		//锁定旋转
    	this.LockRotation = true;
    	//如果要做碰撞检测
    	this.ContactMonitor = true;
    	this.MaxContactsReported = 1;
	}

	public override void _Process(double delta)
	{
	}

	public override void _PhysicsProcess(double delta)
	{
    	base._PhysicsProcess(delta);
    	//通过获取水平轴控制左右移动
    	float horizontal = Input.GetAxis("左", "右");
    	//速度
   	 	this.LinearVelocity = new Vector2(horizontal * 100, this.LinearVelocity.Y);
    	//如果按了空格，跳跃
    	if(Input.IsActionJustPressed("跳跃") && isGround == true)
		{
        this.LinearVelocity = new Vector2(this.LinearVelocity.X, -300);
    	}
	}

	public void bodyEntered(Node body)
	{
		isGround = true;
	}

	public void bodyExit(Node node)
	{
		isGround = false;
	}
}
