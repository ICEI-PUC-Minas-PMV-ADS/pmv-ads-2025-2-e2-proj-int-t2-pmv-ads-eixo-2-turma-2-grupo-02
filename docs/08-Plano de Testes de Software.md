# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |




| **Caso de Teste** 	| **CT0xx – Visualizar Gráfico** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-016 A aplicação deve permitir visualizar relatórios comparativos entre o desempenho real e as metas estabelecidas.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar a página de  Gerenciar metas de vendas <br> - Clicar na aba de relatórios da Página de Gerenciar Metas de Produção  |
|Critério de Êxito | - Gráfico mostrando o comparativo  do desempenho real e metas |



| **Caso de Teste** 	| **CT0x1 – Download Gráfico 1** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-017 	A aplicação deve permitir o download dos relatórios|
| Objetivo do Teste 	| Baixar Relatórios de meta de produção |
| Passos 	| - Vá atá aba de relatório <br> -  Clique na aba de Relatórios metas de produção<br> - Baixe o relatório clicando no campo de download <br>  |
|Critério de Êxito | - O download feito com sucesso. |

| **Caso de Teste** 	| **CT0x2 – Download Gráfico 2** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-017 	A aplicação deve permitir o download dos relatórios|
| Objetivo do Teste 	| Baixar Relatórios de meta de vendas por plantio |
| Passos 	| - Vá atá aba de relatório <br> -  Clique na aba de Relatórios de vendas de plantio<br> - Baixe o relatório clicando no campo de download <br>  |
|Critério de Êxito | - O download feito com sucesso. |

| **Caso de Teste** 	| **CT0x3 – Download Gráfico 3** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-017 	A aplicação deve permitir o download dos relatórios|
| Objetivo do Teste 	| Baixar Relatórios de Clima |
| Passos 	| - Vá atá aba de relatório <br> -  Clique na aba de Relatórios de Clima<br> - Baixe o relatório clicando no campo de download <br>  |
|Critério de Êxito | - O download feito com sucesso. |

| **Caso de Teste** 	| **CT0x4 – Download Gráfico 4** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-017 	A aplicação deve permitir o download dos relatórios|
| Objetivo do Teste 	| Baixar Relatórios de Insumos |
| Passos 	| - Vá atá aba de relatório <br> -  Clique na aba de Relatórios de Insumos<br> - Baixe o relatório clicando no campo de download <br>  |
|Critério de Êxito | - O download feito com sucesso. |



| **Caso de Teste** 	| **CT0xx – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	|RF-018  A aplicação deve fornecer uma previsão do clima dos próximos 7 dias.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |




 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
