using Godot;
using System;
using System.IO;

public partial class SaveArchive : Node2D
{

	public override void _Ready()
	{
		// res:// -> D://
		//把不同的系统转换成不同的路径
		string path = ProjectSettings.GlobalizePath("D://1.txt");
		//路径："D:\1.txt"
		//写入
		File.WriteAllText(path, "Test");
		//读取
		string str = File.ReadAllText(path);
		GD.Print(str);
	}


}
