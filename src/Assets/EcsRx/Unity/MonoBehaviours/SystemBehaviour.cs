﻿using UnityEngine;
using EcsRx;
using UniRx;
using Zenject;
using System.Collections;
using System;

namespace EcsRx.Unity
{
	public abstract class SystemBehaviour : MonoBehaviour, ISystem, IDisposableContainer, IDisposable
	{		
		[Inject] public IEventSystem EventSystem { get; set; }
		[Inject] public IPoolManager PoolManager { get; set; }

		// TODO remove this kludge. only using it for groups, should be created with a factory
		[Inject] protected DiContainer Container = null;

		private CompositeDisposable _disposer = new CompositeDisposable();
		public CompositeDisposable Disposer
		{
			get { return _disposer; }
			set { _disposer = value; }
		}

		[Inject]
		public virtual void Setup ()
		{
		}

		[Inject]
		public virtual IEnumerator SetupAsync ()
		{
			yield break;
		}

		public virtual void Dispose ()
		{
			Disposer.Dispose ();
		}
	}
}
