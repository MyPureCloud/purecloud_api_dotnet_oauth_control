# PureCloud API - .NET OAuth Control

## Overview

This project produces a .NET library that provides a simple way to execute an OAuth 2 flow in a C# application. This is accomplished by providing the OAuthWebBrowser class, which inherits from the [WebBrowser](https://msdn.microsoft.com/en-us/library/2te2y1x6.aspx) winforms control. When invoked, the control will navigate to the appropriate login URL, allow the user to authenticate securely, and will raise events for authentication and error events.

## Install Using nuget

```
install-package PureCloudOAuthControl
```

# Getting Started

## Example Applications

This solution contains two examples projects. The _Oauth Example_ project uses the OAuthWebBrowser control in a winforms app. The _OAuth Example WPF_ project uses the OAuthWebBrowser control in a WPF by making use of the [WindowsFormsHost](https://msdn.microsoft.com/en-us/library/system.windows.forms.integration.windowsformshost.aspx) class.

## Using OAuthWebBrowser

### Referencing the Library

If you've used the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to install the package, there are no additional steps. 

If you're building from source or otherwise not using nuget, reference your version of ININ.PureCloud.OAuthControl.dll in your project and add a reference or install the package for [RestSharp](http://www.nuget.org/packages/RestSharp/).

### Creating an Instance

Use UI tools to add the control or create it in code (must create in code for WPF):

```csharp
var browser = new OAuthWebBrowser();
```

### Setup

The following properties should be configured before invoking an OAuth flow:

* ```RedirectUri``` - The redirect URI configured for the oauth client
* ```ClientId``` - The Client ID (aka Application ID) of the OAuth client
* ```RedirectUriIsFake``` - If set to ```true```, the control will hide itself (visible=false) upon successfully retrieving an auth token.  This exists due to the non-web nature of a .NET app -- there is not necessarially a webpage to redirect to. If a fake URL is used in the configuration (e.g. http://notarealserver/), setting this property to true prevents the user from seeing errors in the browser related to being unable to resolve the address. This setting defaults to ```false```.

The following events may be useful for the consuming application:

* ```ExceptionEncountered``` - Raised when an exception is encountered during an OAuth flow
* ```Authenticated``` - Raised when an OAuth flow has completed and the auth token has been retrieved

In addition to the properties and events defined above, the properties, events, and methods of the underlying WebBrowser control are available.

### Starting the Implicit Grant Flow

To start the implicit grant flow, invoke the ```BeginImplicitGrant()``` method. The ```Authorized``` event will be raised when the flow has completed.

### Closing the Control

When finished with the control, simply dispose of it by calling its ```Dispose()``` method or by letting .NET garbage collect it.
