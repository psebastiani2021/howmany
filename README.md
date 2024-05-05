**NOTE: The code here is for the console version howmany. A Windows Forms app is being developed (#1).**
## What is howmany?
howmany (or howMany) is a console application that is able to measure a variety of things related to your personal information, text length, and more &mdash; everything with simple C# code.
## Instructions to run
To run howMany in a console, you can use .NET for Visual Studio Code ([you can install the framework here](https://dotnet.microsoft.com/en-us/download)). After finishing the .NET Installation Wizard, enter Visual Studio Code and import the .cs file you'd like to try. Then, click <b>Run</b> > <i>Start Debugging</i>. A dropdown list will appear, and pick the .NET version you installed.

If you don't have or can't install this framework, you can try online C# compilers or interpreters - you can run them by copying the program's code. Here are some links to C# playgrounds:
 - [try.dot.net](https://try.dot.net)
 - [Sololearn](https://https://www.sololearn.com/compiler-playground/csharp)
 - [Dotnetfiddle](https://dotnetfiddle.net/srx9kM) (requires public statements)

### Additional compiling resources
If you can't access none of the three online C# compilers, you can open Microsoft PowerShell (used in Windows) and write a continuation prompt without nothing in the initial. Remember that for every line of code, you should open a new continuation prompt. ([see an example here](https://github.com/psebastiani2021/howmany/blob/main/interop/running.ps1))
```shell
$id = Get-Random
$code = @"
using System;
namespace PowerShell {
   public class Program$id {
	public static void Main(){
	 Console.WriteLine("C# in .ps1");
  }
 }
}
"@

Add-Type -TypeDefinition $code -Language CSharp	
iex "[PowerShell.Program$id]::Main()"
```
This example simply outputs a "Hello World!" in the PowerShell console.
## Contributing
If you found an error in a code, update it, or you would like to share some ideas, feel free to do it through pull requests or issues.
