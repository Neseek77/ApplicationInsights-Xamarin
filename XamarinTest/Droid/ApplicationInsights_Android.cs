﻿using System;
using Android;
using Android.App;
using Android.Content;
using Com.Microsoft.Applicationinsights.Library;
using XamarinTest.Droid;

[assembly: Xamarin.Forms.Dependency (typeof (ApplicationInsights_Android))]

namespace XamarinTest.Droid
{
	public class ApplicationInsights_Android : Java.Lang.Object, IApplicationInsights
	{
		public ApplicationInsights_Android ()
		{
		}

		public void Setup (string instrumentationKey){
			// TDOD: Align public interface of SDKs
		}

		public void Setup (Context context, Application application, string instrumentationKey){
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.Setup (context, application, instrumentationKey);
		}

		public void Start (){
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.Start ();
		}

		public string GetServerUrl (){
			return Com.Microsoft.Applicationinsights.Library.ApplicationInsights.Config.EndpointUrl;
		}

		public void SetServerUrl (string serverUrl){
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.Config.EndpointUrl = serverUrl;
		}

		public void  SetCrashManagerDisabled (bool crashManagerDisabled){
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.SetExceptionTrackingDisabled(crashManagerDisabled);
		}

		public void SetTelemetryManagerDisabled (bool telemetryManagerDisabled){
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.SetTelemetryDisabled(telemetryManagerDisabled);
		}

		public void SetAutoPageViewTrackingDisabled (bool autoPageViewTrackingDisabled){
			if (autoPageViewTrackingDisabled) {
				Com.Microsoft.Applicationinsights.Library.ApplicationInsights.DisableAutoPageViewTracking();
			} else {
				Com.Microsoft.Applicationinsights.Library.ApplicationInsights.EnableAutoPageViewTracking();
			}
		}

		public void SetAutoSessionManagementDisabled (bool autoSessionManagementDisabled){
			if (autoSessionManagementDisabled) {
				Com.Microsoft.Applicationinsights.Library.ApplicationInsights.DisableAutoSessionManagement();
			} else {
				Com.Microsoft.Applicationinsights.Library.ApplicationInsights.EnableAutoSessionManagement();
			}
		}

		public void SetUserId (string userId){
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.SetUserId (userId);
		}

		public void StartNewSession (){
		}

		public void SetSessionExpirationTime (int appBackgroundTime){
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.Config.SessionIntervalMs = appBackgroundTime;
		}

		public void RenewSessionWithId (string sessionId){
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.RenewSession (sessionId);
		}

		public bool GetAppStoreEnvironment() {
			return false;
		}

		public bool GetDebugLogEnabled() {
			return Com.Microsoft.Applicationinsights.Library.ApplicationInsights.DeveloperMode;
		}

		public void SetDebugLogEnabled(bool debugLogEnabled) {
			Com.Microsoft.Applicationinsights.Library.ApplicationInsights.DeveloperMode = debugLogEnabled;
		}

	}
}

