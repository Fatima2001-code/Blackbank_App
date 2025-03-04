# Banking Automation System Project in C# "Blackbank_App"

![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)

Welcome to the **Banking Automation System**, a comprehensive application developed using **C#** and **SQL Server**. This project automates essential banking operations such as managing customer accounts, performing money transfers, and generating daily, monthly, and yearly account statements. The system features an intuitive user interface and a robust database design to ensure efficiency and security.

---

## Table of Contents

1. [Project Overview](#project-overview)
2. [Key Features](#key-features)
3. [Database Structure](#database-structure)
4. [User Interfaces](#user-interfaces)
5. [System Workflow](#system-workflow)
6. [Technologies Used](#technologies-used)
7. [How to Run the Project](#how-to-run-the-project)
8. [Future Enhancements](#future-enhancements)

---

## Project Overview

This project provides complete solutions for managing banking operations through the following core functionalities:

### 1. Employee and Customer Management:
- Secure login for employees and administrators.
- Adding new customers and creating bank accounts for them.
- Managing customer data (names, phone numbers, addresses, email).

### 2. Account Management:
- Opening new accounts and closing existing ones.
- Generating daily, monthly, and yearly account statements.
- Printing reports in PDF format.

### 3. Money Transfers:
- Supporting secure and accurate transfers between bank accounts.
- Using **transactions** to ensure no data loss occurs during transfer failures.

### 4. Professional User Interface:
- A simple and organized UI with 9 main interfaces.
- Smooth navigation between different options.

---

## Key Features

### High Security:
- Secure login system based on usernames and passwords stored in the database.
- Use of **views** to control access to sensitive customer data.

### Automation of Operations:
- Stored procedures for executing operations like login, adding customers, and performing transfers.
- Support for daily, monthly, and yearly reports using advanced SQL queries.

### Ease of Use:
- Simple and well-organized interfaces that allow users to perform operations quickly and without complexity.
- Confirmation and alert messages to guide users during operations.

### Report Printing:
- Ability to print account statements in PDF format for easy sharing with customers.

---

## Database Structure

The database was designed using **SQL Server** to ensure high performance and organization. It includes the following tables:

### Employees Table:
- Contains employee information such as name, phone number, password, and job type.
- **Primary Key:** `Employee_id`
- **Foreign Key:** `branch_id` (links to the Branches table).

### Branches Table:
- Stores information about bank branches, including location and number of employees.
- **Primary Key:** `branch_id`

### Customers Table:
- Contains customer data such as name, address, and email.
- **Primary Key:** `Customer_id`

### Accounts Table:
- Manages customer bank accounts, including account type and balance.
- **Primary Key:** `Account_id`
- **Foreign Key:** `Customer_id` (links to the Customers table).

### Transactions Table:
- Logs all transfers between accounts, including details like date and amount.
- **Primary Key:** `Transaction_id`
- **Foreign Keys:** `Account_id_sender`, `Account_id_receiver`, and `Employee_id`.

---

## User Interfaces

The project includes **9 main interfaces** designed to provide a seamless user experience:

1. **Login Screen:**
   - Secure login page for employees and administrators.

2. **Main Menu:**
   - Central control hub that provides access to all functionalities.

3. **Account Statements:**
   - Interfaces for daily, monthly, and yearly account statements.

4. **Opening and Closing Accounts:**
   - Interfaces for adding new accounts and closing old ones.

5. **Money Transfers:**
   - Interface for entering transfer details between accounts.

---

## System Workflow

### Login:
- User credentials are verified using a stored procedure (`LoggIn`).

### Customer Management:
- Add a new customer using a stored procedure (`InsertNewCustm`) and link them to a bank account.

### Money Transfers:
- Transfers are executed using transactions to ensure security and accuracy.

### Report Printing:
- Daily, monthly, and yearly reports are generated using advanced SQL queries.

---

## Technologies Used

- **Programming Language:** C#
- **Database:** SQL Server
- **User Interface:** Windows Forms
- **Development Tools:** Visual Studio, SQL Server Management Studio

---

## How to Run the Project

1. Download the project from GitHub.
2. Set up the database using the attached SQL file.
3. Open the project in Visual Studio and run it.

---

## Future Enhancements

- Add support for multiple languages.
- Improve the user interface using WPF.
- Add more features such as credit cards and SMS notifications.

---
Add more features such as credit cards and SMS notifications.
Project Link


Thank you for visiting!
If you like the project or have any questions or suggestions, feel free to reach out via Issues on GitHub. We always welcome contributions and improvements! 🚀
