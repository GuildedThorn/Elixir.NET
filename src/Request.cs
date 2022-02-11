namespace Elixir.NET; 

public class Request {

    private ElixirAPI _api;
    private string _url;

    private Request(ElixirAPI api, string endpoint) {
        _api = api;
        _url = ElixirAPI.EndPointUrl + endpoint;
    }
    
    
}