namespace LalaPokemon
{
    namespace DataTypes
    {
        public class PokemonDataType
        {
            public enum StatType
            {
                HealPoints,
                Attack,
                Defense,
                SpecialAttack,
                SpecialDefense,
                Speed
            }

            public enum StatCondition
            {
                Poison,
                Badly_Poison,
                Sleep,
                Paralysis,
                Burn,
                Freeze
            }

            //Items for outdoor use
            public enum Repel
            {
                Repel,
                Super_Repel,
                Max_Repel
            }

            public enum Flute
            {
                Blue_Flute,
                Yellow_Flute,
                Red_Flute,
                Black_Flute,
                White_Flute
            }

            public enum Mulch
            {
                Growth_Mulch,
                Damp_Mulch,
                Stable_Mulch,
                Gooey_Mulch,
                Rich_Mulch,
                Surprise_Mulch,
                Boost_Mulch,
                Amaze_Mulch
            }

            public enum Nectar
            {
                Red_Nectar,
                Yellow_Nectar,
                Pink_Nectar,
                Purple_Nectar
            }

            //Items for training Pokémon
            public enum Enhancer
            {
                PP_Up,
                PP_Max,
                HP_Up,
                Protein,
                Iron,
                Calcium,
                Zinc,
                Carbos
            }

            public enum Wing
            {
                Health_Wing,
                Muscle_Wing,
                Resist_Wing,
                Genius_Wing,
                Clever_Wing,
                Swift_Wing
            }

            public enum Ability
            {
                Ability_Capsule,
                Ability_Patch
            }

            public enum Mint
            {
                Lonely_Mint,
                Adamant_Mint,
                Naughty_Mint,
                Brave_Mint,
                Bold_Mint,
                Impish_Mint,
                Lax_Mint,
                Relaxed_Mint,
                Modest_Mint,
                Mild_Mint,
                Rash_Mint,
                Quiet_Mint,
                Calm_Mint,
                Gentle_Mint,
                Careful_Mint,
                Sassy_Mint,
                Timid_Mint,
                Hasty_Mint,
                Jolly_Mint,
                Naive_Mint,
                Serious_Mint
            }

            public enum Grit
            {
                Grit_Gravel,
                Grit_Pebble,
                Grit_Rock
            }

            public enum Mochi
            {
                Health_Mochi,
                Muscle_Mochi,
                Resist_Mochi,
                Genius_Mochi,
                Clever_Mochi,
                Swift_Mochi,
                Fresh_Start_Mochi
            }

            //Evolution Items
            public enum Evolution
            {
                Fire_Stone,
                Thunder_Stone,
                Water_Stone,
                Leaf_Stone,
                Moon_Stone,
                Sun_Stone,
                Shiny_Stone,
                Dusk_Stone,
                Dawn_Stone,
                Ice_Stone,
                Sweet_Apple,
                Tart_Apple,
                Cracked_Pot,
                Chipped_Pot,
                Linking_Cord,
                Black_Augurite,
                Peat_Block,
                Auspicious_Armor,
                Malicious_Armor,
                Syrupy_Apple,
                Unremarkable_Teacup,
                Masterpiece_Teacup
            }

            //Apricorn Items
            public enum Apricorn
            {
                Red_Apricorn,
                Blue_Apricorn,
                Yellow_Apricorn,
                Green_Apricorn,
                Pink_Apricorn,
                White_Apricorn,
                Black_Apricorn
            }

            //Tera Shard Items
            public enum TeraShardType
            {
                Normal_Tera_Shard,
                Fire_Tera_Shard,
                Water_Tera_Shard,
                Electric_Tera_Shard,
                Grass_Tera_Shard,
                Ice_Tera_Shard,
                Fighting_Tera_Shard,
                Poison_Tera_Shard,
                Ground_Tera_Shard,
                Flying_Tera_Shard,
                Psychic_Tera_Shard,
                Bug_Tera_Shard,
                Rock_Tera_Shard,
                Ghost_Tera_Shard,
                Dragon_Tera_Shard,
                Dark_Tera_Shard,
                Steel_Tera_Shard,
                Fairy_Tera_Shard
            }

            //Carry Items
            public enum NormalCarry
            {
                Bright_Powder,
                Quick_Claw,
                King_Rock,
                Silver_Powder,
                Amulet_Coin,
                Cleanse_Tag,
                Smoke_Ball,
                Everstone,
                Focus_Band,
                Lucky_Egg,
                Scope_Lens,
                Metal_Coat,
                Leftovers,
                Dragon_Scale,
                Light_Ball,
                Soft_Sand,
                Hard_Stone,
                Miracle_Seed,
                Black_Glasses,
                Black_Belt,
                Magnet,
                Mystic_Water,
                Sharp_Beak,
                Poison_Barb,
                Never_Melt_Ice,
                Spell_Tag,
                Twisted_Spoon,
                Charcoal,
                Dragon_Fang,
                Pink_Bow,
                Silk_Scarf,
                Berserk_Gene,
                Up_Grade,
                Lucky_Punch,
                Metal_Powder,
                Quick_Powder,
                Thick_Club,
                Stick,
                White_Herb,
                Mental_Herb,
                Power_Herb,
                Macho_Brace,
                Soothe_Bell,
                Choice_Band,
                Choice_Specs,
                Choice_Scarf,
                Soul_Dew,
                Deep_Sea_Tooth,
                Deep_Sea_Scale,
                Shell_Bell
            }

            public enum CarryyBerry
            {
                Berry,
                Gold_Berry,
                PRZCureBerry,
                PSNCureBerry,
                Bitter_Berry,
                Burnt_Berry,
                Ice_Berry,
                Mint_Berry,
                MiracleBerry,
                MysteryBerry
            }

            public enum Incense
            {
                Sea_Incense,
                Lax_Incense,
                Odd_Incense,
                Rock_Incense,
                Full_Incense,
                Wave_Incense,
                Rose_Incense,
                Luck_Incense,
                Pure_Incense
            }

            public enum Plate
            {
                Flame_Plate,
                Splash_Plate,
                Zap_Plate,
                Meadow_Plate,
                Icicle_Plate,
                Fist_Plate,
                Toxic_Plate,
                Earth_Plate,
                Sky_Plate,
                Mind_Plate,
                Insect_Plate,
                Stone_Plate,
                Spooky_Plate,
                Draco_Plate,
                Dread_Plate,
                Iron_Plate,
                Pixie_Plate
            }

            public enum Power
            {
                Power_Bracer,
                Power_Belt,
                Power_Lens,
                Power_Band,
                Power_Anklet,
                Power_Weight
            }

            public enum Drive
            {
                Douse_Drive,
                Shock_Drive,
                Burn_Drive,
                Chill_Drive
            }

            public enum Gem
            {
                Fire_Gem,
                Water_Gem,
                Electric_Gem,
                Grass_Gem,
                Ice_Gem,
                Fighting_Gem,
                Poison_Gem,
                Ground_Gem,
                Flying_Gem,
                Psychic_Gem,
                Bug_Gem,
                Rock_Gem,
                Ghost_Gem,
                Dragon_Gem,
                Dark_Gem,
                Steel_Gem,
                Normal_Gem,
                Fairy_Gem
            }

            public enum MegaStone
            {
                Venusaurite,
                Charizardite_X,
                Charizardite_Y,
                Blastoisinite,
                Beedrillite,
                Pidgeotite,
                Alakazite,
                Slowbronite,
                Gengarite,
                Kangaskhanite,
                Pinsirite,
                Gyaradosite,
                Aerodactylite,
                Mewtwonite_X,
                Mewtwonite_Y,
                Ampharosite,
                Steelixite,
                Scizorite,
                Heracronite,
                Houndoominite,
                Tyranitarite,
                Sceptilite,
                Blazikenite,
                Swampertite,
                Gardevoirite,
                Sablenite,
                Mawilite,
                Aggronite,
                Medichamite,
                Manectite,
                Sharpedonite,
                Cameruptite,
                Altarianite,
                Banettite,
                Absolite,
                Glalitite,
                Salamencite,
                Metagrossite,
                Latiasite,
                Latiosite,
                Lopunnite,
                Lucarionite,
                Garchompite,
                Abomasite,
                Galladite,
                Audinite,
                Diancite
            }

            public enum Seed
            {
                ElectricSeed,
                PsychicSeed,
                MistySeed,
                GrassySeed
            }

            public enum Memory
            {
                FightingMemory,
                FlyingMemory,
                PoisonMemory,
                GroundMemory,
                RockMemory,
                BugMemory,
                GhostMemory,
                SteelMemory,
                FireMemory,
                WaterMemory,
                GrassMemory,
                ElectricMemory,
                PsychicMemory,
                IceMemory,
                DragonMemory,
                DarkMemory,
                FairyMemory
            }

            public enum Sweet
            {
                StrawberrySweet,
                LoveSweet,
                BerrySweet,
                CloverSweet,
                FlowerSweet,
                StarSweet,
                RibbonSweet
            }

            //Mail Items
            public enum MailType
            {
                BlueskyMail,
                EonMail,
                FlowerMail,
                LiteblueMail,
                LovelyMail,
                MirageMail,
                MorphMail,
                PortraitMail,
                MusicMail,
                SurfMail,
                OrangeMail,
                HarborMail,
                GlitterMail,
                MechMail,
                WoodMail,
                WaveMail,
                BeadMail,
                ShadowMail,
                TropicalMail,
                DreamMail,
                MiracleMail,
                RetroMail,
                GrassMail,
                FlameMail,
                BubbleMail,
                BloomMail,
                TunnelMail,
                SteelMail,
                HeartMail,
                SnowMail,
                SpaceMail,
                AirMail,
                MosaicMail,
                BrickMail,
                GreetMail,
                FavoredMail,
                RSVPMail,
                ThanksMail,
                InquiryMail,
                LikeMail,
                ReplyMail,
                BridgeMailS,
                BridgeMailH,
                BridgeMailC,
                BridgeMailV,
                BridgeMailW
            }

            //Candy Items
            public enum Candy
            {
                RareCandy,
                HealthCandy,
                MightyCandy,
                ToughCandy,
                SmartCandy,
                CourageCandy,
                QuickCandy,
                HealthCandyL,
                MightyCandyL,
                ToughCandyL,
                SmartCandyL,
                CourageCandyL,
                QuickCandyL,
                HealthCandyXL,
                MightyCandyXL,
                ToughCandyXL,
                SmartCandyXL,
                CourageCandyXL,
                QuickCandyXL,
                PokémonCandy,
                ExpCandyXS,
                ExpCandyS,
                ExpCandyM,
                ExpCandyL,
                ExpCandyXL,
                DynamaxCandy
            }

            //PokeBall
            public enum PokeBall
            {
                PokeBall,
                GreatBall,
                UltraBall,
                SafariBall,
                MasterBall,
                FastBall,
                LevelBall,
                LureBall,
                LoveBall,
                FriendBall,
                MoonBall,
                HeavyBall,
                LeadenBall,
                GigatonBall,
                SportBall,
                ParkBall,
                NetBall,
                DiveBall,
                NestBall,
                RepeatBall,
                TimerBall,
                LuxuryBall,
                PremierBall,
                DuskBall,
                HealBall,
                QuickBall,
                CherishBall,
                DreamBall,
                BeastBall,
                FeatherBall,
                WingBall,
                JetBall,
                StrangeBall
            }

            //Valuable Item
            public enum Valuable
            {
                TinyMushroom,
                BigMushroom,
                BalmMushroom,
                Pearl,
                BigPearl,
                PearlString,
                Stardust,
                StarPiece,
                CometShard,
                SilverLeaf,
                GoldLeaf,
                Nugget,
                BigNugget,
                RelicCopper,
                RelicSilver,
                RelicGold,
                RelicVase,
                RelicBand,
                RelicStatue,
                RelicCrown,
                TinyBambooShoot,
                BigBambooShoot,
                BrickPiece,
                RareBone,
                Honey,
                PrettyWing,
                StrangeSouvenir,
                StretchySpring,
                ChalkyStone,
                Marble,
                LoneEarring,
                BeachGlass,
                PolishedMudBall,
                TropicalShell,
                PokeshiDoll
            }

            //Fossil Item
            public enum Fossil
            {
                HelixFossil,
                DomeFossil,
                OldAmber,
                RootFossil,
                ClawFossil,
                SkullFossil,
                ArmorFossil,
                CoverFossil,
                PlumeFossil,
                JawFossil,
                SailFossil,
                FossilizedBird,
                FossilizedFish,
                FossilizedDrake,
                FossilizedDino
            }

            //Combat Item
            public enum Combat
            {
                GuardSpec,
                DireHit,
                XAttack,
                XDefense,
                XSpAtk,
                XSpDef,
                XSpeed,
                XAccuracy,
                PokeDoll,
                FluffyTail,
                PokeToy,
                MaxMushrooms,
                AuxPower,
                AuxGuard,
                AuxPowerguard,
                AuxEvasion,
                ChoiceDumpling,
                TwiceSpicedRadish,
                SwapSnack
            }

            //Technical Items
            public enum Technical
            {
                Technical_Machine,
                Technical_Record
            }

            //Recover Items
            public enum Recover
            {
                Potion,
                SuperPotion,
                HyperPotion,
                MaxPotion,
                FullRestore,
                Antidote,
                BurnHeal,
                IceHeal,
                Awakening,
                ParalyzeHeal,
                FullHeal,
                Revive,
                MaxRevive,
                FreshWater,
                SodaPop,
                Lemonade,
                MoomooMilk,
                EnergyPowder,
                EnergyRoot,
                HealPowder,
                RevivalHerb,
                Ether,
                MaxEther,
                Elixir,
                MaxElixir,
                RageCandyBar,
                LavaCookie,
                OldGateau,
                Casteliacone,
                LumioseGalette,
                ShalourSable,
                BigMalasada,
                PewterCrunchies,
                JubilifeMuffin,
                BerryJuice,
                SweetHeart,
                SacredAsh,
                MaxHoney,
                Remedy,
                FineRemedy,
                SuperbRemedy
            }

            //Z Items
            public enum PokemonZ
            {
                NormaliumZ,
                FiriumZ,
                WateriumZ,
                ElectriumZ,
                GrassiumZ,
                IciumZ,
                FightiniumZ,
                PoisoniumZ,
                GroundiumZ,
                FlyiniumZ,
                PsychiumZ,
                BuginiumZ,
                RockiumZ,
                GhostiumZ,
                DragoniumZ,
                DarkiniumZ,
                SteeliumZ,
                FairiumZ,
                PikaniumZ,
                DecidiumZ,
                InciniumZ,
                PrimariumZ,
                TapuniumZ,
                MarshadiumZ,
                AloraichiumZ,
                SnorliumZ,
                EeviumZ,
                MewniumZ,
                PikashuniumZ,
                SolganiumZ,
                LunaliumZ,
                UltranecroziumZ,
                MimikiumZ,
                LycaniumZ,
                KommoniumZ,
                JararangaZ
            }

            //Berry Items
            public enum BerryType
            {
                CheriBerry,
                ChestoBerry,
                PechaBerry,
                RawstBerry,
                AspearBerry,
                LeppaBerry,
                OranBerry,
                PersimBerry,
                LumBerry,
                SitrusBerry,
                FigyBerry,
                WikiBerry,
                MagoBerry,
                AguavBerry,
                IapapaBerry,
                RazzBerry,
                SilverRazzBerry,
                GoldenRazzBerry,
                BlukBerry,
                NanabBerry,
                SilverNanabBerry,
                GoldenNanabBerry,
                WepearBerry,
                PinapBerry,
                SilverPinapBerry,
                GoldenPinapBerry,
                PomegBerry,
                KelpsyBerry,
                QualotBerry,
                HondewBerry,
                GrepaBerry,
                TamatoBerry,
                CornnBerry,
                MagostBerry,
                RabutaBerry,
                NomelBerry,
                SpelonBerry,
                PamtreBerry,
                WatmelBerry,
                DurinBerry,
                BelueBerry,
                OccaBerry,
                PasshoBerry,
                WacanBerry,
                RindoBerry,
                YacheBerry,
                ChopleBerry,
                KebiaBerry,
                ShucaBerry,
                CobaBerry,
                PayapaBerry,
                TangaBerry,
                ChartiBerry,
                KasibBerry,
                HabanBerry,
                ColburBerry,
                BabiriBerry,
                ChilanBerry,
                LiechiBerry,
                GanlonBerry,
                SalacBerry,
                PetayaBerry,
                ApicotBerry,
                LansatBerry,
                StarfBerry,
                EnigmaBerry,
                PumkinBerry,
                DrashBerry,
                EggantBerry,
                StribBerry,
                NutpeaBerry,
                GinemaBerry,
                KuoBerry,
                YagoBerry,
                TougaBerry,
                NinikuBerry,
                TopoBerry,
                MicleBerry,
                CustapBerry,
                JabocaBerry,
                RowapBerry,
                RoseliBerry,
                KeeBerry,
                MarangaBerry,
                HopoBerry
            }
        }
    }
}
