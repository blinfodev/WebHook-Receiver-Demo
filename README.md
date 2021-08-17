# WebHook Receiver

A free demo application for learning and using the Odyssey WebHook system.

# Target Audience

This information is intended for Odyssey administrators or developers who wish to understand how to use the Odyssey WebHook system.

# Getting Started

This is a .NET Core application that can be hosted on a Windows or Linux server. This application is a simple REST API with only one method for accepting a POST request from an Odyssey webhook.

.NET Core (.NET 5) is a completely free, cross-platform tool that can be run on Windows, MacOS, and Linux. In order to use and build this project, you must first install the following free tools.

1. Install [Visual Studio Code](https://code.visualstudio.com/download)
2. Install [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
3. Install the [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
4. Install [git](https://git-scm.com/downloads)

After install all these tools, download and run this project.

1. Open a PowerShell window in the location where you want this project to exist
2. Run `git clone XXX` to clone this repository and download it to your computer
3. Run `dotnet dev-certs https --trust` to enable you to run the application locally via HTTPS.
    -  Select Yes if you agree to trust the development certificate.
4. Open the `webhook-receiver` directory in Visual Studio Code
```
cd webhook-receiver
code .
```
5. Press CTRL/CMD + F5 in Visual Studio Code to run the project

Now, your browser should open to the page `https://localhost:5001/WebHook`, and you should see the text "The WebHook application is functioning.". If you see this text, you know the application is running and functioning properly. When running locally, you can test the WebHook using any tool that supports making POST requests. Our recommended tool is [Postman](https://www.postman.com/downloads/). Postman is a free tool you can use to test API requests.

# Building + Deploying Your Application

TODO: Write these steps.

This application must be deployed to a web server. You must have a web server configured for this work properly. The setup and configuration of a web server is beyond the scope of this article. If you would like additional information or support on this, please contact B&L Information Systems.

After you have identified your webserver.............................................For example, if my webserver is accessible via webserver.company.com, I would deploy this application to the folder 'WebHookAPI', and the URL to my webhook application would be `https://webserver.company.com/WebHookAPI/WebHook`.

# Writing Your Own Code

Now that you have gotten the project running, building, and you can deploy it, you are now ready to write your own code. You would do this starting in the `WebHookController.cs` file, in the `POST` method.

# About

Please contact B&L Information Systems for additional support.

[support@blinfo.com](support@blinfo.com)  
[B&L Information Systems](https://www.blinfo.com)  
[![B&L Information Systems Logo](Images/blinfo-small.png)](https://www.blinfo.com)  