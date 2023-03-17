using exemplo_fundamentos.Models;


Pessoa p1 = new Pessoa(nome: "Cássio", sobrenome: "Daniel");
Pessoa p2 = new Pessoa(nome: "Renato", sobrenome: "Pascarelli");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();