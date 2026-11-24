
---

## Organização e Regras do Grupo

Para garantir uma boa organização e comunicação entre todos os elementos, devem ser respeitadas as seguintes regras:

- **README.md:** Utilizar este documento para consultar informações gerais e a divisão de responsabilidades.
- **Trello:** Todas as tarefas devem ser organizadas e acompanhadas através do Trello. Cada membro deve atualizar o estado das suas tarefas.
- **GitHub:** Atualizar regularmente o repositório com as alterações realizadas.
- **Inteligência Artificial:** Utilizar a IA como ferramenta de apoio à aprendizagem e desenvolvimento. Pode ser utilizada para obter exemplos de código, esclarecer dúvidas e resolver problemas, mas não para realizar o trabalho integralmente por nós. É importante compreender e testar todo o código utilizado.
- **Word:** Utilizar o Word para atualizar as informações do progresso que fizeram durante as aulas com Data do dia que o fizeram caso a pessoa não atualizar o word é contado como não ter feito nada.

---

## Divisão de Trabalhos

### Membro 1 — Gurkirat Singh

**Responsabilidade: Modelação de Dados**

Responsável pela estruturação do modelo orientado a objetos e pela criação das classes principais do projeto.

**Áreas de responsabilidade:**
- Estrutura e organização das classes.
- Modelação de Campeonatos, Torneios, Equipas e Jogadores.
- Definição das propriedades e relações entre objetos.
- Estruturação das coleções de dados.

---
### Membro 2 — Victoria Cholby

**Responsabilidade: Manipulação e Persistência XML**

Responsável pela leitura, escrita, edição e gestão dos dados armazenados em ficheiros XML.

**Áreas de responsabilidade:**
- Importação e leitura de ficheiros XML.
- Exportação e criação de documentos XML.
- Edição de elementos e atributos.
- Guardar e atualizar informações nos ficheiros.

---

### Membro 3 — Henrique Isabel

**Responsabilidade: Manipulação e Persistência JSON**

Responsável pela leitura, escrita e gestão dos dados armazenados em ficheiros JSON.

**Áreas de responsabilidade:**
- Serialização de objetos para JSON.
- Desserialização de ficheiros JSON.
- Exportação e importação de dados.
- Integração dos dados na aplicação.
- Registo de eventos e erros (Log): criação da classe `Log`, que guarda no ficheiro `log.txt` as ações do programa (importações e exportações) e os erros capturados nos `try/catch`, com data e hora.

**Como usar o Log:**
- Evento normal: `Log.Escrever("Importou JSON: " + caminho);`
- Erro (dentro do `catch`): `Log.EscreverErro("nomeDoBotao", ex);`
- O ficheiro `log.txt` fica na pasta `bin\Debug`, junto do `.exe`.

---

### Membro 4 — Leonardo Viana

**Responsabilidade: Interface, Validações e Consultas LINQ**

Responsável pela lógica de negócio, consultas, validações e apresentação dos dados ao utilizador.

**Áreas de responsabilidade:**
- Consultas e pesquisas utilizando LINQ.
- Cálculo de estatísticas dos campeonatos e torneios.
- Validação dos dados importados e introduzidos.
- Apresentação e visualização dos resultados.
- Organização da interação com o utilizador.

---

## Tecnologias e Ferramentas

| Tecnologia | Utilização |
|:---|:---|
| C# | Linguagem de programação |
| XML | Armazenamento e manipulação de dados |
| JSON | Serialização e desserialização |
| LINQ | Consultas e filtragem de dados |
| GitHub | Gestão e partilha do código |
| Trello | Organização das tarefas |

---

## Acompanhamento do Projeto

O desenvolvimento deve ser acompanhado regularmente através do Trello e do GitHub.

Todos os membros são responsáveis por manter o seu trabalho atualizado e comunicar alterações importantes aos restantes elementos.

**Objetivo:** Garantir uma boa distribuição do trabalho, organização e colaboração entre todos os membros.
