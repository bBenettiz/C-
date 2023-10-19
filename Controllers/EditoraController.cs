using Microsoft.AspNetCore.Mvc;
using SP3064751MVCDB.Models;
namespace SP3064751MVCDB.Controllers;
public class EditoraController : Controller
{
    private readonly MvcDBContext _context;

    public EditoraController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Editora);
    }

    public IActionResult Show(int editoraid)
    {
        Editora? editora =_context.Editora.Find(editoraid);

        if(editora == null)
        {
            return NotFound();
        }
        return View(editora);
    }

    public IActionResult Create()
    {      
        return View();
    }

    public IActionResult CreateResult(int editoraid, string nomefantasiaeditora, string razaosocialeditora, string enderecoeditora, string telefoneeditora)
    {
        if(_context.Editora.Find(editoraid) == null)
        {
            _context.Editora.Add(new Editora( editoraid, nomefantasiaeditora, razaosocialeditora, enderecoeditora, telefoneeditora));
            _context.SaveChanges();
            return RedirectToAction("Create");
        }
        else
        {
           return Content("Já existe uma editora com esse id.");
        }
       
    }

    public IActionResult Delete(int editoraid)
    {
        _context.Editora.Remove(_context.Editora.Find(editoraid));
        _context.SaveChanges();
        return View();
    }

    public IActionResult Update(int editoraid)
    {
        Editora editora = _context.Editora.Find(editoraid);
        if(editora == null)
        {
            return Content("Essa editora não existe.");
        }
        else
        {
           return View(editora);
        }
    }

    public IActionResult UpdateResult(int editoraid, string nomefantasiaeditora, string razaosocialeditora, string enderecoeditora, string telefoneeditora)
    {
        Editora editora = _context.Editora.Find(editoraid);

        editora.EditoraId        = editoraid;
        editora.NomeFantasiaEditora          = nomefantasiaeditora;
        editora.RazaoSocialEditora        = razaosocialeditora;
        editora.EnderecoEditora          = enderecoeditora;
        editora.TelefoneEditora        = telefoneeditora;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }   
}