namespace Elixir.NET.requests; 

public class PlayerRequest {

    private ElixirAPI _api;
    private string _guildid, _track;
    private Action _action;
    
    private PlayerRequest(ElixirAPI api, string guildid, Action action, string track) {
        _api = api;
        _guildid = guildid;
        _track = track;
        _action = action;
    }
    
    
}