# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 

Utilize também como referência o exemplo abaixo:

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/AnaClara1.png" alt="Persona1"/>

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ana Clara  | Uma forma de identificar se uma agência é realmente confiável           | Me sentir mais segura ao contratar seus serviços               |
|Ana Clara       | Ter um mecanismo eficiente e rápido de comunicação                 | Que eu possa sanar todas as minhas dúvidas rapidamente |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

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

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
