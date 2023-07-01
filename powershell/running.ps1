#!/bin/bash
$id = get-random
$code = @"
using System;
namespace PowerShell
{
	public class Program$id
	{
		public static void Main(){
			Console.WriteLine();
		}
	}
}
"@

Add-Type -TypeDefinition $code -Language CSharp	
iex "[PowerShell.Program$id]::Main()"
