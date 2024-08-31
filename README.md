# Basic MVC Application Without Framework

This repository contains a simple MVC (Model-View-Controller) application built without using a traditional framework. Instead, it uses minimal code with Microsoft.AspNetCore.Mvc.Formatters to handle HTTP requests and render HTML content directly.

## Features

- **Custom Routing:** Basic routing is implemented to handle GET and POST requests.
- **HTML Rendering:** Renders HTML content directly from the code, allowing for the creation of simple web pages.
- **Login Form:** A basic login form is implemented to demonstrate form handling and POST requests.
- **Simple Authentication:** The application checks a hardcoded username and password and responds with a success or failure message.

## Technology Stack

- **Backend:** .NET with minimal usage of ASP.NET Core features
- **HTML Rendering:** Manual HTML rendering in response to HTTP requests
- **Routing:** Custom route handling within the application

## Code Overview

### `app.MapGet("/")`
This route handles the root URL (`/`) and serves a simple HTML page with a login form. The form submits a POST request to the `/login` endpoint.

### `app.Map("/Login")`
This route handles the `/Login` POST request. It checks the provided username and password:
- **Success:** Renders a welcome message if the credentials match.
- **Failure:** Returns to the login form with an error message.

### `WriteHtml(HttpContext context, string html)`
This method is used to set the content type to HTML and write the HTML response to the HTTP context.

## Setup Instructions

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed

### Running the Application

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/manojtharindu11/Basic-MVC-Application-Without-Framework.git
   cd Basic-MVC-Application-Without-Framework
   ```

2. **Build and Run the Application:**

   ```bash
   dotnet run
   ```


