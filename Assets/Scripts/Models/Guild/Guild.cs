using System;
using System.Collections.Generic;

public sealed class Guild
{
    public List<Merchant> _merchantList { get; private set; }

    private int _guildSize;
    private int _ageOfGuild;
    private float _percentageSuccessfulMerchants;

    public Guild()
    {
        _guildSize = 60;
        _ageOfGuild = 0;
        _percentageSuccessfulMerchants = .2f;

        FillGuild();
    }

    public void SimulationYear()
    {
        if (_ageOfGuild > 0)
        {
            EliminateMerchants();
            AddNewMerchants();
        }

        for (int i = 0; i < _merchantList.Count - 1; ++i)
        {
            for (int y = i + 1; y < _merchantList.Count; ++y)
            {
                _merchantList[i].MakeDeal(_merchantList[y], UnityEngine.Random.Range(5, 11));
            }
        }

        SortMerchantsByProfit();

        _ageOfGuild++;
    }

    private void FillGuild()
    {
        _merchantList = new List<Merchant>();
        
        for (int i = 0; i < 10; ++i)
        {
            AddMerchant(new Altruist());
            AddMerchant(new Hustler());
            AddMerchant(new Trickster());
            AddMerchant(new Unpredictable());
            AddMerchant(new Vindictive());
            AddMerchant(new Clever());
        }
    }

    private void SortMerchantsByProfit()
    {
        for (int i = 0; i < _merchantList.Count - 1; ++i)
        {
           for (int y = i + 1; y < _merchantList.Count; ++y)
           {
                if (_merchantList[i].Purse < _merchantList[y].Purse)
                {
                    var merchant = _merchantList[i];
                    _merchantList[i] = _merchantList[y];
                    _merchantList[y] = merchant;    
                }
           }
        }
    }

    private void EliminateMerchants()
    {
        int countEliminate = Convert.ToInt32(_guildSize * _percentageSuccessfulMerchants);

        for (int i = 0; i < countEliminate; i++)
        {
            _merchantList.RemoveAt(_merchantList.Count - 1);
        }
    }

    private void AddNewMerchants()
    {
        int countAdd = Convert.ToInt32(_guildSize * _percentageSuccessfulMerchants);

        for (int i = 0; i < countAdd; i++)
        {
            Type type = _merchantList[i].GetType();
            object newMerchants = Activator.CreateInstance(type);

            AddMerchant((Merchant)newMerchants);
        }
    }


    private void AddMerchant(Merchant merchant)
    {
        _merchantList.Add(merchant);
    }
}
