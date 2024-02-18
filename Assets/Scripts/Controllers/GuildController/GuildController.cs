using UnityEngine;

public sealed class GuildController : MonoBehaviour
{
    [SerializeField] private GuildView _viewGuild;

    private Guild _guild;

    void Start()
    {
        _guild = new Guild();
        ClickSimulation();
    }

    public void ClickSimulation()
    {
        _guild.SimulationYear();
        GetData();
    }

    private void GetData()
    {
        _viewGuild.GetMerchantsData(_guild._merchantList);
    }
}
