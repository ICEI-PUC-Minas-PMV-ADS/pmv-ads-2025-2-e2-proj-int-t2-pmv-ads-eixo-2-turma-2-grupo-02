# Programação de Funcionalidades (INCLUIR A PROGRAMAÇAÕ DE FUNCIONALIDADE EM PROFUNDIDADE)

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Nesta seção, a implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Nesta seção, é essencial relacionar os requisitos atendidos com os artefatos criados (código fonte) e com o(s) responsável(is) pelo desenvolvimento de cada artefato a cada etapa. Nesta seção também deverão ser apresentadas, se necessário, as instruções para acesso e verificação da **implementação que deve estar funcional no ambiente de hospedagem, OBRIGATORIAMENTE, a partir da Etapa 03**.

**O que DEVE ser utilizado para o desenvolvimento da aplicação:**
- Microsoft Visual Studio (IDE de Codificação)
- HTML e CSS (frontend)
- Javascript (frontend)
- C# (backend)
- MySQL ou SQLServer(Base de Dados)
- Bootstrap (template responsivo para frontend)
- Github (documentação e controle de versão)

**O que NÃO PODE ser utilizado:**
- Template React (e qualquer outro template - exceto o Bootstrap)
- Qualquer outra liguagem de programação diferente de C#

A tabela a seguir é um exemplo de como ela deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefatos produzidos | Aluno(a) responsável |
|------|-----------------------------------------|----|----|
|RF-001| A aplicação deve permitir o gerenciamento de contas de usuários e seus níveis de permissão (CRUD) | Models/Usuario.cs<br>Models/Cargo.cs<br>Controllers/UsuariosController.cs<br>Views/Usuarios/ | Gabriel, Lucas e Tiago |
|RF-002| A aplicação deve permitir que os usuários façam login | Controllers/AuthController.cs<br>Views/Auth/Login.cshtml<br>Views/Auth/RecuperarSenha.cshtml | Pamela e Tiago |
|RF-003| A aplicação deve permitir o gerenciamento das áreas de plantio (CRUD) | Models/AreaDePlantio.cs<br>Controllers/AreaDePlantioController.cs<br>Views/AreaDePlantio/ | Gabriel e Mario |
|RF-004| A aplicação deve permitir o gerenciamento das culturas plantadas em cada área, com informações como data de plantio, espécie e variedade (CRUD) | Models/Cultura.cs<br>Models/Plantacao.cs<br>Controllers/CulturasController.cs<br>Controllers/PlantacoesController.cs<br>Views/Culturas/<br>Views/Plantacoes/ | Pamela e Tiago |
|RF-005| A aplicação deve gerar recomendações de rotação de cultura com base no histórico de cultivo de cada área | Models/Cultura.cs (campo RecomendacaoRotacao)<br>Views/Plantacoes/Details.cshtml | Pamela |
|RF-006| A aplicação deve disponibilizar mapas com informações sobre a saúde das plantações (ex.: vigor da planta, umidade, índices vegetativos) | Controllers/AreaDePlantioController.cs<br>Views/AreaDePlantio/Details.cshtml<br>wwwroot/js/map.js | Lucas e Mario |
|RF-007| A aplicação deve permitir o gerenciamento do registro de aplicação de insumos (fertilizantes, sementes, água, defensivos) em cada área de plantio (CRUD) | Models/Insumo.cs<br>Controllers/InsumosController.cs<br>Views/Insumos/ | Mateus e Pamela |
|RF-008| A aplicação deve emitir alertas ao agricultor sobre riscos de clima adverso ou presença de pragas | Controllers/AreaDePlantioController.cs<br>Views/AreaDePlantio/Details.cshtml<br>wwwroot/js/alertas.js | Lucas e Mario |
|RF-009| A aplicação deve permitir o gerenciamento de imagens da fazenda (CRUD) | Models/ImagemFazenda.cs<br>Models/ImagemPlantacao.cs<br>Controllers/ImagensController.cs<br>Views/Imagens/ | Lucas |
|RF-010| A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD) | Models/Venda.cs<br>Controllers/VendasController.cs<br>Views/Vendas/ | Mario |
|RF-011| A aplicação deve permitir a comparação entre dados de safras anteriores, mostrando evolução de produtividade | Controllers/RelatoriosController.cs<br>Views/Relatorios/ComparativoSafras.cshtml<br>wwwroot/js/charts.js | Mateus |
|RF-012| A aplicação deve gerar relatórios financeiros com custos de insumos e receitas por safra, apresentando o lucro líquido | Controllers/RelatoriosController.cs<br>Views/Relatorios/Financeiro.cshtml<br>wwwroot/js/relatorio-financeiro.js | Pamela |
|RF-013| A aplicação deve permitir que o técnico agrícola acesse relatórios detalhados com base em dados e imagens coletadas sobre as plantações | Controllers/PlantacoesController.cs<br>Views/Plantacoes/Details.cshtml<br>Views/Relatorios/DetalhesPlantacao.cshtml | Pamela |
|RF-014| A aplicação deve fornecer recomendações automáticas de boas práticas para otimização da produção (ex.: irrigação, correção do solo) | Models/Cultura.cs (campo BoasPraticas)<br>Views/Plantacoes/Details.cshtml | Pamela |
|RF-015| A aplicação deve permitir o gerenciamento de metas de produção para cada área de plantio e safra (CRUD) | Models/Meta.cs<br>Controllers/MetasController.cs<br>Views/Metas/ | Pamela |
|RF-016| A aplicação deve permitir visualizar relatórios comparativos entre o desempenho real e as metas estabelecidas | Controllers/MetasController.cs<br>Views/Metas/Relatorios.cshtml<br>wwwroot/js/metas-chart.js | Gabriel e Pamela |
|RF-017| A aplicação deve permitir o download dos relatórios | Views/Relatorios/ (funcionalidade de download)<br>wwwroot/js/download-chart.js | Gabriel |
|RF-018| A aplicação deve fornecer uma previsão do clima dos próximos 5 dias | Controllers/ClimaController.cs<br>Views/Relatorios/Clima.cshtml<br>Services/WeatherService.cs | Pamela |
|RF-019| A aplicação deve permitir o gerenciamento da fazenda (CRUD) | Models/PropriedadeAgricola.cs<br>Controllers/PropriedadeAgricolaController.cs<br>Views/PropriedadeAgricola/ | Mario e Tiago |


# Instruções de acesso

## Aplicação em Produção

**URL de Acesso:** https://agrinov-b3b2emayh8bmgsft.eastus2-01.azurewebsites.net

**Status:** Online (Ambiente de Homologação)

**Credenciais de Teste:**
- **Login:** teste@teste.com
- **Senha:** 123123

## Perfis de Usuário Disponíveis

A aplicação possui 3 perfis de acesso com permissões específicas:

1. **Administrador (TI)** - Gerenciamento de usuários e sistema
2. **Gestor de Fazenda** - Gestão financeira, relatórios e metas
3. **Técnico Agrícola** - Gestão de culturas, plantações e imagens

## Funcionalidades Implementadas

Todas as 19 funcionalidades (RF-001 a RF-019) estão implementadas e disponíveis para teste na aplicação em produção.

## Tecnologias Utilizadas

- **Back-end:** C# / ASP.NET Core MVC
- **Front-end:** HTML5, CSS3, JavaScript, Bootstrap
- **Banco de Dados:** SQL Server
- **Hospedagem:** Microsoft Azure
- **Controle de Versão:** GitHub
