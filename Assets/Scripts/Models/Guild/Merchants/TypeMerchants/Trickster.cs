public sealed class Trickster : Merchant
{
    public override MerchantType Type => MerchantType.Trickster;

    public override int Purse => _bank.GetBalance();

    public Trickster()
    {
        _bank = new Bank();
        _isHonestCooperation = true;
    }

    public override void MakeDeal(Merchant merchant, int numberTransactions)
    {
        for (int i = 0; i < numberTransactions; ++i)
        {
            base.MakeDeal(merchant, numberTransactions);

            _isHonestCooperation = merchant.IsHonestCooperation;
        }
    }
}
