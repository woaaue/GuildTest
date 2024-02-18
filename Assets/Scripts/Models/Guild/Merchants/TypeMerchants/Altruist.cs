public sealed class Altruist : Merchant
{
    public override MerchantType Type => MerchantType.Altruist;

    public override int Purse => _bank.GetBalance();

    public Altruist()
    {
        _bank = new Bank();
        _isHonestCooperation = true;
    }

    public override void MakeDeal(Merchant merchant, int numberTransactions)
    {
        for (int i = 0; i < numberTransactions; ++i)
        {
            base.MakeDeal(merchant, numberTransactions);
        }
    }
}
