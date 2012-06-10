Wcf Useragent C# Library
=============================================================

A free, open source, C#/.NET Library plugin (Message inspector) for WCF to be able to configur the Useragent HTTP header on WCF Requests.

See [Nuget](https://nuget.org/packages/WcfUserAgent)

In package manager console:
PM> Install-Package WcfUserAgent

##News
 + **June 6, 2012** Initial dump and setup on Nuget
 
##Features
 + Set useragent on WCF calls by configuration (endpoint configuration behaviour)
 
##Details
This is a pretty simplistic library, based on a blog post by Paulo Morgado:
http://msmvps.com/blogs/paulomorgado/archive/2007/04/27/wcf-building-an-http-user-agent-message-inspector.aspx

The idea is that you can just add it to a project via nuget, instead of copy those classes to each project or drag your own library around to each other project.

I will add other dotnet versions on request. Its now only 4.0. 

##Contributing
If you have improvements to my code, by all means let me know.