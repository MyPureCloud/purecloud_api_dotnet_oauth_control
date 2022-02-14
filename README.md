# PureCloud API - .NET OAuth Control

[![NuGet Badge](https://buildstats.info/nuget/PureCloudOAuthControl)](https://www.nuget.org/packages/PureCloudOAuthControl/)

## Overview

This project produces a .NET library that provides a simple way to execute an OAuth 2 flow in a C# application. This is accomplished by providing the OAuthWebBrowser class, which inherits from the [WebBrowser](https://msdn.microsoft.com/en-us/library/2te2y1x6.aspx) winforms control. When invoked, the control will navigate to the appropriate login URL, allow the user to authenticate securely, and will raise events for authentication and error events.

## Install Using nuget

```
install-package PureCloudOAuthControl
```

# Getting Started

## Example Applications

This solution contains three examples projects. The _Oauth Example_ project uses the OAuthWebBrowser control in a winforms app. The _OAuth Example WPF_ project uses the OAuthWebBrowser control in a WPF by making use of the [WindowsFormsHost](https://msdn.microsoft.com/en-us/library/system.windows.forms.integration.windowsformshost.aspx) class. The _OAuth Standalone Form Example_ project uses the OAuthWebBrowserForm winform in a console application.

## Using OAuthWebBrowser

### Referencing the Library

If you've used the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to install the package, there are no additional steps. 

If you're building from source or otherwise not using nuget, reference your version of ININ.PureCloud.OAuthControl.dll in your project and add a reference or install the package for [RestSharp](http://www.nuget.org/packages/RestSharp/).

### Using the Library

#### Creating an Browser Instance

To create just the web browser control, use UI tools to add the control or create it in code (must create in code for WPF):

```csharp
var browser = new OAuthWebBrowser();
```

#### Setting the Environment

The browser control will use the mypurecloud.com environment by default. If the user should log in to an org in another region, simply specify that region in the browser's `Environment` property prior to initiating the login flow. There is no validation on the values, but should be one of "mypurecloud.com", "mypurecloud.com.au", "mypurecloud.ie", or "mypurecloud.jp" as of the time of this writing. If additional regions are added, simply use the new URL in the same partial format.

```csharp
var browser = new OAuthWebBrowser();
browser.Environment = "mypurecloud.ie";
```

#### Using the Standalone Form

The easiest method of use for this control is to use the OAuthWebBrowserForm form to handle authentication with just a few lines of code. This example will instiantiate and configure the form, initiate the login process, and log the result:

```csharp
// Create form
var form = new OAuthWebBrowserForm();

// Set settings
form.oAuthWebBrowser1.ClientId = "babbc081-0761-4f16-8f56-071aa402ebcb";
form.oAuthWebBrowser1.RedirectUriIsFake = true;
form.oAuthWebBrowser1.RedirectUri = "http://localhost:8080";

// Open it
var result = form.ShowDialog();

Console.WriteLine($"Result: {result}");
Console.WriteLine($"AccessToken: {form.oAuthWebBrowser1.AccessToken}");
```

*Notes*

* The form has overridden the methods `Show()`, `Show(IWin32Window)`, `ShowDialog()`, and `ShowDialog(IWin32Window)` to validate the configuration (client ID and redirect URI properties must be set), begin the implicit grant flow, and set the dialog result based on if there is an access token (`return string.IsNullOrEmpty(oAuthWebBrowser1.AccessToken) ? DialogResult.Cancel : DialogResult.OK;`).
* The form does not proxy properties or events from the browser. The browser object can be directly accessed via `OAuthWebBrowserForm.oAuthWebBrowser1`.
* When using this in a console application, remember that the application must be decorated with [[STAThread]](https://msdn.microsoft.com/en-us/library/system.stathreadattribute(v=vs.110).aspx) to interact with UI components.
* The Show and ShowDialog methods will log all exceptions to the console and rethrow them. Handle the custom exception type `OAuthSettingsValidationException` to identify validation errors.

### Setup

The following properties should be configured before invoking an OAuth flow:

* ```RedirectUri``` - The redirect URI configured for the oauth client
* ```ClientId``` - The Client ID (aka Application ID) of the OAuth client
* ```RedirectUriIsFake``` - If set to ```true```, the control will hide itself (visible=false) upon successfully retrieving an auth token.  This exists due to the non-web nature of a .NET app -- there is not necessarially a webpage to redirect to. If a fake URL is used in the configuration (e.g. http://notarealserver/), setting this property to true prevents the user from seeing errors in the browser related to being unable to resolve the address. This setting defaults to ```false```.
* ```ForceLoginPrompt``` - If set to ```true```, the user will be prompted to enter credentials at the Genesys Cloud login screen and any remembered sessions (auth cookies) will be ignored.
* ```State``` - An abitrary string used to associate a login request with a login response.
* ```Org``` - The organization name that would normally be used when logging in.
* ```Provider``` - The Authentication provider to log in with.

***Note:*** Org must be set if Provider is set and likewise, Provider must be set if Org is set.

The following events may be useful for the consuming application:

* ```ExceptionEncountered``` - Raised when an exception is encountered during an OAuth flow
* ```Authenticated``` - Raised when an OAuth flow has completed and the auth token has been retrieved

In addition to the properties and events defined above, the properties, events, and methods of the underlying WebBrowser control are available.

### Starting the Implicit Grant Flow

To start the implicit grant flow, invoke the ```BeginImplicitGrant()``` method. The ```Authenticated``` event will be raised when the flow has completed.

### Closing the Control

When finished with the control, simply dispose of it by calling its ```Dispose()``` method or by letting .NET garbage collect it.
