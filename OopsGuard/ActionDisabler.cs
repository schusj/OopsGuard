using System;
using Dalamud.Hooking;
using OopsGuard.JobActions;
using FFXIVClientStructs.FFXIV.Client.Game;
using Dalamud.Plugin.Services;
using System.Linq;

namespace OopsGuard
{
    public class ActionDisabler
    {

        public delegate uint OnGetActionStatusDelegate(IntPtr self, uint param1, uint param2, ulong param3, bool param4, bool param5, UIntPtr param6);

        private readonly Hook<OnGetActionStatusDelegate> getActionStatusHook;

        private const int DISABLED = 572;

        private static readonly uint[] ComboActions = [
            DNC.Fountain,
            DNC.Bladeshower,
            DRG.VorpalThrust,
            DRG.LanceBarrage,
            DRG.FullThrust,
            DRG.HeavensThrust,
            DRG.ChaosThrust,
            DRG.ChaoticSpring,
            DRG.SonicThrust,
            DRG.CoerthanTorment,
            DRG.FangAndClaw,
            DRG.WheelingThrust,
            DRG.Disembowel,
            DRG.SpiralBlow,
            DRK.SyphonStrike,
            DRK.Souleater,
            DRK.StalwartSoul,
            GNB.BrutalShell,
            GNB.SolidBarrel,
            GNB.DemonSlaughter,
            MCH.SlugShot,
            MCH.HeatedSlugShot,
            MCH.CleanShot,
            MCH.HeatedCleanShot,
            NIN.GustSlash,
            NIN.AeolianEdge,
            NIN.ArmorCrush,
            NIN.HakkeMujinsatsu,
            PLD.RiotBlade,
            PLD.RoyalAuthority,
            PLD.RageOfHalone,
            PLD.Prominence,
            RDM.Zwerchhau,
            RDM.EnchantedZwerchhau,
            RDM.Redoublement,
            RDM.EnchantedRedoublement,
            RPR.WaxingSlice,
            RPR.InfernalSlice,
            RPR.NightmareScythe,
            WAR.Maim,
            WAR.StormsPath,
            WAR.StormsEye,
            WAR.MythrilTempest,
            SAM.Jinpu,
            SAM.Gekko,
            SAM.Shifu,
            SAM.Kasha,
            SAM.Yukikaze,
            SAM.Mangetsu,
            SAM.Oka
        ];

        public ActionDisabler(IGameInteropProvider hookProvider)
        {
            getActionStatusHook = hookProvider.HookFromAddress<OnGetActionStatusDelegate>(ActionManager.Addresses.GetActionStatus.Value, GetActionStatusDetour);
        }

        public void Enable()
        {
            getActionStatusHook.Enable();
        }

        unsafe private uint GetActionStatusDetour(IntPtr self, uint actionType, uint actionID, ulong a3, bool a4, bool a5, UIntPtr a6)
        {
            if ((ActionType)actionType == ActionType.Action && ComboActions.Contains(actionID) && !ActionManager.Instance()->IsActionHighlighted((ActionType)actionType, actionID))
            {
                return DISABLED;
            }

            return getActionStatusHook.Original(self, actionType, actionID, a3, a4, a5, a6);
        }

        public void Dispose()
        {
            getActionStatusHook.Dispose();
        }
    }
}
