using System;
using System.Collections.Generic;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }
    
    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }
    
    public int ObterQuantidadeDeAlunosMatriculados()
    {
        int quantidade = Alunos.Count;
        
        return quantidade;
    }
    
    public bool RemoverAluno(Pessoa aluno)
    {
        return Alunos.Remove(aluno);
    }
    
    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos do curso de: {Nome}");
        
        for(int count = 0; count < Alunos.Count; count++)
        {
            string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
            
            Console.WriteLine(texto);
        }
    }
}