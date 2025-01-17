﻿using NAudio.Wave;
using System.Drawing;
using System.Windows.Forms;

namespace Time2Rest.Config
{
    public class T2rConfig
    {
        // Config
        // Function Config
        public int alertInterval = 30 * 60;

        public int minimumRestTime = 20;
        public int alertAgainInterval = 1 * 60;
        public bool hideWhenFullscreen = true;

        // UI Config
        public double maxOpacity = 0.8;

        private Color _backColor = Color.Black;
        private Color _foreColor = Color.White;

        public string backColorString
        {
            set { _backColor = ColorTranslator.FromHtml(value); }
            get { return ColorTranslator.ToHtml(_backColor); }
        }

        public string foreColorString
        {
            set { _foreColor = ColorTranslator.FromHtml(value); }
            get { return ColorTranslator.ToHtml(_foreColor); }
        }

        private string _backGroundImgPath;

        public string backGroundImgPath
        {
            set
            {
                if (ValidateImg(value))
                    _backGroundImgPath = value;
                else
                    _backGroundImgPath = "";
            }
            get
            {
                return _backGroundImgPath;
            }
        }

        private string _ringtonePath;

        public string ringtonePath
        {
            set
            {
                if (ValidateSnd(value))
                    _ringtonePath = value;
                else
                    _ringtonePath = "";
            }
            get
            {
                return _ringtonePath;
            }
        }

        public bool startup = true;

        // Screen Config
        private int _screenIndex = -1;

        public int screenIndex
        {
            set
            {
                if (ValidateScreen(value))
                    _screenIndex = value;
                else
                    _screenIndex = -1;
            }
            get
            {
                if (ValidateScreen(_screenIndex))
                    return _screenIndex;
                else
                    return GetPrimaryScreenIndex();
            }
        }

        public Screen screen
        {
            get
            {
                if (_screenIndex == -1)
                {
                    return Screen.PrimaryScreen;
                }
                else
                {
                    return Screen.AllScreens[_screenIndex];
                }
            }
        }

        public Color GetBackColor()
        {
            return _backColor;
        }

        public Color GetForeColor()
        {
            return _foreColor;
        }

        public static bool ValidateImg(string path)
        {
            if (string.IsNullOrEmpty(path))
                return true;
            try
            {
                Image.FromFile(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidateSnd(string path)
        {
            if (string.IsNullOrEmpty(path))
                return true;

            try
            {
                new AudioFileReader(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidateScreen(int index)
        {
            var allScreen = Screen.AllScreens;
            if (index < allScreen.Length && index >= 0)
                return true;
            return false;
        }

        public static int GetPrimaryScreenIndex()
        {
            var primary = Screen.PrimaryScreen;
            int i = 0;
            foreach (var screen in Screen.AllScreens)
            {
                if (screen == primary)
                    return i;
                i += 1;
            }
            return -1;
        }
    }
}