// Copyright 2004-2008 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// -------------------------------------------------------------------------------
// Changes:
// - June 6th, 2008. FB / Solutions Design: adapted code to LLBLGen Pro coding standards:
//					 namespace change, extra comments, variable name changes to meet the standard used in the LLBLGen Pro system code.
// - June 7th, 2008. FB / Solutions Design: changed a couple of lines to fix a small issue and to add the compiled flag to the regex. Changed Arraylist
//					 into List<string> and List<Rule>
// -------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AW.LLBLGen.Plugins
{
  /// <summary>
  /// The Inflector class transforms words from one 
  /// form to another. For example, from singular to plural.
  /// </summary>
  public class Inflector
  {

    #region Private class declarations
    /// <summary>
    /// Rule class for defining a transformation rule
    /// </summary>
    private class Rule
    {
      #region Class Member Declarations
      private readonly Regex _regexToUse;
      private readonly string _replacement;
      #endregion

      /// <summary>
      /// Initializes a new instance of the <see cref="Rule"/> class.
      /// </summary>
      /// <param name="pattern">The pattern.</param>
      /// <param name="replacement">The replacement.</param>
      public Rule(string pattern, string replacement)
      {
        // [FB] Added Compiled flag to Regex constructor call so execution is sped up. 
        _regexToUse = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        _replacement = replacement;
      }

      /// <summary>
      /// Applies the specified word.
      /// </summary>
      /// <param name="word">The word.</param>
      /// <returns></returns>
      public string Apply(string word)
      {
        if(!_regexToUse.IsMatch(word))
        {
          return null;
        }

        return _regexToUse.Replace(word, _replacement);
      }
    }
    #endregion

    #region Statics
    // [FB] made rule list generic, so performance is higher as rule lists are checked a lot
    private static readonly List<Rule> _plurals = new List<Rule>();
    private static readonly List<Rule> _singulars = new List<Rule>();
    private static readonly List<string> _uncountables = new List<string>();
    #endregion


    /// <summary>
    /// Initializes a new instance of the <see cref="Inflector"/> class.
    /// </summary>
    private Inflector()
    {
    }


    /// <summary>
    /// Initializes the <see cref="Inflector"/> class.
    /// </summary>
    static Inflector()
    {
      AddPlural("$", "s");
      AddPlural("s$", "s");
      AddPlural("(ax|test)is$", "$1es");
      AddPlural("(octop|vir)us$", "$1i");
      AddPlural("(alias|status)$", "$1es");
      AddPlural("(bu)s$", "$1ses");
      AddPlural("(buffal|tomat)o$", "$1oes");
      AddPlural("([ti])um$", "$1a");
      AddPlural("sis$", "ses");
      AddPlural("(?:([^f])fe|([lr])f)$", "$1$2ves");
      AddPlural("(hive)$", "$1s");
      AddPlural("([^aeiouy]|qu)y$", "$1ies");
      AddPlural("(x|ch|ss|sh)$", "$1es");
      AddPlural("(matr|vert|ind)ix|ex$", "$1ices");
      AddPlural("([m|l])ouse$", "$1ice");
      AddPlural("^(ox)$", "$1en");
      AddPlural("(quiz)$", "$1zes");

      AddSingular("s$", "");
      AddSingular("(n)ews$", "$1ews");
      AddSingular("([ti])a$", "$1um");
      AddSingular("((a)naly|(b)a|(d)iagno|(p)arenthe|(p)rogno|(s)ynop|(t)he)ses$", "$1$2sis");
      AddSingular("(^analy)ses$", "$1sis");
      AddSingular("([^f])ves$", "$1fe");
      AddSingular("(hive)s$", "$1");
      AddSingular("(tive)s$", "$1");
      AddSingular("([lr])ves$", "$1f");
      AddSingular("([^aeiouy]|qu)ies$", "$1y");
      AddSingular("(s)eries$", "$1eries");
      AddSingular("(m)ovies$", "$1ovie");
      AddSingular("(x|ch|ss|sh)es$", "$1");
      AddSingular("([m|l])ice$", "$1ouse");
      AddSingular("(bus)es$", "$1");
      AddSingular("(o)es$", "$1");
      AddSingular("(shoe)s$", "$1");
      AddSingular("(cris|ax|test)es$", "$1is");
      AddSingular("(octop|vir)i$", "$1us");
      AddSingular("(alias|status)es$", "$1");
      AddSingular("^(ox)en", "$1");
      AddSingular("(vert|ind)ices$", "$1ex");
      AddSingular("(matr)ices$", "$1ix");
      AddSingular("(quiz)zes$", "$1");

      AddIrregular("person", "people");
      AddIrregular("man", "men");
      AddIrregular("child", "children");
      AddIrregular("sex", "sexes");
      AddIrregular("move", "moves");

      AddUncountable("equipment");
      AddUncountable("information");
      AddUncountable("rice");
      AddUncountable("money");
      AddUncountable("species");
      AddUncountable("series");
      AddUncountable("fish");
      AddUncountable("sheep");
    }


    /// <summary>
    /// Return the plural of a word.
    /// </summary>
    /// <param name="word">The singular form</param>
    /// <returns>The plural form of <paramref name="word"/></returns>
    public static string Pluralize(string word)
    {
      return ApplyRules(_plurals, word);
    }


    /// <summary>
    /// Return the singular of a word.
    /// </summary>
    /// <param name="word">The plural form</param>
    /// <returns>The singular form of <paramref name="word"/></returns>
    public static string Singularize(string word)
    {
      return ApplyRules(_singulars, word);
    }


    /// <summary>
    /// Capitalizes a word.
    /// </summary>
    /// <param name="word">The word to be capitalized.</param>
    /// <returns><paramref name="word"/> capitalized.</returns>
    public static string Capitalize(string word)
    {
      return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
    }


    /// <summary>
    /// Adds the passed in irregular form
    /// </summary>
    /// <param name="singular">The singular.</param>
    /// <param name="plural">The plural.</param>
    private static void AddIrregular(string singular, string plural)
    {
      AddPlural("(" + singular[0] + ")" + singular.Substring(1) + "$", "$1" + plural.Substring(1));
      AddSingular("(" + plural[0] + ")" + plural.Substring(1) + "$", "$1" + singular.Substring(1));
    }


    /// <summary>
    /// Adds the passed in uncountable form
    /// </summary>
    /// <param name="word">The word.</param>
    private static void AddUncountable(string word)
    {
      _uncountables.Add(word.ToLower());
    }


    /// <summary>
    /// Adds the plural conversion rule with the replacement to use.
    /// </summary>
    /// <param name="rule">The rule.</param>
    /// <param name="replacement">The replacement.</param>
    private static void AddPlural(string rule, string replacement)
    {
      _plurals.Add(new Rule(rule, replacement));
    }


    /// <summary>
    /// Adds the singular conversion rule with the replacement to use.
    /// </summary>
    /// <param name="rule">The rule.</param>
    /// <param name="replacement">The replacement.</param>
    private static void AddSingular(string rule, string replacement)
    {
      _singulars.Add(new Rule(rule, replacement));
    }


    /// <summary>
    /// Applies the rules passed in to the word passed in
    /// </summary>
    /// <param name="rules">The rules.</param>
    /// <param name="word">The word.</param>
    /// <returns>Result of the rule application on the word passed in.</returns>
    private static string ApplyRules(List<Rule> rules, string word)
    {
      string result = word;

      if (!_uncountables.Contains(word.ToLower()))
      {
        for (int i = rules.Count - 1; i >= 0; i--)
        {
          Rule rule = rules[i];

          if ((result = rule.Apply(word)) != null)
          {
            break;
          }
        }
      }

      // [FB] Fixed an issue in the Castle Inflector version where it would return null if no rule applied. This isn't what
      // callcode expects, so we in that case return word again.
      if(result == null)
      {
        result = word;
      }
      return result;
    }
  }
}