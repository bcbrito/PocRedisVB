# Projeto de Exemplo VB.NET com Redis para Unimed

Este é um projeto de exemplo em Visual Basic (.NET) que demonstra a integração com o Redis na versão 7 para operações básicas 
de armazenamento e recuperação de dados em cache.

## Configuração do Ambiente com Docker

1. **Instale o Docker:**
   Certifique-se de ter o Docker instalado em seu sistema. [Download do Docker](https://www.docker.com/get-started).

2. **Baixe a imagem do docker com o comando a seguir:**
    No terminal ou Prompt de Comando execute o seguinte comando baixar a imagem:
    ```bash
    docker pull redis 

2. **Execute o Container Redis versão 7:**
   No terminal ou Prompt de Comando, execute o seguinte comando para iniciar um contêiner do Redis na versão 7:
   ```bash
   docker run --name meu-redis -p 6379:6379 -d redis:7
