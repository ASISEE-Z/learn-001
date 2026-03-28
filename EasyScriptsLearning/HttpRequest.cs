using Godot;
using System;
using System.Text;

public partial class HttpRequest : Godot.HttpRequest
{
	
	public override void _Ready()
	{
		//发起get请求
		Error error = this.Request("api地址");
		if(error != Error.Ok)
		{
			GD.Print("请求失败！");
		}
	}
	//请求完成的方法
	public void Request_completed(int res, int code, string[] header, byte[] body)
	{
		//转为json字符串
		string str = Encoding.UTF8.GetString(body);
		GD.Print(str);
	}
	
}
