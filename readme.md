

# ST2SAS - Docker Containers : Delice Pizza Application
#### by Cédric Yoganathan and Romain Villeneuve

## Overview

DelicePizza is a multi-container application designed to provide a seamless environment for a pizza delivery service. The application consists of front-end and back-end components, a PostgreSQL database for data storage, and RabbitMQ for message queuing.

## Technical Specifications

- OS: Windows 11
- Docker Desktop: 4.1.1
- Docker Engine: 20.10.11
- Docker Compose: 2.2.3

## **Underlying Steps Executed by Docker Compose**

### 1. User-defined Custom Networks

#### Network Definition:
- A user-defined bridge network named "DelicePizza" is specified in the `networks` section.
- The network uses the bridge driver for container communication.

### 2. Image Building

#### Frontend and Backend Services:
- Docker Compose builds the frontend and backend services using the specified Docker images (`cybonix1/front-delice-pizza:latest` and `cybonix1/back-end-delice-pizza:latest`).

### 3. Container Creation

#### Frontend, Backend, PostgreSQL, and RabbitMQ Containers:
- Docker Compose creates containers for each service using the specified images, container names, port mappings, restart policies, and network connections.

### 4. Volumes

#### PostgreSQL Volume Mapping:
- A volume named `./postgres-data` is mapped to `/var/lib/postgresql/data` in the PostgreSQL container. This allows for persistent data storage.

### 5. Port Mapping

#### Port Mapping for Services:
- Ports are mapped between the host machine and containers for services such as frontend, backend, PostgreSQL, and RabbitMQ.

### 6. Network Connection

#### Network Connection:
- Containers for all services are connected to the user-defined bridge network "DelicePizza."


## Services

### 1. Frontend (front-delice-pizza)

- **Build Context:** front
- **Image:** cybonix1/front-delice-pizza:latest
- **Container Name:** frontend-DelicePizza
- **Ports:** 8080:8080
- **Restart Policy:** Always
- **Network:** DelicePizza

### 2. Backend (back-end-delice-pizza)

- **Build Context:** Back
- **Image:** cybonix1/back-end-delice-pizza:latest
- **Container Name:** backend-DelicePizza
- **Ports:** 5165:80
- **Restart Policy:** Always
- **Network:** DelicePizza

### 3. PostgreSQL Database (postgres-db-delice-pizza)

- **Image:** postgres:alpine3.18
- **Container Name:** postgres-db-DelicePizza
- **Restart Policy:** Always
- **Environment Variables:**
    - POSTGRES_USER: postgres
    - POSTGRES_PASSWORD: admin
    - POSTGRES_DB: PostgreSQL15
- **Ports:** 5432:5432
- **Network:** DelicePizza
- **Volumes:** ./postgres-data:/var/lib/postgresql/data

### 4. RabbitMQ (rabbitmq-delice-pizza)

- **Image:** rabbitmq:management
- **Container Name:** rabbitmq-DelicePizza
- **Environment Variables:**
    - RABBITMQ_DEFAULT_USER=guest
    - RABBITMQ_DEFAULT_PASS=guest
- **Ports:**
    - 5672:5672 (AMQP)
    - 15672:15672 (Management Console)
- **Network:** DelicePizza

## Networks

- **Name:** DelicePizza

## How to Run

```bash
docker-compose up -d
```

## How to Stop

```bash
docker-compose down
```

## How to Access the Application

- **Frontend:** http://localhost:8080


