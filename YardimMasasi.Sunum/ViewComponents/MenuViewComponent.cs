using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace YardimMasasi.Sunum.ViewComponents
{
	public class MenuViewComponent : ViewComponent
	{
		private readonly IHttpContextAccessor _context;
        public MenuViewComponent(IHttpContextAccessor context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
            if(_context.HttpContext == null || !_context.HttpContext.Session.Keys.Any(a=>a.Equals("userMenu")))
            {
                return View(new List<KeyValuePair<string, string>>());
            }

            var menuJson = _context.HttpContext.Session.GetString("userMenu");
            var menu = JsonConvert.DeserializeObject<List<KeyValuePair<string,string>>>(menuJson);

            return View(menu);
		}
	}
}
