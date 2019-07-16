# aspnetcore-jwt-authentication-api

This repository contains a simple example of how to implement JWT (JSON Web Token) in an ASP.NET Core 2.2 API with C#.

###### I'll try to keep this repository with the latest changes, so stay tuned.

## Languages
- [PT-BR](./docs/PT-BR.md)

## Tools and Technologies

To develop the API was used the following tools and technologies:
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- [JWT](https://jwt.io/)
- [CORS](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS)

## Overview

The API only has two endpoints to demonstrate the authenticating.
- ```/users/authenticate``` - public endpoint that accepts HTTP **POST** requests that contains the *username* and the *password* in the body. If the providing information is correct then a JWT token and the user details are returned.
- ```/users``` - secure endpoint that accepts HTTP **GET** requests and return a list of all users if the HTTP Authorization header contains a valid JWT token. If no token is provided or the token is invalid then a **401 Unauthorized** response is returned.

