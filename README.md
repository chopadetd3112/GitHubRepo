# GitHubRepo
GitHubRepo


Q2 AzureWebsites Automation Project + 1 excel containing Q1 and Q3 answer

How to run the test case: Question 2:

Pre-req: install .NET framwork 4.6.1 
Get the Git project AzureTests.
Open visual studio and from Test menuItem -> select Windows -> Test Explorer. Build the project. From Test Explorer: Right Click on SignUpForFlightSearchScenario() and click on Run Tests.

OR

If your machine has TestAgent installed. Open command prompt and run as administrator and cd to the corresponding path: C:\Program Files (x86)\Microsoft Visual Studio\2019\TestAgent\Common7\IDE\CommonExtensions\Microsoft\TestWindow
OR C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\

Now replace project path to your corresponding project's bin->debug path and click enter: vstest.console.exe {YourProjectLocation}\Debug\AzureTests.dll /tests:SignUpForFlightSearchScenario /logger:trx

Example: vstest.console.exe C:\Users\crh5415\source\repos\AzureWebsite.UITests\AzureTests\bin\Debug\AzureTests.dll /tests:SignUpForFlightSearchScenario /logger:trx

and you will see the test case running.
