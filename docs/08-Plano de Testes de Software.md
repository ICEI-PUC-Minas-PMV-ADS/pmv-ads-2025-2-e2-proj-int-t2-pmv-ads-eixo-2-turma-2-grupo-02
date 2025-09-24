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

---


 
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
