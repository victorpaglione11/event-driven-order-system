# Distributed Order System

A scalable and modular Order Management System built with **.NET 8**, following **Clean Architecture** principles and designed to evolve into a **distributed, event-driven system**.

---

## Overview

This project simulates a real-world order processing system, focusing on:

* Clean Architecture
* Separation of concerns
* Scalability
* Maintainability
* Preparation for microservices and event-driven architecture

---

##  Architecture

The solution is structured into multiple layers:

* **API** → Entry point (HTTP requests)
* **Application** → Use cases and business orchestration
* **Domain** → Core business rules and entities
* **Infrastructure** → External concerns (repositories, integrations)

Additionally:

* **BuildingBlocks.Contracts** → Shared event contracts
* **BuildingBlocks.EventBus** → Event abstraction layer

---

##  Current Features (v1)

* Create Order
* In-memory persistence
* Clean Architecture implementation
* Event publishing abstraction (in-memory)

---

## Tech Stack

* .NET 8
* ASP.NET Core Web API
* Clean Architecture
* Dependency Injection
* In-Memory Data Storage

---

## Next Steps

This project is being actively evolved. Upcoming improvements:

* RabbitMQ integration
* Event-driven communication
* Inventory Service (event consumer)
* Saga Pattern
* Database persistence (EF Core)
* Docker support

---

## Project Goal

This project was built to demonstrate real-world backend architecture skills, including:

* Distributed systems design
* Scalable application structure
* Event-driven patterns (in progress)

---
