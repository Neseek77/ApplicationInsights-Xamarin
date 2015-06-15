﻿using System;
using Android;
using Android.Runtime;
using Android.App;
using Android.Content;
using Com.Microsoft.Applicationinsights.Library;
using System.Collections.Generic;
using XamarinTest.Droid;

[assembly: Xamarin.Forms.Dependency (typeof (TelemetryManager_Android))]

namespace XamarinTest.Droid
{
	public class TelemetryManager_Android : Java.Lang.Object, ITelemetryManager
	{

		public TelemetryManager_Android(){}

		public void TrackEvent (string eventName)
		{
			TelemetryClient.Instance.TrackEvent (eventName);
		}

		public void TrackEvent (string eventName, Dictionary<string, string> properties)
		{
			TelemetryClient.Instance.TrackEvent (eventName, properties);
		}

		public void TrackEvent (string eventName, Dictionary<string, string> properties, Dictionary<string, double> measurements)
		{
			TelemetryClient.Instance.TrackEvent(eventName, properties, null);
		}

		public void TrackTrace (string message)
		{
			TelemetryClient.Instance.TrackTrace (message);
		}

		public void TrackTrace (string message, Dictionary<string, string> properties)
		{
			TelemetryClient.Instance.TrackTrace (message, properties);
		}

		public void TrackMetric (string metricName, double value)
		{
			TelemetryClient.Instance.TrackMetric (metricName, value);
		}

		public void TrackMetric (string metricName, double value, Dictionary<string, string> properties)
		{
			TelemetryClient.Instance.TrackMetric (metricName, value);
		}

		public void TrackPageView (string pageName)
		{
			TelemetryClient.Instance.TrackPageView (pageName);
		}

		public void TrackPageView (string pageName, int duration)
		{
			TelemetryClient.Instance.TrackPageView (pageName);
		}

		public void TrackPageView (string pageName, int duration, Dictionary<string, string> properties)
		{
			TelemetryClient.Instance.TrackPageView (pageName, properties);
		}

		public void TrackManagedException (Exception  exception, bool handled)
		{
			if (exception != null) {
			}	
		}

	}
}

