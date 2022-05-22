namespace CatalogoWebApp.Services
{
    public class PathResolver : IPathResolver
    {
        private readonly IHttpContextAccessor _context;

        public PathResolver(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string? GetUrl(string imagenPaths)
        {
            if (string.IsNullOrEmpty(imagenPaths)) return null;
            var paths = imagenPaths.Split(";");
            if (paths.Length <= 0) return null;
            var newsPaths = string.Empty;
            var urlBase = $"{_context.HttpContext?.Request.Scheme}://{_context.HttpContext?.Request.Host}";
            newsPaths = paths.Aggregate(newsPaths, (current, path) => current + @$"{urlBase}/{path};");

            return newsPaths.Contains(";") ? newsPaths.Remove((newsPaths.Length - 1)) : newsPaths;
        }
    }
}
