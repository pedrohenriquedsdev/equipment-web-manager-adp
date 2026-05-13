# 🖥️ Gestão de Equipamentos Web

> Sistema web para controle de inventário de equipamentos e chamados de manutenção.

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2026

---

## 📋 Sobre o Projeto

Junior gerencia o estoque de equipamentos da empresa onde trabalha e controlava tudo manualmente em planilhas do Excel — fabricantes, inventário e histórico de manutenções.

Para automatizar esse processo, ele contou com o apoio da **Academia do Programador** no desenvolvimento deste software, que centraliza todas essas informações em uma aplicação web organizada e eficiente.

---

## ✨ Funcionalidades

### 🏭 Controle de Fabricantes
- Cadastrar fabricantes com nome, e-mail e telefone
- Visualizar todos os fabricantes e a quantidade de equipamentos vinculados
- Editar e excluir fabricantes registrados

### ⚙️ Controle de Equipamentos
- Cadastrar equipamentos com nome (mín. 6 caracteres), preço de aquisição, fabricante e data de fabricação
- Visualizar o inventário completo de equipamentos
- Editar e excluir equipamentos registrados

### 📞 Controle de Chamados
- Abrir chamados de manutenção vinculados a equipamentos, com título, descrição e data de abertura
- Visualizar todos os chamados com o número de dias em aberto
- Editar e excluir chamados registrados

---

## 🚀 Como Executar

### Pré-requisitos

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Passos

1. **Clone o repositório**
   ```bash
   git clone https://github.com/seu-usuario/gestao-de-equipamentos-web.git
   cd gestao-de-equipamentos-web
   ```

2. **Restaure as dependências**
   ```bash
   dotnet restore
   ```

3. **Execute o projeto**
   ```bash
   dotnet run --project GestaoDeEquipamentosWeb.ConsoleApp
   ```

---

## 🗂️ Estrutura do Projeto

```
GestaoDeEquipamentosWeb/
├── GestaoDeEquipamentosWeb.ConsoleApp/   # Ponto de entrada da aplicação
├── GestaoDeEquipamentosWeb.Dominio/      # Entidades e regras de negócio
├── GestaoDeEquipamentosWeb.Infra/        # Acesso a dados e repositórios
└── GestaoDeEquipamentosWeb.Testes/       # Testes automatizados
```

---

## 📐 Requisitos do Sistema

| Módulo | Requisito | Descrição |
|---|---|---|
| Fabricantes | Cadastro | Nome, e-mail e telefone |
| Fabricantes | Listagem | Exibe quantidade de equipamentos vinculados |
| Fabricantes | Edição / Exclusão | Todos os campos editáveis |
| Equipamentos | Cadastro | Nome (mín. 6 chars), preço, fabricante, data de fabricação |
| Equipamentos | Listagem | Exibe todos os campos + ID |
| Equipamentos | Edição / Exclusão | Todos os campos editáveis |
| Chamados | Cadastro | Título, descrição, equipamento, data de abertura |
| Chamados | Listagem | Exibe título, equipamento, data e dias em aberto |
| Chamados | Edição / Exclusão | Todos os campos editáveis |

---

## 🛠️ Tecnologias

- **C# / .NET 10.0**
- **ASP.NET Core** (Web)
- **Entity Framework Core** (ORM)

---

## 📄 Licença

Este projeto foi desenvolvido para fins educacionais no contexto do curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net).