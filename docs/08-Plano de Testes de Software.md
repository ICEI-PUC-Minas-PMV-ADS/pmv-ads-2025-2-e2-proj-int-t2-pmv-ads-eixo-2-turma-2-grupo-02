# Plano de Testes de Software

| **Caso de Teste** | **CT01 – Criar usuário** |
|:---:|:---:|
| Requisito Associado | RF-001 – A aplicação deve permitir o gerenciamento de contas de usuários e seus níveis de permissão (CRUD). |
| Objetivo do Teste | Verificar se o administrador consegue cadastrar novos usuários. |
| Passos | - Acessar a plataforma <br> - Efetuar login como administrador <br> - Acessar menu “Gerenciar Usuários” <br> - Clicar em “Novo Usuário” <br> - Preencher os dados obrigatórios (nome, email, senha, nível de permissão) <br> - Clicar em “Salvar” |
| Critério de Êxito | O usuário deve ser cadastrado e listado com seu respectivo nível de permissão. |
|   |   |

---

| **Caso de Teste** | **CT02 – Efetuar login** |
|:---:|:---:|
| Requisito Associado | RF-002 – A aplicação deve permitir que os usuários façam login. |
| Objetivo do Teste | Verificar se o usuário consegue acessar o sistema com credenciais válidas. |
| Passos | - Acessar a tela inicial <br> - Informar email e senha válidos <br> - Clicar em “Entrar” |
| Critério de Êxito | O login deve ser realizado e o usuário direcionado à tela principal da aplicação. |
|   |   |

---

| **Caso de Teste** | **CT03 – Cadastrar área de plantio** |
|:---:|:---:|
| Requisito Associado | RF-003 – A aplicação deve permitir o gerenciamento das áreas de plantio (CRUD). |
| Objetivo do Teste | Garantir que o usuário consiga cadastrar uma nova propriedade agrícola. |
| Passos | - Acessar a plataforma <br> - Efetuar login <br> - Acessar menu “Gerenciar Áreas de Plantio” <br> - Clicar em “Área de Plnatio” <br> - Preencher dados obrigatórios (Data ínicio, Data Fim prevista, Área Utilizadas e Status) <br> - Clicar em “Salvar” |
| Critério de Êxito | A área de plantio deve ser cadastrada corretamente e listada no sistema. |
|   |   |

---

| **Caso de Teste** | **CT04 – Cadastrar cultura em uma área de plantio** |
|:---:|:---:|
| Requisito Associado | RF-004 – A aplicação deve permitir o gerenciamento das culturas plantadas em cada área, com informações como data de plantio, espécie e variedade (CRUD). |
| Objetivo do Teste | Garantir que o usuário consiga cadastrar uma nova cultura vinculada a uma área de plantio. |
| Passos | - Acessar a plataforma <br> - Efetuar login <br> - Selecionar “Gerenciar Áreas de Plantio” <br> - Escolher a área de plantio desejada <br> - Clicar em “Adicionar Cultura” <br> - Preencher informações (espécie, variedade, data de plantio) <br> - Clicar em “Salvar” |
| Critério de Êxito | A cultura deve ser cadastrada e vinculada corretamente à área de plantio selecionada. |
|   |   |
| **Caso de Teste** 	| **CT05 – Rotação de cultura** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve gerar recomendações de rotação de cultura com base no histórico de cultivo de cada área. |
| Objetivo do Teste 	| Verificar se a aplicação fornece recomendações corretas de rotação de cultura |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Efetuar login <br> - Clicar em "Gerenciar Área de Plantio" <br> - Clicar em "Visualizar" <br> - Clicar em "Visualizar" <br> - Visualizar o campo "Recomendações de rotação de cultura" |
|Critério de Êxito | - As recomendações foram feitas de forma correta |
|  	|  	|
| **Caso de Teste** 	| **CT06 – Saúde das plantações**	|
|Requisito Associado | RF-006	- A aplicação deve disponibilizar mapas com informações sobre a saúde das plantações (ex.: vigor da planta, umidade, índices vegetativos). |
| Objetivo do Teste 	| Verificar se o sistema fornece informações corretas sobre a saúde das plantações |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Efetuar login <br> - Clicar em "Gerenciar Área de Plantio" <br> - Clicar em "Visualizar" <br> - Clicar em "Visualizar" <br> - Visualizar o campo  "Saúde da plantação" |
|Critério de Êxito | - As informações foram passadas de forma correta |
|  	|  	|
| **Caso de Teste** 	| **CT07 – Gerenciamento de insumos**	|
|Requisito Associado | RF-007	- A aplicação deve permitir o gerenciamento do registro de aplicação de insumos (fertilizantes, sementes, água, defensivos) em cada área de plantio (CRUD). |
| Objetivo do Teste 	| Verificar se o usuário consegue gerenciar corretamente os insumos |
| Passos 	| - Acessar o endereço do site<br> - Efetuar login<br>  - clicar em "Gerenciar compra de insumos"<br> - Preencher os campos obrigatórios(Nome, Quantidade, Unidade de medida) <br> - Clicar em "Cadastrar"<br> - Clicar em "Atualizar"<br> - Atualizar os dados desejados<br> - Clicar em "Atualizar"<br> - Clicar em "Remover"<br> - Clicar em "Confirmar"<br> |
|Critério de Êxito | - O gerenciamento foi realizado com sucesso |



| **Caso de Teste** 	| **CT08 – Visualizar Informação sobre o risco a saúde da plantação** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008 - A aplicação deve emitir alertas ao agricultor sobre riscos de clima adverso ou presença de pragas |
| Objetivo do Teste 	| Verificar se a aplicação está exibindo os alertas sobre os riscos que podem acontecer |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Gerenciar área de plantio" <br> - Selecionar uma plantação da listagem em: **Visualizar** <br> - Será exibido o mapa da plantação com as informações sobre a saúde da plantação, no qual será exibido a informação da causa da saúde em que se encontra |
|Critério de Êxito | - A visualização sobre o alerta sobre os riscos foi exibido com sucesso |
|  	|  	|
| **Caso de Teste**	| **CT09 – Gerenciar Imagens da Fazenda - Visualizar as Imagens**	|
|Requisito Associado | RF-009	A aplicação deve permitir o gerenciamento de imagens da fazenda |
| Objetivo do Teste 	| Verificar se a aplicação exibe o gerenciamento das imagens da fazenda permitindo visualizá-las|
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no módulo de **Gerenciar Imagens da Fazenda** <br> - Será exibido um carrousel com as imagens da fazenda <br> |
|Critério de Êxito | - As imagens estão sendo exibidas corretamente |
|  	|  	|
| **Caso de Teste**	| **CT10 – Gerenciar Imagens da Fazenda - Anexar as Imagens**	|
|Requisito Associado | RF-009	A aplicação deve permitir o gerenciamento de imagens da fazenda |
| Objetivo do Teste 	| Verificar se a aplicação exibe o gerenciamento das imagens da fazenda permitindo anexá-las. |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no módulo de **Gerenciar Imagens da Fazenda** <br> - Será exibido a página do gerenciamento da fazenda <br> - No canto Superior direito deverá conter um botão de **Anexar Imagens da Fazenda**<br> - Ao clicar neste botão deverá ser exibido um modal para anexar a imagem da fazenda <br> - Ao anexar a imagem e clicar em **Confirmar** deverá ser possível ver a imagem anexada|
|Critério de Êxito | - A imagem foi anexada com sucesso|
|  	|  	|
| **Caso de Teste**	| **CT11 – Gerenciar Imagens da Fazenda - Desistir de Anexar a imagem**	|
|Requisito Associado | RF-009	A aplicação deve permitir o gerenciamento de imagens da fazenda |
| Objetivo do Teste 	| Verificar se a aplicação exibe o gerenciamento das imagens da fazenda permitindo anexá-las. |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no módulo de **Gerenciar Imagens da Fazenda** <br> - Será exibido a página do gerenciamento da fazenda <br> - No canto Superior direito deverá conter um botão de **Anexar Imagens da Fazenda**<br> - Ao clicar neste botão deverá ser exibido um modal para anexar a imagem da fazenda <br> - Ao anexar a imagem e clicar no X ou **cancelar** a imagem não deverá ser anexada|
|Critério de Êxito | - A imagem não foi anexada|
|  	|  	|
| **Caso de Teste**       | **CT12 – Visualizar a listagem de vendas**                                                                                                                               |****
| **Requisito Associado** | RF-010 – A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD).                                                                                |
| **Objetivo do Teste**   | Verificar se a aplicação exibe corretamente a listagem de vendas cadastradas.                                                                                                     |
| **Passos**              | - Acessar a aplicação <br> - Informar o endereço da aplicação <br> - Clicar no módulo **Gerenciar Vendas** <br> - O sistema deve exibir a listagem de todas as vendas cadastradas |
| **Critério de Êxito**   | - A listagem exibe todas as vendas cadastradas com informações corretas (ex.: receita, custo,plantio, data operação).                                                                     |
| **Caso de Teste**       | **CT13 – Cadastrar uma nova venda**                                                                                                                                                          |
| **Requisito Associado** | RF-010 – A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD).                                                                                           |
| **Objetivo do Teste**   | Verificar se a aplicação permite cadastrar uma nova venda corretamente.                                                                                                                      |
| **Passos**              | - Acessar o módulo **Gerenciar Vendas** <br> - Clicar em **Cadastrar Venda** <br> - Preencher os campos obrigatórios (receita, custo, plantio, data operação, chave de acesso NF-e e quantidade) <br> - Clicar em **Cadastrar** |
| **Critério de Êxito**   | - A nova venda é exibida na listagem com os dados informados.                                                                                                                                |
| **Caso de Teste**       | **CT14 – Atualizar uma venda existente**                                                                                                                                                  |
| **Requisito Associado** | RF-010 – A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD).                                                                                        |
| **Objetivo do Teste**   | Verificar se a aplicação permite atualizar as informações de uma venda existente.                                                                                                         |
| **Passos**              | - Acessar o módulo **Gerenciar Vendas** <br> - Selecionar uma venda já cadastrada <br> - Clicar em **Atualizar** <br> - Alterar algum campo (ex.: quantidade ou plantio) <br> - Clicar em **Atualizar** |
| **Critério de Êxito**   | - A venda é atualizada e a alteração aparece corretamente na listagem.                                                                                                                    |
| **Caso de Teste**       | **CT15 – Remover uma venda**                                                                                                             |
| **Requisito Associado** | RF-010 – A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD).                                       |
| **Objetivo do Teste**   | Verificar se a aplicação permite remover uma venda cadastrada.                                                                           |
| **Passos**              | - Acessar o módulo **Gerenciar Vendas** <br> - Selecionar uma venda da listagem <br> - Clicar em **Remover** <br> - Confirmar a exclusão |
| **Critério de Êxito**   | - A venda selecionada não aparece mais na listagem.                                                                                      |
|Critério de Êxito | - O login foi realizado com sucesso. |
| **Caso de Teste**	| **CT16 – Visualizar dados de safras anteriores**	|
|Requisito Associado | RF-011	A aplicação deve permitir a comparação entre dados de safras anteriores, mostrando evolução de produtividade |
| Objetivo do Teste 	| Verificar se a aplicação a comparação de safras anteriores da fazenda permitindo visualizá-las|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no módulo de **Comparar dados históricos de safras** <br> - Serão exibidos gráficos e tabelas comparando os dados das safras anteriores <br> |
|Critério de Êxito | - os gráficos e tabelas estão sendo exibidos corretamente |
|  	|  	|
| **Caso de Teste**	| **CT17 – Visualizar relatório financeiro**	|
|Requisito Associado | RF-012	A aplicação deve gerar relatórios financeiros com custos de insumos e receitas por safra, apresentando o lucro líquido |
| Objetivo do Teste 	| Verificar se a aplicação exibe o relatório financeiro da fazenda com custos de insumos e receitas por safra|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no módulo de **Visualizar relatórios** <br> - Será exibido o relatório financeiro da fazenda <br> |
|Critério de Êxito | - O relatório está sendo exibido corretamente |
| **Caso de Teste** 	| **CT18 – Relatórios sobre as plantações**	|
|Requisito Associado | RF-013	- A aplicação deve permitir que o técnico agrícola acesse relatórios detalhados com base em dados e imagens coletadas sobre as plantações. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar as informações sobre as plantações |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Faça login como técnico agrícola <br> - Clicar no botão "Gerenciar Área de Plantio" <br> - Clicar no botão "Visualizar" de alguma das plantações <br> -  Visualizar a seção de dados sobre a plantação escolhida. | 
|Critério de Êxito | - As informações sobre a plantação serem exibidas. |
| **Caso de Teste** 	| **CT19 – Recomendações sobre otimização da produção**	|
|Requisito Associado | RF-014	- A aplicação deve fornecer recomendações automáticas de boas práticas para otimização da produção (ex.: irrigação, correção do solo). |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar as recomendações para otmização da produção |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://agrinov-b3b2emayh8bmgsft.eastus2-01.azurewebsites.net/Plantacoes/Index<br> - Faça login como técnico agrícola <br> - Clicar no módulo de Plantações <br> - Clicar em alguma plantação <br> - Deverá ser exibido os campos preenchidos com a as boas práticas e as recomendações da rotação de cultura | 
|Critério de Êxito | - As recomendações de otimizações serem exibidas. |
| **Caso de Teste** 	| **CT20 – Cadastrar meta de produção**	|
|Requisito Associado | RF-015	- A aplicação deve permitir o gerenciamento de metas de produção para cada área de plantio e safra (CRUD). |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar uma meta de produção |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://agrinov-b3b2emayh8bmgsft.eastus2-01.azurewebsites.net/Metas/Index<br> - Faça login como gestor <br> - Clicar no botão "Gerenciar metas de  produção" <br> - Clicar em "CADASTRAR META DE PRODUÇÃO" <br> - Preencher os campos obrigatórios (Data Início, Data Fim, Cultura e Quantidade) <br> - Clicar em "Cadastrar" | 
|Critério de Êxito | - A meta é cadastrada com sucesso. |
| **Caso de Teste** 	| **CT21 – Atualizar meta de produção**	|
|Requisito Associado | RF-015	- A aplicação deve permitir o gerenciamento de metas de produção para cada área de plantio e safra (CRUD). |
| Objetivo do Teste 	| Verificar se o usuário consegue atualizar uma meta de produção cadastrada |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://agrinov-b3b2emayh8bmgsft.eastus2-01.azurewebsites.net/Metas/Index<br> - Faça login como gestor <br> - Clicar no botão "Gerenciar metas de  produção" <br> - Selecionar uma meta de produção cadastrada e clicar em "Atualizar" <br> - Alterar algum dos campos e clicar em "Atualizar" | 
|Critério de Êxito | - A meta é atualizada com sucesso. |
| **Caso de Teste** 	| **CT22 – Remover meta de produção**	|
|Requisito Associado | RF-015	- A aplicação deve permitir o gerenciamento de metas de produção para cada área de plantio e safra (CRUD). |
| Objetivo do Teste 	| Verificar se o usuário consegue remover uma meta de produção cadastrada |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://agrinov-b3b2emayh8bmgsft.eastus2-01.azurewebsites.net/Metas/Index<br> - Faça login como gestor <br> - Clicar no botão "Gerenciar metas de  produção" <br> - Selecionar a meta de produção criada e clicar em "REMOVER" <br> - Clicar em "Confirmar" no modal de remoção | 
|Critério de Êxito | - A meta é removida com sucesso. |
| **Caso de Teste** 	| **CT23 – Visualizar Gráfico** 	|
|	Requisito Associado 	| RF-016 A aplicação deve permitir visualizar relatórios comparativos entre o desempenho real e as metas estabelecidas.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar a página de  Gerenciar metas de vendas <br> - Clicar na aba de relatórios da Página de Gerenciar Metas de Produção  |
|Critério de Êxito | - Gráfico mostrando o comparativo  do desempenho real e metas |
| **Caso de Teste** 	| **CT24 – Download Gráfico 1** 	|
|	Requisito Associado 	| RF-017 	A aplicação deve permitir o download dos relatórios|
| Objetivo do Teste 	| Baixar Relatórios de meta de produção |
| Passos 	| - Vá atá aba de relatório <br> -  Clique na aba de Relatórios metas de produção<br> - Baixe o relatório clicando no campo de download <br>  |
|Critério de Êxito | - O download feito com sucesso. |
| **Caso de Teste** 	| **CT25 – Download Gráfico 2** 	|
|	Requisito Associado 	| RF-017 	A aplicação deve permitir o download dos relatórios|
| Objetivo do Teste 	| Baixar Relatórios de meta de vendas por plantio |
| Passos 	| - Vá atá aba de relatório <br> -  Clique na aba de Relatórios de vendas de plantio<br> - Baixe o relatório clicando no campo de download <br>  |
|Critério de Êxito | - O download feito com sucesso. |
| **Caso de Teste** 	| **CT26 – Download Gráfico 3** 	|
|	Requisito Associado 	| RF-017 	A aplicação deve permitir o download dos relatórios|
| Objetivo do Teste 	| Baixar Relatórios de Clima |
| Passos 	| - Vá atá aba de relatório <br> -  Clique na aba de Relatórios de Clima<br> - Baixe o relatório clicando no campo de download <br>  |
|Critério de Êxito | - O download feito com sucesso. |
| **Caso de Teste** 	| **CT27 – Download Gráfico 4** 	|
|	Requisito Associado 	| RF-017 	A aplicação deve permitir o download dos relatórios|
| Objetivo do Teste 	| Baixar Relatórios de Insumos |
| Passos 	| - Vá atá aba de relatório <br> -  Clique na aba de Relatórios de Insumos<br> - Baixe o relatório clicando no campo de download <br>  |
|Critério de Êxito | - O download feito com sucesso. |
| **Caso de Teste** 	| **CT28 – Previsão do clima** 	|
|	Requisito Associado 	|RF-018  A aplicação deve fornecer uma previsão do clima dos próximos 5 dias.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar a Plataforma <br> - Acessar a página de Relatório <br>- Clicar em relatório de Clima <br>|
|Critério de Êxito | - Visualizar relatório de clima com os últimos 5 dias |
| **Caso de Teste** 	| **CT29 – Cadastrar propriedade agrícola** 	|
|	Requisito Associado 	|RF-019  A aplicação deve permitir o gerenciamento da fazenda (CRUD).|
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar a fazenda. |
| Passos 	| - Acessar a Plataforma <br> - Acessar a página de Propriedade Agrícola <br>- Cadastrar os dados obrigatórios da propriedade (Nome da propriedade, CNPJ, Area, Imagem, Localização, Tipos de Solos e Tamanho Hectares). <br>|
|Critério de Êxito | - As informações são cadastradas corretamente |
| **Caso de Teste** 	| **CT30 – Atualizar propriedade agrícola** 	|
|	Requisito Associado 	|RF-019  A aplicação deve permitir o gerenciamento da fazenda (CRUD).|
| Objetivo do Teste 	| Verificar se o usuário consegue atualizar a fazenda. |
| Passos 	| - Acessar a Plataforma <br> - Acessar a página de Propriedade Agrícola <br>- Clicar no botão "Editar". <br>- Editar os dados da fazenda. <br>- Clicar no botão "Atualizar". <br>|
|Critério de Êxito | - As informações são atualizadas corretamente |
