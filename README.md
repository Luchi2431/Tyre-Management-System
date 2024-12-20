
Tyre Management System – TMS

Project task will cover design and development of simple TMS solution. Purpose of this front-end app should be implemented as Windows Desktop application (C#).
In the project scope are:
-	Data model design
-	Implementation of data model using SQL Server Database
-	TMS front-end application (Windows Desktop/Web/Android) that will address needs of 3 main users: 
o	Production Operator (can add new production entries)
o	Quality Supervisor (has full privileges)
o	Business Unit Leader (read-only)  
-	Database objects like stored procedures, functions, views, roles, users, …
-	Technical specification of the implemented solution (including high level design and description of most important features)
Initial load of master data should be performed using SQL Server Management Studio (SQL Server Express can be used).
TMS front-end application
Application should implement features that are addressing the needs of 3 main stakeholders:
-	Production Operator is a user responsible for registering of produced tyres.
-	Quality Supervisor is user responsible for registering of tyres production. This role can also modify entries created by Production Operator.
-	Business Unit Leader can only view production reports.
Production Operator Requirements
As a Production Operator I would like to be able to register tyres production (tyre code, quantity of tyres produced, operator ID, production date, production shift, machine number). 
As a Production Operator I would like to be able to choose all possible values from predefined drop-down lists.
As a Production Operator I should not be able to modify already submitted production record.
As a Production Operator I would like to be able to see history of my submitted production records.
Quality Supervisor Requirements
As an Quality Supervisor I would like to be able to register tyres sales (tyre name, quantity of tyres sold, unit of measure, price per unit of measure, date of sale, reference production order ID, destination market, purchasing company). 
As an Quality Supervisor I would like to be able to choose all possible values from predefined drop-down lists.
As an Quality Supervisor I should have full control on all production and production records.
As an Quality Supervisor I would like to be able to see history of all submitted records.

Business Unit Leader Requirements
As a Business Unit Leader I would like to be able to view all entries and some basic summary reports:
•	Production by day;
•	Production by shift;	
•	Production by machine;
•	Production by operator
•	Stock balance on given date for each tyre code. 

Additional requirements: 
All actions should be logged (who performed the action and when).

