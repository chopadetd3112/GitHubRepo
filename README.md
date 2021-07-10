# GitHubRepo
GitHubRepo


Q2 AzureWebsites Automation Project :


How to run the test case: Question 2:
Pre-req: install .NET framwork 4.6.1 
click on https://github.com/chopadetd3112/GitHubRepo -> click on code button -> Download ZIP -> GitHubRepo-main gets downloaded in yourdownloads folder
Unzip this folder and Open visual studio -> restore Nuget packages -> click clean solution -> build solution

In visual studio and from Test menuItem -> select Windows -> Test Explorer. From Test Explorer: Right Click on SignUpForFlightSearchScenario() and click on Run Tests.

OR

After unzipping GitHubRepo-main folder, it will contain Debug.zip. Unzip the same.

If your machine has TestAgent installed. Open command prompt and run as administrator and cd to the corresponding path: C:\Program Files (x86)\Microsoft Visual Studio\2019\TestAgent\Common7\IDE\CommonExtensions\Microsoft\TestWindow
OR C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\

Now replace project path to your corresponding project's bin->debug path and click enter: vstest.console.exe {YourDebugLocation}\Debug\AzureTests.dll /tests:SignUpForFlightSearchScenario /logger:trx

Example: vstest.console.exe C:\Users\crh5415\source\repos\AzureWebsite.UITests\AzureTests\bin\Debug\AzureTests.dll /tests:SignUpForFlightSearchScenario /logger:trx

and you will see the test case running.
