using System;

namespace M9_Ficha05_Ex4_Alunos
{
 public class Aluno
 {
 private int numero;
 private string nome;

 public Aluno()
 {
 numero =0;
 nome = "";
 }

 public Aluno(int novoNum, string novoNome)
 {
 numero = novoNum;
 nome = novoNome ?? "";
 }

 public int getNumero() => numero;
 public void setNumero(int n) => numero = n;
 public string getNome() => nome;
 public void setNome(string n) => nome = n;

 public override string ToString() => $"Número: {numero}, Nome: {nome}";
 }
}