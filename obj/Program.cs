using System;
using System.Collections.Generic;

class Program {
  static void Main() {
    Pessoa p1 = new Pessoa(nome: "Rafael", sobrenome: "Alves");
    Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Nevez Queiroz");
    
    Curso cursoDeIngles = new Curso();
    cursoDeIngles.Nome = "Inglês";
    cursoDeIngles.Alunos = new List<Pessoa>();
    
    cursoDeIngles.AdicionarAluno(p1);
    cursoDeIngles.AdicionarAluno(p2);
    cursoDeIngles.ListarAlunos();
  }
}