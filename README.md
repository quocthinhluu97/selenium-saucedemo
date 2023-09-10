# Selenium SauceDemo Automation

This repository contains automation scripts for the SauceDemo website using Selenium and SpecFlow in C#.

## Features

- **Login Feature**: Automates the login process for the SauceDemo website. It includes scenarios for successful login with valid credentials.
  - [Login Feature File](./Features/Login.feature)

- **Shopping Feature**: Automates the shopping process on the SauceDemo website. It includes scenarios for adding items to the cart, proceeding through the checkout process, and completing the purchase.
  - [Shopping Feature File](./Features/Shopping.feature)

## Project Structure

- **Features**: Contains the SpecFlow feature files and their corresponding step definitions.
- **Hooks**: Contains configuration and setup for dependency injection and other pre/post scenario actions.
  - [DI Configuration](./Hooks/DIConfiguration.cs)
  
- **Interactions**: Defines tasks or actions that an actor can perform.
  - [Add To Cart Interaction](./Interactions/AddToCart.cs)
  
- **Pages**: Contains page object models for different pages of the SauceDemo website.
  - [Login Page](./Pages/LoginPage.cs)
  - [Inventory Page](./Pages/InventoryPage.cs)
  - [Cart Page](./Pages/CartPage.cs)
  
- **Steps**: Contains step definitions for the SpecFlow scenarios.
  - [Shopping Step Definitions](./Steps/ShoppingStepDefinition.cs)

## Setup & Execution

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Build the solution.
5. Run the tests using the Test Explorer.

## Screenshots

Screenshots of failed tests can be found in the `screenshots` directory.

## Living doc
Run this command to install SpecFlow.Plus.LivingDoc.CLI
```
dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
```

After that, run this command to generate the file LivingDoc.html, suppose you have run the tests
```
livingdoc.exe test-assembly .\bin\Debug\net6.0\tests.dll -t .\bin\Debug\net6.0\TestExecution.json
```
