namespace SP3064751MVCDB.Models;

public class Livro
{
    public int      LivroId { get; set; }
    public int      EditoraId { get; set; }
    public string   CategoriaLivro { get; set; }
    public string   PrecoLivro { get; set; }
    public string      TituloLivro { get; set; }
    public int      IsbnLivro { get; set; }

    public Livro() { }

    public Livro(int livroid, int editoraid, string categorialivro, string precolivro, string titulolivro, int isbnlivro)
    {
        LivroId             = livroid;
        EditoraId          = editoraid;
        CategoriaLivro           = categorialivro;
        PrecoLivro                 = precolivro;
        TituloLivro    = titulolivro;
        IsbnLivro      = isbnlivro;
    }
}
