# Instruções de utilização

## Instalação e Execução

### Pré-requisitos
- .NET SDK 8 ou superior
- SQL Server ou banco de dados compatível
- Visual Studio 2022 ou VS Code

### Instalação Local

1. Clone o repositório:
```bash
git clone https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t2-pmv-ads-eixo-2-turma-2-grupo-02.git
```

2. Configure a string de conexão no arquivo `appsettings.json`

3. Execute as migrations do banco de dados:
```bash
dotnet ef database update
```

4. Execute a aplicação:
```bash
dotnet run
```

5. Acesse no navegador: `http://localhost:5000`

### Acesso à Aplicação em Produção

**URL:** https://agrinov-b3b2emayh8bmgsft.eastus2-01.azurewebsites.net

**Credenciais de teste:**
- Login: teste@teste.com
- Senha: 123123

## Tecnologias Utilizadas

- **Back-end:** C# / ASP.NET Core
- **Front-end:** HTML5, CSS3, JavaScript
- **Banco de Dados:** SQL Server (Relacional)
- **Hospedagem:** Microsoft Azure

## Histórico de versões

### [1.0.0] - 12/2025
#### Adicionado
- Sistema de autenticação e recuperação de senha
- Gerenciamento de usuários com 3 perfis (Administrador, Gestor, Técnico Agrícola)
- CRUD de propriedades agrícolas
- CRUD de áreas de plantio
- CRUD de culturas e plantações
- CRUD de compra de insumos
- CRUD de vendas
- CRUD de metas de produção
- Visualização de mapas com saúde das plantações
- Sistema de alertas de clima e pragas
- Recomendações automáticas de rotação de cultura
- Recomendações de boas práticas agrícolas
- Relatórios financeiros (custos, receitas, lucros)
- Relatórios comparativos de safras anteriores
- Relatórios de desempenho vs metas
- Download de relatórios
- Previsão do tempo (5 dias)
- Upload e gerenciamento de imagens da fazenda
- Upload e gerenciamento de imagens das plantações
- Deploy em produção no Azure

#### Testado
- 28 casos de teste de software (100% aprovados)
- 12 cenários de teste de usabilidade com 8 usuários
- Validação de 19 requisitos funcionais
- Validação de 5 requisitos não funcionais
