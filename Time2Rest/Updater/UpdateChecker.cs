﻿using System;
using System.Windows.Forms;
using System.Xml;

namespace Time2Rest.Updater
{
    internal class UpdateChecker
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private const string resXmlUrl = @"https://gitee.com/SDchao/Time2Rest/raw/main/Time2Rest/Resource.resx";
        private const string releaseUrl = "https://github.com/SDchao/Time2Rest/releases/latest";

        public static void CheckUpdate()
        {
            try
            {
                logger.Info("Update check started");
                float nowVersion = float.Parse(Resource.VERSION);

                XmlDocument document = new XmlDocument();
                logger.Info("Loading XML from {0}", resXmlUrl);
                document.Load(resXmlUrl);
                XmlNode node = document.SelectSingleNode(@"/root/data[@name='VERSION']/value");
                float newVersion = float.Parse(node.InnerText);

                if (newVersion > nowVersion)
                {
                    logger.Info("New version found: {0}", newVersion);
                    var lang = Languages.LanguageManager.GetLangRes();
                    var cultureName = Languages.LanguageManager.GetCultureName();

                    string updateLog = "";

                    if (cultureName == "zh-CN")
                        updateLog = document.SelectSingleNode(@"/root/data[@name='VERSION_LOG']/value").InnerText;
                    else
                        updateLog = document.SelectSingleNode(@"/root/data[@name='VERSION_LOG_EN']/value").InnerText;

                    string message = lang.GetString("TIP_UPDATE");

                    message = String.Format(message, nowVersion, newVersion, updateLog);
                    var result = MessageBox.Show(message, lang.GetString("TIP"), MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(releaseUrl);
                    }
                }
            }
            catch (Exception e)
            {
                logger.Warn("Unable to check update");
                logger.Warn(e);
            }
        }
    }
}