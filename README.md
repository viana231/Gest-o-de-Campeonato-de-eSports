[Trabalho PSI1- Divisão de Trabalhos.txt](https://github.com/user-attachments/files/34811923/Trabalho.PSI1-.Divisao.de.Trabalhos.txt)
Utilizem este README.md para colocar informações ou algo do género, não se esqueçam de irem atualizando enquanto fazem o trabalho para os outros terem o trabalho atualizado 

Trabalho PSI1- Divisão de Trabalhos

Membro 1: 
 - Modelação de Dados e Estrutura de ClassesResponsável por garantir que a base do projeto (o modelo orientado a objetos) está corretamente estruturada.Análise inicial: Analisar exaustivamente os ficheiros XML e JSON de exemplo fornecidos pelo docente para mapear todos os campos necessários.
 - Implementação de Classes: Criar em C# as classes do domínio do torneio: Campeonato, Torneio, Equipa e Jogador, definindo corretamente as propriedades (ex: IDs, nomes, estatísticas) e as relações hierárquicas entre elas (ex: um campeonato tem vários torneios, um torneio tem várias equipas, uma equipa tem vários jogadores).
 - Testes unitários do modelo: Garantir que a criação de instâncias e coleções (List<T>) funciona sem erros de compilação.

Membro 2: 
 - Módulo de Manipulação e Persistência XMLResponsável por toda a interceção e gestão de dados baseados em ficheiros XML.
 - Importação e Leitura: Implementar a leitura de dados a partir de ficheiros XML utilizando XDocument e XElement, convertendo os elementos do ficheiro em objetos C#.
 - Escrita e Exportação: Desenvolver as funções para criar novos documentos XML ou atualizar os existentes.
 - Edição Direta: Programar a lógica para procurar registos específicos no XML (recorrendo a atributos ou elementos) e alterar os seus valores diretamente no ficheiro (ex: atualizar dados de uma equipa ou jogador) antes de guardar (doc.Save()).   

Membro 3:
 - Módulo de Manipulação e Persistência JSONResponsável por toda a interceção e gestão de dados baseados em ficheiros JSON.
 - Serialização: Implementar a conversão das estruturas de classes C# (como listas de equipas ou torneios) em texto JSON estruturado utilizando o JsonSerializer (com opções de indentação para facilitar a leitura).
 - Desserialização: Programar a leitura de ficheiros JSON e a sua respetiva conversão de volta para objetos e listas em C#.   Sincronização: Garantir que os dados lidos do JSON são validados e integrados corretamente na aplicação.

Membro 4:
 - Interface, Validações e Consultas LINQResponsável pela lógica de negócio avançada, relatórios e interação com o utilizador.Consultas LINQ e Estatísticas: Desenvolver as pesquisas avançadas exigidas no projeto, utilizando LINQ para filtrar equipas, ordenar jogadores ou calcular estatísticas do torneio (ex: melhores marcadores, total de pontos, equipas em destaque).    
 - Validações de Dados: Implementar validações rigorosas para evitar erros de dados corrompidos ou inserções inválidas (tanto na importação como na edição manual).
 - Interface / Apresentação: Coordenar a exibição dos resultados (seja em consola ou interface gráfica, como o uso de DataGridView), permitindo visualizar de forma clara os dados importados via XML e JSON.
