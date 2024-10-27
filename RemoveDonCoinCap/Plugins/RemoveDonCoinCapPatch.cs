using HarmonyLib;
using Scripts.Common;
using Scripts.GameSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDonCoinCap.Plugins
{
    internal class RemoveDonCoinCapPatch
    {
        [HarmonyPatch(typeof(UiDonCoin))]
        [HarmonyPatch(nameof(UiDonCoin.Refresh))]
        [HarmonyPatch(MethodType.Normal)]
        [HarmonyPostfix]
        public static void UiDonCoin_Refresh_Postfix(UiDonCoin __instance)
        {
            //Logger.Log("UiDonCoin_Refresh_Postfix");
            __instance.coinNum.text = SingletonMonoBehaviour<CommonObjects>.Instance.SaveData.PlayerData.DonCoin.ToString();
        }
    }
}
