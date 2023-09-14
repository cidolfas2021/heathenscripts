using UnityEngine;
using GameZero;
using HeathenEngineering.SteamworksIntegration.UI;
using HeathenEngineering.SteamworksIntegration;
namespace GameZero
{
    public class LeaderboardEntryUIRecord : MonoBehaviour, ILeaderboardEntryDisplay
    {
        [SerializeField]
        private SetUserAvatar avatar;
        [SerializeField]
        private SetUserName userName;
        //[SerializeField]
        //private TMPro.TextMeshProUGUI score;
        [SerializeField]
        private TMPro.TextMeshProUGUI rank;
        [SerializeField]
        private TMPro.TextMeshProUGUI Level;
        [SerializeField]
        private TMPro.TextMeshProUGUI Gold;
        [SerializeField]
        private TMPro.TextMeshProUGUI lifetimePlayerKills;
        [SerializeField]
        private TMPro.TextMeshProUGUI thismatchPlayerKills;
        [SerializeField]
        private TMPro.TextMeshProUGUI GoonKills;
        [SerializeField]
        private TMPro.TextMeshProUGUI BossKills;
        [SerializeField]
        private TMPro.TextMeshProUGUI lifetimedeaths;
        [SerializeField]
        private TMPro.TextMeshProUGUI thismatchdeaths;


        private LeaderboardEntry _entery;
        public LeaderboardEntry Entry
        {
            get => _entery;
            set => SetEntry(value);
        }

        private void SetEntry(LeaderboardEntry entry)
        { 


            avatar.UserData = entry.User;
            userName.UserData = entry.User;
            //score.text = entry.Score.ToString();
            rank.text = entry.Rank.ToString();
            Level.text = entry.Level.ToString(); ;
            Gold.text = entry.Gold.ToString();
            lifetimePlayerKills.text = entry.lifetimePlayerKills.ToString();
            thismatchPlayerKills.text = entry.thismatchPlayerKills.ToString();
            GoonKills.text = entry.GoonKills.ToString();
            BossKills.text = entry.BossKills.ToString();
            lifetimedeaths.text = entry.lifetimedeaths.ToString();
            thismatchdeaths.text = entry.thismatchdeaths.ToString();

            _entery = entry;
        }
    }
}