
# 🚗 UsedCarApp - Object-Oriented Used Car Sales System

The **UsedCarApp** is a system developed based on a given scenario to manage used car sales efficiently. The project involves designing and implementing an object-oriented infrastructure while adhering to **SOLID principles** and incorporating the **Singleton design pattern**.

---

## 📄 Project Overview

### Key Objectives:
- Design a UML diagram representing the system's object-oriented structure.
- Showcase objects, their relationships, and behaviors in the system.
- Implement the system in C# by following:
  - **SOLID principles**: Ensures scalable and maintainable code.
  - **Singleton design pattern**: Manages shared resources efficiently.

---

## 🧩 Features

- **UML Design**:
  - Comprehensive UML diagram illustrating objects, relationships, and behaviors.
  - Includes prototype methods to showcase functionality.
  
- **Object-Oriented Programming (OOP)**:
  - Encapsulation, inheritance, and polymorphism.
  - Clear separation of responsibilities using SOLID principles.

- **Singleton Design Pattern**:
  - Ensures a single instance of shared resources, such as a database connection.

---

## 🛠️ System Design

### UML Diagram
The system design includes the following components:

1. **Car Class**:
   - Properties: `CarId`, `Brand`, `Model`, `Year`, `Price`, `IsAvailable`
   - Methods: `SellCar()`, `GetCarDetails()`

2. **Customer Class**:
   - Properties: `CustomerId`, `Name`, `Phone`
   - Methods: `PurchaseCar(Car car)`

3. **SalesManager Class**:
   - Properties: `ManagerId`, `Name`
   - Methods: `ManageInventory()`, `ViewSalesReport()`

4. **Inventory Class**:
   - Properties: `Cars` (List<Car>)
   - Methods: `AddCar(Car car)`, `RemoveCar(int carId)`, `GetAvailableCars()`

5. **SalesRecord Class**:
   - Properties: `SaleId`, `Car`, `Customer`, `SaleDate`, `Price`
   - Methods: `GenerateInvoice()`

6. **Singleton DatabaseManager**:
   - Properties: `Instance` (static)
   - Methods: `Connect()`, `Disconnect()`

---

## 🚀 How to Run the Application

### 1. Clone the Repository
```bash
git clone https://github.com/Sarizeybekk/UsedCarApp_Solid_Singleton.git
cd UsedCarApp_Solid_Singleton
