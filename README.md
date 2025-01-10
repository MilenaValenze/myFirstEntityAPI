# Minhaprimeira API, usando Entity Framework e PostgreSQL

Utilizei a arquitetura MVC para comunicar meu código com o banco de dados e com a interface. Utilizar este modelo facilita a manutenção do código, uma vez que os dados, a lógica e a interface ficam separados.

- Instalei as bibliotecas "Npgsql.EntityFrameworkCore.PostgreSQL" e "Microsoft.EntityFrameworkCore".
- Criei a tabela no banco de dados
- Criei os Models para definir como os dados do código se relacionariam com os dados do banco de dados. Seria um "de/para" das variáveis e campos da tabela.
- Criei o arquivo de conexão com o banco de dados, em "Infraestrutura" e defini a interface de comunicação.


Me baseei na segunda aula do Filipe Brito sobre Web API: https://youtu.be/0_V-xHiRbgY?list=PLIICLSbtN_uFPLnXg7VPq30pMymwCd8hX

Resumindo a serventia de cada arquivo:

1. ConnectionContext.cs
Define a classe ConnectionContext, que herda de DbContext. Configura a conexão com o banco de dados PostgreSQL e o conjunto de dados Employees.

2. Employee.cs
Define a classe Employee, que mapeia as propriedades id, name, age e photo para as colunas da tabela no banco de dados.

3. EmployeeRepository.cs
Implementa a classe EmployeeRepository, com métodos Add e Get para manipular dados no banco de dados.

4. IEmployeeRepository.cs
Define a interface IEmployeeRepository, que declara os métodos Add e Get.

5. EmployeeController.cs
Define a classe EmployeeController, que processa requisições HTTP relacionadas a Employees e utiliza o EmployeeRepository para interagir com o banco de dados.

6. EmployeeViewModel
Mostra ao usuário 
