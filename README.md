# BevNet Challenge

## Requirements

  - .Net Core 6
  - Reactjs 18.2.0
  - Visual Studio 2022

## Documentation Location

  - Analysis: documention\BevNet Challenge - Analysis.docx
  - Mockup: documention\BevNet Challenge - mockup design

## Installation

### Runing WEB APP

The location of the web app is src\bevnet_challenge.webapp

Install dependencies:

```bash
npm i
```

Run the server:

```bash
npm start
```

### Runing API

The location of the API solution is src\bevnet_challenge.api

 - Open solution with Visual Studio 2022.
 - Set project bevnet_challenge.api as startup project if it isn't already configured.
 - Build and Run project.

### Configuring API Url in WEB APP

The api URL must be configure if different of http://localhost:5222.

To configure go to the file src\bevnet_challenge.webapp\\.env.development and change the url.