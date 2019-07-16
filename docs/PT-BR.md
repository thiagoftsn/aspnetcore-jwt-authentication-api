# aspnetcore-jwt-authentication-api

Este repositório existe um simples exemplo de como implementar JWT (JSON Web Token) em uma API do ASP.NET Core 2.2 com C#.

## Ferramentas e Tecnologias

Para o desenvolvimento da API foi utilizado somente as seguintes ferramentas e tecnologias:
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- [JWT](https://jwt.io/)

## Visão Geral

A API tem apenas dois endpoints para demonstrar a autenticação.
- ```/users/authenticate``` - endpoint público que aceita requisições HTTP **POST** que contenham o *username* e o *password* no corpo da requisição. Caso as informações estejam corretas um token de autenticação e os detalhes do usuário será retornado.
- ```/users``` - endpoint seguro que aceita requisições HTTP **GET** e retorna uma lista de todos os usuários se o token que está no cabeçalho da requisição seja válido. Se nenhum token for informado, ou for inválido, então será retornado um **401 Unauthorized**

