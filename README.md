# WebHook Receiver Demo

This free source code can be used to learn the Odyssey WebHook system. Out of the box, this application will log all webhook requests. This could be helpful to you if you're just starting out with the webhook system, and wish to set it up on your web server.

Additionally, you can modify this source code to fulfill your needs, and run this in production.

There are many different coding languages and application platforms that would support the Odyssey WebHook system. This is because Odyssey will initiate a HTTP POST Request to a URL of your choosing. While this demo is written in C# using .NET5, you can also write programs in languages like NodeJS, Python, Java, and many others.

# Target Audience

This information is intended for tech-savvy Odyssey administrators or developers who wish to understand how to use the Odyssey WebHook system.

# Getting Started

This is a .NET Core application that can be developed and hosted on a Windows or Linux system. This application is a simple REST API with a method for accepting a POST request from an Odyssey webhook.

.NET Core (.NET 5) is a completely free, cross-platform tool that can be run on Windows, MacOS, and Linux. In order to use and build this project, you must first install the following free tools.

1. Install [Visual Studio Code](https://code.visualstudio.com/download)
2. Install [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
3. Install the [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
4. Install the [git](https://git-scm.com/downloads) source control tool

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

Now, your browser should open. Navigate to the page `https://localhost:5001/WebHook`, and you should see the text "The WebHook application is functioning.". If you see this text, you know the application is running and functioning properly. When running locally, you can test the WebHook using any tool that supports making POST requests. Our recommended tool is [Postman](https://www.postman.com/downloads/). Postman is a free tool you can use to test API requests.

# How does the Odyssey WebHook System work?

After you define your WebHook URL and your WebHook Token, you can choose tables for webhooks to be fired on. An HTTP POST request is sent to your WebHook URL, and the WebHook Token is sent in an `X-Token` HTTP Header.

To use the webhook, you must have an application listening for a POST request to that URL. Additionally, that application should verify that the `X-Token` is present an correct to prevent unexpected or unauthorized use.

Webhooks can be fired for changes to Master Table data, such as Products. To enable a Product webhook, you would first go into System Configuration and define your WebHook URL and token. Then, you would navigate to the Table List within Odyssey and enable webhooks for Products. After that, when a user changes a Product master record, the webhook will be called. The information that will be sent to your WebHook URL is as follows:

```json
// POST: <your webhook URL>
// X-Token: <your webhook Token>
{
	// The ID of the User that caused this webhook to occur.
	"userID": "",

	// The company in which this webhook occurred.
	"companyID": "",

	// The source of the webhook. This is typically a database table name,
	// may also refer to other sources in Odyssey, such as a production transaction.
	"source": "",

	// The action that was performed to cause this webhook. Example values are:
	// 'ADD' to denote a new record, 'CHANGE' to denote an update, and 'DELETE' to denote record removal.
	"action": "",

	// An array of objects. If applicable, this array contains all the records that existed
	// before the change. For example, if a Product is being updated, this would contain a
	// single object that represents the Product before the change.
	"previousData": [
		{ }
	],

	// An array of objects. If applicable, this array contains all the records that existed
	// after the change. For example, if a Product is being updated, this would contain a
	// single object that represents the Product after the change.
	"Data": [
		{ }
	]
}
```

# Building + Deploying Your Application

This application must be deployed to a web server. You must have a web server configured for this work properly. The setup and configuration of a web server is beyond the scope of this article. If you would like additional information or support on this, please contact B&L Information Systems.

**Note** This application must be deployed to a Web Server that is accessible from Odyssey's App Server. If you are a B&L Cloud Customer and your web server is behind a firewall, you can add B&L's IP Addresses to your allow-lists to enable B&L's cloud to access your API. Please contact B&L's Technology Department for the list of these IP Addresses.

We have included steps for hosting the application in Windows on IIS, but you can also host this application on MacOS or Linux. Consult Microsoft's documentation for steps for those platforms.
## Steps for IIS
1. You must install the [.NET Core Hosting Bundle](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-aspnetcore-6.0.0-preview.7-windows-hosting-bundle-installer).
2. On your webserver, create a folder within the website you are deploying to
3. Create a new application pool in IIS. Use the `No Managed Code` .NET CLR Version
4. Right-click your new folder and 'Convert to Application' - choose the application pool your just created
5. In PowerShell, in your application folder, run `dotnet publish --configuration Release`
6. Copy the contents of `bin\Release\net6.0\publish` to the folder you created on your webserver
7. To test the deploy, navigate to the application in your web browser.
    -  For example, if I created a `WebHookApp` folder on my web server, and
    -  My web server is located at `mycompany.com`, then the URL I would navigate to is
    -  `https://mycompany.com/WebHookApp/WebHook`
    -  If you see the "The WebHook application is functioning." text here, you know you have deployed your application properly.
    -  Now, a POST to `https://mycompany.com/WebHookApp/WebHook` will process whatever code is written in your WebHookController.cs file.

# Writing Your Own Code

Now that you have gotten the project running, building, and you can deploy it, you are now ready to write your own code. You would do this starting in the `WebHookController.cs` file, in the `POST` method.

# About

Please contact B&L Information Systems for additional support.

[support@blinfo.com](support@blinfo.com)  
[B&L Information Systems](https://www.blinfo.com)  
[![B&L Information Systems Logo](Images/blinfo-small.png)](https://www.blinfo.com)  