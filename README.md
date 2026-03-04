# Velox

Velox is a modern, enterprise-ready web application built on the .NET 10 framework. It utilizes a decoupled architecture, separating the client interface from the backend services to ensure scalability, maintainability, and a clean separation of concerns.

## About the Project

This initiative is developed by a team of four friends and developers who aspire to continuously advance their technical skills. The core vision of Velox is to integrate the most effective and reusable components from the team's previous individual projects into a single, cohesive ecosystem. A primary focus of this collaborative effort is the exploration and practical implementation of Artificial Intelligence (AI) features within a robust software architecture.

## System Architecture

The solution is divided into three primary projects:

* **Velox.Api**: An ASP.NET Core Web API serving as the backend. It handles business logic, data access, and security. This project is configured with Linux Docker support for containerized deployment.
* **Velox.Client**: A Blazor WebAssembly standalone application. It provides a highly interactive, client-side user interface that runs directly in the browser.
* **Velox.Shared**: A common .NET class library containing Shared Data Transfer Objects (DTOs), domain models, and interfaces. Both the API and Client projects reference this library to ensure strict type safety and eliminate code duplication across the network boundary.

## Prerequisites

To build and run this project locally, the following tools are required:

* [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
* [Docker Desktop](https://www.docker.com/products/docker-desktop) (if running via containers)
* JetBrains Rider or Visual Studio (latest version supporting .NET 10)

## Getting Started

### Option 1: Running via Docker Compose (Recommended)

The project includes a `docker-compose.yml` file configured to spin up the backend infrastructure.

1. Open a terminal at the root of the solution.
2. Execute the following command:
   ```bash
   docker-compose up --build -d
