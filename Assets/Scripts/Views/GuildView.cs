using TMPro;
using UnityEngine;
using System.Collections.Generic;

public sealed class GuildView : MonoBehaviour
{
    [SerializeField] private GuildController _controller;
    [SerializeField] private List<GameObject> _merchantData;

    public void GetMerchantsData(List<Merchant> merchantsList)
    {
        FillView(merchantsList);
    }

    private void FillView(List<Merchant> merchantsList)
    {
        for (int i = 0; i < merchantsList.Count; i++)
        {
            _merchantData[i].transform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().text = (i + 1).ToString();
            _merchantData[i].transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = merchantsList[i].Type.ToString();
            _merchantData[i].transform.GetChild(2).GetComponentInChildren<TextMeshProUGUI>().text = merchantsList[i].Purse.ToString();
        }
    }



}
