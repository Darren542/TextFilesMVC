using Microsoft.AspNetCore.Mvc;

namespace TextFilesMVC;

public class FileController : Controller
{
    private readonly ILogger<FileController> _logger;

    private readonly IWebHostEnvironment _env;

    public FileController(ILogger<FileController> logger, IWebHostEnvironment env)
    {
        _logger = logger;
        _env = env;
    }

    public IActionResult Index()
    {
        // _logger.LogInformation(_env.ContentRootPath);

        var path = Path.Combine(_env.ContentRootPath, "TextFiles");
        // _logger.LogInformation(path);
        var files = Directory.GetFiles(path);
        ViewBag.Files = files;
        return View();
    }

}
