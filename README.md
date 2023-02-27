# onvif-client

#### 介绍

这个项目研究ONVIF协议在各种摄像头设备上的可行性

#### 软件架构

软件架构说明
使用C# WinForm
使用VLC,播放需要VLC的x86dll
使用SOAP方式调用onvif

#### 安装教程
https://www.nuget.org/packages/Onvif/
```
dotnet add package Onvif 
```

#### 使用说明

```
Agent = new OnvifAgent(ipAddress, userName, password)
var channels = Agent.Media.GetChannels();
Agent.Ptz.MoveUp();
Agent.Ptz.Stop();
```

#### 参与贡献

1. Fork 本仓库
2. 新建 Feat_xxx 分支
3. 提交代码
4. 新建 Pull Request

#### 特技
