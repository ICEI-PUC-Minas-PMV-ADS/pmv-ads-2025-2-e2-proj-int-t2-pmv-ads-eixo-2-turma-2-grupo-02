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


## Cenários de Teste  

# Plano de Testes de Usabilidade – AGRINOV

## Cenário 1 – Primeiro acesso ao sistema  
- **Objetivo:** Avaliar a clareza e a simplicidade da tela de login para um novo usuário.  
- **Contexto:** Imagine que hoje é seu primeiro dia na empresa. Seu gestor te passou o e-mail e a senha de acesso e sua primeira tarefa é simplesmente entrar no sistema AGRINOV.  
- **Tarefas:**  
    1. Localizar e preencher o campo **E-mail** com o endereço fornecido.
    2. Localizar e preencher o campo **Senha** com a senha fornecida.
    3. Clicar no botão **Login** para acessar o sistema.
- **Critérios de Sucesso:**  
  - O participante insere os dados nos campos corretos sem hesitação.
  - A tarefa é concluída com velocidade.
  - O participante não expressa nenhuma confusão sobre o que fazer na tela.

---

## Cenário 2 – Recuperação de acesso  
- **Objetivo:** Testar a facilidade de encontrar a opção de recuperação e a confiança do usuário no processo.  
- **Contexto:** Passaram-se algumas semanas e você esqueceu completamente a sua senha. Você precisa urgentemente acessar o sistema para verificar uns dados, mas não consegue logar.  
- **Tarefas:**  
   1. Identificar o link **"Esqueceu a senha?"** na tela de login.  
  2. Clicar no link para iniciar o processo de recuperação.  
  3. Preencher o campo solicitado com o **e-mail cadastrado**.  
  4. Confirmar a solicitação para receber as instruções de redefinição. 
- **Critérios de Sucesso:**  
  - O participante localiza o link **"Esqueceu a senha?"** em menos de 10 segundos.  
  - Ele entende que precisa inserir o e-mail para receber as instruções.  
  - O participante expressa confiança de que, ao fazer isso, conseguirá resolver o problema.  

---

## Cenário 3 – Cadastrar um novo membro da equipe  
- **Objetivo:** Avaliar a facilidade e a eficiência do fluxo de cadastro de um novo usuário pelo administrador.  
- **Contexto:** Você é o administrador do sistema. Uma nova técnica agrícola foi contratada. Você precisa criar uma conta para ela para que possa registrar as visitas de campo. 
- **Tarefas:**  
  1. Acessar a área **Gerenciar Usuários** no sistema.  
  2. Selecionar a opção **Adicionar Novo Usuário**.  
  3. Preencher os campos obrigatórios (ex: nome, e-mail, senha).  
  4. Definir o cargo da nova usuária como **Técnico Agrícola**.  
  5. Salvar o cadastro para concluir o processo.    
- **Critérios de Sucesso:**  
  - O participante encontra a área de **"Gerenciar Usuários"** e o botão para criar um novo usuário sem ajuda.  
  - O preenchimento do formulário é fluido, sem pausas longas ou dúvidas sobre os campos.  
  - A tarefa é concluída em menos de 2 minutos.  

---

## Cenário 4 – Atualizar o cargo de um colaborador  
- **Objetivo:** Garantir que o processo de edição de um usuário existente seja intuitivo.  
- **Contexto:** Um colaborador foi promovido. O cargo dele está desatualizado no sistema e você, como administrador, precisa corrigir isso.  
- **Tarefas:**  
  1. Localizar o usuário na lista de colaboradores.  
  2. Clicar no botão ou ícone **Editar** associado ao seu cadastro.  
  3. Alterar o campo **Cargo** para **Técnico Agrícola**.  
  4. Salvar as alterações realizadas.    
- **Critérios de Sucesso:**  
  - O participante identifica rapidamente o botão/ícone para **Editar**.  
  - Ele realiza a alteração e salva sem erros.  
  - O participante sente confiança de que a informação foi atualizada com sucesso.  

---

## Cenário 5 – Desligar um funcionário do sistema  
- **Objetivo:** Testar a clareza do processo de exclusão e a eficácia da confirmação para evitar acidentes.  
- **Contexto:** Um funcionário não trabalha mais na fazenda. Por razões de segurança, o acesso dele ao AGRINOV precisa ser removido o mais rápido possível.  
- **Tarefas:**  
  1. Localizar o usuário na lista de colaboradores.  
  2. Selecionar a opção **Remover/Excluir Usuário**.  
  3. Ler atentamente a mensagem de confirmação exibida.  
  4. Confirmar a exclusão para finalizar o processo.  
- **Critérios de Sucesso:**  
  - O participante encontra a opção para remover o usuário facilmente.  
  - Ele lê a mensagem de confirmação antes de prosseguir, entendendo a consequência do ato.  
  - A tarefa é completada com uma sensação de segurança no processo.  

---

## Cenário 6 – Cadastrar uma nova área de plantio  
- **Objetivo:** Verificar a clareza dos campos e a lógica do formulário de cadastro de uma nova propriedade.  
- **Contexto:** A cooperativa fechou parceria com uma nova propriedade. Você precisa cadastrá-la no sistema para que as operações de campo possam ser gerenciadas.  
- **Tarefas:**  
  1. Acessar a seção **Propriedades** no sistema. 
  2. Selecionar a opção **Cadastrar Nova Propriedade**.  
  3. Preencher os campos obrigatórios do formulário (ex: nome, localização, matrícula rural).  
  4. Revisar os dados preenchidos para evitar erros.  
  5. Salvar o cadastro para concluir a inclusão da propriedade.    
- **Critérios de Sucesso:**  
  - O participante encontra a seção correta para cadastro da propriedade sem dificuldades.  
  - Ele preenche o formulário sem expressar dúvidas sobre termos técnicos (ex: *Matrícula Rural*).  
  - O participante considera o processo rápido e direto.  



---

### Cenário 7 - Cadastrar de plantação

- **Objetivo:** Avaliar a facilidade e eficiência do usuário em cadastrar uma nova plantação, anexar a foto aérea, visualizar a análise automática e acessar as recomendações geradas pelo sistema.
- **Contexto:** O usuário é um técnico agrícola que deseja registrar uma nova plantação em uma das áreas de plantio da própriedade agrícola. Ele deve cadastrar as informações básicas da plantação, enviar uma foto obtida por drone e, em seguida, visualizar os dados gerados pelo sistema sobre a saúde da plantação e a recomendação de rotação de cultura.
- **Tarefa(s):** 
  1. Acessar o sistema e entrar na área de gerenciar área de plantio.
  2. Selecionar uma área de plantio já cadastrada.
  3. Cadastrar uma nova plantação preenchendo os seguintes dados:
     - Nome da plantação
     - Data de início
     - Data prevista de término 
     - Área utilizada
     - Cultura (ex.: milho, soja, café etc.)
     - Status (ex.: semeado, plantado, colhido)
     - Foto da plantação
  4. Visualizar a análise automática gerada pelo sistema (saúde da plantação e recomendação de rotação de cultura).
  5. Acessar a página da plantação e confirmar se as informações cadastradas e os dados da análise foram exibidos corretamente.
- **Critério(s) de Sucesso(s):**
  - O usuário consegue localizar a área de gerenciamento de plantio sem dificuldades.
  - A plantação é cadastrada corretamente com todas as informações solicitadas.
  - O upload da foto ocorre sem erros.
  - O sistema gera e exibe automaticamente a análise e a recomendação de rotação de cultura.
  - O usuário consegue visualizar os dados da plantação cadastrada na página da plantação.
  - Todo o processo ocorre em menos de 7 minutos, sem necessidade de assistência.

---

### Cenário 8 – Cadastrar compra de insumos
- **Objetivo:** Verificar se o gestor consegue cadastrar compra de insumos.  
- **Contexto:** O gestor deseja cadastrar compra de insumos.  
- **Tarefas:**  
  1. Acessar o menu **Gerenciar compra de insumos**.  
  2. Clicar em **Cadastrar compra de insumos**.  
  3. Preencher os campos: Nome, Quantidade, Unidade de Medida.  
  4. Confirmar cadastro.  
- **Critérios de Sucesso:**  
  - Insumo aparece na lista.  
  - Informações cadastradas são exibidas corretamente. 

---

### Cenário 9 – Cadastrar metas de Produção
- **Objetivo:** Verificar se o Gestor consegue cadastrar as metas de produção.
- **Contexto:** O Gestor necessita ter o controle das metas de produção e para isso ele necessita cadastrar uma meta.
- **Tarefas:**  
  1. Acessar o menu **Gerenciar Metas de Produção**.  
  2. Clicar em **Cadastrar Metas de Produção**.  
  3. Preencher os campos: Data Início, Data Fim, Cultura e Quantidade
  4. Clicar em **Cadastrar**.  
- **Critérios de Sucesso:**  
  - Após o cadastro a meta cadastrada deve ser exibida na listagem
  - Informações cadastradas devem ser exibidas corretamente.  

### Cenário 10 – Visualizar vendas
- **Objetivo:** Verificar se o Gestor consegue gerenciar as vendas a partir das listagens.
- **Contexto:** O Gestor necessita ter o controle das vendas da plantação.
- **Tarefas:**  
  1. Acessar o menu **Gerenciar vendas**.  
  2. **Acessar listagem das vendas**.
- **Critérios de Sucesso:**  
  - Deverá ser exibida a listagem atualizada das vendas.
  - Deveram ser exibidas as opções de atualizar e remover habilitadas em cada venda.


## Cenário 11 - Upload Imagem Fazenda

**Objetivo:** Avaliar a facilidade e eficiência do usuário adicionar uma Imagem da Fazenda

**Contexto:** O usuário desejar fazer upload de uma  imagem da fazenda para ter uma visualização geral da sua propriedade. 

**Tarefa(s):** 
- Acessar o site e localiza a aba de gerenciar imagens.
- Clicar na aba  Anexar Imagem da Fazenda.
- Clicar ou arrastar um imagem  para o modal de upload de imagem.
- Clicar no botão  "confirmar envio" e visualizar a confirmação.

**Critério(s) de Sucesso(s):**
- Fazer upload de imagem
- Mensagem de sucesso de envio


## Cenário 12 - Upload Imagem Plantação

**Objetivo:** Avaliar a facilidade e eficiência do usuário adicionar uma Imagem da Plantação.

**Contexto:** O usuário desejar fazer upload de uma  imagem de uma plantação para ter uma visualização geral da sua propriedade. 

**Tarefa(s):** 
- Acessar o site e localiza a aba de gerenciar imagens.
- Clicar na aba  Anexar Imagem da Plantação
- Selecionar a plantação que deseja fazer upload da imagem.
- Clicar ou arrastar um imagem  para o modal de upload de imagem.
- Clicar no botão  "confirmar envio" e visualizar a confirmação.

**Critério(s) de Sucesso(s):**
- Fazer upload de imagem
- Mensagem de sucesso de envio