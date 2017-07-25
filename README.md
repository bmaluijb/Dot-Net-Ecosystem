# Dot-Net-Ecosystem

![Pluralsight logo](https://www.pluralsight.com/content/dam/pluralsight/newsroom/brand-assets/logos/pluralsight-logo-vrt-color-2.png)  

Hi! 

Welcome to the GitHub repository for the .NET Ecosystem - the big picture Pluralsight course.
This repository contains the examples for the Pluralsight course: [The .NET Ecosystem: The Big Picture](https://app.pluralsight.com/profile/author/barry-luijbregts).

The solution consists of:

 - FrameworkDependantApp
   - A .NET Core console application that depends on .NET Core to be installed on the machine to run
 - SelfContainedApp
   - A .NET Core console application that is self-contained and does not depend on .NET Core to be installed on the machine to run
 - SimpleXamarinAndroidApp
   - A very simple Xamarin.Android application that shows a single view
 - WindowsSpecific
   - A very simple Windows Forms application, based on the .NET Framework 4.7
   
   

#### Running the samples

In order to run the projects in the solution, you need the following:
 - Visual Studio 2017
 - .NET Core ([Get it here](https://www.microsoft.com/net/download/core))
 - .NET 4.7 for the Windows Forms application (WindowsSpecific project)
   - You could also retarget the WindowsSpecific project to a lower version of the .NET Framework
 - Xamarin Tools for Visual Studio and the Android SDK. 
   - In the Visual Studio Installer, select the **Mobile development with .NET workload**, like in the picture below
   
![Visual Studio Installer](https://azureoverview.blob.core.windows.net/cdn/Visual%20Studio%20Installer.png)
