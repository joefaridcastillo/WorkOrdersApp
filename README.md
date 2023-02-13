# Work Orders App

A web application built with Microsoft .NET to manage work orders, including a web API and a database to store the data. 
The home page displays all open work orders with all their respective fields.
A drop-down list is provided to view work orders by status, allowing for an easy and seamless update of the displayed work orders without the need to reload the entire page.
The application also includes a button to add a new work order, which opens a modal dialog to enter information such as email, contact name, contact number, problem description, and technician. 
The DateReceived field is automatically set to the date and time the work order is submitted, ensuring accurate tracking and organization of work orders.
The web API allows for easy access to the data stored in the database, making it possible to retrieve and manipulate work order information as needed.

## Features

1.Work Order Management: View all open work orders with all their respective fields, including email, contact name, contact number, problem description, technician, and date received.
2.Status Filter: Easily filter work orders by status using a drop-down list. The displayed work orders are updated without the need to reload the entire page.
3.New Work Order Creation: Add a new work order with a modal dialog that allows the user to enter information such as email, contact name, contact number, problem description, and technician. The DateReceived field is automatically set to the date and time the work order is submitted.
4.Web API Access: The application includes a web API that provides easy access to the data stored in the database, making it possible to retrieve and manipulate work order information as needed.
5.Database: All work order information is stored in a database, ensuring that data is easily accessible and well-organized.
6.Responsive Design: The application is designed to be mobile-friendly, ensuring that work orders can be managed from anywhere, on any device.
7.Easy Navigation: A simple, intuitive interface makes it easy for users to manage their work orders and access the information they need.


## Requirements

Operating system: Windows 7 or later
Software: Visual Studio 2019 or later, .NET core 6.0, SQL server 2019 or later
Library and Frameworks: Entity Framework, bootstrap 4.5 or later

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

1. Clone the repository
https://github.com/joefaridcastillo/WorkOrdersApp.git

2. Navigate to the project directory

cd project-name

3. Restore dependencies

dotnet restore

4. Run the project

dotnet run 



