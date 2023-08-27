using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instacias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Fernando Arruda", "857.032.950-41", "meusarkkivos@gmail.com", "Pingo");
        Cliente cliente2 = new Cliente(02, "William Henry", "039.618.250-09", "bill@microsoft.com", "bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.777.920-50", "ada@adalanguage.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "933.622.400-03", "torvaldis@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        //lista de Clientes e atribuir os clientes
        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);
        listaCliente.Add(cliente5);

        ViewBag.listacliente = listaCliente;

        //Lista do tipo Fornecedor e atribuir os fornecedores 
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-00", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224./0001-83", "boots_pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.768.614/0001-37", "contato@bff.us");

       //Lista de Fornecedor 
       List<Fornecedor> listaFornecedores = new List<Fornecedor>();
       listaFornecedores.Add(fornecedor1);
       listaFornecedores.Add(fornecedor2);
       listaFornecedores.Add(fornecedor3);
       listaFornecedores.Add(fornecedor4);
       listaFornecedores.Add(fornecedor5);

       ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
