namespace SP3064751MVCDB.Models;

public class Editora
{
    public int      EditoraId { get; set; }
    public string   NomeFantasiaEditora { get; set; }
    public string   RazaoSocialEditora { get; set; }
    public string   EnderecoEditora { get; set; }
    public string   TelefoneEditora { get; set; }

    public Editora() { }

    public Editora(int editoraid, string nomefantasiaeditora, string razaosocialeditora, string enderecoeditora, string telefoneeditora)
    {
        EditoraId        = editoraid;
        NomeFantasiaEditora          = nomefantasiaeditora;
        RazaoSocialEditora        = razaosocialeditora;
        EnderecoEditora          = enderecoeditora;
        TelefoneEditora        = telefoneeditora;
    }
}