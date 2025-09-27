# Especificações do Projeto

## Personas
<br>

![ana](https://github.com/user-attachments/assets/d2f8a7ba-7f88-460f-b93a-aa377535c416)

**Persona 1 - Administrador**

Ana tem 35 anos, mora em Goiânia (GO), é administradora de sistemas e precisa cadastrar novos usuários na plataforma para que os gestores e técnicos agrícolas possam ter acesso. O objetivo dela é certificar a segurança do sistema para que cada perfil de usuário tenha acesso as funcionalidades conforme suas funções. 

<br>

![joao](https://github.com/user-attachments/assets/c8ba9506-8a41-4078-9817-10cdb9d72003)

**Persona 2 - Gestor**

João tem 45 anos, mora em Uberlândia (MG), é gestor de fazenda e busca uma visão abrangente do plantio e das vendas, além do controle operacional da propriedade. Seu objetivo é utilizar essas informações detalhadas para identificar perdas, otimizar processos e aumentar a eficiência da produção. 

<br>

![carlos](https://github.com/user-attachments/assets/4e0c875c-cfab-4283-8b8e-939873096411)

**Persona 3 - Técnico Agrícola**

Carlos tem 32 anos, mora em Ribeirão Preto (SP), é técnico agrícola e precisa cadastrar áreas de plantio e durante seu trabalho acompanha as áreas de plantio da fazenda. Ele busca maneiras de registrar e organizar as informações sobre os insumos e os cultivos. Ele tem a necessidade de ter uma visão confiável do desenvolvimento da lavoura para tomar decisões mais precisas e colaborar com a eficiência da produção. 

<br>

![mariana](https://github.com/user-attachments/assets/0e8934e7-c6cd-489c-b4b7-5265a4a135e1)

**Persona 4 – Técnico Agrícola**

Mariana tem 28 anos, mora em Cascavel (PR), é técnica agrícola e acompanha pequenas propriedades familiares. Ela sente dificuldade em centralizar os dados de diferentes fazendas, pois cada produtor utiliza métodos manuais distintos. Sua necessidade é ter uma ferramenta que unifique as informações, permitindo registrar cultivos e insumos de forma organizada para apoiar os agricultores locais na busca por maior produtividade.

<br>

![rafael](https://github.com/user-attachments/assets/2421dd3d-ef51-4c76-890f-9df8896f3bfe)

**Persona 5 – Técnico Agrícola**

Rafael tem 40 anos, mora em Barreiras (BA), trabalha há mais de 15 anos na área agrícola e acompanha grandes áreas de produção de soja e milho. Ele já tem contato com tecnologias digitais, mas enfrenta barreiras quando precisa integrar informações de campo com relatórios gerenciais. Seu objetivo é otimizar o tempo de coleta de dados em campo, reduzindo falhas e garantindo relatórios mais precisos para os gestores.

<br>

![fernanda](https://github.com/user-attachments/assets/dfa8a044-a8d0-4dd9-b269-7bec994d0270)

**Persona 6 – Técnico Agrícola**

Fernanda tem 34 anos, mora em Sinop (MT), é engenheira agrônoma e atua como técnica agrícola em fazendas de médio porte. Ela busca ferramentas que permitam não apenas registrar os dados, mas também gerar análises comparativas de diferentes safras. Sua necessidade é identificar padrões de produtividade e propor estratégias de manejo mais sustentáveis, auxiliando a reduzir custos e preservar o solo.


## Histórias de Usuários
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
| Carlos (Técnico Agrícola) | Registrar culturas com data, variedade e safra         | Manter histórico organizado e planejar safras futuras       |
| Fernanda (Técnica Agrícola)| Receber sugestões automáticas de boas práticas         | Tomar decisões informadas e melhorar a produtividade        |
| João (Gestor)             | Baixar relatórios em PDF ou planilha                   | Compartilhar em reuniões e analisar dados offline           |
| Rafael (Técnico Agrícola) | Visualizar previsão do tempo na plataforma             | Planejar atividades de campo com mais eficiência e segurança|                               |
| Rafael (Técnico Agrícola)          | Trocar a senha da conta                                  | Recuperar o acesso à conta criada                      |
| Mariana (Técnico Agrícola)         | Fazer login na plataforma com as credenciais cadastradas | Acessar a aplicação e suas funcionalidades             |
| Mariana (Técnico Agrícola)      | Visualizar a quantidade de insumos por safra             | Acompanhar o gasto de recursos de cada safra           |
| Rafael(Técnico Agrícola)         | Receber alertas sobre o clima e pragas                   | Tomar as devidas providências e evitar prejuísos       |
| João(Gestor)                  | Cadastrar diferentes áreas de plantil                    | Poder acompanhar cada safra de forma mais detalhada    |
| João(Gestor)                | Alterar as permições dos usuários                        | Garantir que todos estejam com os acessos corretos     |
| Fernanda(Técnico agrícola)      | Cadastrar diferentes fazendas                            | Organizar as informações de cada uma individualmente   |
| Mariana(Gestor)                 | Comparar dados de safras anteriores                      | Entender tendências e otimizar processos               |
| Carlos(Técnico Agrícola)      | Receber sugestões de rotação de cultura                  | Manter a fertilidade do solo e reduzir pragas          |
| Fernada (Técnico Agrícola)        | Visualizar mapas com informações da plantação            | Entender a saúde das plantações e os solos para plantio|
| Ana (Administrador)             | Visualizar lista de usuários cadastrados                 | Conferir quem tem acesso ao sistema                   |
| Ana (Administrador)             | Ativar ou desativar contas de usuários                   | Impedir acesso de usuários que não deveriam usar o sistema |
| Ana (Administrador)             | Editar informações básicas de usuário                    | Corrigir dados simples, como nome ou e-mail           |
| Ana (Administrador)             | Ver lista de fazendas cadastradas                        | Ter noção geral de todas as propriedades gerenciadas  |
| Ana (Administrador)             | Definir metas de produção por área de plantio            | Acompanhar desempenho e incentivar melhoria contínua  |
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
|RF-010| A aplicação deve permitir o gerenciamento de registros de vendas, custos e lucros (CRUD). | MÉDIA |
|RF-011| A aplicação deve permitir a comparação entre dados de safras anteriores, mostrando evolução de produtividade. | MÉDIA |
|RF-012| A aplicação deve gerar relatórios financeiros com custos de insumos e receitas por safra, apresentando o lucro líquido. | MÉDIA |
|RF-013| A aplicação deve permitir que o técnico agrícola acesse relatórios detalhados com base em dados e imagens coletadas sobre as plantações. | MÉDIA |
|RF-014| A aplicação deve fornecer recomendações automáticas de boas práticas para otimização da produção (ex.: irrigação, correção do solo). | MÉDIA |
|RF-015| A aplicação deve permitir o gerenciamento de metas de produção para cada área de plantio e safra (CRUD). | MÉDIA |
|RF-016| A aplicação deve permitir visualizar relatórios comparativos entre o desempenho real e as metas estabelecidas. | MÉDIA |
|RF-017| A aplicação deve permitir o download dos relatórios. | BAIXA |
|RF-018| A aplicação deve fornecer uma previsão do clima dos próximos 7 dias. | BAIXA |
|RF-019| A aplicação deve permitir o gerenciamento da fazenda (CRUD). | ALTA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve armazenar dados sensíveis de forma criptografada e seguir a LGPD para proteção das informações dos agricultores. | ALTA |
|RNF-002| A aplicação deve estar disponível 24 horas por dia, 7 dias por semana, com tempo de inatividade mínimo para manutenções programadas. | ALTA |
|RNF-003| A aplicação deve responder às interações do usuário em até 2 segundos para operações comuns, como consultas de dados e visualização de relatórios. | ALTA |
|RNF-004| A aplicação deve ser capaz de processar e armazenar imagens (ex.: drones, satélites) de forma organizada e otimizada para consultas rápidas. | ALTA |
|RNF-005| A aplicação deve ser compatível com os principais navegadores do mercado (ex.:Google Chrome, Safari, Firefox). | MÉDIA |

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

<img width="1873" height="1994" alt="AgrInov_atualizado" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t2-pmv-ads-eixo-2-turma-2-grupo-02/blob/main/docs/img/AgrInov%20-%20OFICIAL%20-%20DIAGRAMA%20DE%20CASO%20DE%20USO.png" />


