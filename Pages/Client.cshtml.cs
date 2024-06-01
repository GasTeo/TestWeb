using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAppWeb.Model;
using TestAppWeb.Repository;

namespace TestAppWeb.Pages
{
    public class ClientModel : PageModel
    {
        public ClientModel(IMarlboro clientRepository)
        {
            _clientRepository = clientRepository;
        }
        private IMarlboro _clientRepository;
        public Marlboro? Client { get; set; }
        public IActionResult OnGet(int id = 1)
        {
            Client = _clientRepository.Get(id);
            if (Client == null) return NotFound(); 
            return Page(); 
        }
    }
}