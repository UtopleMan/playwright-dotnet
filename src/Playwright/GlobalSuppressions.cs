// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Performance", "CA1847:Use char literal for a single character lookup", Justification = "Bump to NET7", Scope = "namespaceanddescendants", Target = "Microsoft.Playwright")]
[assembly: SuppressMessage("Performance", "CA1835:Prefer the 'Memory'-based overloads for 'ReadAsync' and 'WriteAsync'", Justification = "Bump to NET7", Scope = "namespaceanddescendants", Target = "Microsoft.Playwright")]
[assembly: SuppressMessage("Usage", "VSTHRD110:Observe result of async calls", Justification = "Bump to NET7", Scope = "namespaceanddescendants", Target = "Microsoft.Playwright")]
[assembly: SuppressMessage("Performance", "CA1851:Possible multiple enumerations of 'IEnumerable' collection", Justification = "Bump to NET7", Scope = "namespaceanddescendants", Target = "Microsoft.Playwright")]
