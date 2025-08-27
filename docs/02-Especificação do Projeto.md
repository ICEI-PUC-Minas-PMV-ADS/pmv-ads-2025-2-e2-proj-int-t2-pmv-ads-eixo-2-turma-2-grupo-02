# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas


**Persona 1 - Administrador**
Ana tem 35 anos, mora em Goiânia (GO), é administradora de sistemas e precisa cadastrar novos usuários na plataforma para que os gestores e técnicos agrícolas possam ter acesso. O objetivo dela é certificar a segurança do sistema para que cada perfil de usuário tenha acesso as funcionalidades conforme suas funções. 

**Persona 2 - Gestor**
João tem 45 anos, mora em Uberlândia (MG), é gestor de fazenda e busca uma visão abrangente do plantio e das vendas, além do controle operacional da propriedade. Seu objetivo é utilizar essas informações detalhadas para identificar perdas, otimizar processos e aumentar a eficiência da produção. 

**Persona 3 - Técnico Agrícola**
Carlos tem 32 anos, mora em Ribeirão Preto (SP), é técnico agrícola e precisa cadastrar áreas de plantio e durante seu trabalho acompanha as áreas de plantio da fazenda. Ele busca maneiras de registrar e organizar as informações sobre os insumos e os cultivos. Ele tem a necessidade de ter uma visão confiável do desenvolvimento da lavoura para tomar decisões mais precisas e colaborar com a eficiência da produção. 


**Persona 4 – Técnico Agrícola**
Mariana tem 28 anos, mora em Cascavel (PR), é técnica agrícola e acompanha pequenas propriedades familiares. Ela sente dificuldade em centralizar os dados de diferentes fazendas, pois cada produtor utiliza métodos manuais distintos. Sua necessidade é ter uma ferramenta que unifique as informações, permitindo registrar cultivos e insumos de forma organizada para apoiar os agricultores locais na busca por maior produtividade.

**Persona 5 – Técnico Agrícola**
Rafael tem 40 anos, mora em Barreiras (BA), trabalha há mais de 15 anos na área agrícola e acompanha grandes áreas de produção de soja e milho. Ele já tem contato com tecnologias digitais, mas enfrenta barreiras quando precisa integrar informações de campo com relatórios gerenciais. Seu objetivo é otimizar o tempo de coleta de dados em campo, reduzindo falhas e garantindo relatórios mais precisos para os gestores.

**Persona 6 – Técnico Agrícola**
Fernanda tem 34 anos, mora em Sinop (MT), é engenheira agrônoma e atua como técnica agrícola em fazendas de médio porte. Ela busca ferramentas que permitam não apenas registrar os dados, mas também gerar análises comparativas de diferentes safras. Sua necessidade é identificar padrões de produtividade e propor estratégias de manejo mais sustentáveis, auxiliando a reduzir custos e preservar o solo.


## Histórias de Usuários
<!-- TODO: Lucas -->
Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| João (Gestor)             | Visualizar relatórios consolidados de produção e vendas  | Ter uma visão abrangente da fazenda                    |
| João (Gestor)             | Acompanhar indicadores de produtividade por área         | Identificar perdas e otimizar processos                |
| João (Gestor)             | Registrar compras e vendas diretamente na plataforma     | Centralizar dados financeiros da fazenda               |
| João (Gestor)             | Receber alertas sobre pragas ou clima                    | Tomar decisões rápidas e reduzir riscos                |
| Carlos (Técnico Agrícola)          | Visualizar relatórios de custos e lucros por safra       | Acompanhar a rentabilidade                             |
| Carlos (Técnico Agrícola)          | Acessar relatórios                                       | Validar as recomendações do sistema                    |
| Carlos (Técnico Agrícola)          | Visualizar imagens da região agrícola                    | Conhecer o terreno                                     |
| Mariana (Técnico Agrícola)          | Trocar a senha da conta                                  | Recuperar o acesso à conta criada                      |
| Mariana (Técnico Agrícola)         | Fazer login na plataforma com as credenciais cadastradas | Acessar a aplicação e suas funcionalidades             |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir o gerenciamento de contas de usuários e seus níveis de permissão (CRUD). | ALTA |
|RF-002| A aplicação deve permitir que os usuários façam login. | ALTA |
|RF-003| A aplicação deve permitir o gerenciamento das áreas de plantio (CRUD). | ALTA |
|RF-004| A aplicação deve permitir o gerenciamento das culturas plantadas em cada área, com informações como data de plantio, espécie e variedade (CRUD). | ALTA |
|RF-005| A aplicação deve gerar recomendações de rotação de cultura com base no histórico de cultivo de cada área. | ALTA |
|RF-006| A aplicação deve disponibilizar mapas com informações sobre a saúde das plantações (ex.: vigor da planta, umidade, índices vegetativos). | ALTA |
|RF-007| A aplicação deve permitir o gerenciamento do registro de aplicação de insumos (fertilizantes, sementes, água, defensivos) em cada área de plantio (CRUD). | ALTA |
|RF-008| A aplicação deve emitir alertas ao agricultor sobre riscos de clima adverso ou presença de pragas. | ALTA |
|RF-009| A aplicação deve permitir o gerenciamento de imagens da fazenda (CRUD). | ALTA |
|RF-010| A aplicação deve permitir a comparação entre dados de safras anteriores, mostrando evolução de produtividade. | MÉDIA |
|RF-011| A aplicação deve gerar relatórios financeiros com custos de insumos e receitas por safra, apresentando o lucro líquido. | MÉDIA |
|RF-012| A aplicação deve permitir que o técnico agrícola acesse relatórios detalhados com base em dados e imagens coletadas. | MÉDIA |
|RF-013| A aplicação deve fornecer recomendações automáticas de boas práticas para otimização da produção (ex.: irrigação, correção do solo). | MÉDIA |
|RF-014| A aplicação deve permitir que os administradores façam download dos relatórios. | BAIXA |
|RF-015| A aplicação deve fornecer uma previsão do clima dos próximos 7 dias. | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve armazenar dados sensíveis de forma criptografada e seguir a LGPD para proteção das informações dos agricultores. | ALTA |
|RNF-002| A aplicação deve estar disponível 24 horas por dia, 7 dias por semana, com tempo de inatividade mínimo para manutenções programadas. | ALTA |
|RNF-003| A aplicação deve responder às interações do usuário em até 2 segundos para operações comuns, como consultas de dados e visualização de relatórios. | ALTA |
|RNF-004| A aplicação deve ser capaz de processar e armazenar imagens (ex.: drones, satélites) de forma organizada e otimizada para consultas rápidas. | ALTA |
|RNF-005| A aplicação deve ser compatível com os principais navegadores do mercado (ex.:Google Chrome, Safari, Firefox). | MÉDIA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |
|03| O sistema não fará integração com sensores            |
|04| O banco de dados usado precisa ser relacional         |
|05|  A Linguagem de progração back-end utilizada é c#     |
|06| O Front-End Utiliza apenas HTML,CSS e Javascript |
|07| Não haverá validação dos dados em processos agrícolas reais, ou seja, não terão testes práticos; |
|08|Por conta da limitação no orçamento, o sistema não permitirá utilização de equipamentos externos; |
|09|As funcionalidades avançadas  e Venda ,fora do CRUD, ficam fora do escopo atual |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

<img width="4355" height="4153" alt="AgrInov(1)" src="https://github.com/user-attachments/assets/330cb120-524e-4c74-b0dd-ef19d2665648" />


<!-- TODO: Lucas delete -->
As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
