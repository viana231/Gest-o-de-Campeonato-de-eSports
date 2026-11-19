# Trabalho PSI1 — Gestão de Campeonatos e Torneios

> Projeto desenvolvido no âmbito da disciplina de PSI1



\


---

## Sobre o Projeto

Este projeto tem como objetivo desenvolver uma aplicação em C# para a gestão de campeonatos, torneios, equipas e jogadores, permitindo manipular, importar, exportar, editar e consultar informações através de ficheiros XML e JSON.

## Organização e Regras do Grupo

Para garantir uma boa organização e comunicação entre todos os elementos, devem ser respeitadas as seguintes regras:

- 📝 **README.md:** Manter este documento atualizado com informações sobre o desenvolvimento do projeto.
- 📋 **Trello:** Utilizar o Trello para acompanhar as tarefas concluídas, em desenvolvimento e por realizar.
- 💻 **GitHub:** Atualizar regularmente o repositório com as alterações realizadas.
- 🤖 **Inteligência Artificial:** Utilizar a IA como ferramenta de apoio à aprendizagem e desenvolvimento. Pode ser utilizada para obter exemplos de código, esclarecer dúvidas e resolver problemas, mas não para realizar o trabalho integralmente por nós. É importante compreender e testar todo o código utilizado.

---

## 👥 Divisão de Trabalhos

| Membro          | Responsabilidade                  | Área         |
| :-------------- | :-------------------------------- | :----------- |
| Gurkirat Singh  | Modelação de Dados                | C# / Classes |
| Victoria Cholby | Manipulação e Persistência XML    | XML          |
| Henrique Isabel | Manipulação e Persistência JSON   | JSON         |
| Leonardo Viana  | Interface, Validações e Consultas | LINQ / C#    |

---

## 👨‍💻 Membro 1 — Gurkirat Singh

**Responsabilidade: Modelação de Dados e Estrutura de Classes**

Responsável por garantir que a base do projeto (modelo orientado a objetos) está corretamente estruturada.

### Tarefas

- [ ] **Análise inicial:** Analisar os ficheiros XML e JSON de exemplo fornecidos pelo docente para identificar todos os campos necessários.
- [ ] **Implementação de Classes:** Criar em C# as classes principais:
  - `Campeonato`
  - `Torneio`
  - `Equipa`
  - `Jogador`
- [ ] **Definição de propriedades:** Criar propriedades como IDs, nomes e estatísticas.
- [ ] **Relações entre classes:** Definir as relações hierárquicas (um campeonato tem vários torneios, um torneio tem várias equipas e uma equipa tem vários jogadores).
- [ ] **Testes do modelo:** Garantir que a criação de objetos e coleções (`List<T>`) funciona corretamente.

---

## 👩‍💻 Membro 2 — Victoria Cholby

**Responsabilidade: Manipulação e Persistência XML**

Responsável pela gestão de dados através de ficheiros XML.

### Tarefas

- [ ] **Importação e Leitura:** Implementar a leitura de ficheiros XML utilizando `XDocument` e `XElement`, convertendo os elementos em objetos C#.
- [ ] **Escrita e Exportação:** Desenvolver funções para criar novos documentos XML ou atualizar os existentes.
- [ ] **Edição Direta:** Implementar a lógica para procurar registos específicos no XML, através de atributos ou elementos, e alterar os respetivos valores.
- [ ] **Gravação:** Garantir que as alterações são guardadas corretamente através de `doc.Save()`.

---

## 👨‍💻 Membro 3 — Henrique Isabel

**Responsabilidade: Manipulação e Persistência JSON**

Responsável pela gestão de dados através de ficheiros JSON.

### Tarefas

- [ ] **Serialização:** Converter estruturas de classes C# (como listas de equipas ou torneios) em texto JSON utilizando `JsonSerializer`.
- [ ] **Formatação:** Utilizar opções de indentação para facilitar a leitura dos ficheiros JSON.
- [ ] **Desserialização:** Implementar a leitura de ficheiros JSON e a conversão dos dados para objetos e listas em C#.
- [ ] **Sincronização:** Garantir que os dados importados são validados e integrados corretamente na aplicação.

---

## 👨‍💻 Membro 4 — Leonardo Viana

**Responsabilidade: Interface, Validações e Consultas LINQ**

Responsável pela lógica de negócio avançada, relatórios e interação com o utilizador.

### Tarefas

- [ ] **Consultas LINQ e Estatísticas:** Desenvolver pesquisas avançadas utilizando LINQ para:
  - Filtrar equipas.
  - Ordenar jogadores.
  - Calcular estatísticas dos torneios.
  - Identificar os melhores marcadores.
  - Calcular o total de pontos.
  - Identificar equipas em destaque.
- [ ] **Validações de Dados:** Implementar validações para evitar dados inválidos ou corrompidos, tanto durante a importação como na edição manual.
- [ ] **Interface / Apresentação:** Coordenar a apresentação dos resultados, seja através da consola ou de uma interface gráfica (por exemplo, `DataGridView`).
- [ ] **Visualização de Dados:** Permitir consultar de forma clara os dados importados através de XML e JSON.

---

## 🛠️ Tecnologias e Ferramentas

| Tecnologia | Utilização                               |
| :--------- | :--------------------------------------- |
| C#         | Linguagem de programação                 |
| XML        | Armazenamento e manipulação de dados     |
| JSON       | Serialização e desserialização           |
| LINQ       | Consultas e filtragem de dados           |
| GitHub     | Gestão e partilha do código              |
| Trello     | Organização e acompanhamento das tarefas |

---

## 📊 Estado do Projeto

| Área               | Responsável     | Estado         |
| :----------------- | :-------------- | :------------- |
| Modelação de Dados | Gurkirat Singh  | 🟡 Por iniciar |
| XML                | Victoria Cholby | 🟡 Por iniciar |
| JSON               | Henrique Isabel | 🟡 Por iniciar |
| Interface / LINQ   | Leonardo Viana  | 🟡 Por iniciar |

**Legenda:**

- 🟡 Por iniciar
- 🔵 Em desenvolvimento
- 🟢 Concluído

---

## 📅 Acompanhamento

Este README deve ser atualizado regularmente por todos os membros do grupo, de forma a manter a informação sobre o desenvolvimento do projeto organizada e acessível.

**Objetivo:** Garantir que todos os elementos sabem o que já foi feito, o que está a ser desenvolvido e quais são as próximas tarefas.
