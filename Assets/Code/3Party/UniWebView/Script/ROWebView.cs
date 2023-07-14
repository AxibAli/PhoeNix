using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[SLua.CustomLuaClassAttribute]
public class ROWebView:Singleton<ROWebView>
{
	private UniWebView _webView;
	public UniWebView webView 
	{
		get{
			if (_webView==null)
			{
				GameObject go = new GameObject("WebView");
				_webView = go.AddComponent<UniWebView>();
			}
			return _webView;
		}
	}
	public bool toolBarShow = false;
	public string url = "";
	public static ROWebView Instance
	{
		get
		{
			return ins;
		}
	}

	private UniWebViewEdgeInsets savedInsets = new UniWebViewEdgeInsets(0,0,0,0);


	public void OpenButtonClicked() {
		webView.OnLoadComplete += OnLoadComplete;
		webView.InsetsForScreenOreitation += InsetsForScreenOreitation;
		webView.toolBarShow = toolBarShow;
		webView.url = url;
		webView.Load();
	}

	public void GoBack()
	{
		if (webView!=null) {
			if (webView.CanGoBack ()) {
				webView.GoBack ();
			}
		}
	}

	public void GoForward()
	{
		if (webView!=null) {
			if (webView.CanGoForward ()) {
				webView.GoForward ();
			}
		}
	}

	public void Reload()
	{
		if (webView!=null) {
			webView.Reload ();
		}
	}

	public void Show()
	{
		if (webView!=null) {
			webView.Show ();
		}
	}

	public void ShowToolBar(bool animate)
	{
		if (webView!=null) {
			webView.ShowToolBar (animate);
		}
	}

	public void SetUserAgent(string value)
	{
		UniWebView.SetUserAgent (value);
	}

	public void SetInsets(int aTop, int aLeft, int aBottom, int aRight)
	{
		if (webView!=null) {
			webView.insets = new UniWebViewEdgeInsets (aTop, aLeft, aBottom, aRight);
		}
	}

	public void SetSavedInsets(int aTop, int aLeft, int aBottom, int aRight)
	{
		savedInsets.top = aTop;
		savedInsets.left = aLeft;
		savedInsets.bottom = aBottom;
		savedInsets.right = aRight;
	}

	public void CleanCache()
	{
		if (webView!=null) {
			webView.CleanCache ();
		}
	}
		
	public void Hide(bool fade)
	{
		if (webView!=null) {
			webView.Stop ();
			webView.Hide (fade);
		}
	}
		
	void OnLoadComplete(UniWebView webView, bool success, string errorMessage) {
		if (success) {
			webView.Show();
		} else {
			Debug.Log("Something wrong in webview loading: " + errorMessage);
		}
	}

	UniWebViewEdgeInsets InsetsForScreenOreitation(UniWebView webView, UniWebViewOrientation orientation) {
		if (orientation == UniWebViewOrientation.Portrait) {
			return savedInsets;
		} else {
			return savedInsets;
		}
	}

}


//    public static UniWebView CreateWebView(GameObject parent = null)
//    {
//        UniWebView webview = null;
//        if (parent != null) webview = parent.GetComponentInChildren<UniWebView>();
//        GameObject obj = webview != null ? webview.gameObject : new GameObject();
//        if (webview == null) webview = obj.GetComponent<UniWebView>();
//        if (webview == null)
//        {
//            webview = obj.AddComponent<UniWebView>();
//        }
//        obj.transform.parent = parent.transform;
//        return webview;
//    }
//
////    public static void OnPageFinished(UniWebView webView, UniWebView.PageFinishedDelegate onComplete = null)
////    {
////        if (webView == null) return;
////        webView.OnPageFinished += onComplete;
////    }
//
//    public static void LoadUrl(UniWebView webView = null, string url = null)
//    {
//        if (webView == null) return;
//        if (url == null) return;
//        webView.Load(url);
//    }
//
//    public static void Reload(UniWebView webView)
//    {
//        if (webView != null) webView.Reload();
//    }
//
//    public static void Show(UniWebView webView = null)
//    {
//        if (webView != null) webView.Show();
//    }
//
////    public static void SetFrame(UniWebView webView, int top = 0, int left = 0, int bottom = 0, int right = 0)
////    {
////        if (webView == null) return;
////        webView.Frame = new Rect(top, left, bottom, right);
////    }
////
////    public static void SetReferenceRectTransform(UniWebView webView, RectTransform rectTransfrom)
////    {
////        if (webView == null) return;
////        webView.ReferenceRectTransform = rectTransfrom;
////    }
////
////    public static void LoadOnStart(UniWebView webView, bool loadOnStart = true)
////    {
////        if (webView == null) return;
////        webView.showOnStart = loadOnStart;
////    }
////
////    public static void BackButtonEnable(UniWebView webView, bool enable = true)
////    {
////        if (webView == null) return;
////        webView.SetBackButtonEnabled(enable);
////    }
//
//    public static void GoBack(UniWebView webView)
//    {
//        if (webView != null) webView.GoBack();
//    }
//
//    public static void GoForward(UniWebView webView)
//    {
//        if (webView != null) webView.GoForward();
//    }
//
//    public static void ClearCache(UniWebView webView)
//    {
//        if (webView != null) webView.CleanCache();
//    }
//
//    public static void ShowToolBar(UniWebView webView, bool show = true)
//    {
//        //if (webView != null) webView.useToolbar = show;
//    }
//
//    public static void SetShowToolBar(UniWebView webView, bool show = true)
//    {
//        if (webView == null) return;
//        //webView.SetShowToolbar(show);
//    }
//
//    public static void Hide(UniWebView webView, bool fade)
//    {
//        if (webView != null) webView.Hide(fade);
//    }
//
//    public static void SetOnWebViewShouldClose(UniWebView webView, Func<bool> check = null)
//    {
//        if (webView == null) return;
//        //webView.OnShouldClose += view => { return check(); };
//    }
//
//    public static void SetOpenLinksInExBrowser(UniWebView webView, bool flag = false)
//    {
//        if (webView == null) return;
//        //webView.SetOpenLinksInExternalBrowser(flag);
//    }
//
//    public static void SetUserAgent(UniWebView webView,string userAgent)
//    {
//        if (webView == null) return;
//        if (string.IsNullOrEmpty(userAgent)) return;
//        //webView.SetUserAgent(userAgent);
//    }
//
//    public static string URL(UniWebView webView)
//    {
//        //if (webView != null) return webView.Url;
//        return null;
//    }
//
//    public static void ZoomEnable(UniWebView webView, bool enable)
//    {
//        if (webView == null) return;
//        //webView.SetZoomEnabled(enable);
//    }
//
//    public static string GetUserAgent(UniWebView webView)
//    {
//        if (webView == null) return null;
//        //return webView.GetUserAgent();
//
//		return null;
//    }
//
//    public static void SetUseWideViewPort(UniWebView webView, bool use)
//    {
//        if (webView != null) webView.SetUseWideViewPort(use);
//    }
//
//    public static void SetLoadWithOverviewMode(UniWebView webView, bool overview)
//    {
//        //if (webView != null) webView.SetImmersiveModeEnabled(overview);
//    }
//
//    public static void SetHeaderField(UniWebView webView, string key, string value)
//    {
//        if (webView != null && !string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
//        {
//            webView.SetHeaderField(key, value);
//        }
//    }
//
//    public static void AddTrustWriteSite(UniWebView webView, string url)
//    {
//        if (webView != null && !string.IsNullOrEmpty(url))
//        {
//            //webView.AddPermissionTrustDomain(url);
//        }
//    }
//
//    public static void AddOnLoadBegin(UniWebView webView, Action<string> onLoadBegin)
//    {
//        //if (webView != null && onLoadBegin != null) webView.OnPageStarted += (view, url) => { onLoadBegin(url); };
//    }
//
////    public static void AddOnLoadBeginFunc(UniWebView webView, UniWebView.PageStartedDelegate onLoadBegin)
////    {
////        if (webView != null && onLoadBegin != null)
////        {
////            webView.OnPageStarted += onLoadBegin;
////        }
////    }
//
//    public static void AddOnRecvMessage(UniWebView webView, Action<UniWebViewMessage> recvMsg)
//    {
//        if (webView != null && recvMsg != null)
//        {
//            //webView.OnMessageReceived += (view, msg) => { recvMsg(msg); };
//        }
//    }
//
////    public static void AddOnRecvMessageFunc(UniWebView webView, UniWebView.MessageReceivedDelegate recvMsg)
////    {
////        if (webView != null && recvMsg != null)
////        {
////            webView.OnMessageReceived += recvMsg;
////        }
////    }
//
//    public static void SetToolbarDoneButtonText(UniWebView webView,string txt)
//    {
//        if (txt != null && webView != null)
//        {
//            //webView.SetToolbarDoneButtonText(txt);
//        }
//    }
//
//    public static void AddUrlScheme(UniWebView webView, string scheme)
//    {
//        if (webView != null && !string.IsNullOrEmpty(scheme))
//        {
//            webView.AddUrlScheme(scheme);
//        }
//    }
//
//    public static void RemoveUrlScheme(UniWebView webView, string scheme)
//    {
//        if (webView != null && !string.IsNullOrEmpty(scheme))
//        {
//            webView.RemoveUrlScheme(scheme);
//        }
//    }
//
//    public static void SetVerticalScrollBarShow(UniWebView webView, bool show)
//    {
//        if (webView != null)
//        {
//            //webView.SetVerticalScrollBarEnabled(show);
//        }
//    }
//
//    public static void SetHorizonScrollBarShow(UniWebView webView, bool show)
//    {
//        if (webView != null)
//        {
//            //webView.SetHorizontalScrollBarEnabled(show);
//        }
//    }
//
//    public static void GetInsets4f(GameObject anchor, out float top, out float left, out float bottom, out float right)
//    {
//        top = left = bottom = right = 0f;
//        if (anchor == null) return;
//        UIWidget widget = anchor.GetComponent<UIWidget>();
//        if (widget == null) return;
//
//        widget.ResetAndUpdateAnchors();
//        Camera cam = widget.anchorCamera;
//        // bottomleft topleft topright bottomright clockwise
//        Vector3 bottomLeft = cam.WorldToScreenPoint(widget.worldCorners[0]);
//        Vector3 topRight = cam.WorldToScreenPoint(widget.worldCorners[2]);
//
//        top = Screen.height - topRight.y;
//        left = bottomLeft.x;
//        bottom = bottomLeft.y;
//        right = Screen.width - topRight.x;
//    }
//
//    public static void GetInsets4fi(float top, float left, float bottom, float right, out int _top, out int _left, out int _bottom, out int _right)
//    {
//        _top = (int)top;
//        _left = (int)left;
//        _bottom = (int)bottom;
//        _right = (int)right;
//#if UNITY_IPHONE && !UNITY_EDITOR
//        // 还有一种计算是用 screenWidth / Screen.width 来计算每个point对应的pixels
//        //_top = (int)(top / UniWebViewHelper.screenScale);
//        //_left = (int)(left / UniWebViewHelper.screenScale);
//        //_bottom = (int)(bottom / UniWebViewHelper.screenScale);
//        //_right = (int)(right / UniWebViewHelper.screenScale);
//#endif
//    }
//
//    public static void GetInsets(GameObject anchor, out int top, out int left, out int bottom, out int right)
//    {
//        float _top, _left, _bottom, _right;
//        GetInsets4f(anchor, out _top, out _left, out _bottom, out _right);
//        GetInsets4fi(_top, _left, _bottom, _right, out top, out left, out bottom, out right);
//    }
//}
