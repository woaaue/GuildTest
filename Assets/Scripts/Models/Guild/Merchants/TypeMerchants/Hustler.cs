public sealed class Hustler : Merchant
{
    public override MerchantType Type => MerchantType.Hustler;

    public override int Purse => _bank.GetBalance();

    public Hustler()
    {
        _bank = new Bank();
        _isHonestCooperation = false;
    }

    public override void MakeDeal(Merchant merchant, int numberTransactions)
    {
        for (int i = 0; i < numberTransactions; ++i)
        {
            base.MakeDeal(merchant, numberTransactions);
        }
    }
}
