# Unquoted

A simple project to generate a valid service binary for windows, used when exploiting [unquoted service paths](https://book.hacktricks.xyz/windows-hardening/windows-local-privilege-escalation#unquoted-service-paths).

E.g. if the service is running `c:\program files\ivpn service\ivpn service.exe` and you can drop a binary in `c:\program files\ivpn service\` (or `c:\program files\` but that's rarer) named `ivpn.exe`, then when the service starts it will run your binary rather than the target.

Particularly useful if you **a)** can restart the service yourself, or **b)** have the right to restart the machine when its marked as autostart.

The command it runs is inside [src/Service1.cs]. Change before compiling.

## Building

You can of course build with **Visual Studio Community**, make sure when setting up you install support for the target framework used (here .NET Framework 4.7.2).

If you want a simpler option, install modern **dotnet** (which is just a cli tool) and the **.NET Framework 4.7.2 developer pack**. Then this can be built just with `dotnet build` from the src directory.

- [full (free) Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)
- [modern, simpler, dotnet cli](https://dotnet.microsoft.com/en-us/download)
- [developer pack for .NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net472-developer-pack-offline-installer)