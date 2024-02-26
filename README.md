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

<details>
  <summary>Clique para mostrar conteúdo</summary>
  
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

</details>

 


 ## Utilização do sistema
 
 #### Criação do Perfil
 
 Necessário a criação de perfil dos usuários para que as manifestações possam puxar as informações como nome, telefone, tipo de perfil e etc.

<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/aca620fb-c307-4882-b279-7ad9274db22a" style="width:90%">
</div>



 
 #### Criação da Manifestação
 
 A tabela perfil tem um relacionamento 1:N com as manifestações, logo um usuario pode criar quantas manifestaçôes forem necessárias, onde cada manifestação tem 4 tipos de status e 2 tipos de status de setor



<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/6ec0b83c-323e-4aa7-85ca-5a2e58ff9fb7" style="width:90%">
</div>

 
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




<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/7ced223d-4589-483c-b80e-cded05ef32ce" style="width:90%">
</div>


#### Criação da Resposta Manifestação
 
 O ouvidor visualizará a manifestação e terá opção de responder a manifestação ao ouvinte e anexar um arquivo juntamente, opcionalmente podendo encaminhar para o setor desejado
 
 * Caso a Manifestação ja tenha sido respondida o formulario ficará indisponivel.
 * Caso a Manifestação seja respondida, seu status mudará de Pendente para Respondida
 * Caso a Manifestação seja encaminhada para setor, seu status mudará de Não encaminhado para Encaminhado
 * Caso a Manifestação esteja respondida ou encaminhada não será possivel exclui-la

<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/5bdbfb41-ed24-404e-bb13-013a3f9d8924" style="width:90%">
</div>



### Resultado


<div align="center">
<img src="https://github.com/lucasmargui/ASP_Projeto_Gestao/assets/157809964/f83f2a02-074e-4e01-8640-439e5056f988" style="width:90%">
</div>


