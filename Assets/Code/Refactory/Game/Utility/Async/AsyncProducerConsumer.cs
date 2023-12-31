﻿using UnityEngine;
using System.Collections.Generic;
using System.Threading;
using Ghost.Utility;

namespace Ghost.Async
{
	public abstract class ProducerConsumerBase
	{
		protected class Context : System.IDisposable
		{
			public bool closed{get; private set;}

			private object productContainerLocker = new object();
			private ReuseableList<object> productContainer;
			private ObjectPool<ReuseableList<object>> containerPool;

			public Context()
			{
				closed = false;
				containerPool = new ObjectPool<ReuseableList<object>>();
				productContainer = containerPool.Create();
			}

			#region virtual
			public virtual void Close()
			{
				closed = true;
			}
			#endregion virtual

			#region IDisposable
			public void Dispose() 
			{
				containerPool.Destroy(productContainer);
				containerPool.Dispose();
			}
			#endregion IDisposable

			public void PostProduct(object p)
			{
				lock (productContainerLocker)
				{
					productContainer.list.Add(p);
				}
			}

			public ReuseableList<object> GetProductContainer()
			{
				lock (productContainerLocker)
				{
					if (0 >= productContainer.list.Count)
					{
						return null;
					}
				}
				var newContainer = containerPool.SafeCreate();
				lock (productContainerLocker)
				{
					var ret = productContainer;
					productContainer = newContainer;
					return ret;
				}
			}

			public void ReuseProductContainer(ReuseableList<object> p)
			{
				lock (productContainerLocker)
				{
					if (p == productContainer)
					{
						return;
					}
				}
				containerPool.SafeDestroy(p);
			}
		}
	
		private Thread thread;

		public bool working
		{
			get
			{
				return null != thread;
			}
		}

		public bool StartWork(ParameterizedThreadStart proc, object param)
		{
			if (working)
			{
				return false;
			}
			DoStart();
			thread = ThreadFactory.Create(proc);
			thread.Start(param);
			return true;
		}

		public void EndWork()
		{
			if (!working)
			{
				return;
			}
			DoEnd();
			thread.Interrupt();
			ThreadFactory.Destroy(thread);
			thread = null;
		}

		#region virtual
		protected virtual void DoStart()
		{

		}

		protected virtual void DoEnd()
		{
			
		}
		#endregion virtual
	}
} // namespace Ghost.Async
