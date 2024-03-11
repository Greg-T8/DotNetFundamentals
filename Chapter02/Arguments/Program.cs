//WriteLine($"There are {args.Length} arguments.");
//foreach (string arg in args)
//    WriteLine(arg);


if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // stop running
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true);

if (OperatingSystem.IsWindows())
{
    // Execute code that only works in Windows
} 
else if (OperatingSystem.IsWindowsVersionAtLeast(major:10))
{
    // Execute code that only works on Windows 10 or later
} else if (OperatingSystem.IsIOSVersionAtLeast(major:14, minor:5))
{
   // Execute code that only works on iOS 14.5 or later 
} else if (OperatingSystem.IsBrowser())
{
    // Execute code that only works in the browser with Blazor
}

