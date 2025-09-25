using ElementsAwoken.Content.Events.RadiantRain.Enemies;
using ElementsAwoken.Content.Events.VoidEvent.Enemies.Phase2.ShadeWyrm;
using ElementsAwoken.Content.NPCs.Bosses.Ancients;
using ElementsAwoken.Content.NPCs.Bosses.Aqueous;
using ElementsAwoken.Content.NPCs.Bosses.Azana;
using ElementsAwoken.Content.NPCs.Bosses.CosmicObserver;
using ElementsAwoken.Content.NPCs.Bosses.Infernace;
using ElementsAwoken.Content.NPCs.Bosses.Obsidious;
using ElementsAwoken.Content.NPCs.Bosses.Permafrost;
using ElementsAwoken.Content.NPCs.Bosses.Regaroth;
using ElementsAwoken.Content.NPCs.Bosses.ScourgeFighter;
using ElementsAwoken.Content.NPCs.Bosses.TheGuardian;
using ElementsAwoken.Content.NPCs.Bosses.TheTempleKeepers;
using ElementsAwoken.Content.NPCs.Bosses.Volcanox;
using ElementsAwoken.Content.NPCs.Bosses.Wasteland;
using ElementsAwoken.Content.NPCs.Bosses.VoidLeviathan;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace EAMusic
{
    public class EAMusicGlobalNPC : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (EAMusic.EARetroLoaded == false)
            {
                if (npc.type == NPCType<Wasteland>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("WastelandTheme"));
                    return;
                }
                if (npc.type == NPCType<Infernace>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("InfernaceTheme"));
                    return;
                }
                if (npc.type == NPCType<ScourgeFighter>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("ScourgeFighterTheme"));
                    return;
                }
                if (npc.type == NPCType<RegarothHead>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("RegarothTheme"));
                    return;
                }
                if (npc.type == NPCType<Obsidious>() || npc.type == NPCType<ObsidiousHuman>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("ObsidiousTheme"));
                    return;
                }
                if (npc.type == NPCType<Permafrost>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("PermafrostTheme"));
                    return;
                }
                if (npc.type == NPCType<Aqueous>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("AqueousTheme"));
                    return;
                }
                if (npc.type == NPCType<TheGuardian>() || npc.type == NPCType<TheEye>() || npc.type == NPCType<AncientWyrmHead>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("EyeDragonTheme"));
                    return;
                }
                if (npc.type == NPCType<TheGuardianFly>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("GuardianTheme"));
                    return;
                }
                if (npc.type == NPCType<Volcanox>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("VolcanoxTheme"));
                    return;
                }
                if (npc.type == NPCType<VoidLeviathanHead>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("VoidLeviathanTheme"));
                    return;
                }
                if (npc.type == NPCType<AzanaEye>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("AzanaThemeP1"));
                    return;
                }
                if (npc.type == NPCType<Azana>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("AzanaTheme"));
                    return;
                }
                if (npc.type == NPCType<ShadeWyrmHead>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("VoidEventMiniboss"));
                    return;
                }
                if (npc.type == NPCType<CosmicObserver>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("ObserverTheme"));
                    return;
                }
                if (npc.type == NPCType<Izaris>() || npc.type == NPCType<Kirvein>() || npc.type == NPCType<Krecheus>() || npc.type == NPCType<Xernon>() || npc.type == NPCType<AncientAmalgam>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("AncientsTheme"));
                    return;
                }
                if (npc.type == NPCType<RadiantMaster>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("RadiantMasterTheme"));
                    npc.ModNPC.SceneEffectPriority = SceneEffectPriority.BossLow;
                    return;
                }
                if (npc.type == NPCType<RadiantMasterDeath>())
                {
                    npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("RadiantMasterDeath"));
                    npc.ModNPC.SceneEffectPriority = SceneEffectPriority.BossHigh;
                }
            }
        }
        public override void PostAI(NPC npc)
        {
            if (npc.type == NPCType<RadiantMaster>() && npc.ai[3] > 0f && EAMusic.EARetroLoaded == false)
            {
                npc.ModNPC.Music = MusicLoader.GetMusicSlot(EAMusic.SoundSlot("RadiantMasterDeath"));
            }
        }
    }
}