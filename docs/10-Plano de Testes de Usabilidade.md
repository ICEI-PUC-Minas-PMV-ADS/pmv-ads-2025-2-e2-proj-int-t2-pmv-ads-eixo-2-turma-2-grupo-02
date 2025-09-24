# Plano de Testes de Usabilidade

Os testes de usabilidade permitem avaliar a qualidade da interface com o usuário da aplicação interativa.

Um plano de teste de usabilidade deverá conter: 

## Definição do(s) objetivo(s)

Antes de iniciar os testes, é essencial definir o que se deseja avaliar na usabilidade do sistema. 
Alguns exemplos de objetivos são:
- Verificar se os usuários conseguem concluir tarefas essenciais sem dificuldades.
- Identificar barreiras na navegação e interação com o sistema.
- Avaliar a eficiência e a satisfação do usuário ao utilizar a interface.
- Testar a acessibilidade para diferentes perfis de usuários.

## Seleção dos participantes

Para garantir que o teste reflita o uso real do sistema, escolha participantes representativos do público-alvo.

**Critérios para selecionar participantes:**
- Perfis variados (experientes e iniciantes no sistema).
- Diferentes níveis de familiaridade com tecnologia.
- Pessoas com necessidades especiais (se aplicável).

**Quantidade recomendada:**
Mínimo: 5 participantes.
Ideal: Entre 8 e 12 para maior diversidade.

## Definição de cenários de teste

Os cenários representam tarefas reais que os usuários executam no sistema. Neste projeto, cada grupo deverá definir, no mínimo, **CINCO cenários para a aplicação** e cada cenário deve incluir:

- Objetivo: O que será avaliado.
- Contexto: A situação que leva o usuário a interagir com o sistema.
- Tarefa: A ação que o usuário deve realizar.
- Critério de sucesso: Como determinar se a tarefa foi concluída corretamente.

**Exemplo: Cenário 1**

**Objetivo:** Avaliar a facilidade e eficiência do usuário em pesquisar, adicionar um produto ao carrinho e finalizar a compra sem dificuldades.

**Contexto:** O usuário deseja comprar um notebook para uso pessoal. Para isso, ele deverá entrar no site www.compras.com.br para buscar opções disponíveis, comparar preços, adicionar o produto ao carrinho e finalizar a compra com pagamento via cartão de crédito.

**Tarefa(s):** 
- Acessar o site e localizar a barra de pesquisa.
- Pesquisar por "notebook" e utilizar os filtros para refinar a busca (exemplo: marca, preço, processador).
- Escolher um dos notebooks listados e acessar a página do produto.
- Adicionar o produto ao carrinho.
- Finalizar a compra, preenchendo os dados de pagamento e endereço de entrega.
- Confirmar a transação e verificar a tela de pedido concluído.

**Critério(s) de Sucesso(s):**
- O usuário consegue encontrar e filtrar os produtos sem dificuldades.
- O produto é adicionado ao carrinho corretamente.
- O usuário consegue preencher as informações de pagamento e entrega sem erros.
- A compra é finalizada com sucesso, e o usuário visualiza a confirmação do pedido.
- Todo o processo ocorre em menos de 5 minutos, sem necessidade de assistência.

## Métodos de coleta de dados

Os dados coletados devem ajudar a entender a experiência dos usuários e os dados podem ser coletados por observação direta incluindo métricas quantitativas (quantidade de cliques, número de erros, tempo gasto para cada tarefa etc.), métricas qualitativas (dificuldades, comentários etc.) e questionários pós-teste (A interface foi fácil de entender? Você encontrou dificuldades em alguma etapa? O que poderia ser melhorado?)

Para cada voluntário do teste, é fundamental coletar e apresentar todos os dados/métricas previamente definidos, mas não se esqueça: atendendo à LGPD (Lei Geral de Proteção de Dados), nenhum dado sensível, que permita identificar o voluntário, deverá ser apresentado).

As referências abaixo irão auxiliá-lo na geração do artefato "Plano de Testes de Usabilidade".
<!--gabriel -->
---

## Cenários de Teste  

### Cenário 1 – Login no sistema  
- **Objetivo:** Validar se o usuário consegue acessar o sistema com credenciais válidas.  
- **Contexto:** O usuário deseja acessar o AGRINOV para gerenciar dados de plantio.  
- **Tarefas:**  
  1. Inserir e-mail cadastrado.  
  2. Inserir senha válida.  
  3. Clicar em **Login**.  
- **Critérios de Sucesso:**  
  - O sistema valida as credenciais.  
  - O usuário é redirecionado para a tela inicial do sistema.  

---

### Cenário 2 – Recuperar senha  
- **Objetivo:** Testar se o usuário consegue redefinir senha esquecida.  
- **Contexto:** O usuário não lembra a senha de acesso.  
- **Tarefas:**  
  1. Acessar a tela de login.  
  2. Clicar em **Esqueceu a senha?**  
  3. Informar o e-mail cadastrado.  
  4. Acessar o link enviado.  
  5. Definir e confirmar nova senha.  
- **Critérios de Sucesso:**  
  - O sistema envia o e-mail de recuperação.  
  - O usuário redefine a senha com sucesso.  
  - O acesso é restabelecido.  

---

### Cenário 3 – Cadastrar novo usuário  
- **Objetivo:** Validar se o administrador consegue cadastrar usuários no sistema.  
- **Contexto:** O administrador deseja adicionar um novo técnico agrícola.  
- **Tarefas:**  
  1. Acessar o menu **Gerenciar Usuários**.  
  2. Clicar em **Cadastrar Usuário**.  
  3. Preencher campos: Nome, E-mail, CPF, Matrícula e Cargo.  
  4. Confirmar cadastro.  
- **Critérios de Sucesso:**  
  - O novo usuário aparece na lista.  
  - Todos os dados são exibidos corretamente.  

---

### Cenário 4 – Atualizar informações de usuário  
- **Objetivo:** Garantir que o administrador possa editar dados já cadastrados.  
- **Contexto:** Um usuário mudou de cargo e precisa atualizar suas informações.  
- **Tarefas:**  
  1. Acessar **Gerenciar Usuários**.  
  2. Selecionar usuário.  
  3. Clicar em **Editar**.  
  4. Alterar dados (ex.: cargo, e-mail).  
  5. Salvar alterações.  
- **Critérios de Sucesso:**  
  - Alterações são salvas.  
  - Lista exibe informações atualizadas.  

---

### Cenário 5 – Remover usuário  
- **Objetivo:** Testar a exclusão de usuários pelo administrador.  
- **Contexto:** Um funcionário saiu da fazenda e deve ser removido do sistema.  
- **Tarefas:**  
  1. Acessar **Gerenciar Usuários**.  
  2. Selecionar usuário da lista.  
  3. Clicar em **Remover**.  
  4. Confirmar exclusão.  
- **Critérios de Sucesso:**  
  - Usuário removido não aparece mais na lista.  
  - Sistema exibe mensagem de confirmação.  

---

### Cenário 6 – Cadastrar propriedade agrícola  
- **Objetivo:** Verificar se o administrador consegue cadastrar novas propriedades.  
- **Contexto:** O gestor deseja adicionar uma nova área de plantio.  
- **Tarefas:**  
  1. Acessar o menu **Propriedade Agrícola**.  
  2. Clicar em **Cadastrar Propriedade**.  
  3. Preencher os campos: Nome, Localização, Área, Responsável, Matrícula Rural.  
  4. Confirmar cadastro.  
- **Critérios de Sucesso:**  
  - Propriedade aparece na lista.  
  - Informações cadastradas são exibidas corretamente.

### Cenário 7 - Criação de Plantação

**Objetivo:** Avaliar a facilidade e eficiência do usuário em cadastrar uma nova plantação, anexar a foto aérea, visualizar a análise automática e acessar as recomendações geradas pelo sistema.

**Contexto:** O usuário é um técnico agrícola que deseja registrar uma nova plantação em uma das áreas de plantio da própriedade agrícola. Ele deve cadastrar as informações básicas da plantação, enviar uma foto obtida por drone e, em seguida, visualizar os dados gerados pelo sistema sobre a saúde da plantação e a recomendação de rotação de cultura.

**Tarefa(s):** 
- Acessar o sistema e entrar na área de gerenciar área de plantio.
- Selecionar uma área de plantio já cadastrada.
- Cadastrar uma nova plantação preenchendo os seguintes dados:
  - Nome da plantação
  - Data de início
  - Data prevista de término 
  - Área utilizada
  - Cultura (ex.: milho, soja, café etc.)
  - Status (ex.: semeado, plantado, colhido)
  - Foto da plantaçõa
- Visualizar a análise automática gerada pelo sistema (saúde da plantação e recomendação de rotação de cultura).
- Acessar a página da plantação e confirmar se as informações cadastradas e os dados da análise foram exibidos corretamente.

**Critério(s) de Sucesso(s):**
- O usuário consegue localizar a área de gerenciamento de plantio sem dificuldades.
- A plantação é cadastrada corretamente com todas as informações solicitadas.
- O upload da foto ocorre sem erros.
- O sistema gera e exibe automaticamente a análise e a recomendação de rotação de cultura.
- O usuário consegue visualizar os dados da plantação cadastrada na página da plantação.
- Todo o processo ocorre em menos de 7 minutos, sem necessidade de assistência.


> **Links Úteis**:
> - [Teste De Usabilidade: O Que É e Como Fazer Passo a Passo (neilpatel.com)](https://neilpatel.com/br/blog/teste-de-usabilidade/)
> - [Teste de usabilidade: tudo o que você precisa saber! | by Jon Vieira | Aela.io | Medium](https://medium.com/aela/teste-de-usabilidade-o-que-voc%C3%AA-precisa-saber-39a36343d9a6/)
> - [Planejando testes de usabilidade: o que (e o que não) fazer | iMasters](https://imasters.com.br/design-ux/planejando-testes-de-usabilidade-o-que-e-o-que-nao-fazer/)
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
