# RFIDapp

rfid app is a desktop application that build in a .net fromework using C# programming language. it uses Octian SDK 6.0.0 . It actualy build for Impinj R700 RFID reader. The appliction allows users to view EPC (Electronic Prodect Code) and make an Alarm.
---
## Features
The appliction gives four Forms:
1. Index form : this is a landing page. it has a menuStrip to go to the next form.
2. ReaderConnect form : this form is used to connect to the Impinj R700 RFID reader. it has a button to connect and disconnect the reader. it also has a textBox to enter the reader IP address or hostname.
3. EPCTable form : this form is used to view the EPCs that are read by the reader. it has a DataGridView to display the EPCs and a button to clear the table.
4. buzzer form : this form is used to make an alarm. it has a button to start and stop the alarm.
---
## Tech Stack
	- ** Language : ** C#
	- ** Framework : ** .NET Framework 10.0
	- ** SDK : ** Octian SDK 6.0.0
	- ** IDE : ** Visual Studio 2026 community edition
---	
## prerequisites
Make sure you have the following installed on your machine:

1. [Visual Studio 2026 community edition](https://visualstudio.microsoft.com/vs/community/)
1. [.NET Framework 10.0](https://dotnet.microsoft.com/download)
1. [Octian SDK 6.0.0](https://www.impinj.com/developers/software/octane-sdk)
---
## installation
Follow these steps to run the project locally:
1. Clone the repository:
   ```bash
   git clone [https://github.com/MUHAMMED-AMEEN-01/RFIDapp.git](https://github.com/MUHAMMED-AMEEN-01/RFIDapp.git)
   ```
1. Open the solution:
	- double click on the `RFIDapp.sln` file to open the solution in Visual Studio.
1. Run the application:
	- Press `F5` or click on the `Start` button in Visual Studio to run the application.

---
Project structure:
```
RFIDapp/
|-- dependencies/	## Contains the Octian SDK 6.0.0 and other dependencies required for the project.
|-- Form1.cs		## The Wellcome form of the application.
|-- ReaderConnect.cs	## The form to connect to the Impinj R700 RFID reader.
|-- EPCTable.cs		## The form to view the EPCs that are read by the reader.
|-- buzzer.cs		## The form to make an alarm.
|--ipPortValid.cs	## The class to validate the IP address and port number.
|-- Program.cs		## The main entry point of the application.
```

---	
## What I learned
- how to use SDK's. 
- How to use Octian SDK 6.0.0 to connect to the Impinj R700 RFID reader and read EPCs.
- how is working real life projects.
 
 ---
 ## Author
 - Muhammed Ameen
	- Github: [MUHAMMED-AMEEN-01](https://github.com/MUHAMMED-AMEEN-01)
	- Linkedin: [Muhammed Ameen](https://www.linkedin.com/in/ameen-thaikadan/)
