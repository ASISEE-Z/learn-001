using Godot;
using System;

public partial class InputTest : Node
{
	public override void _Ready()
	{
		//鼠标设置：显示，隐藏，限制在游戏窗口
		// Input.MouseMode = Input.MouseModeEnum.Hidden; 
			//Hidden：隐藏；Visible：显示：Confined：限制鼠标在窗口内；ConfinedHidden：限制并隐藏鼠标在窗口内

	}

	public override void _Process(double delta)
	{
		//是否按下键盘上的B键
		if (Input.IsKeyPressed(Key.B))
			GD.Print("按下了B键");
		
		//按下虚拟按键
		if (Input.IsActionJustPressed("跳跃"))
			GD.Print("按下跳跃");
		if(Input.IsActionPressed("跳跃"))
			GD.Print("跳跃中");
		if (Input.IsActionJustReleased("跳跃"))
			GD.Print("结束跳跃");

		//获取按键力度
		// float s = Input.GetActionStrength("跳跃");
		// GD.Print(s);

		//获取一个x轴，水平轴
		// float horizontal = Input.GetAxis("左","右");
		// GD.Print(horizontal);

		//获取上下左右组成的一个向量
		Vector2 dir = Input.GetVector("左","右","上","下");
		GD.Print(dir);
	}

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
		//如果是键盘事件
		if(@event is InputEventKey)
		{
			//转成键盘事件
			var key = @event as InputEventKey;
			//判断当前是否按下的是V键
			if(key.Keycode == Key.V)
			{
				//判断当前是否是持续按压
				if (key.IsEcho())
				{
					GD.Print("持续长按V");
				}
				//判断当前是否是按下瞬间
				else if (key.IsPressed())
				{
					GD.Print("按下V");
				}
				//判断当前是否是按键抬起瞬间
				else if (key.IsReleased())
				{
					GD.Print("抬起V");
				}
			}
		}
		//如果是鼠标事件
		if(@event is InputEventMouse)
		{
			//转成鼠标事件
			var mouse = @event as InputEventMouse;
			if (mouse.IsPressed())
			{
				//打印鼠标位置
				GD.Print(mouse.Position);
				//打印鼠标按键
				GD.Print(mouse.ButtonMask);
			}
		}
    }

}
