using Microsoft.AspNetCore.Mvc;
using SP3064751MVCDB.Models;

namespace SP3064751MVCDB.Controllers;

public class LivroController : Controller
{
    private readonly MvcDBContext _context;

    public LivroController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        return View(_context.Livro);
    }

    public IActionResult Show(int livroid)
    {
        Livro? livro =_context.Livro.Find(livroid);

        if(livro == null)
        {
            return NotFound();
        }
        return View(livro);
    }

    public IActionResult Create(){
                
        return View();
    }

    public IActionResult CreateResult(int livroid, int editoraid, string categorialivro, string precolivro, string titulolivro, int isbnlivro)
    {
        if(_context.Livro.Find(livroid) == null)
        {
            _context.Livro.Add(new Livro(livroid, editoraid, categorialivro, precolivro, titulolivro, isbnlivro));
            _context.SaveChanges();
            return RedirectToAction("Create");
        }
        else
        {
           return Content("Já existe um livro com esse id");
        }
       
    }

    public IActionResult Delete(int livroid){
        _context.Livro.Remove(_context.Livro.Find(livroid));
        _context.SaveChanges();
        return View();
    }

    public IActionResult Update(int livroid)
    {
        Livro livro = _context.Livro.Find(livroid);
        if(livro == null)
        {
            return Content("Esse livro não existe!");
        }
        else
        {
           return View(livro);
        }
    }

    public IActionResult UpdateResult(int livroid, int editoraid, string categorialivro, string precolivro, string titulolivro, int isbnlivro)
    {
        Livro livro = _context.Livro.Find(livroid);

        livro.LivroId             = livroid;
        livro.EditoraId          = editoraid;
        livro.CategoriaLivro           = categorialivro;
        livro.PrecoLivro                 = precolivro;
        livro.TituloLivro    = titulolivro;
        livro.IsbnLivro      = isbnlivro;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
}