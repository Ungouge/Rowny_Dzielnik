using System.Runtime.CompilerServices;

// Argumety projektu dające dostęp do wewnetrznych zasobów projektom testów jednostkowych oraz zestawu do tworzenia atrap.

[assembly: InternalsVisibleTo("Dzielnik.Testy.Zasoby")]
[assembly: InternalsVisibleTo("Dzielnik.Testy.Zasoby.stworz")]
[assembly: InternalsVisibleTo("Dzielnik.Testy.Zasoby.stworzMocki")]
[assembly: InternalsVisibleTo("Dzielnik.Testy.Model")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]