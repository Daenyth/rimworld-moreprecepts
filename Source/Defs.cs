using RimWorld;
using Verse;

namespace MorePrecepts
{
    [DefOf]
    public static class PreceptDefOf
    {
        public static PreceptDef Superstition_Strong;

        public static PreceptDef Superstition_Weak;
    }

    [DefOf]
    public static class ThoughtDefOf
    {
        public static ThoughtDef Superstition_Superstitious_Strong_Plus;

        public static ThoughtDef Superstition_Superstitious_Strong_Minus;

        public static ThoughtDef Superstition_Superstitious_Weak_Plus;

        public static ThoughtDef Superstition_Superstitious_Weak_Minus;
    }

    [DefOf]
    public static class HistoryEventDefOf
    {
        public static HistoryEventDef Superstition_Superstitious_Generic;

        public static HistoryEventDef Superstition_Superstitious_Strong_Plus;

        public static HistoryEventDef Superstition_Superstitious_Strong_Minus;

        public static HistoryEventDef Superstition_Superstitious_Weak_Plus;

        public static HistoryEventDef Superstition_Superstitious_Weak_Minus;

        [MayRequireIdeology]
        public static HistoryEventDef BuiltTrap;
    }

}
