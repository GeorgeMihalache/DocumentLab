﻿namespace DocumentLab.Ocr
{
  using Core.Storage;
  using System;
  using System.Drawing.Imaging;
  using System.Collections.Generic;

  public static class Constants
  {
    // External paths
    public static string OcrFixDictionaryConfigurationPath = "data\\configuration\\OcrFixDictionary.json";
    public static string OcrConfigurationPath = "data\\configuration\\OcrConfiguration.json";
    public static string HOcrModifiersConfigurationPath = "data\\configuration\\HOcrModifiers.json";

    // Configuration objects
    public static Dictionary<string, string> OcrConfiguration = JsonSerializer.FromFile<Dictionary<string, string>>(Constants.OcrConfigurationPath);
    public static Dictionary<string, string> OcrFixDictionary = JsonSerializer.FromFile<Dictionary<string, string>>(Constants.OcrFixDictionaryConfigurationPath);
    public static string[] HOcrModifiers = JsonSerializer.FromFile<String[]>(Constants.HOcrModifiersConfigurationPath);

    // OCR
    public static string LanguageFilePath => "tessdata";
    public static string DefaultLanguage => DocumentLab.Core.Constants.Language;
    public static int ResultChunkSize => int.Parse(OcrConfiguration["ResultChunkSize"]);
    public static int TesseractEnginePoolSize => int.Parse(OcrConfiguration["TesseractEnginePoolSize"]);
    public static int NumberOfThreads => int.Parse(OcrConfiguration["NumberOfThreads"]);
    public static ImageFormat ConvertBetween => ImageFormat.MemoryBmp;
  }
}
