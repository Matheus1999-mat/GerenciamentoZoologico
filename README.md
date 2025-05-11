# Projeto: Sistema de Gerenciamento de um Zoologico

## Sobre o projeto
Foi desenvolvida uma aplicação web, utilizando .NET Core, além do Entity Framework e nUnit para testes unitários. Essa aplicação usa o Model-View-Controller, para garantir que o código esteja organizado e fácil 
de manter, além de estar documentado para que qualquer pessoa possa entender e utilizar.

## Ferramentas necessárias para executar o projeto
Para utilizar esse projeto, algumas ferramentas são necessárias: 
- **Visual Studio**: é a IDE que pode ser usada. Nesse caso, pode-se instalar a versão Community. O link de download é esse: https://visualstudio.microsoft.com/pt-br/vs/community/
- **SQL Server**: é o banco de dados utilizado no projeto.

### Funcionalidades
- **Animais**: permitir que os usuários cadastrem, busquem, atualizem ou removam informações sobre os animais.
- **Cuidados**: permitir que os usuários cadastrem, busquem, atualizem ou removam informações sobre os cuidados que os animais do zoológico devem ter.
- **Testes**: foram desenvolvidos testes unitários com nUnit, para garantir que as funções implementadas funcionem corretamente e sejam validadas.

## Como rodar o projeto
1. Faça o download do Visual Studio Community e do SQL Server, se ainda não tiver feito.
2. Para baixar o projeto, no GitHub, clique no botão verde escrito "Code" e depois escolha a opção "Download ZIP". Após isso, descompacte o projeto.
3. Após descompactar, navegue pela pasta "GerenciamentoZoologico", até encontrar um arquivo com o nome "GerenciamentoZoologico.sln". Dê um duplo clique.
4. Após isso, na parte lateral direita do Visual Studio, dentro da solução "GerenciamentoZoologico", procure o arquivo appsettings.json;
![Captura de tela 2025-05-09 210431](https://github.com/user-attachments/assets/686fcf0a-a566-42cc-985e-99cf6bcb1c3c)
5. Depois isso, abra esse arquivo appsettings.json. No item "ConnectionSettings", faça a configuração da string de conexão ao banco de dados, colocando as respectivas credenciais do seu SQL Server;
![Captura de tela 2025-05-09 210503](https://github.com/user-attachments/assets/f0ba3687-1aa1-4ae5-b17d-1fb73b49e949)
6. Depois isso, na parte superior do Visual Studio, porcure a aba Compilação, em seguida clique em Recompilar solução;
![Captura de tela 2025-05-09 210624](https://github.com/user-attachments/assets/de6c0ab4-a021-4740-8c94-dcadbe7ca13e)
7. Depois isso, na parte inferior do Visual Studio, procure o item  "Console do gerenciador de pacotes". Escreva o comando indicado e dê enter;
![Captura de tela 2025-05-09 210741](https://github.com/user-attachments/assets/1c753c3c-1a30-4dca-b6d6-0168d7442a64)
8. Execute o projeto. Uma interface do swagger deve aparecer.

## Além dos requisitos básicos
Além dos requisitos básicos, algumas funcionalidades foram implementadas:
- **Testes unitários**: Foram desenvolvidos testes unitários, com o uso do nUnit, para cada funcionalidade implementada;
- **Banco de dados SQL Server**: Foi desenvolvida uma conexão com o banco de dados SQL Server, com o relacionamento entre tabelas.
![Captura de tela 2025-05-10 220559](https://github.com/user-attachments/assets/26649f57-d95e-4d52-aa66-bfa1e755def0)

## As dificuldades encontradas
Algumas das dificuldades encontradas dizem respeito ao desenvolvimento front-end. Ainda não consegui compreender muito bem a parte do Angular/React JS, no que diz respeito a sua estrutura e funcionamento.
Mas coloco-me à disposição para aprender e ganhar experiência, uma vez contratado. 




