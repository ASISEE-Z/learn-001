using Godot;
using Godot.Collections;
using System;

public partial class JsonTest : Node2D
{

	public override void _Ready()
	{
		//创建json
		Dictionary user1 = new Dictionary();
		Dictionary user2 = new Dictionary();
		user1["name"] = "张三";
		user1["HP"] = 100;
		user2["name"] = "李四";
		user2["HP"] = 90;
		//放到数组中
		var users = new Godot.Collections.Array{user1,user2};
		//创建最外层
		Dictionary dic = new Dictionary();
		dic["user"] = users;
		//转为json
		string json = Json.Stringify(dic);
		GD.Print(json);

		//解析，就是把json字符串转回成字典
		Dictionary newDic = Json.ParseString(json).AsGodotDictionary();
		var array = newDic["name"];
	}

	
}
