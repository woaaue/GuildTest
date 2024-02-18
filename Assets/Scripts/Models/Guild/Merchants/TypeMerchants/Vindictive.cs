public sealed class Vindictive : Merchant
{
    public override MerchantType Type => MerchantType.Vindictive;

    public override int Purse => _bank.GetBalance();

    public Vindictive()
    {
        _bank = new Bank();
        _isHonestCooperation = true;
    }

    public override void MakeDeal(Merchant merchant, int numberTransactions)
    {
        for (int i = 0; i < numberTransactions; ++i)
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

                _isHonestCooperation = false;
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

                _isHonestCooperation = false;
            }
        }
    }
}
