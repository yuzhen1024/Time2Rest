﻿# Time2Rest

## Chinese Version

请前往 [README](https://github.com/SDchao/Time2Rest/blob/main/README.md)

## Download
Please goto Release Page: [CLICK ME](https://github.com/SDchao/Time2Rest/releases/latest)

If you do not need the source code, please download **"Time2Rest_\*\*\*.zip"** in the list.

## Runtime Requirement

Time2Rest can **only run on Windows OS**

This program needs .Net Framework 4.7.2 to run correctly. The runtime has been deployed on Windows 10 October 2018 Update and newer Windows system.

If you have not installed, please click the link below to download.

[Download .Net Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)

You should choose Runtime on this page.

## Software Function

Time2Rest can help you protect your eyes! When you have kept using your computer for over 30 minutes (can be set), transparent reminder, which tells you current time and the time you using the computer, will show up in the screen.

![Reminder](https://github.com/SDchao/Time2Rest/blob/main/Time2Rest/Resources/Demo_Reminder.png)

When the reminder shows, you can choose to rest at least 20 seconds (can be set too). After that, just shake your mouse or type something and it's gone!

If you dismiss the reminder, it will remind you again 1 minute later (also can be set)

You can rest on your own through the menu to reset the 30 minute countdown. Leaving your computer for 5 minutes can achieve that too.

If fullscreen application is running, the reminder will not show up. Of course, it can be adjusted in settings! No problem!

## Customization

Time2Rest can customize the UI! FANTASTIC!

![Settings](https://github.com/SDchao/Time2Rest/blob/main/Time2Rest/Resources/Demo_Settings.png)

You can choose the text color, background color. Single color is too dull? All right! You can set image background, just like that:

![WAIFU HERE](https://github.com/SDchao/Time2Rest/blob/main/Time2Rest/Resources/Demo_Img.png)


## How it works

Time2Rest will monitor your keyboard, mouse and the foreground window's screenshot to determine if you are using your computer.

Relax! Time2Rest **WILL NOT** record or upload and data (including but not limited to your keyboard history, mouse history and screenshots)! You can check that part of source code anytime:

* [DefaultHook.cs](https://github.com/SDchao/Time2Rest/blob/main/Time2Rest/WinInteractors/DefaultHook.cs)
* [AlerForm.cs](https://github.com/SDchao/Time2Rest/blob/main/Time2Rest/AlertForm.cs#L153-L192) Line 153
* [ScreenshotChecker.cs](https://github.com/SDchao/Time2Rest/blob/main/Time2Rest/WinInteractors/ScreenshotChecker.cs)

## About Me

Sorry but if you can understand Chinese, there is a video for instructions:

[Video Link](https://www.bilibili.com/video/BV1rq4y1T7cx)

Please follow me on Github if you like!

Of course, you can subscribe me on Bilibili!

[My Bilibili homepage](https://space.bilibili.com/12263994)