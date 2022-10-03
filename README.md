# Clima Tempo Simples
AUVO - Aplicação de Clima Tempo Simples

## Tecnologias

**Back-End**
- Microsoft .NET Framework 4.6 ( _com C#_ );

**Front-End**
- Microsoft ASP.NET MVC;
- jQuery;
- Bootstrap;
- Select2;

## Configurar e Compilar
1. Abra o projeto no Visual Studio.
2. Instale as dependências do NuGet (se necessárias).
3. Configure a solução para inicializar os projetos de **API** e **View**.
4. Compile!

## Informações
- A **ConnectionString** está apontando para o banco _localhost_.
- Toda vez que a aplicação é rodada, as informações do banco são removidas e populadas novamente.
  - Isso pode ser desligado no **Startup** do projeto de **API**.



## Localhost
Se ao rodar o projeto a porta do _localhost_ for diferente de **44322**, você pode:
- Alterar o link da API no arquivo **main.js**, localizado em "Assets/js/main.js";
  
  ou

- Configurar o projeto no Visual Studio para rodar na porta **44322**. 



# Projeto

## Cidades Mais Quentes/Frias
Ao abrir o sistema, você vai se deparar com dois blocos grandes no topo da página.

![Blocos de Climas](/readme-images/blocos-de-climas.png)

O da **esquerda** é o bloco de **Cidades mais quentes hoje** e o da **direita** é o bloco de **Cidades mais frias hoje**.

Ambos indicam 3 cidades com temperaturas mais elevadas e mais baixas respectivamente.

<br/>

**Tempo:** 

Ao lado esquerdo do nome da cidade, vai aparecer um ícone, indicando como vai estar o tempo no dia de hoje para aquela cidade.

<br/>
<br/>

## Previsão dos 7 Dias
Abaixo do bloco de **Cidades mais frias hoje**, você vai encontrar um **seletor** ( _select_ ) para **selecionar** uma cidade para o sistema buscar a previsão completa para os próximos 7 dias.

![Blocos de Climas](/readme-images/selecionar-cidade.png)

Selecionando uma cidade, o sitema vai buscar a previsão completa e renderizar logo abaixo.

![Blocos de Climas](/readme-images/previsao-gramado.png)

**Dias da Semana**
- A previsão do tempo para o dia de hoje, vai aparecer com a nomenclatura **Hoje**.
- A previsão do tempo para o dia de amanhã, vai aparecer com a nomenclatura **Amanhã**.
- O restantes dos dias vaia aparecer com o nome do dia da semana normalmente.

**Icones**
- Cada tipo de tempo é representado por um ícone.


---

**Observações**

Como o sistema **Grid** do **Bootstrap** divide somente a _row_ em 12 colunas, ficou complicado renderizar 7 blocos em uma única linha.

A alternativa foi fazer o primeiro bloco, referente ao dia de **Hoje** ocupar a _row_ inteira. 

Para em seguida mostrar os outros 6 dias na linha de baixo.


