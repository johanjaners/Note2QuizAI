# Note2QuizAI
> Full-stack AI application with independent AWS deployment (Amplify, Elastic Beanstalk, CloudFront)

AI-powered quiz generator that converts uploaded notes into quiz questions using Azure AI Vision (OCR) and Azure OpenAI.

## Live Demo
Frontend: https://main.d2tidw0fafhzdw.amplifyapp.com

## Overview
Note2QuizAI allows users to upload an image of their notes and automatically generate quiz questions.

The system extracts text from the uploaded image using Azure AI Vision and sends the extracted text to Azure OpenAI to generate structured quiz questions. The backend is built with ASP.NET Core Web API and the frontend with React and TypeScript.

## My Contributions
- Deployed full-stack application to AWS (Amplify, Elastic Beanstalk, CloudFront)
- Configured HTTPS backend access via CloudFront
- Diagnosed and resolved CORS issues between frontend and backend
- Managed environment variables and production configuration
- Implemented AI-powered quiz generation service using Azure OpenAI
- Implemented quiz submission and scoring logic
- Built REST API endpoints using a service-layer architecture
- Added validation in the service flow for reliable quiz generation and submission handling
- Implemented global error handling middleware for consistent API responses
- Implemented unit tests for backend services (OpenAIService integration and quiz generation logic) using xUnit and Moq
- Followed clean dependency flow: Controller → Service → Repository / AI integrations

## Tech Stack

Backend  
- ASP.NET Core Web API  
- Entity Framework Core  
- PostgreSQL  

Frontend  
- React  
- TypeScript  

AI  
- Azure OpenAI  
- Azure AI Vision  

Cloud / DevOps  
- AWS Amplify  
- AWS Elastic Beanstalk  
- AWS CloudFront  

Testing  
- xUnit  
- Moq

## Deployment (AWS)

Deployed and configured independently in production.

Frontend  
- AWS Amplify (React app hosting)  
- Automatic CI/CD from GitHub  

Backend  
- AWS Elastic Beanstalk (ASP.NET Core API)  

Networking / Security  
- AWS CloudFront used as HTTPS proxy for backend  
- CORS configured for Amplify frontend domain  

Infrastructure Notes  
- Environment variables configured in Amplify and Elastic Beanstalk  
- Resolved production issues: CORS, API routing, environment config  

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
