// Hello World Example
// JNBridge Sales Engineering
// Visual Studio 2019, .NET Core 3.1, Java 8

// Before attempting to run this demo, be sure to see included jnbridgeConfig.json and make path adjustments
// to insure the app can find your systems installed JVM(s) and other system dependent components.
// Demo assumes there is a valid JNBridgePro evaluation license in default location: "C:\\Program Files (x86)\\JNBridge\\JNBridgePro v10.1"

using System;
using helloWorldDemo; 

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from .NET Core!");

            int a = 255;
            int b = 2;

            // Call our Java class.  Note cross-platform intelliSense enabled
            JavaClassMultiply javaClass = new JavaClassMultiply();
            
            // Call a class method on Java side. Note cross-platform code complete enabled
            javaClass.multiply(a, b);

            /* NOTE: The proxies for the Java objects in javaClass are used exactly as the original objects would be used 
                in Java.  Note specifically the following items of interest:
            
            • Proxies for the Java classes have namespaces identical to the package names of the original Java classes.
                Thus, we simply import the namespace java.lang, helloWorldDemo, etc and afterwards can use the names of the Java classes.

            • The.NET class Program’s calls to the JavaClass object will cause messages to be written to the same
                output as the messages logged by the .NET Class.
            
            • When typing in the calls to the Java objects, Visual Studio’s IntelliSense facility will offer to complete the names of method calls 
                in the same way that it would for calls to.NET objects, and will provide information on number and types of parameters.  Cool! */
        }
    }
}

// Further Explanation of Demo
//
// On the Java src side C:\JNBridge Demos\DotNetCore2J_HelloWorld_v10.1\ConsoleApp\java\helloWorldDemo\JavaClassMultiply.java we have:

/* package helloWorldDemo;

public class JavaClassMultiply
{

    public void multiply(int a, int b) 
    {	
        System.out.println("Hello World from Java Multiply!");
        System.out.println(a * b);	
    }

} */

// After the above src is complied to to JavaClassMutiply.class, We use the JNBridge Proxy Generator to build HelloJavaProxy.dll.  
// HelloJavaProxy.dll is next added to the VS Project via Project->Add Reference (Browse to HelloJavaProxy.dll to add to our ConsoleApp).  
// We now have full access to the Java side from .NET Core!
