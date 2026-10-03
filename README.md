# CyberSecureApp

A VB.NET Windows Forms application for managing clients, accounts, cloud services, subscriptions, and cybersecurity incidents stored in Microsoft SQL Server.

## Features

- Central navigation form for opening each management area
- Client add, update, and delete operations through stored procedures
- Account management with client selection and an account-services sub-form
- Service add, update, and delete operations through stored procedures
- Subscription creation using account and service selections
- Cybersecurity incident creation, updating, and resolution
- DataGridView-based record display and selection
- SQL Server views for joined client, account, and service information
- Basic database exception handling with user-facing messages

## Technology

- VB.NET
- Windows Forms
- .NET 10 for Windows
- Microsoft SQL Server / SQL Server Express
- Microsoft.Data.SqlClient 7.0.1

## Assessment results

The supplied grading breakdown confirms **87/90 across the criteria whose scores were provided**. The separate 10-point error-handling score was not included in the supplied breakdown, so no overall grade is claimed here.

| Criterion | Score |
|---|---:|
| Form design and intuitive layout | 8/8 |
| Correct stored-procedure implementation | 10/10 |
| Add, delete, and update buttons | 12/12 |
| Sub-form functionality | 6/8 |
| Sub-form design | 5/5 |
| Stored-procedure integration | 12/12 |
| Buttons connected to the correct procedures | 10/10 |
| Navigation design and layout | 6/6 |
| Logical navigation flow | 8/8 |
| Error-free navigation | 6/6 |
| Code quality and readability | 4/5 |
| Error handling | Score not supplied (maximum 10) |
| **Confirmed subtotal** | **87/90** |

## Repository structure

| Path | Purpose |
|---|---|
| `*.vb`, `*.Designer.vb`, and `*.resx` | Windows Forms source, generated layouts, and resources |
| `CyberSecureApp2.vbproj` | Visual Basic project configuration |
| `CyberSecureApp2.slnx` | Visual Studio solution |
| `database/01_Create_Populate.sql` | Creates and populates the database |
| `database/02_Views_Procedures.sql` | Creates views and application stored procedures |

Build outputs and user-specific Visual Studio files are intentionally excluded.

## Setup

1. Install Microsoft SQL Server or SQL Server Express.
2. Run `database/01_Create_Populate.sql`.
3. Run `database/02_Views_Procedures.sql`.
4. Open `CyberSecureApp2.slnx` in Visual Studio with the .NET 10 Windows desktop workload.
5. Restore NuGet packages and start the application.

By default, the application connects to:

```text
Data Source=localhost\SQLEXPRESS;
Initial Catalog=CyberSecureCloudSolutionsDB;
Integrated Security=True;
TrustServerCertificate=True;
```

To use another SQL Server instance, set the `CYBERSECURE_DB_CONNECTION` environment variable to a complete SQL Server connection string before launching the application.

## Related project

The database design and assessment evidence are documented separately in the [CyberSecure Cloud Solutions Database](https://github.com/Tirth0989/CyberSecure-Cloud-Solutions-Database) repository.

No open-source license is applied because this repository is an academic portfolio submission.
