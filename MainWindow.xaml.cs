using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Trans {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void TextboxBeforeConverted_OnTextChanged(object sender, TextChangedEventArgs e) {
      Convert(TextboxBeforeConverted.Text, ComboboxBeforeConverted.SelectedIndex);
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e) {
      Convert(TextboxBeforeConverted.Text, ComboboxBeforeConverted.SelectedIndex);
    }

    private void Convert(string text, int fromLanguage) {
      TextboxAfterConverted.Text = FromLanguageToLatin(text, fromLanguage);
    }

    private string FromLanguageToLatin(string text, int fromLanguage) {
      if (fromLanguage == 0) {
        return text; // Latin
      }
      else if (fromLanguage == 1) {
        // Russian Cyrillic
        Dictionary<string, string> russianCyrillic = new Dictionary<string, string> {
          { "А", "A" }, { "Б", "B" }, { "В", "V" }, { "Г", "G" }, { "Д", "D" },
          { "Е", "YE" }, { "Ё", "YO" }, { "Ж", "ZH" }, { "З", "Z" }, { "И", "I" },
          { "Й", "J" }, { "К", "K" }, { "Л", "L" }, { "М", "M" }, { "Н", "N" },
          { "О", "O" }, { "П", "P" }, { "Р", "R" }, { "С", "S" }, { "Т", "T" },
          { "У", "U" }, { "Ф", "F" }, { "Х", "KH" }, { "Ц", "TS" }, { "Ч", "CH" },
          { "Ш", "SH" }, { "Щ", "SSH" }, { "Ъ", "‘’" }, { "Ы", "Y" }, { "Ь", "'" },
          { "Э", "E" }, { "Ю", "YU" }, { "Я", "YA" },
          { "а", "a" }, { "б", "b" }, { "в", "v" }, { "г", "g" }, { "д", "d" },
          { "е", "ye" }, { "ё", "yo" }, { "ж", "zh" }, { "з", "z" }, { "и", "i" },
          { "й", "j" }, { "к", "k" }, { "л", "l" }, { "м", "m" }, { "н", "n" },
          { "о", "o" }, { "п", "p" }, { "р", "r" }, { "с", "s" }, { "т", "t" },
          { "у", "u" }, { "ф", "f" }, { "х", "kh" }, { "ц", "ts" }, { "ч", "ch" },
          { "ш", "sh" }, { "щ", "ssh" }, { "ъ", "‘’" }, { "ы", "y" }, { "ь", "'" },
          { "э", "e" }, { "ю", "yu" }, { "я", "ya" }
        };

        foreach (var pair in russianCyrillic) {
          text = text.Replace(pair.Key, pair.Value);
        }

        return text;
      }
      else if (fromLanguage == 2) {
        // Ukrainian Cyrillic to Latin
        Dictionary<string, string> ukrainianCyrillic = new Dictionary<string, string> {
          { "Щ", "SCH" }, { "Ж", "ZH" }, { "Ц", "TS" }, { "Ч", "CH" }, { "Ш", "SH" }, { "Х", "KH" },
          { "А", "A" }, { "Б", "B" }, { "В", "V" }, { "Г", "H" }, { "Ґ", "G" },
          { "Д", "D" }, { "Е", "E" }, { "Є", "YE" }, { "З", "Z" }, { "И", "Y" },
          { "І", "I" }, { "Ї", "YI" }, { "Й", "J" }, { "К", "K" }, { "Л", "L" },
          { "М", "M" }, { "Н", "N" }, { "О", "O" }, { "П", "P" }, { "Р", "R" },
          { "С", "S" }, { "Т", "T" }, { "У", "U" }, { "Ф", "F" }, { "Ъ", "'" },
          { "Ю", "YU" }, { "Я", "YA" },
          { "щ", "sch" }, { "ж", "zh" }, { "ц", "ts" }, { "ч", "ch" }, { "ш", "sh" }, { "х", "kh" },
          { "а", "a" }, { "б", "b" }, { "в", "v" }, { "г", "h" }, { "ґ", "g" },
          { "д", "d" }, { "е", "e" }, { "є", "ye" }, { "з", "z" }, { "и", "y" },
          { "і", "i" }, { "ї", "yi" }, { "й", "j" }, { "к", "k" }, { "л", "l" },
          { "м", "m" }, { "н", "n" }, { "о", "o" }, { "п", "p" }, { "р", "r" },
          { "с", "s" }, { "т", "t" }, { "у", "u" }, { "ф", "f" }, { "ъ", "'" },
          { "ю", "yu" }, { "я", "ya" }
        };

        foreach (var pair in ukrainianCyrillic) {
          text = text.Replace(pair.Key, pair.Value);
        }

        return text;
      }
      else if (fromLanguage == 3) {
        // Greek Cyrillic
        Dictionary<string, string> greek = new Dictionary<string, string> {
          { "Α", "A" }, { "Β", "V" }, { "Γ", "G" }, { "Δ", "D" }, { "Ε", "E" },
          { "Ζ", "Z" }, { "Η", "I" }, { "Θ", "TH" }, { "Ι", "I" }, { "Κ", "K" },
          { "Λ", "L" }, { "Μ", "M" }, { "Ν", "N" }, { "Ξ", "KS" }, { "Ο", "O" },
          { "Π", "P" }, { "Ρ", "R" }, { "Σ", "S" }, { "Τ", "T" },
          { "Υ", "I" }, { "Φ", "F" }, { "Χ", "KH" }, { "Ψ", "PS" }, { "Ω", "O" },
          { "α", "a" }, { "β", "v" }, { "γ", "g" }, { "δ", "d" }, { "ε", "e" },
          { "ζ", "z" }, { "η", "i" }, { "θ", "th" }, { "ι", "i" }, { "κ", "k" },
          { "λ", "l" }, { "μ", "m" }, { "ν", "n" }, { "ξ", "ks" }, { "ο", "o" },
          { "π", "p" }, { "ρ", "r" }, { "σ", "s" }, { "ς", "s" }, { "τ", "t" },
          { "υ", "i" }, { "φ", "f" }, { "χ", "kh" }, { "ψ", "ps" }, { "ω", "o" },

          { "ά", "á" }, { "έ", "é" }, { "ή", "í" }, { "ί", "í" }, { "ό", "ó" },
          { "ύ", "ý" }, { "ώ", "ó" }, { "Ά", "Á" }, { "Έ", "É" }, { "Ή", "Í" },
          { "Ί", "Í" }, { "Ό", "Ó" }, { "Ύ", "Ý" }, { "Ώ", "Ó" }, { "ϊ", "ï" },
          { "ϋ", "ÿ" }, { "ΐ", "ï" }, { "ΰ", "ÿ" }, { "Ϊ", "Ï" }, { "Ϋ", "Ÿ" }
        };

        foreach (var pair in greek) {
          text = text.Replace(pair.Key, pair.Value);
        }

        return text;
      }

      return null;
    }
  }
}