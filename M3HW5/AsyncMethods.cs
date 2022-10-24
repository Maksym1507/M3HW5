namespace M3HW5
{
    public class AsyncMethods
    {
        private string _path = "C:\\Users\\Maksym\\Desktop\\курсы\\ДЗ№2\\M3HW5\\M3HW5\\Files\\";

        public async Task<string> HelloWorldAsync()
        {
            var hello = await HelloAsync();
            var world = await WorldAsync();

            return $"{hello} {world}";
        }

        private async Task<string> HelloAsync()
        {
            using (var sr = new StreamReader($"{_path}\\hello.txt"))
            {
                return await sr.ReadToEndAsync();
            }
        }

        private async Task<string> WorldAsync()
        {
            using (var sr = new StreamReader($"{_path}\\world.txt"))
            {
                return await sr.ReadToEndAsync();
            }
        }
    }
}
