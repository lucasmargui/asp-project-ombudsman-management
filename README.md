# Projeto: Teste Aptidão

Desenvolvimento do projeto para teste de aptidão de um sistema de Gestão de Ouvidoria em Asp.NET MVC & Entity Framework.



## Recursos Utilizados

 * Visual Studio 2017
 * Asp.NET MVC 4;
 * Entity Framework 4;
 * Code First;
 * SQL Server Management 2014;
 * Single Reposity Pattern;
 * Bootstrap 3;
 * .NET Framework 4.5;
 
 ## Execução do Entity Framework nas IDE's: VS 2015/2017:
 
 Ao realizar os comandos:
 
  ```
    Enable-Migrations
  
  ```
  e
  
  ```
    Update-Database -Verbose
  
  ```
  
Nas versões mais recentes do Visual Studio (2015/2017), se faz necessário criar uma nova instância do localdb do sql no seu computador. A qual poderá ser criado da seguinte maneira:

Passo1: Abrir o cmd e executar o seguinte comando:
  ```
  SqlLocalDB.exe create "MSSQLLocalDB"
  
  ```
 Passo2: Executar a instance com seguinte comando:
  ```
  SqlLocalDb.exe start
  
  ```
  
Passo3: Ir até o 'Package Manager Console' e executar o seguinte comando:
  ```
  Update-Database -Verbose
  
  ```

 Ao seguir esses passos, evitará de ocorrer o problema/error 50, de conexão com o SQL Server, erro que evita a criação da tabela via 'Code First' do Entity Framework.

 ## Utilização do sistema
 
 #### Criação do Perfil
 
 Necessário a criação de perfil dos usuários para que as manifestações possam puxar as informações como nome, telefone, tipo de perfil e etc.
 
 #### Criação da Manifestação
 
 A tabela perfil tem um relacionamento 1:N com as manifestações, logo um usuario pode criar quantas manifestaçôes forem necessárias, onde cada manifestação tem 4 tipos de status e 2 tipos de status de setor
 
 ###### Status
  * Respondida
  * Pendente
  * Excluida
  * Vencida

 ###### Status Setor
  * Encaminhado
  * Não encaminhado

#### Criação da Resposta Manifestação
 
 O ouvidor visualizará a manifestação e terá opção de responder a manifestação ao ouvinte e anexar um arquivo juntamente, opcionalmente podendo encaminhar para o setor desejado
 
 * Caso a Manifestação ja tenha sido respondida o formulario ficará indisponivel.
 * Caso a Manifestação seja respondida, seu status mudará de Pendente para Respondida
 * Caso a Manifestação seja encaminhada para setor, seu status mudará de Não encaminhado para Encaminhado
 * Caso a Manifestação esteja respondida ou encaminhada não será possivel exclui-la

 
