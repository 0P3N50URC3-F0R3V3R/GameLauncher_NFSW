﻿using GameLauncher.App.Classes.LauncherCore.Global;
using GameLauncher.App.Classes.LauncherCore.Languages.Visual_Forms;

namespace GameLauncher.App.Classes.InsiderKit
{
    /* This sets Build Number Information */
    class InsiderInfo
    {
        /* Current month, day, year (2 digits), and letter! Ex: 12-15-20-A */
        public static string InsiderBuildNumber = "10-09-21-R";

        public static string BuildNumberOnly()
        {
            return InsiderBuildNumber;
        }

        public static string BuildNumber()
        {
            if (EnableInsiderDeveloper.Allowed())
            {
                return Translations.Database("KitEnabler_Dev") + ": " + InsiderBuildNumber;
            }
            else if (EnableInsiderBetaTester.Allowed())
            {
                return Translations.Database("KitEnabler_Beta") + ": " + InsiderBuildNumber;
            }

            return Translations.Database("KitEnabler_Stable") + ": " + InsiderBuildNumber;
        }
    }

    /* This is only used for Developers (Bypasses Most Checks) */
    class EnableInsiderDeveloper
    {
        public static bool Enabled = false;

        public static bool Allowed()
        {
            return Enabled;
        }
    }

    /* This is only used for Beta Testers (Treated like a Public Release) */
    class EnableInsiderBetaTester
    {
        public static bool Enabled = false;

        public static bool Allowed()
        {
            return Enabled;
        }
    }
}