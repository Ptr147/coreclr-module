﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Shared.Elements.Entities;
using AltV.Net.Shared.Enums;

namespace AltV.Net.Async.Elements.Entities
{
    [SuppressMessage("ReSharper",
        "InconsistentlySynchronizedField")] // we sometimes use object in lock and sometimes not
    public class AsyncMarker : AsyncWorldObject, IMarker, IAsyncConvertible<IMarker>
    {
        protected readonly IMarker Marker;
        public IntPtr MarkerNativePointer => Marker.MarkerNativePointer;
        public uint Id => Marker.Id;

        public AsyncMarker(IMarker marker, IAsyncContext asyncContext) : base(marker, asyncContext)
        {
            Marker = marker;
        }

        public AsyncMarker(ICore core, IntPtr nativePointer, uint id) : this(new Marker(core, nativePointer, id), null)
        {
        }

        [Obsolete("Use new async API instead")]
        public IMarker ToAsync(IAsyncContext asyncContext)
        {
            return this;
        }

        public bool IsGlobal
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.IsGlobal;
                }
            }
        }

        public ISharedPlayer Target
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.Target;
                }
            }
        }

        public Rgba Color
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.Color;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.Color = value;
                }
            }
        }

        public bool Visible
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.Visible;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.Visible = value;
                }
            }
        }
        public MarkerType MarkerType
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.MarkerType;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.MarkerType = value;
                }
            }
        }
        public Position Scale
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.Scale;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.Scale = value;
                }
            }
        }
        public Rotation Rotation
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.Rotation;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.Rotation = value;
                }
            }
        }
        public Position Direction
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.Direction;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.Direction = value;
                }
            }
        }

        public uint StreamingDistance
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.StreamingDistance;
                }
            }
        }

        public bool IsFaceCamera
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.IsFaceCamera;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.IsFaceCamera = value;
                }
            }
        }

        public bool IsRotating
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.IsRotating;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.IsRotating = value;
                }
            }
        }

        public bool IsBobUpDown
        {
            get
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return default;
                    return Marker.IsBobUpDown;
                }
            }
            set
            {
                lock (Marker)
                {
                    if (!AsyncContext.CheckIfExistsNullable(Marker)) return;
                    Marker.IsBobUpDown = value;
                }
            }
        }
    }
}