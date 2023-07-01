#!/bin/bash
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
