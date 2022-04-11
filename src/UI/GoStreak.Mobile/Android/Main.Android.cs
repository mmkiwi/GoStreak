// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System;

using Android.Runtime;

using Com.Nostra13.Universalimageloader.Core;

using Microsoft.UI.Xaml.Media;

namespace GoStreak.Droid
{
    [global::Android.App.ApplicationAttribute(
		Label = "@string/ApplicationName",
		Icon = "@mipmap/icon",
		LargeHeap = true,
		HardwareAccelerated = true,
		Theme = "@style/AppTheme"
	)]
	public class Application : Microsoft.UI.Xaml.NativeApplication
	{
		public Application(IntPtr javaReference, JniHandleOwnership transfer)
			: base(() => new App(), javaReference, transfer)
		{
			ConfigureUniversalImageLoader();
		}

		private static void ConfigureUniversalImageLoader()
		{
			// Create global configuration and initialize ImageLoader with this config
			ImageLoaderConfiguration config = new ImageLoaderConfiguration
				.Builder(Context)
				.Build();

			ImageLoader.Instance.Init(config);

			ImageSource.DefaultImageLoader = ImageLoader.Instance.LoadImageAsync;
		}
	}
}
