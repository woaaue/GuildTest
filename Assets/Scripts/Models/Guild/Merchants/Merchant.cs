public abstract class Merchant
{   
    public abstract MerchantType Type { get; }
    public abstract int Purse { get; }
    public bool IsHonestCooperation => _isHonestCooperation;

    protected Bank _bank;
    protected bool _isHonestCooperation;
    protected int _errorProbability = UnityEngine.Random.Range(0, 101);

    public virtual void MakeDeal(Merchant merchant, int numberTransactions)
    {
        bool honestCooperation = _isHonestCooperation;

        if (_errorProbability < 6)
            honestCooperation = !honestCooperation;

        if (honestCooperation && merchant.IsHonestCooperation)
        {
            _bank.AddValue(4);
            GetBank(merchant).AddValue(4);
        }
        else if (honestCooperation && !merchant.IsHonestCooperation)
        {
            _bank.AddValue(1);
            GetBank(merchant).AddValue(5);
        }
        else if (!honestCooperation && merchant.IsHonestCooperation)
        {
            _bank.AddValue(5);
            GetBank(merchant).AddValue(1);
        }
        else if (!honestCooperation && !merchant.IsHonestCooperation)
        {
            _bank.AddValue(2);
            GetBank(merchant).AddValue(2);
        }
    }

    public Bank GetBank(Merchant merchant)
    {
        return merchant._bank;
    }
}
