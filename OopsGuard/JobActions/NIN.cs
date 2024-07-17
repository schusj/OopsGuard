namespace OopsGuard.JobActions
{

    internal static class NIN
    {
        public const byte ClassID = 29;
        public const byte JobID = 30;

        public const uint
            SpinningEdge = 2240,
            ShadeShift = 2241,
            GustSlash = 2242,
            Hide = 2245,
            Assassinate = 2246,
            ThrowingDaggers = 2247,
            Mug = 2248,
            DeathBlossom = 2254,
            AeolianEdge = 2255,
            TrickAttack = 2258,
            Kassatsu = 2264,
            ArmorCrush = 3563,
            DreamWithinADream = 3566,
            TenChiJin = 7403,
            Bhavacakra = 7402,
            HakkeMujinsatsu = 16488,
            Meisui = 16489,
            Bunshin = 16493,
            PhantomKamaitachi = 25774,
            ForkedRaiju = 25777,
            FleetingRaiju = 25778,
            Hellfrog = 7401,
            HollowNozuchi = 25776,

            //Mudras
            Ninjutsu = 2260,
            Rabbit = 2272,

            //-- initial state mudras (the ones with charges)
            Ten = 2259,
            Chi = 2261,
            Jin = 2263,

            //-- mudras used for combos (the ones used while you have the mudra buff)
            TenCombo = 18805,
            ChiCombo = 18806,
            JinCombo = 18807,

            //Ninjutsu
            FumaShuriken = 2265,
            Hyoton = 2268,
            Doton = 2270,
            Katon = 2266,
            Suiton = 2271,
            Raiton = 2267,
            Huton = 2269,
            GokaMekkyaku = 16491,
            HyoshoRanryu = 16492,

            //TCJ Jutsus (why they have another ID I will never know)
            TCJFumaShurikenTen = 18873,
            TCJFumaShurikenChi = 18874,
            TCJFumaShurikenJin = 18875,
            TCJKaton = 18876,
            TCJRaiton = 18877,
            TCJHyoton = 18878,
            TCJHuton = 18879,
            TCJDoton = 18880,
            TCJSuiton = 18881;

        public static class Buffs
        {
            public const ushort
                Mudra = 496,
                Kassatsu = 497,
                Suiton = 507,
                Hidden = 614,
                TenChiJin = 1186,
                AssassinateReady = 1955,
                RaijuReady = 2690,
                PhantomReady = 2723,
                Meisui = 2689,
                Doton = 501,
                Bunshin = 1954;
        }

        public static class Debuffs
        {
            public const ushort
                TrickAttack = 3254,
                Mug = 638;
        }

        


    }
}
