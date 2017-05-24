// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SwitchTestApp.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }

    #region Setting Constants

    private const string SettingsKey = "settings_key";
    private static readonly string SettingsDefault = string.Empty;

    // Initial favourites set
    private const string InitFavSetKey = "Init_Fav_Set_key";
    private static readonly bool InitFavSetKeyDefault = true;

    // Initial favourites set
    private const string InitRegSetKey = "Init_Reg_Set_key";
    private static readonly bool InitRegSetKeyDefault = true;

        #endregion


        public static string GeneralSettings
    {
      get
      {
        return AppSettings.GetValueOrDefault<string>(SettingsKey, SettingsDefault);
      }
      set
      {
        AppSettings.AddOrUpdateValue<string>(SettingsKey, value);
      }
    }

      public static bool InitFavSet
      {
          get
          {
              return AppSettings.GetValueOrDefault(InitFavSetKey, InitFavSetKeyDefault);
          }
          set
          {
              AppSettings.AddOrUpdateValue(InitFavSetKey, value);
          }
      }

      public static bool InitRegSet
      {
          get
          {
              return AppSettings.GetValueOrDefault(InitRegSetKey, InitRegSetKeyDefault);
          }
          set
          {
              AppSettings.AddOrUpdateValue(InitRegSetKey, value);
          }
      }

    }
}