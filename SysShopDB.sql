--***Arquivo de scrip que voc� pode rodar para criar o banco de dados do nosso exemplo***

-- Se��o para cria��o do banco em si - N�o execute essa parte caso v� criar o banco pelo Visual Studio
--CREATE DATABASE SysShop
--USE SysShop

--Se��o para cria��o das tabelas
CREATE TABLE Produto
(
	ProdutoId INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
	Descricao VARCHAR (250),
	Preco MONEY NOT NULL,
	TipoProdutoId INT NOT NULL
)

CREATE TABLE TipoProduto
(
	TipoProdutoId INT IDENTITY PRIMARY KEY,
	Descricao VARCHAR(80) NOT NULL
)

CREATE TABLE Cliente
(
	ClienteId INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
	Creditos MONEY NOT NULL DEFAULT 0,
	CPF VARCHAR(15) NOT NULL,
	Telefone VARCHAR(15) NOT NULL,
	Endereco VARCHAR (50)
)

CREATE TABLE Compra
(
	CompraId INT IDENTITY PRIMARY KEY,
	Data DATETIME NOT NULL DEFAULT GETDATE(),
	ClienteId INT 
)

CREATE TABLE ItemCompra
(
	ProdutoId INT NOT NULL,
	CompraId INT NOT NULL,
	Quantidade INT NOT NULL,
	Preco MONEY NOT NULL
)

--Se��o para cria��o das chaves estrangeiras
ALTER TABLE Produto ADD FOREIGN KEY(TipoProdutoId) REFERENCES TipoProduto(TipoProdutoId) ON DELETE CASCADE

ALTER TABLE Compra ADD FOREiGN KEY(ClienteId) REFERENCES Cliente(ClienteId) ON DELETE SET NULL

ALTER TABLE ItemCompra ADD FOREiGN KEY(ProdutoId) REFERENCES Produto(ProdutoId) ON DELETE CASCADE
ALTER TABLE ItemCompra ADD FOREiGN KEY(CompraId) REFERENCES Compra(CompraId) ON DELETE CASCADE
