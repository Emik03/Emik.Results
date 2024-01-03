# Emik.Results

[![NuGet package](https://img.shields.io/nuget/v/Emik.Results.svg?color=50fa7b&logo=NuGet&style=for-the-badge)](https://www.nuget.org/packages/Emik.Results)
[![License](https://img.shields.io/github/license/Emik03/Emik.Results.svg?color=6272a4&style=for-the-badge)](https://github.com/Emik03/Emik.Results/blob/main/LICENSE)

`Result<TOk, TErr>` is the type used for returning and propagating errors. It is either `Ok`, representing success and containing a value, or `Err`, representing error and containing an error value.

This project has a dependency to [Emik.Morsels](https://github.com/Emik03/Emik.Morsels), if you are building this project, refer to its [README](https://github.com/Emik03/Emik.Morsels/blob/main/README.md) first.

---

- [Example](#examples)
- [Contribute](#contribute)
- [License](#license)

---

## Examples

```csharp
using System;
using System.Linq;
using Emik.Results;
using static Emik.Results.Please;

T Throw<T>(T unused) => throw new();

// Turn try-catch into a Result, and/or use operators to transform them.
Result<string, Exception> fail = "foo" & Try(Throw, "bar");

// 'IsErr' guarantees each variant be non-null in their appropriate branches.
string value = fail.IsErr ? fail.Err.Message : fail.Ok;

// You can also use the out parameter variant.
value = fail.Out(out var str, out var exception) ? str : exception.Message;

// Implements 'IEnumerable<T>', allowing for LINQ usage.
int length = fail.Select(x => x.Length).ToArray();

// Implements 'ISet<T>' as well, allowing for quering of other 'IEnumerable<T>' instances.
var thisIsTrue = Result.Ok(2).IsSupersetOf([2]);
```

```csharp
using System;
using System.Threading.Tasks;
using Emik.Results.Extensions;
using static Emik.Results.Result;

// Works with Tasks and ValueTasks too.
Result<int, Exception> success = await Task<int>.FromResult(10).Try();

// Works with Lazy.
Result<int, Exception> failure = new Lazy<int>(() => throw new()).Try();

// Convert nullable value types into Result.
Result<int, object> none = default(int?).IntoOk();

// Convert nullable reference types into Result.
Result<string, object> some = "".IntoOk();

// Filter and map.
var thisIsAlsoTrue = Err(2).MapErr(x => new List<int>(x)).IsErrAnd(x => x is { Capacity: 2, Count: 0 });
```

For a list of APIs, [click here](https://github.com/Emik03/Emik.Results/blob/main/Documentation/index.md).

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
