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

| **Caso de Teste** | **CT03 – Cadastrar propriedade agrícola** |
|:---:|:---:|
| Requisito Associado | RF-003 – A aplicação deve permitir o gerenciamento das áreas de plantio (CRUD). |
| Objetivo do Teste | Garantir que o usuário consiga cadastrar uma nova propriedade agrícola. |
| Passos | - Acessar a plataforma <br> - Efetuar login <br> - Acessar menu “Áreas de Plantio” <br> - Clicar em “Nova Propriedade Agrícola” <br> - Preencher dados obrigatórios (nome da propriedade, localização, tamanho) <br> - Clicar em “Salvar” |
| Critério de Êxito | A propriedade agrícola deve ser cadastrada corretamente e listada no sistema. |
|   |   |

---

| **Caso de Teste** | **CT04 – Cadastrar cultura em uma área de plantio** |
|:---:|:---:|
| Requisito Associado | RF-004 – A aplicação deve permitir o gerenciamento das culturas plantadas em cada área, com informações como data de plantio, espécie e variedade (CRUD). |
| Objetivo do Teste | Garantir que o usuário consiga cadastrar uma nova cultura vinculada a uma área de plantio. |
| Passos | - Acessar a plataforma <br> - Efetuar login <br> - Selecionar “Gerenciar Propriedade Agrícola” <br> - Escolher a área de plantio desejada <br> - Clicar em “Adicionar Cultura” <br> - Preencher informações (espécie, variedade, data de plantio) <br> - Clicar em “Salvar” |
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
|  	|  	|
 
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
