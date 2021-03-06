using System;
using System.Collections.Generic;
using ModestTree;
using ModestTree.Util;

namespace Zenject
{
    public abstract class InstanceMethodSignalHandlerBase<THandler> : SignalHandlerBase
    {
        readonly Lazy<THandler> _handler;

        [Inject]
        public InstanceMethodSignalHandlerBase(
            BindingId signalId, SignalManager manager,
            Lazy<THandler> handler)
            : base(signalId, manager)
        {
            _handler = handler;
        }

        public override void Execute(object[] args)
        {
            InternalExecute(_handler.Value, args);
        }

        protected abstract void InternalExecute(THandler handler, object[] args);
    }

    public class InstanceMethodSignalHandler<THandler> : InstanceMethodSignalHandlerBase<THandler>
    {
        readonly Func<THandler, Action> _methodGetter;

        [Inject]
        public InstanceMethodSignalHandler(
            BindingId signalId, SignalManager manager, Lazy<THandler> handler,
            Func<THandler, Action> methodGetter)
            : base(signalId, manager, handler)
        {
            _methodGetter = methodGetter;
        }

        protected override void InternalExecute(THandler handler, object[] args)
        {
            Assert.That(args.IsEmpty());

            var method = _methodGetter(handler);
#if UNITY_EDITOR
            using (ProfileBlock.Start(method.ToDebugString()))
#endif
            {
                method();
            }
        }
    }

    public class InstanceMethodSignalHandler<TParam1, THandler> : InstanceMethodSignalHandlerBase<THandler>
    {
        readonly Func<THandler, Action<TParam1>> _methodGetter;

        [Inject]
        public InstanceMethodSignalHandler(
            BindingId signalId, SignalManager manager, Lazy<THandler> handler,
            Func<THandler, Action<TParam1>> methodGetter)
            : base(signalId, manager, handler)
        {
            _methodGetter = methodGetter;
        }

        protected override void InternalExecute(THandler handler, object[] args)
        {
            Assert.That(args.IsLength(1));
            ValidateParameter<TParam1>(args[0]);

            var method = _methodGetter(handler);
#if UNITY_EDITOR
            using (ProfileBlock.Start(method.ToDebugString()))
#endif
            {
                method((TParam1)args[0]);
            }
        }
    }

    public class InstanceMethodSignalHandler<TParam1, TParam2, THandler> : InstanceMethodSignalHandlerBase<THandler>
    {
        readonly Func<THandler, Action<TParam1, TParam2>> _methodGetter;

        [Inject]
        public InstanceMethodSignalHandler(
            BindingId signalId, SignalManager manager, Lazy<THandler> handler,
            Func<THandler, Action<TParam1, TParam2>> methodGetter)
            : base(signalId, manager, handler)
        {
            _methodGetter = methodGetter;
        }

        protected override void InternalExecute(THandler handler, object[] args)
        {
            Assert.That(args.IsLength(2));
            ValidateParameter<TParam1>(args[0]);
            ValidateParameter<TParam2>(args[1]);
            var method = _methodGetter(handler);
#if UNITY_EDITOR
            using (ProfileBlock.Start(method.ToDebugString()))
#endif
            {
                method((TParam1)args[0], (TParam2)args[1]);
            }
        }
    }

    public class InstanceMethodSignalHandler<TParam1, TParam2, TParam3, THandler> : InstanceMethodSignalHandlerBase<THandler>
    {
        readonly Func<THandler, Action<TParam1, TParam2, TParam3>> _methodGetter;

        [Inject]
        public InstanceMethodSignalHandler(
            BindingId signalId, SignalManager manager, Lazy<THandler> handler,
            Func<THandler, Action<TParam1, TParam2, TParam3>> methodGetter)
            : base(signalId, manager, handler)
        {
            _methodGetter = methodGetter;
        }

        protected override void InternalExecute(THandler handler, object[] args)
        {
            Assert.That(args.IsLength(3));
            ValidateParameter<TParam1>(args[0]);
            ValidateParameter<TParam2>(args[1]);
            ValidateParameter<TParam3>(args[2]);
            var method = _methodGetter(handler);
#if UNITY_EDITOR
            using (ProfileBlock.Start(method.ToDebugString()))
#endif
            {
                method((TParam1)args[0], (TParam2)args[1], (TParam3)args[2]);
            }
        }
    }

    public class InstanceMethodSignalHandler<TParam1, TParam2, TParam3, TParam4, THandler> : InstanceMethodSignalHandlerBase<THandler>
    {
        readonly Func<THandler, Action<TParam1, TParam2, TParam3, TParam4>> _methodGetter;

        [Inject]
        public InstanceMethodSignalHandler(
            BindingId signalId, SignalManager manager, Lazy<THandler> handler,
            Func<THandler, Action<TParam1, TParam2, TParam3, TParam4>> methodGetter)
            : base(signalId, manager, handler)
        {
            _methodGetter = methodGetter;
        }

        protected override void InternalExecute(THandler handler, object[] args)
        {
            Assert.That(args.IsLength(4));
            ValidateParameter<TParam1>(args[0]);
            ValidateParameter<TParam2>(args[1]);
            ValidateParameter<TParam3>(args[2]);
            ValidateParameter<TParam4>(args[3]);
            var method = _methodGetter(handler);
#if UNITY_EDITOR
            using (ProfileBlock.Start(method.ToDebugString()))
#endif
            {
                method((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);
            }
        }
    }
}
