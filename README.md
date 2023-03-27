# Xs任务管理器
XS.Jobs升级版，支持 .net core,.net 6及以上。
集成了常用日志系统秘配置系统
基于XS.ModuleForCore框架开发，因此你可以在此框架上开发自己的模块管理自己的数据。

任务依赖项目：
-  XS.Core2
- XsWinFormsTools

# 一、简单任务的创建
你要创建一个类，并继承自AJobXs, IJobXs即可，同时工实现基本的接口程序（参考Jobs/TestJob.cs）

# 二、独立任务的自定义任务配置
有时我们希望这个任务的配置可在外部被修改，你可以重写virtual public Dictionary<string, string> InitConfig()来实现：
如在任务类中给任务添加一个配置：
```cs
override public Dictionary<string, string> InitConfig() => new Dictionary<string, string>() {
            { "MuseScorePath",@"D:\Program Files\MuseScore 3\bin\MuseScore3.exe"}
        };
```
这样在任务界面右键这个任务即可通过自定义配置修改这个值。
然后在需要的地方这样获取配置：
```cs
string MuseScorePath = GetCf("MuseScorePath");
```
其中，MuseScorePath是配置的键值。

# 三.任务的全局配置
任务的全局配置主要参考conf下的conf.ini文件
- IsOpen=1 表示软件启动是否开启所有任务
- MaxLastReport=30 表示任务报告最多保留多少条

# 四、开发模块
有时需要通过界面来管理一些任务中用到的数据
你可以通过模块的方式开发，具体请参考XS.ModuleForCore
模块建议存放在Modules目录下，
同时建议与模块相关的Job也存放在模块目录下，
这样删除模块的时候直接删除这个文件夹就可以连同模块一起删除了。


 

