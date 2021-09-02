﻿# Time2Rest

## English Version:

Please go to [English README]()

## 软件功能

Time2Rest 可以帮助您保护双眼！每当您使用电脑超过30分钟（可以自行设置），屏幕将会浮现出透明提示，告知您当前时间与使用电脑的时间。

TODO Vignette Here

当界面出现时，你可以选择休息至少20秒（也可以设置）。完事了晃晃鼠标或者敲敲键盘界面就没了！

如果不管他继续操作电脑，程序将会在1分钟后再次提醒。（还是可以设置）

您也可以随时主动休息来重置30分钟定时器。停止鼠标、键盘操作5分钟也可以达到同样的效果。

在您使用全屏应用时，提示将不会显示。当然，这也可以在设置里禁用！没有问题！

## 自定义

Time2Rest 支持自定义界面！真牛逼！

您可以自行选择字体颜色、背景颜色。单色背景太单调了？没问题！您还可以自定图片，就像这样：

TODO Vignette Here

## 这是怎么实现的

Time2Rest 会实时监控您的键盘、鼠标活动来判断您是否在使用电脑。

放心！Time2Rest **不会** 以任何方式记录或上传您的操作记录！您可以随时检查此部分源代码：

* [DefaultHook.cs](https://github.com/SDchao/Time2Rest/blob/main/Time2Rest/WinInteractors/DefaultHook.cs)
* [AlerForm.cs](https://github.com/SDchao/Time2Rest/blob/main/Time2Rest/AlertForm.cs) 153行

## 关于我

还是不大明白怎么弄？这里有个视频可以给你参考啊！

如果喜欢的话，欢迎在 Github 上 follow 我。

当然，你也可以在 Bilibili 上关注我！

[我的Bilibili首页](https://space.bilibili.com/12263994)