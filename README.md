<H1 align="center">Gestão Ouvidoria</H1>
<p align="center">🚀 Desenvolvimento do projeto para teste de aptidão de um sistema de Gestão de Ouvidoria em Asp.NET MVC & Entity Framework.</p>

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

Passo 1: Abrir o cmd e executar o seguinte comando:
  ```
  SqlLocalDB.exe create "Local"
  ```
Passo 2: Executar a instance com seguinte comando:
  ```
  SqlLocalDb.exe start
  ```
  
Passo 3: Ir até o 'Package Manager Console' e executar o seguinte comando:
  ```
  Update-Database -Verbose
  ```

 Ao seguir esses passos, evitará de ocorrer o problema/error 50, de conexão com o SQL Server, erro que evita a criação da tabela via 'Code First' do Entity Framework.

 ## Utilização do sistema
 
 #### Criação do Perfil
 
 Necessário a criação de perfil dos usuários para que as manifestações possam puxar as informações como nome, telefone, tipo de perfil e etc.

 <img src="https://cdn.discordapp.com/attachments/1046824853015113789/1205233803816083456/image.png?ex=65d7a072&is=65c52b72&hm=a2e614792db382fa344a4c3bf92fb225cea9593fc6850a24404dea5b4a3698d7&" alt="">

 
 #### Criação da Manifestação
 
 A tabela perfil tem um relacionamento 1:N com as manifestações, logo um usuario pode criar quantas manifestaçôes forem necessárias, onde cada manifestação tem 4 tipos de status e 2 tipos de status de setor

 <img src="https://cdn.discordapp.com/attachments/1046824853015113789/1205234350048813096/image.png?ex=65d7a0f5&is=65c52bf5&hm=7fecf55dd37aae86c57af25d00643fbec78246b780846b957d97b1227c7de9f3&" alt="">
 
 ###### Status
  * Respondida
  * Pendente
  * Excluida
  * Vencida

 ###### Status Setor
  * Encaminhado
  * Não encaminhado

#### Lista de Manifestações

Uma tabela com lista de manifestações com seus respectivos Status

<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1205235173957050398/image.png?ex=65d7a1b9&is=65c52cb9&hm=76a7cd7def9e099a431ce614111d837637336d94415ad94278fc560c71063d36&" alt="">

#### Criação da Resposta Manifestação
 
 O ouvidor visualizará a manifestação e terá opção de responder a manifestação ao ouvinte e anexar um arquivo juntamente, opcionalmente podendo encaminhar para o setor desejado
 
 * Caso a Manifestação ja tenha sido respondida o formulario ficará indisponivel.
 * Caso a Manifestação seja respondida, seu status mudará de Pendente para Respondida
 * Caso a Manifestação seja encaminhada para setor, seu status mudará de Não encaminhado para Encaminhado
 * Caso a Manifestação esteja respondida ou encaminhada não será possivel exclui-la

<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1205235898669735996/image.png?ex=65d7a266&is=65c52d66&hm=b0fbfebd863b8d80257579d4c692a2d6c4228ebaddc446c95edd730f5812fd75&" alt="">


### Resultado

<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1205236058426708008/image.png?ex=65d7a28c&is=65c52d8c&hm=c185dceb33344173edd828be8f65b9dee9d5e38e46364bcacf6e273cacf43921&" alt="">

