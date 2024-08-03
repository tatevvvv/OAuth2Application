using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

public sealed class Program
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to our solution.");

        Console.WriteLine("Press S to sign in or R for Register");
        var result = Console.ReadLine();

        if (result == "S")
        {
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();

            var token = await LoginUser(username, password);
            if (!string.IsNullOrEmpty(token))
            {
                Console.WriteLine("Login successful!");
                Console.WriteLine($"Token: {token}");

                var resourceResult = await AccessProtectedResource(token);
                Console.WriteLine(resourceResult);
            }
            else
            {
                Console.WriteLine("Login failed!");
            }
        }
        else if (result == "R")
        {
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();

            var registerResult = await RegisterUser(username, email, password);
            Console.WriteLine(registerResult ? "User registered successfully!" : "User registration failed!");

            if (!registerResult)
            {
                return;
            }
        }
    }

    private static async Task<bool> RegisterUser(string username, string email, string password)
    {
        var payload = new { Username = username, Email = email, Password = password };
        var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

        var response = await client.PostAsync("https://localhost:5001/api/auth/register", content);
        return response.IsSuccessStatusCode;
    }

    private static async Task<string> LoginUser(string username, string password)
    {
        var payload = new { Username = username, Password = password };
        var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

        var response = await client.PostAsync("https://localhost:5001/api/auth/login", content);
        if (response.IsSuccessStatusCode)
        {
            var result = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
            return result.token;
        }
        return null;
    }

    private static async Task<string> AccessProtectedResource(string token)
    {
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await client.GetAsync("https://localhost:5001/api/resource");
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        return "Access to protected resource failed.";
    }
}
