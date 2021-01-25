using System;

namespace BlazorBattles.Client.Services
{
    public interface IBananaService
    {
        public int Bananas { get; set; }

        event Action OnChange;

        void EatBananas(int amount);
        void AddBananas(int amount);
    }
}