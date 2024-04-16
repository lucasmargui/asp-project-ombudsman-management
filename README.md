<H1>Asp.net - Ombudsman Management </H1>
<p align="left">Development of the project for aptitude testing of an Ombudsman Management system in Asp.NET MVC & Entity Framework.</p>


## Resources Used

  * Visual Studio 2017
  * Asp.NET MVC 4;
  * Entity Framework 4;
  * Code First;
  * SQL Server Management 2014;
  * Single Repositivity Pattern;
  * Bootstrap 3;
  * .NET Framework 4.5;

<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/f83f2a02-074e-4e01-8640-439e5056f988" style="width:100%">
</div>


  ## System usage
 
  #### Profile Create
 
  It is necessary to create a user profile so that manifestations can retrieve information such as name, telephone number, type of profile, etc.

<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/aca620fb-c307-4882-b279-7ad9274db22a" style="width:100%">
</div>



 
  #### Manifestation Create
 
  The profile table has a 1:N relationship with the manifestations, so a user can create as many manifestations as necessary, where each manifestation has 4 types of status and 2 types of sector status



<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/6ec0b83c-323e-4aa7-85ca-5a2e58ff9fb7" style="width:100%">
</div>

 
  ###### Status
   * Answered
   * Pending
   * Deleted
   * Due

  ###### Sector Status
   * Forwarded
   * Not forwarded

#### List of Manifestations

A table with a list of manifestations with their respective Status


<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/7ced223d-4589-483c-b80e-cded05ef32ce" style="width:100%">
</div>

#### Creation of the Manifestation Response
 
  The listener will view the manifestation and will have the option to respond to the listener and attach a file together, optionally being able to forward it to the desired sector
 
  * If the Manifestation has already been responded to, the form will be unavailable.
  * If the Manifestation is responded to, its status will change from Pending to Responded
  * If the Manifestation is forwarded to the sector, its status will change from Not forwarded to Forwarded
  * If the Manifestation is answered or forwarded, it will not be possible to delete it

<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/5bdbfb41-ed24-404e-bb13-013a3f9d8924" style="width:100%">
</div>







 
  ## Entity Framework execution in IDE's: VS 2015/2017:

<details>
   <summary>Click to show content</summary>
  
  When executing the commands:
 
   ```
     Enable-Migrations
   ```
   It is
  
   ```
     Update-Database -Verbose
   ```
  
In the most recent versions of Visual Studio (2015/2017), it is necessary to create a new instance of sql localdb on your computer. Which can be created in the following way:

Step 1: Open cmd and execute the following command:
   ```
   SqlLocalDB.exe create "Local"
   ```
Step 2: Run the instance with the following command:
   ```
   SqlLocalDb.exe start
   ```
  
Step 3: Go to the 'Package Manager Console' and execute the following command:
   ```
   Update-Database -Verbose
   ```

  By following these steps, you will avoid problem/error 50, connecting to SQL Server, an error that prevents the creation of the table via 'Code First' of the Entity Framework.

</details>

 




