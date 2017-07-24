using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSI_Keyboard_LED_Manager.Classes {
	class Startup {
		public static String name = "MSI Keyboard LED Manager";
		public static String location = System.Reflection.Assembly.GetEntryAssembly().Location;

		public static void Add() {
			Startup.Remove();

			RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			key.SetValue(Startup.name, Startup.location);
			key.Close();
		}

		public static void Remove() {
			RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

			if(key.GetValue(Startup.name) != null)
				key.DeleteValue(Startup.name);

			key.Close();
		}

		public static bool Check() {
			RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

			if (key.GetValue(Startup.name) != null)
				return key.GetValue(Startup.name).Equals(Startup.location);
			else
				return false;
		}
	}
}
