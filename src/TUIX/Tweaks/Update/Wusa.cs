﻿using System;
using System.Diagnostics;
using System.IO;

namespace TweakUIX.Tweaks.Update
{
    internal class Wusa : TweaksBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private static string kbList = Helpers.Strings.Data.DataRootDir + "brokenKB.app";

        public override string ID()
        {
            return "*Uninstall broken Windows updates";
        }

        public override string Info()
        {
            return "This will uninstall Windows updates that have known issues or that are causing problems on your computer.\n" +
                    "Click the <Check> button to search the database for broken updates.";
        }

        public override bool CheckTweak()
        {
            try
            {
                logger.Log("The following KnowledgeBase (KB) numbers will be uninstalled:");

                string[] Kb = File.ReadAllLines(kbList);

                foreach (var currentKb in Kb)
                {
                    logger.Log("- KB" + currentKb.ToString());
                }
            }
            catch
            {
                logger.Log("- There are currently no Windows updates registered in the database which might cause problems or crashes.");
            }

            return (File.Exists(kbList));
        }

        public override bool DoTweak()
        {
            try
            {
                logger.Log("The following KnowledgeBase (KB) numbers will be uninstalled:");

                string[] Kb = File.ReadAllLines(kbList);

                foreach (var currentKb in Kb)
                {
                    logger.Log("- KB" + currentKb.ToString());
                    var kbNumber = Convert.ToInt32(currentKb.ToString().Replace("KB", null));
                    WindowsHelper.RunCmd($"/c start wusa /uninstall /kb:{kbNumber} /norestart");
                }
                logger.Log("\nPlease restart your PC for the changes to take effect.");
                return true;
            }
            catch
            {
                logger.Log("- There are currently no Windows updates registered in the database which might cause problems or crashes.");
                return false;
            }
        }

        public override bool UndoTweak()
        {
            logger.Log("Reinstall the Update via Windows update...\nWe've opened the Windows update page.");
            Process.Start("ms-settings:windowsupdate-action");
            return true;
        }
    }
}