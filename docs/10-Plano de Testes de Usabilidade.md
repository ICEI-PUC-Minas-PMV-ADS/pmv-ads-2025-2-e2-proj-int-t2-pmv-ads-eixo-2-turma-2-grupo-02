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
  - O usuário insere os dados nos campos corretos sem hesitação.
  - O usuário não expressa nenhuma confusão sobre o que fazer na tela.

## Cenário 2 – Recuperação de acesso  
- **Objetivo:** Testar a facilidade de encontrar a opção de recuperação e a confiança do usuário no processo.  
- **Contexto:** Passaram-se algumas semanas e você esqueceu completamente a sua senha. Você precisa urgentemente acessar o sistema para verificar uns dados, mas não consegue logar.  
- **Tarefas:**  
  1. Identificar o link **"Esqueceu a senha?"** na tela de login.  
  2. Clicar no link para iniciar o processo de recuperação.  
  3. Preencher o campo solicitado com o **e-mail cadastrado**.  
  4. Confirmar a solicitação para receber as instruções de redefinição. 
- **Critérios de Sucesso:**  
  - O usuário localiza o link **"Esqueceu a senha?"** em menos de 10 segundos.  
  - O usuário entende que precisa inserir o e-mail para receber as instruções.  
  - O usuário expressa confiança de que, ao fazer isso, conseguirá resolver o problema.

## Cenário 3 – Cadastrar um novo membro da equipe  
- **Objetivo:** Avaliar a facilidade e a eficiência do fluxo de cadastro de um novo usuário pelo administrador.  
- **Contexto:** Você é o administrador do sistema. Uma nova técnica agrícola foi contratada. Você precisa criar uma conta para ela para que possa registrar as visitas de campo. 
- **Tarefas:**  
  1. Acessar a área **Gerenciar Usuários** no sistema.  
  2. Selecionar a opção **Adicionar Novo Usuário**.  
  3. Preencher os campos obrigatórios (nome, e-mail, cpf e matricula).  
  4. Definir o cargo da nova usuária como **Técnico Agrícola**.  
  5. Salvar o cadastro para concluir o processo.    
- **Critérios de Sucesso:**  
  - O usuário encontra a área de **"Gerenciar Usuários"** e o botão para criar um novo usuário sem ajuda.
  - O preenchimento do formulário é fluido, sem pausas longas ou dúvidas sobre os campos.
  - A tarefa é concluída em menos de 2 minutos.

## Cenário 4 – Atualizar o cargo de um usuário  
- **Objetivo:** Garantir que o processo de edição de um usuário existente seja intuitivo.  
- **Contexto:** Um colaborador foi promovido. O cargo dele está desatualizado no sistema e você, como administrador, precisa corrigir isso.  
- **Tarefas:**  
  1. Localizar o usuário na área **Gerenciar Usuários** no sistema.  
  2. Clicar no botão ou ícone **Atualizar** associado ao cadastro.  
  3. Alterar o campo **Cargo** para **Técnico Agrícola**.  
  4. Clicar no botão de **Atualizar**.
  5. Salvar as alterações realizadas.
- **Critérios de Sucesso:**  
  - O usuário identifica rapidamente o botão/ícone para **Atualizar**.  
  - O usuário identifica o campo de cargo em menos de 10 segundos.
  - O usuário sente confiança de que a informação foi atualizada com sucesso. 

## Cenário 5 – Desligar um funcionário do sistema  
- **Objetivo:** Testar a clareza do processo de exclusão.  
- **Contexto:** Um funcionário não trabalha mais na fazenda. Por razões de segurança, o acesso dele ao AGRINOV precisa ser removido o mais rápido possível.  
- **Tarefas:**  
  1. Localizar o usuário na área **Gerenciar Usuários** no sistema.
  2. Selecionar a opção **Deletar**.  
  3. Ler atentamente a mensagem de confirmação exibida.  
  4. Confirmar a exclusão para finalizar o processo.  
- **Critérios de Sucesso:**  
  - O usuário encontra a opção para remover o usuário facilmente.  
  - Ele lê a mensagem de confirmação antes de prosseguir, entendendo a consequência do ato.  
  - A tarefa é completada com uma sensação de segurança no processo. 

## Cenário 6 – Cadastrar uma nova área de plantio  
- **Objetivo:** Verificar a clareza dos campos de cadastro de uma nova propriedade.  
- **Contexto:** A cooperativa fechou parceria com uma nova propriedade. Você precisa cadastrá-la no sistema para que as operações de campo possam ser gerenciadas.  
- **Tarefas:**  
  1. Acessar a seção **Propriedade Agrícola** no sistema. 
  2. Preencher os campos obrigatórios do formulário (nome da propriedade, cnpj, área, imagem, localização, tipos de solo e tamanho hectares).  
  3. Salvar o cadastro para concluir a inclusão da propriedade.    
- **Critérios de Sucesso:**  
  - Todo o processo ocorre em menos de 5 minutos.
  - A tarefa é completada com uma sensação de segurança no processo.
  - Se houver um erro no cadastro aparece uma mensagem informando o problema.
  - Se o cadastro for feito com corretamente aparece uma mensagem de sucesso.

## Cenário 7 - Cadastrar de plantação

- **Objetivo:** Avaliar a facilidade e eficiência do usuário em cadastrar uma nova plantação.
- **Contexto:** O usuário é um técnico agrícola que deseja registrar uma nova plantação em uma das áreas de plantio da própriedade agrícola.
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
- **Critério(s) de Sucesso(s):**
  - Todo o processo ocorre em menos de 5 minutos.
  - A tarefa é completada com uma sensação de segurança no processo.
  - Se houver um erro no cadastro aparece uma mensagem informando o problema.
  - Se o cadastro for feito com corretamente aparece uma mensagem de sucesso.

## Cenário 8 – Cadastrar compra de insumos
- **Objetivo:** Avaliar a facilidade e eficiência do usuário em cadastrar compra de insumos.
- **Contexto:** O gestor deseja cadastrar compra de insumos.  
- **Tarefas:**  
  1. Acessar o menu **Gerenciar compra de insumos**.  
  2. Clicar em **Cadastrar compra de insumos**.  
  3. Preencher os campos: Nome, Quantidade, Unidade de Medida.  
  4. Clicar no botão de **Cadastrar**.  
- **Critérios de Sucesso:**
  - Todo o processo ocorre em menos de 2 minutos.
  - A tarefa é completada com uma sensação de segurança no processo.
  - Se houver um erro no cadastro aparece uma mensagem informando o problema.
  - Se o cadastro for feito com corretamente aparece uma mensagem de sucesso.

## Cenário 9 – Cadastrar metas de produção
- **Objetivo:** Avaliar a facilidade e eficiência do usuário em cadastrar as metas de produção.
- **Contexto:** O Gestor necessita ter o controle das metas de produção e para isso ele necessita cadastrar uma meta.
- **Tarefas:**  
  1. Acessar o menu **Gerenciar Metas de Produção**.  
  2. Clicar em **Cadastrar Metas de Produção**.  
  3. Preencher os campos: Data Início, Data Fim, Cultura e Quantidade
  4. Clicar em **Cadastrar**.  
- **Critérios de Sucesso:**  
  - Todo o processo ocorre em menos de 3 minutos.
  - A tarefa é completada com uma sensação de segurança no processo.
  - Se houver um erro no cadastro aparece uma mensagem informando o problema.
  - Se o cadastro for feito com corretamente aparece uma mensagem de sucesso.

## Cenário 10 – Visualizar relatório de vendas
- **Objetivo:** Avaliar se o gestor consegue entender as informações do relatório de vendas com facilidade.
- **Contexto:** O Gestor necessita acessar o relatório de vendas da propriedade.
- **Tarefas:**  
  1. Acessar o menu **Gerenciar vendas por plantio**.  
  1. Clicar no botão **Visualizar relatório**.   
- **Critérios de Sucesso:**  
  - O usuário consegue entender os simbolos dos relatórios.
  - As informações são relevantes para o usuário.

## Cenário 11 - Upload Imagem Fazenda
- **Objetivo:** Avaliar a facilidade e eficiência do usuário adicionar uma imagem da fazenda
- **Contexto:** O usuário desejar fazer upload de uma  imagem da fazenda para ter uma visualização geral da sua propriedade. 
- **Tarefa(s):** 
  - Acessar o site e localiza a aba de gerenciar imagens.
  - Clicar na aba  Anexar Imagem da Fazenda.
  - Clicar ou arrastar um imagem  para o modal de upload de imagem.
  - Clicar no botão  "confirmar envio" e visualizar a confirmação.
- **Critério(s) de Sucesso(s):**
  - Se houver um erro no upload aparece uma mensagem informando o problema.
  - Se o upload for feito com corretamente aparece uma mensagem de sucesso.

## Cenário 12 - Upload Imagem Plantação
- **Objetivo:** Avaliar a facilidade e eficiência do usuário adicionar uma imagem da plantação.
- **Contexto:** O usuário desejar fazer upload de uma  imagem de uma plantação para ter uma visualização geral da sua propriedade. 
- **Tarefa(s):** 
  - Acessar o site e localiza a aba de gerenciar imagens.
  - Clicar na aba  Anexar Imagem da Plantação
  - Selecionar a plantação que deseja fazer upload da imagem.
  - Clicar ou arrastar um imagem  para o modal de upload de imagem.
  - Clicar no botão  "confirmar envio" e visualizar a confirmação.
- **Critério(s) de Sucesso(s):**
  - Se houver um erro no upload aparece uma mensagem informando o problema.
  - Se o upload for feito com corretamente aparece uma mensagem de sucesso.
