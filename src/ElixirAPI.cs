namespace Elixir.NET;

public class ElixirAPI {

    private string _apiKey;
    public static string EndPointUrl = "https://app.ponjo.club/elixir/";

    private ElixirAPI(string apiKey) {
        _apiKey = apiKey;
    }

    public static ElixirAPI Create(string apiKey) {
        return new ElixirAPI(apiKey);
    }
}