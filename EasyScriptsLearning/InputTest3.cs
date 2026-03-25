using Godot;
using System;

public partial class InputTest3 : Node
{
	//跳转场景2  方法2
	//新场景
	[Export]
	public PackedScene newScene;
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		//按下键盘方向键左键
		if (Input.IsActionJustPressed("左"))
		{
			//获取场景树
			SceneTree st = this.GetTree();
			//跳转场景2  方法1
			// st.ChangeSceneToFile("res://game2.tscn");
			//跳转场景2  方法2
			st.ChangeSceneToPacked(newScene);
		}

		//按下键盘方向键右键
		if (Input.IsActionJustPressed("右"))
		{
			//实例化新场景，并返回一个根节点
			Node node = newScene.Instantiate();
			//添加进来
			this.GetTree().CurrentScene.AddChild(node);
		}
	}
}
