# Projeto de Relatório de Produtos 📊

Um projeto simples para gerar relatórios fictícios de produtos com dados aleatórios.

## Tecnologias Utilizadas 🚀

- ASP.NET Core 5.0
- C#

## Funcionalidades do Projeto 📋

- Geração de dados fictícios de produtos com mês e ano.
- Listagem de produtos com diferentes filtros, como categoria e marca.

## Como Executar 🏃‍♂️

Para executar este projeto localmente, siga os passos abaixo:

1. Clone este repositório:

```bash
git clone https://github.com/mareanalitica/backend-dotnet.git
```

2. Navegue até a pasta do projeto:

```bash
cd backend-dotnet
```

3. Execute o projeto:

```bash
dotnet run
```

A API estará acessível em [http://localhost:5255](http://localhost:5255).

## Uso da API 📝

### Listar Produtos

- **Endpoint**: `/product`
- **Método**: GET
- **Descrição**: Retorna uma lista de produtos fictícios com dados aleatórios.

### Filtrar Produtos por Categoria

- **Endpoint**: `/product/category/{category}`
- **Método**: GET
- **Descrição**: Retorna uma lista de produtos fictícios com base na categoria especificada.

### Filtrar Produtos por Marca

- **Endpoint**: `/product/brand/{brand}`
- **Método**: GET
- **Descrição**: Retorna uma lista de produtos fictícios com base na marca especificada.

### Listar Categorias Disponíveis

- **Endpoint**: `/product/categories`
- **Método**: GET
- **Descrição**: Retorna a lista de categorias disponíveis.

### Listar Marcas Disponíveis

- **Endpoint**: `/product/brands`
- **Método**: GET
- **Descrição**: Retorna a lista de marcas disponíveis.


Feito com ❤️ por Paulo Victor 👨‍💻