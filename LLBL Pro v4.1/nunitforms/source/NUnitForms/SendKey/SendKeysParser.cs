#region Copyright (c) 2003-2005, Luke T. Maxon

/********************************************************************************************************************
'
' Copyright (c) 2003-2005, Luke T. Maxon
' All rights reserved.
' 
' Redistribution and use in source and binary forms, with or without modification, are permitted provided
' that the following conditions are met:
' 
' * Redistributions of source code must retain the above copyright notice, this list of conditions and the
' 	following disclaimer.
' 
' * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and
' 	the following disclaimer in the documentation and/or other materials provided with the distribution.
' 
' * Neither the name of the author nor the names of its contributors may be used to endorse or 
' 	promote products derived from this software without specific prior written permission.
' 
' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED
' WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
' PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
' ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
' LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
' INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
' OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN
' IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
'
'*******************************************************************************************************************/

#endregion

using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Extensions.Forms.Win32Interop;

namespace NUnit.Extensions.Forms.SendKey
{
	public class SendKeysParser : ISendKeysParser
	{
		private readonly List<SendKeysParserGroup> groups = new List<SendKeysParserGroup>();

		private readonly List<string> groupModifiers = new List<string>();
		private readonly List<VirtualKeyCodes> escapedKeyCodes = new List<VirtualKeyCodes>();
		private readonly List<string> bodyTexts = new List<string>();

		private const string groupsPattern = @"(?<group> ([\(\{+^%~\[] .+? [\)\}]) | ([^\(\{+^%~\[\)\}]+) | ([+^%~].) )";
		private const string modifiersPattern = @"^(?<modifier> [+^%~] + )? (?<escapedKey>\{ [^\}]+? \})? ([\(\{\[]? (?<body> .*? )? [\)\}\]]?) $";
		private readonly Dictionary<string, VirtualKeyCodes> keyValueMap = new Dictionary<string, VirtualKeyCodes>();

		public SendKeysParser(string sendKeysFormattedText)
		{
			InitialiseKeyValueMap();

			Regex regex = new Regex(groupsPattern, RegexOptions.IgnorePatternWhitespace);
			MatchCollection matches = regex.Matches(sendKeysFormattedText);
			List<string> groupsList = new List<string>();
			foreach (Match match in matches)
			{
				groupsList.Add(match.Value);
			}

			foreach (string group in groupsList)
			{
				ParseGroupElements(group);
			}
		}

		private void InitialiseKeyValueMap()
		{
			keyValueMap.Add("{BACKSPACE}", VirtualKeyCodes.BACK);
			keyValueMap.Add("{BS}", VirtualKeyCodes.BACK);
			keyValueMap.Add("{BKSP}", VirtualKeyCodes.BACK);

			keyValueMap.Add("{DELETE}", VirtualKeyCodes.DELETE);
			keyValueMap.Add("{DEL}", VirtualKeyCodes.DELETE);
			keyValueMap.Add("{DOWN}", VirtualKeyCodes.DOWN);
			keyValueMap.Add("{END}", VirtualKeyCodes.END);
			keyValueMap.Add("{ENTER}", VirtualKeyCodes.RETURN);
			keyValueMap.Add("{ESC}", VirtualKeyCodes.ESCAPE);
			keyValueMap.Add("{HELP}", VirtualKeyCodes.HELP);
			keyValueMap.Add("{HOME}", VirtualKeyCodes.HOME);
			keyValueMap.Add("{INSERT}", VirtualKeyCodes.INSERT);
			keyValueMap.Add("{INS}", VirtualKeyCodes.INSERT);

			keyValueMap.Add("{F1}", VirtualKeyCodes.F1);
			keyValueMap.Add("{F2}", VirtualKeyCodes.F2);
			keyValueMap.Add("{F3}", VirtualKeyCodes.F3);
			keyValueMap.Add("{F4}", VirtualKeyCodes.F4);
			keyValueMap.Add("{F5}", VirtualKeyCodes.F5);
			keyValueMap.Add("{F6}", VirtualKeyCodes.F6);
			keyValueMap.Add("{F7}", VirtualKeyCodes.F7);
			keyValueMap.Add("{F8}", VirtualKeyCodes.F8);
			keyValueMap.Add("{F9}", VirtualKeyCodes.F9);
			keyValueMap.Add("{F10}", VirtualKeyCodes.F10);
			keyValueMap.Add("{F11}", VirtualKeyCodes.F11);
			keyValueMap.Add("{F12}", VirtualKeyCodes.F12);
			keyValueMap.Add("{F13}", VirtualKeyCodes.F13);
			keyValueMap.Add("{F14}", VirtualKeyCodes.F14);
			keyValueMap.Add("{F15}", VirtualKeyCodes.F15);
			keyValueMap.Add("{F16}", VirtualKeyCodes.F16);
		}

		private void ParseGroupElements(string group)
		{
			Regex regex = new Regex(modifiersPattern, RegexOptions.IgnorePatternWhitespace);

			string modifierCharacters = string.Empty;
			VirtualKeyCodes keyCode = VirtualKeyCodes.None; 
			string bodyText = string.Empty;

			MatchCollection match = regex.Matches(group);
			if (match.Count == 1)
			{
				Group modiferGroup = match[0].Groups["modifier"];
				if (modiferGroup.Success)
				{
					modifierCharacters = modiferGroup.Value;
				}

				Group escapedKeyGroup = match[0].Groups["escapedKey"];
				if (escapedKeyGroup.Success)
				{
					if (keyValueMap.TryGetValue(escapedKeyGroup.Value, out keyCode) == false)
					{
						keyCode = VirtualKeyCodes.None;
						if (escapedKeyGroup.Value.Length == 3)
						{
							// escaped character
							bodyText = escapedKeyGroup.Value.Substring(1,1);
						}
					}
				}

				if (bodyText == string.Empty)
				{
					Group bodyGroup = match[0].Groups["body"];
					if (bodyGroup.Success)
					{
						bodyText = bodyGroup.Value;
					}
				}
			}

			groupModifiers.Add(modifierCharacters);
			escapedKeyCodes.Add(keyCode);
			bodyTexts.Add(bodyText);

			groups.Add(new SendKeysParserGroup(modifierCharacters, bodyText, keyCode));
		}

		public int GroupCount
		{
			get { return bodyTexts.Count; }
		}

		public string[] Modifiers
		{
			get { return groupModifiers.ToArray(); }
		}

		public VirtualKeyCodes[] EscapedKeys
		{
			get { return escapedKeyCodes.ToArray();  }
		}

		public string[] Text
		{
			get { return bodyTexts.ToArray(); }
		}

		public ISendKeysParserGroup[] Groups
		{
			get { return groups.ToArray(); }
		}
	}
}