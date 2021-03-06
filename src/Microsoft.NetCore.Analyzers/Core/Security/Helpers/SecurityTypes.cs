﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis;

namespace Microsoft.NetCore.Analyzers.Security.Helpers
{
    public static class SecurityTypes
    {
        public static INamedTypeSymbol MD5(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.MD5");
        }

        public static INamedTypeSymbol SHA1(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.SHA1");
        }

        public static INamedTypeSymbol HMACSHA1(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.HMACSHA1");
        }
        public static INamedTypeSymbol DES(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.DES");
        }

        public static INamedTypeSymbol DSA(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.DSA");
        }

        public static INamedTypeSymbol DSASignatureFormatter(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.DSASignatureFormatter");
        }

        public static INamedTypeSymbol HMACMD5(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.HMACMD5");
        }

        public static INamedTypeSymbol RC2(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.RC2");
        }

        public static INamedTypeSymbol TripleDES(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.TripleDES");
        }

        public static INamedTypeSymbol RIPEMD160(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.RIPEMD160");
        }

        public static INamedTypeSymbol HMACRIPEMD160(Compilation compilation)
        {
            return compilation.GetTypeByMetadataName("System.Security.Cryptography.HMACRIPEMD160");
        }
    }
}
