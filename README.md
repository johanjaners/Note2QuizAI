# Note2QuizAI

AI-powered quiz generator that converts uploaded notes into quiz questions using Azure AI services.

## Live Demo
Frontend: https://blue-smoke-07fa87403.1.azurestaticapps.net

## Overview
Note2QuizAI allows users to upload an image of their notes and automatically generate quiz questions.

The system extracts text from the uploaded image using Azure AI Vision and sends the extracted text to Azure OpenAI to generate structured quiz questions. The backend is built with ASP.NET Core Web API and the frontend with React and TypeScript.

## Architecture Flow
Image Upload  
↓  
Azure AI Vision (OCR)  
↓  
Azure OpenAI (Quiz Generation)  
↓  
QuizService  
↓  
Quiz Session + Questions

## My Contributions
- Implemented AI-powered quiz generation service using Azure OpenAI
- Implemented quiz submission and scoring logic
- Built REST API endpoints using a service-layer architecture
- Added validation in the service flow for reliable quiz generation and submission handling
- Implemented global error handling middleware for consistent API responses
- Implemented unit tests for backend services (OpenAIService integration and quiz generation logic) using xUnit and Moq
- Followed clean dependency flow: Controller → Service → Repository / AI integrations

## Tech Stack

Backend  
ASP.NET Core Web API  
Entity Framework Core  
Azure SQL  

AI Services  
Azure OpenAI  
Azure AI Vision  

Frontend  
React  
TypeScript  

Testing  
xUnit  
Moq
