using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Ads.Mediation.Adcolony
{
    public partial class AdColonyMediationAdapter
    {
		public override unsafe void Initialize(global::Android.Content.Context p0, global::Android.Gms.Ads.Mediation.IInitializationCompleteCallback p1, global::System.Collections.Generic.IList<global::Android.Gms.Ads.Mediation.MediationConfiguration> p2)
		{
			const string __id = "initialize.(Landroid/content/Context;Lcom/google/android/gms/ads/mediation/InitializationCompleteCallback;Ljava/util/List;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Android.Gms.Ads.Mediation.MediationConfiguration>.ToLocalJniHandle(p2);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[3];
				__args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
				__args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
				__args[2] = new JniArgumentValue(native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p2);
			}
		}
	}
}