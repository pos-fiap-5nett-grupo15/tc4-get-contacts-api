# Tech Challenge 4 - Grupo 15

Projeto realizado pelo **Grupo 15** da turma da FIAP de Arquitetura de Sistemas .NET com Azure


## Autores

||
|--|
| Caio Vinícius Moura Santos Maia |
| Guilherme Castro Batista Pereira |
| Evandro Prates Silva |
| Luis Gustavo Gonçalves Reimberg |


## GetContact

### Tecnologias Utilizadas
- .NET 8
- Dapper
- RabbitMQ
- FluentValidation
- XUnit
- MediatR
- Moq

Dentro da arquitetura de microsserviços desenvolvida para este tech challenge, este projeto realiza a função de buscar os contatos, seguindo o passo a passo abaixo:

### API
- Receber a requisição
- Validar os dados da requisição
- Busca o(s) contato(s) na base de dados
- Retorna os dados dos contatos encontrados
