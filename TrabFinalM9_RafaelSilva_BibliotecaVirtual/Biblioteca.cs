using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace M9_Ficha05_Ex4_Alunos
{
 public class Biblioteca
 {
 private readonly List<Livro> livros;
 private readonly List<Aluno> alunos;
 public Biblioteca()
 {
 livros = new List<Livro>();
 alunos = new List<Aluno>();
 }
 public void AddLivro(Livro l)
 {
 if (l == null) throw new ArgumentNullException(nameof(l));
 livros.Add(l);
 }
 public bool RemoveLivro(int id)
 {
 var livro = livros.FirstOrDefault(x => x.getId() == id);
 if (livro == null) return false;
 if (livro.estaEmprestado()) return false;
 livros.Remove(livro);
 return true;
 }
 public IList<Livro> ListarLivros()
 {
 return livros.AsReadOnly();
 }
 public Livro GetLivroById(int id)
 {
 return livros.FirstOrDefault(x => x.getId() == id);
 }
 public void AddAluno(Aluno a)
 {
 if (a == null) throw new ArgumentNullException(nameof(a));
 if (alunos.Any(x => x.getNumero() == a.getNumero())) throw new ArgumentException("Já existe aluno com esse número.");
 alunos.Add(a);
 }
 public IList<Aluno> ListarAlunos()
 {
 return alunos.AsReadOnly();
 }
 public Aluno GetAlunoByNumero(int numero)
 {
 return alunos.FirstOrDefault(x => x.getNumero() == numero);
 }
 public bool Emprestar(int livroId, int alunoNumero, DateTime? data = null)
 {
 var livro = GetLivroById(livroId);
 var aluno = GetAlunoByNumero(alunoNumero);
 if (livro == null || aluno == null) return false;
 return livro.emprestar(aluno, data);
 }
 public bool Devolver(int livroId)
 {
 var livro = GetLivroById(livroId);
 if (livro == null) return false;
 return livro.devolver();
 }
 public void Salvar(string pasta)
 {
 if (!Directory.Exists(pasta)) Directory.CreateDirectory(pasta);
 string livrosPath = Path.Combine(pasta, "livros.csv");
 string alunosPath = Path.Combine(pasta, "alunos.csv");
 using (var sw = new StreamWriter(alunosPath, false, System.Text.Encoding.UTF8))
 {
 foreach (var a in alunos)
 {
 sw.WriteLine($"{a.getNumero()}|{Escape(a.getNome())}");
 }
 }
 using (var sw = new StreamWriter(livrosPath, false, System.Text.Encoding.UTF8))
 {
 foreach (var l in livros)
 {
 int emprestadoNum = l.getAlunoEmprestado() != null ? l.getAlunoEmprestado().getNumero() :0;
 long ticks = l.getDataEmprestimo() != DateTime.MinValue ? l.getDataEmprestimo().Ticks :0;
 sw.WriteLine($"{l.getId()}|{Escape(l.getTitulo())}|{Escape(l.getAutor())}|{Escape(l.getISBN())}|{l.getAnoPublicacao()}|{(l.estaEmprestado() ?1 :0)}|{emprestadoNum}|{ticks}");
 }
 }
 }
 public void Carregar(string pasta)
 {
 livros.Clear();
 alunos.Clear();
 string livrosPath = Path.Combine(pasta, "livros.csv");
 string alunosPath = Path.Combine(pasta, "alunos.csv");
 if (File.Exists(alunosPath))
 {
 foreach (var line in File.ReadAllLines(alunosPath))
 {
 if (string.IsNullOrWhiteSpace(line)) continue;
 var parts = line.Split(new[] { '|' },2);
 if (parts.Length <2) continue;
 if (!int.TryParse(parts[0], out int numero)) continue;
 string nome = Unescape(parts[1]);
 alunos.Add(new Aluno(numero, nome));
 }
 }
 if (File.Exists(livrosPath))
 {
 foreach (var line in File.ReadAllLines(livrosPath))
 {
 if (string.IsNullOrWhiteSpace(line)) continue;
 var parts = line.Split('|');
 if (parts.Length <8) continue;
 if (!int.TryParse(parts[0], out int id)) continue;
 string titulo = Unescape(parts[1]);
 string autor = Unescape(parts[2]);
 string isbn = Unescape(parts[3]);
 int.TryParse(parts[4], out int ano);
 int.TryParse(parts[5], out int emprestadoFlag);
 int.TryParse(parts[6], out int emprestadoNum);
 long.TryParse(parts[7], out long ticks);
 var livro = new Livro(id, titulo, autor, isbn, ano);
 if (emprestadoFlag ==1 && emprestadoNum !=0)
 {
 var aluno = GetAlunoByNumero(emprestadoNum);
 if (aluno != null)
 {
 DateTime data = ticks !=0 ? new DateTime(ticks) : DateTime.Now;
 livro.emprestar(aluno, data);
 }
 }
 livros.Add(livro);
 }
 }
 }
 private static string Escape(string s)
 {
 if (s == null) return "";
 return s.Replace("|", "&#124;").Replace("\n", "\\n").Replace("\r", "");
 }
 private static string Unescape(string s)
 {
 if (s == null) return "";
 return s.Replace("&#124;", "|").Replace("\\n", "\n");
 }
 }
}