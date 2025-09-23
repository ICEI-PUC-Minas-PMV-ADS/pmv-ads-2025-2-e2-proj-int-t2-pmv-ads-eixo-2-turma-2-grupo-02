# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma **sequencial** e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT01 – Visualizar Informação sobre o risco a saúde da plantação** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008 - A aplicação deve emitir alertas ao agricultor sobre riscos de clima adverso ou presença de pragas |
| Objetivo do Teste 	| Verificar se a aplicação está exibindo os alertas sobre os riscos que podem acontecer |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Gerenciar área de plantio" <br> - Selecionar uma plantação da listagem em: **Visualizar** <br> - Será exibido o mapa da plantação com as informações sobre a saúde da plantação, no qual será exibido a informação da causa da saúde em que se encontra |
|Critério de Êxito | - A visualização sobre o alerta sobre os riscos foi exibido com sucesso |
|  	|  	|
| **Caso de Teste**	| **CT02 – Gerenciar Imagens da Fazenda - Visualizar as Imagens**	|
|Requisito Associado | RF-009	A aplicação deve permitir o gerenciamento de imagens da fazenda |
| Objetivo do Teste 	| Verificar se a aplicação exibe o gerenciamento das imagens da fazenda permitindo visualizá-las|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no módulo de **Gerenciar Imagens da Fazenda** <br> - Será exibido um carrousel com as imagens da fazenda <br> |
|Critério de Êxito | - As imagens estão sendo exibidas corretamente |
|  	|  	|
| **Caso de Teste**	| **CT03 – Gerenciar Imagens da Fazenda - Anexar as Imagens**	|
|Requisito Associado | RF-009	A aplicação deve permitir o gerenciamento de imagens da fazenda |
| Objetivo do Teste 	| Verificar se a aplicação exibe o gerenciamento das imagens da fazenda permitindo anexá-las. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no módulo de **Gerenciar Imagens da Fazenda** <br> - Será exibido a página do gerenciamento da fazenda <br> - No canto Superior direito deverá conter um botão de **Anexar Imagens da Fazenda**<br> - Ao clicar neste botão deverá ser exibido um modal para anexar a imagem da fazenda <br> - Ao anexar a imagem e clicar em **Confirmar** deverá ser possível ver a imagem anexada|
|Critério de Êxito | - A imagem foi anexada com sucesso|
|  	|  	|
| **Caso de Teste**	| **CT04 – Gerenciar Imagens da Fazenda - Desistir de Anexar a imagem**	|
|Requisito Associado | RF-009	A aplicação deve permitir o gerenciamento de imagens da fazenda |
| Objetivo do Teste 	| Verificar se a aplicação exibe o gerenciamento das imagens da fazenda permitindo anexá-las. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no módulo de **Gerenciar Imagens da Fazenda** <br> - Será exibido a página do gerenciamento da fazenda <br> - No canto Superior direito deverá conter um botão de **Anexar Imagens da Fazenda**<br> - Ao clicar neste botão deverá ser exibido um modal para anexar a imagem da fazenda <br> - Ao anexar a imagem e clicar no X ou **cancelar** a imagem não deverá ser anexada|
|Critério de Êxito | - A imagem não foi anexada|
|  	|  	|
| **Caso de Teste**       | **CT05 – Visualizar a listagem de vendas**                                                                                                                               |****
| **Requisito Associado** | RF-010 – A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD).                                                                                |
| **Objetivo do Teste**   | Verificar se a aplicação exibe corretamente a listagem de vendas cadastradas.                                                                                                     |
| **Passos**              | - Acessar o navegador <br> - Informar o endereço da aplicação <br> - Clicar no módulo **Gerenciar Vendas** <br> - O sistema deve exibir a listagem de todas as vendas cadastradas |
| **Critério de Êxito**   | - A listagem exibe todas as vendas cadastradas com informações corretas (ex.: receita, custo,plantio, data operação).                                                                     |
| **Caso de Teste**       | **CT06 – Cadastrar uma nova venda**                                                                                                                                                          |
| **Requisito Associado** | RF-010 – A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD).                                                                                           |
| **Objetivo do Teste**   | Verificar se a aplicação permite cadastrar uma nova venda corretamente.                                                                                                                      |
| **Passos**              | - Acessar o módulo **Gerenciar Vendas** <br> - Clicar em **Cadastrar Venda** <br> - Preencher os campos obrigatórios (receita, custo, plantio, data operação, chave de acesso NF-e e quantidade) <br> - Clicar em **Cadastrar** |
| **Critério de Êxito**   | - A nova venda é exibida na listagem com os dados informados.                                                                                                                                |
| **Caso de Teste**       | **CT07 – Atualizar uma venda existente**                                                                                                                                                  |
| **Requisito Associado** | RF-010 – A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD).                                                                                        |
| **Objetivo do Teste**   | Verificar se a aplicação permite atualizar as informações de uma venda existente.                                                                                                         |
| **Passos**              | - Acessar o módulo **Gerenciar Vendas** <br> - Selecionar uma venda já cadastrada <br> - Clicar em **Atualizar** <br> - Alterar algum campo (ex.: quantidade ou plantio) <br> - Clicar em **Atualizar** |
| **Critério de Êxito**   | - A venda é atualizada e a alteração aparece corretamente na listagem.                                                                                                                    |
| **Caso de Teste**       | **CT08 – Remover uma venda**                                                                                                             |
| **Requisito Associado** | RF-010 – A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD).                                       |
| **Objetivo do Teste**   | Verificar se a aplicação permite remover uma venda cadastrada.                                                                           |
| **Passos**              | - Acessar o módulo **Gerenciar Vendas** <br> - Selecionar uma venda da listagem <br> - Clicar em **Remover** <br> - Confirmar a exclusão |
| **Critério de Êxito**   | - A venda selecionada não aparece mais na listagem.                                                                                      |




 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
