using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessController
{
    public enum Key
    {
        //
        // Summary:
        //     None
        None = 0,
        //
        // Summary:
        //     Left mouse button
        LButton = 1,
        //
        // Summary:
        //     Right mouse button
        RButton = 2,
        //
        // Summary:
        //     Control-break processing
        Cancel = 3,
        //
        // Summary:
        //     Middle mouse button (three-button mouse) - NOT contiguous with LBUTTON and RBUTTON
        MButton = 4,
        //
        // Summary:
        //     Windows 2000/XP: X1 mouse button - NOT contiguous with LBUTTON and RBUTTON
        XButton1 = 5,
        //
        // Summary:
        //     Windows 2000/XP: X2 mouse button - NOT contiguous with LBUTTON and RBUTTON
        XButton2 = 6,
        //
        // Summary:
        //     BACKSPACE key
        Back = 8,
        //
        // Summary:
        //     TAB key
        Tab = 9,
        //
        // Summary:
        //     CLEAR key
        Clear = 12,
        //
        // Summary:
        //     ENTER key
        Enter = 13,
        //
        // Summary:
        //     SHIFT key
        Shift = 16,
        //
        // Summary:
        //     CTRL key
        Control = 17,
        //
        // Summary:
        //     ALT key
        Alt = 18,
        //
        // Summary:
        //     PAUSE key
        Pause = 19,
        //
        // Summary:
        //     CAPS LOCK key
        Capital = 20,
        //
        // Summary:
        //     CAPS LOCK key
        CapsLock = 20,
        //
        // Summary:
        //     Input Method Editor (IME) Kana mode
        Kana = 21,
        //
        // Summary:
        //     IME Hanguel mode (maintained for compatibility; use HANGUL)
        Hangeul = 21,
        //
        // Summary:
        //     IME Hangul mode
        Hangul = 21,
        //
        // Summary:
        //     IME Junja mode
        Junja = 23,
        //
        // Summary:
        //     IME final mode
        Final = 24,
        //
        // Summary:
        //     IME Hanja mode
        Hanja = 25,
        //
        // Summary:
        //     IME Kanji mode
        Kanji = 25,
        //
        // Summary:
        //     ESC key
        Escape = 27,
        //
        // Summary:
        //     IME convert
        Convert = 28,
        //
        // Summary:
        //     IME nonconvert
        NonConvert = 29,
        //
        // Summary:
        //     IME accept
        Accept = 30,
        //
        // Summary:
        //     IME mode change request
        ModeChange = 31,
        //
        // Summary:
        //     SPACEBAR
        Space = 32,
        //
        // Summary:
        //     PAGE UP key
        PageUp = 33,
        //
        // Summary:
        //     PAGE DOWN key
        PageDown = 34,
        //
        // Summary:
        //     END key
        End = 35,
        //
        // Summary:
        //     HOME key
        Home = 36,
        //
        // Summary:
        //     LEFT ARROW key
        Left = 37,
        //
        // Summary:
        //     UP ARROW key
        Up = 38,
        //
        // Summary:
        //     RIGHT ARROW key
        Right = 39,
        //
        // Summary:
        //     DOWN ARROW key
        Down = 40,
        //
        // Summary:
        //     SELECT key
        Select = 41,
        //
        // Summary:
        //     PRINT key
        Print = 42,
        //
        // Summary:
        //     EXECUTE key
        Execute = 43,
        //
        // Summary:
        //     PRINT SCREEN key
        PrintScreen = 44,
        //
        // Summary:
        //     INS key
        Insert = 45,
        //
        // Summary:
        //     DEL key
        Delete = 46,
        //
        // Summary:
        //     HELP key
        Help = 47,
        //
        // Summary:
        //     0 key
        D0 = 48,
        //
        // Summary:
        //     1 key
        D1 = 49,
        //
        // Summary:
        //     2 key
        D2 = 50,
        //
        // Summary:
        //     3 key
        D3 = 51,
        //
        // Summary:
        //     4 key
        D4 = 52,
        //
        // Summary:
        //     5 key
        D5 = 53,
        //
        // Summary:
        //     6 key
        D6 = 54,
        //
        // Summary:
        //     7 key
        D7 = 55,
        //
        // Summary:
        //     8 key
        D8 = 56,
        //
        // Summary:
        //     9 key
        D9 = 57,
        //
        // Summary:
        //     A key
        A = 65,
        //
        // Summary:
        //     B key
        B = 66,
        //
        // Summary:
        //     C key
        C = 67,
        //
        // Summary:
        //     D key
        D = 68,
        //
        // Summary:
        //     E key
        E = 69,
        //
        // Summary:
        //     F key
        F = 70,
        //
        // Summary:
        //     G key
        G = 71,
        //
        // Summary:
        //     H key
        H = 72,
        //
        // Summary:
        //     I key
        I = 73,
        //
        // Summary:
        //     J key
        J = 74,
        //
        // Summary:
        //     K key
        K = 75,
        //
        // Summary:
        //     L key
        L = 76,
        //
        // Summary:
        //     M key
        M = 77,
        //
        // Summary:
        //     N key
        N = 78,
        //
        // Summary:
        //     O key
        O = 79,
        //
        // Summary:
        //     P key
        P = 80,
        //
        // Summary:
        //     Q key
        Q = 81,
        //
        // Summary:
        //     R key
        R = 82,
        //
        // Summary:
        //     S key
        S = 83,
        //
        // Summary:
        //     T key
        T = 84,
        //
        // Summary:
        //     U key
        U = 85,
        //
        // Summary:
        //     V key
        V = 86,
        //
        // Summary:
        //     W key
        W = 87,
        //
        // Summary:
        //     X key
        X = 88,
        //
        // Summary:
        //     Y key
        Y = 89,
        //
        // Summary:
        //     Z key
        Z = 90,
        //
        // Summary:
        //     Left Windows key (Microsoft Natural keyboard)
        LWin = 91,
        //
        // Summary:
        //     Right Windows key (Natural keyboard)
        RWin = 92,
        //
        // Summary:
        //     Applications key (Natural keyboard)
        Apps = 93,
        //
        // Summary:
        //     Computer Sleep key
        Sleep = 95,
        //
        // Summary:
        //     Numeric keypad 0 key
        Numpad0 = 96,
        //
        // Summary:
        //     Numeric keypad 1 key
        Numpad1 = 97,
        //
        // Summary:
        //     Numeric keypad 2 key
        Numpad2 = 98,
        //
        // Summary:
        //     Numeric keypad 3 key
        Numpad3 = 99,
        //
        // Summary:
        //     Numeric keypad 4 key
        Numpad4 = 100,
        //
        // Summary:
        //     Numeric keypad 5 key
        Numpad5 = 101,
        //
        // Summary:
        //     Numeric keypad 6 key
        Numpad6 = 102,
        //
        // Summary:
        //     Numeric keypad 7 key
        Numpad7 = 103,
        //
        // Summary:
        //     Numeric keypad 8 key
        Numpad8 = 104,
        //
        // Summary:
        //     Numeric keypad 9 key
        Numpad9 = 105,
        //
        // Summary:
        //     Multiply key
        Multiply = 106,
        //
        // Summary:
        //     Add key
        Add = 107,
        //
        // Summary:
        //     Separator key
        Separator = 108,
        //
        // Summary:
        //     Subtract key
        Subtract = 109,
        //
        // Summary:
        //     Decimal key
        Decimal = 110,
        //
        // Summary:
        //     Divide key
        Divide = 111,
        //
        // Summary:
        //     F1 key
        F1 = 112,
        //
        // Summary:
        //     F2 key
        F2 = 113,
        //
        // Summary:
        //     F3 key
        F3 = 114,
        //
        // Summary:
        //     F4 key
        F4 = 115,
        //
        // Summary:
        //     F5 key
        F5 = 116,
        //
        // Summary:
        //     F6 key
        F6 = 117,
        //
        // Summary:
        //     F7 key
        F7 = 118,
        //
        // Summary:
        //     F8 key
        F8 = 119,
        //
        // Summary:
        //     F9 key
        F9 = 120,
        //
        // Summary:
        //     F10 key
        F10 = 121,
        //
        // Summary:
        //     F11 key
        F11 = 122,
        //
        // Summary:
        //     F12 key
        F12 = 123,
        //
        // Summary:
        //     F13 key
        F13 = 124,
        //
        // Summary:
        //     F14 key
        F14 = 125,
        //
        // Summary:
        //     F15 key
        F15 = 126,
        //
        // Summary:
        //     F16 key
        F16 = 127,
        //
        // Summary:
        //     F17 key
        F17 = 128,
        //
        // Summary:
        //     F18 key
        F18 = 129,
        //
        // Summary:
        //     F19 key
        F19 = 130,
        //
        // Summary:
        //     F20 key
        F20 = 131,
        //
        // Summary:
        //     F21 key
        F21 = 132,
        //
        // Summary:
        //     F22 key
        F22 = 133,
        //
        // Summary:
        //     F23 key
        F23 = 134,
        //
        // Summary:
        //     F24 key
        F24 = 135,
        //
        // Summary:
        //     NUM LOCK key
        NumLock = 144,
        //
        // Summary:
        //     SCROLL LOCK key
        Scroll = 145,
        //
        // Summary:
        //     SCROLL LOCK key
        ScrollLock = 145,
        //
        // Summary:
        //     Left SHIFT key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        LShift = 160,
        //
        // Summary:
        //     Right SHIFT key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        RShift = 161,
        //
        // Summary:
        //     Left CONTROL key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        LControl = 162,
        //
        // Summary:
        //     Right CONTROL key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        RControl = 163,
        //
        // Summary:
        //     Left Alt key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        LAlt = 164,
        //
        // Summary:
        //     Right Alt key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        RAlt = 165,
        //
        // Summary:
        //     Windows 2000/XP: Browser Back key
        BrowserBack = 166,
        //
        // Summary:
        //     Windows 2000/XP: Browser Forward key
        BrowserForward = 167,
        //
        // Summary:
        //     Windows 2000/XP: Browser Refresh key
        BrowserRefresh = 168,
        //
        // Summary:
        //     Windows 2000/XP: Browser Stop key
        BrowserStop = 169,
        //
        // Summary:
        //     Windows 2000/XP: Browser Search key
        BrowserSearch = 170,
        //
        // Summary:
        //     Windows 2000/XP: Browser Favorites key
        BrowserFavorites = 171,
        //
        // Summary:
        //     Windows 2000/XP: Browser Start and Home key
        BrowserHome = 172,
        //
        // Summary:
        //     Windows 2000/XP: Volume Mute key
        VolumeMute = 173,
        //
        // Summary:
        //     Windows 2000/XP: Volume Down key
        VolumeDown = 174,
        //
        // Summary:
        //     Windows 2000/XP: Volume Up key
        VolumeUp = 175,
        //
        // Summary:
        //     Windows 2000/XP: Next Track key
        MediaNextTrack = 176,
        //
        // Summary:
        //     Windows 2000/XP: Previous Track key
        MediaPrevTrack = 177,
        //
        // Summary:
        //     Windows 2000/XP: Stop Media key
        MediaStop = 178,
        //
        // Summary:
        //     Windows 2000/XP: Play/Pause Media key
        MediaPlayPause = 179,
        //
        // Summary:
        //     Windows 2000/XP: Start Mail key
        LaunchMail = 180,
        //
        // Summary:
        //     Windows 2000/XP: Select Media key
        LaunchMediaSelect = 181,
        //
        // Summary:
        //     Windows 2000/XP: Start Application 1 key
        LaunchApp1 = 182,
        //
        // Summary:
        //     Windows 2000/XP: Start Application 2 key
        LaunchApp2 = 183,
        //
        // Summary:
        //     Used for miscellaneous characters; it can vary by keyboard. Windows 2000/XP:
        //     For the US standard keyboard, the ';:' key
        Semicolon = 186,
        //
        // Summary:
        //     Windows 2000/XP: For any country/region, the '+' key
        Plus = 187,
        //
        // Summary:
        //     Windows 2000/XP: For any country/region, the ',' key
        Comma = 188,
        //
        // Summary:
        //     Windows 2000/XP: For any country/region, the '-' key
        Minus = 189,
        //
        // Summary:
        //     Windows 2000/XP: For any country/region, the '.' key
        Period = 190,
        //
        // Summary:
        //     Used for miscellaneous characters; it can vary by keyboard. Windows 2000/XP:
        //     For the US standard keyboard, the '/?' key
        Question = 191,
        //
        // Summary:
        //     Used for miscellaneous characters; it can vary by keyboard. Windows 2000/XP:
        //     For the US standard keyboard, the '`~' key
        Tilde = 192,
        //
        // Summary:
        //     Used for miscellaneous characters; it can vary by keyboard. Windows 2000/XP:
        //     For the US standard keyboard, the '[{' key
        OpenBrackets = 219,
        //
        // Summary:
        //     Used for miscellaneous characters; it can vary by keyboard. Windows 2000/XP:
        //     For the US standard keyboard, the '\|' key
        Backslash = 220,
        //
        // Summary:
        //     Used for miscellaneous characters; it can vary by keyboard. Windows 2000/XP:
        //     For the US standard keyboard, the ']}' key
        CloseBrackets = 221,
        //
        // Summary:
        //     Used for miscellaneous characters; it can vary by keyboard. Windows 2000/XP:
        //     For the US standard keyboard, the 'single-quote/double-quote' key
        Quotes = 222,
        //
        // Summary:
        //     Used for miscellaneous characters; it can vary by keyboard.
        Oem8 = 223,
        //
        // Summary:
        //     Windows 2000/XP: Either the angle bracket key or the backslash key on the RT
        //     102-key keyboard
        Oem102 = 226,
        //
        // Summary:
        //     Windows 95/98/Me, Windows NT 4.0, Windows 2000/XP: IME PROCESS key
        ProcessKey = 229,
        //
        // Summary:
        //     Windows 2000/XP: Used to pass Unicode characters as if they were keystrokes.
        //     The PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard
        //     input methods. For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN,
        //     and WM_KEYUP
        Packet = 231,
        //
        // Summary:
        //     Attn key
        Attn = 246,
        //
        // Summary:
        //     CrSel key
        Crsel = 247,
        //
        // Summary:
        //     ExSel key
        Exsel = 248,
        //
        // Summary:
        //     Erase EOF key
        EraseEoF = 249,
        //
        // Summary:
        //     Play key
        Play = 250,
        //
        // Summary:
        //     Zoom key
        Zoom = 251,
        //
        // Summary:
        //     Reserved
        NoName = 252,
        //
        // Summary:
        //     PA1 key
        PA1 = 253,
        //
        // Summary:
        //     Clear key
        OemClear = 254,
        //
        // Summary:
        //     The bitmask to extract a key code from a key value.
        KeyCode = 65535
    }
}
