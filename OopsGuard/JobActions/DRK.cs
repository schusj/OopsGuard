namespace OopsGuard.JobActions
{

    internal static class DRK
    {
        public const byte JobID = 32;


        public const uint
            // Single-Target 1-2-3 Combo
            HardSlash = 3617,
            SyphonStrike = 3623,
            Souleater = 3632,

            // AoE 1-2-3 Combo
            Unleash = 3621,
            StalwartSoul = 16468,

            // Single-Target oGCDs
            CarveAndSpit = 3643,      // With AbyssalDrain
            EdgeOfDarkness = 16467,   // For MP
            EdgeOfShadow = 16470,     // For MP // Upgrade of EdgeOfDarkness
            Bloodspiller = 7392,      // For Blood
            ScarletDelirium = 36928,  // Under Delirium
            Comeuppance = 36929,      // Under Delirium
            Torcleaver = 36930,       // Under Delirium

            // AoE oGCDs
            AbyssalDrain = 3641,      // With CarveAndSpit
            FloodOfDarkness = 16466,  // For MP
            FloodOfShadow = 16469,    // For MP // Upgrade of FloodOfDarkness
            Quietus = 7391,           // For Blood
            SaltedEarth = 3639,
            SaltAndDarkness = 25755,  // Recast of Salted Earth
            Impalement = 36931,       // Under Delirium

            // Buffing oGCDs
            BloodWeapon = 3625,
            Delirium = 7390,

            // Burst Window
            LivingShadow = 16472,
            Shadowbringer = 25757,
            Disesteem = 36932,

            // Ranged Option
            Unmend = 3624;


    }
}
