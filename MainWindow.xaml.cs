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
        // Russian Cyrillic to Latin
        Dictionary<string, string> cyrillicToLatin = new Dictionary<string, string> {
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

        foreach (var pair in cyrillicToLatin) {
          text = text.Replace(pair.Key, pair.Value);
        }

        return text;
      }

      return null;
    }
  }
}