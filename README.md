Trabalho PSI1- Divisão de Trabalhos
Utilizem este README.md para colocar informações ou algo do género, não se esqueçam de irem atualizando enquanto fazem o trabalho para os outros terem o trabalho atualizado, Tambem têm de utilizar o trello para confirmar o que já fizeram!!!

!!! Utilizem inteligencia artificial para fazer o trabalho mas nao para fazer por voces, com isso quero dizer que peçam codigo a ele e copiem nao insiram o trabalho lá e peçam para ele fazer por voces !!!
[Trabalho PSI1- Divisão de Trabalhos aaa.txt](https://github.com/user-attachments/files/34980284/Trabalho.PSI1-.Divisao.de.Trabalhos.aaa.txt)

Membro 1: Gurkirat Singh
 - Modelação de Dados e Estrutura de ClassesResponsável por garantir que a base do projeto (o modelo orientado a objetos) está corretamente estruturada.Análise inicial: Analisar exaustivamente os ficheiros XML e JSON de exemplo fornecidos pelo docente para mapear todos os campos necessários.
 - Implementação de Classes: Criar em C# as classes do domínio do torneio: Campeonato, Torneio, Equipa e Jogador, definindo corretamente as propriedades (ex: IDs, nomes, estatísticas) e as relações hierárquicas entre elas (ex: um campeonato tem vários torneios, um torneio tem várias equipas, uma equipa tem vários jogadores).
 - Testes unitários do modelo: Garantir que a criação de instâncias e coleções (List<T>) funciona sem erros de compilação.

Membro 2: Victoria Cholby
 - Módulo de Manipulação e Persistência XMLResponsável por toda a interceção e gestão de dados baseados em ficheiros XML.
 - Importação e Leitura: Implementar a leitura de dados a partir de ficheiros XML utilizando XDocument e XElement, convertendo os elementos do ficheiro em objetos C#.
 - Escrita e Exportação: Desenvolver as funções para criar novos documentos XML ou atualizar os existentes.
 - Edição Direta: Programar a lógica para procurar registos específicos no XML (recorrendo a atributos ou elementos) e alterar os seus valores diretamente no ficheiro (ex: atualizar dados de uma equipa ou jogador) antes de guardar (doc.Save()).   

Membro 3: Henrique Isabel
 - Módulo de Manipulação e Persistência JSONResponsável por toda a interceção e gestão de dados baseados em ficheiros JSON.
 - Serialização: Implementar a conversão das estruturas de classes C# (como listas de equipas ou torneios) em texto JSON estruturado utilizando o JsonSerializer (com opções de indentação para facilitar a leitura).
 - Desserialização: Programar a leitura de ficheiros JSON e a sua respetiva conversão de volta para objetos e listas em C#.   Sincronização: Garantir que os dados lidos do JSON são validados e integrados corretamente na aplicação.


---

## Organização e Regras do Grupo

Para garantir uma boa organização e comunicação entre todos os elementos, devem ser respeitadas as seguintes regras:

- **README.md:** Utilizar este documento para consultar informações gerais e a divisão de responsabilidades.
- **Trello:** Todas as tarefas devem ser organizadas e acompanhadas através do Trello. Cada membro deve atualizar o estado das suas tarefas.
- **GitHub:** Atualizar regularmente o repositório com as alterações realizadas.
- **Inteligência Artificial:** Utilizar a IA como ferramenta de apoio à aprendizagem e desenvolvimento. Pode ser utilizada para obter exemplos de código, esclarecer dúvidas e resolver problemas, mas não para realizar o trabalho integralmente por nós. É importante compreender e testar todo o código utilizado.

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
