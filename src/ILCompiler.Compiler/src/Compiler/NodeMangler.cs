// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Internal.Text;
using Internal.TypeSystem;

namespace ILCompiler
{
    //
    // NodeMangler is responsible for producing mangled names for specific nodes
    // and for node-related purposes, where the name needs to be in a special format
    // on some platform
    // 
    public abstract class NodeMangler
    {
        public NameMangler NameMangler;

        // Mangled name of boxed version of a type
        public abstract string MangledBoxedTypeName(TypeDesc type);

        public abstract string EEType(TypeDesc type);
        public abstract string GCStatics(TypeDesc type);
        public abstract string NonGCStatics(TypeDesc type);
        public abstract string ThreadStatics(TypeDesc type);
    }
}
