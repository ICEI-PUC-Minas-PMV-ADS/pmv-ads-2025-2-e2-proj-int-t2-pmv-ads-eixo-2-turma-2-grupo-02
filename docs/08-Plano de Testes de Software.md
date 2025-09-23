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



| Caso de Teste | CT01 – Criar usuário |
| Requisito Associado | RF-001 – A aplicação deve permitir o gerenciamento de contas de usuários e seus níveis de permissão (CRUD). |
| Objetivo do Teste | Verificar se o administrador consegue cadastrar novos usuários. |
| Passos |- Acessar a plataforma <br> - Efetuar login como administrador <br> - Acessar menu “Gerenciar Usuários” <br> - Clicar em “Novo Usuário” <br> - Preencher os dados obrigatórios (nome, email, senha, nível de permissão) <br> - Clicar em “Salvar” |
| Critério de Êxito | O usuário deve ser cadastrado e listado com seu respectivo nível de permissão. |

| Caso de Teste | CT02 – Efetuar login |
| Requisito Associado | RF-002 – A aplicação deve permitir que os usuários façam login. |
| Objetivo do Teste | Verificar se o administrador consegue cadastrar uma nova propriedade agrícola no sistema. |
| Passos | - Acessar a tela inicial <br> - Informar email e senha válidos <br> - Clicar em “Entrar” |
| Critério de Êxito | O login deve ser realizado e o usuário direcionado à tela principal da aplicação. |

| Caso de Teste | CT03 – Cadastrar propriedade agrícola |
| Requisito Associado | RF-003 – A aplicação deve permitir o gerenciamento das áreas de plantio (CRUD). |
| Objetivo do Teste | Garantir que o usuário consiga cadastrar uma nova área de plantio. |
| Passos | - Acessar a plataforma <br> - Efetuar login <br> - Acessar menu “Áreas de Plantio” <br> - Selecionar uma área cadastrada <br> - Clicar em “Adicionar Cultura” <br> - Preencher dados obrigatórios (espécie, variedade, data de plantio) <br> - Clicar em “Salvar” |
| Critério de Êxito | A cultura deve ser cadastrada corretamente e vinculada à área de plantio selecionada. |

| Caso de Teste | CT04 – Cadastrar cultura em uma área de plantio |
| Requisito Associado | RF-004 – A aplicação deve permitir o gerenciamento das culturas plantadas em cada área, com informações como data de plantio, espécie e variedade (CRUD). |
| Objetivo do Teste | Garantir que o usuário consiga cadastrar uma nova cultura vinculada a uma área de plantio. |
| Passos | - Acessar a plataforma <br> - Efetuar login <br> - Selecionar “Gerenciar Propriedade agricola” <br> - Escolher a área de plantio desejada <br> - Clicar em “Adicionar Cultura” <br> - Preencher informações (espécie, variedade, data de plantio) <br> - Clicar em “Salvar” |
| Critério de Êxito | A cultura deve ser cadastrada e vinculada corretamente à área de plantio selecionada. |
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7) 

