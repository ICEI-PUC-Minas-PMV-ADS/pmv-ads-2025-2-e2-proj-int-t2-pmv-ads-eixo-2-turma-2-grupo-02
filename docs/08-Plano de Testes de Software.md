# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT05 – Rotação de cultura** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - A aplicação deve gerar recomendações de rotação de cultura com base no histórico de cultivo de cada área. |
| Objetivo do Teste 	| Verificar se a aplicação fornece recomendações corretas de rotação de cultura |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Efetuar login <br> - Clicar em "Gerenciar Área de Plantio" <br> - Clicar em "Visualizar" <br> - Clicar em "Visualizar" <br> - Visualizar o campo "Recomendações de rotação de cultura" |
|Critério de Êxito | - As recomendações foram feitas de forma correta |
|  	|  	|
| Caso de Teste 	| CT06 – Saúde das plantaações	|
|Requisito Associado | RF-006	- A aplicação deve disponibilizar mapas com informações sobre a saúde das plantações (ex.: vigor da planta, umidade, índices vegetativos). |
| Objetivo do Teste 	| Verificar se o sistema fornece informações corretas sobre a saúde das plantações |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Efetuar login <br> - Clicar em "Gerenciar Área de Plantio" <br> - Clicar em "Visualizar" <br> - Clicar em "Visualizar" <br> - Visualizar o campo  "Saúde da plantação" |
|Critério de Êxito | - As informações foram passadas de forma correta |
|  	|  	|
| Caso de Teste 	| CT07 – Gerenciamento de insumos	|
|Requisito Associado | RF-007	- A aplicação deve permitir o gerenciamento do registro de aplicação de insumos (fertilizantes, sementes, água, defensivos) em cada área de plantio (CRUD). |
| Objetivo do Teste 	| Verificar se o usuário consegue gerenciar corretamente os insumos |
| Passos 	| - Acessar o endereço do site<br> - Efetuar login<br>  - clicar em "Gerenciar compra de insumos"<br> - Preencher os campos obrigatórios(Nome, Quantidade, Unidade de medida) <br> - Clicar em "Cadastrar"<br> - Clicar em "Atualizar"<br> - Atualizar os dados desejados<br> - Clicar em "Atualizar"<br> - Clicar em "Remover"<br> - Clicar em "Confirmar"<br> |
|Critério de Êxito | - O gerenciamento foi realizado com sucesso |
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7) 

