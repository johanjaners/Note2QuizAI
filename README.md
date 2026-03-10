# Note2QuizAI

AI-powered quiz generator that converts uploaded notes into quiz questions.

## Live Demo
Frontend: https://blue-smoke-07fa87403.1.azurestaticapps.net

## Overview
Note2QuizAI extracts text from uploaded images using Azure AI Vision and generates quiz questions using Azure OpenAI.  
The backend is built with ASP.NET Core Web API and the frontend with React and TypeScript.

## My Contributions
- Implemented AI-powered quiz generation service using Azure OpenAI
- Implemented quiz submission and scoring logic
- Built REST API endpoints using a service-layer architecture
- Implemented global error handling middleware for consistent API error responses
- Followed clean dependency flow: Controller → Service → Repository / AI integrations

## Tech Stack
Backend: ASP.NET Core, Entity Framework  
AI: Azure OpenAI, Azure AI Vision  
Frontend: React, TypeScript  
Database: Azure SQL  
Testing: xUnit, Moq
