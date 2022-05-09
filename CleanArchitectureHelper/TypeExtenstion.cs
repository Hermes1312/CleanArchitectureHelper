namespace CleanArchitectureHelper;

public static class TypeExtension
{
    public static string Alias(this Type type)
    {
        return TypeAliases.ContainsKey(type) ?
            TypeAliases[type] : string.Empty;
    }

    public static string AliasOrName(this Type type)
    {
        if(TypeAliases.ContainsKey(type))
            return TypeAliases.ContainsKey(type) ? TypeAliases[type] : type.FullName ?? type.Name;
        
        if (type.IsGenericType)
        {
            var name = type.Name[..type.Name.IndexOf('`')];
            var args = string.Join(',', type.GetGenericArguments().Select(a => a.AliasOrName()).ToList());

            if (name == "Nullable" && !args.Contains(','))
                return args + "?";

            return $"{name}<{args}>";
        }

        return type.FullName!;
    }

    private static readonly Dictionary<Type, string> TypeAliases = new Dictionary<Type, string>
    {
        { typeof(byte), "byte" },
        { typeof(sbyte), "sbyte" },
        { typeof(short), "short" },
        { typeof(ushort), "ushort" },
        { typeof(int), "int" },
        { typeof(uint), "uint" },
        { typeof(long), "long" },
        { typeof(ulong), "ulong" },
        { typeof(float), "float" },
        { typeof(double), "double" },
        { typeof(decimal), "decimal" },
        { typeof(object), "object" },
        { typeof(bool), "bool" },
        { typeof(char), "char" },
        { typeof(string), "string" },
        { typeof(void), "void" },
        { typeof(byte?), "byte?" },
        { typeof(sbyte?), "sbyte?" },
        { typeof(short?), "short?" },
        { typeof(ushort?), "ushort?" },
        { typeof(int?), "int?" },
        { typeof(uint?), "uint?" },
        { typeof(long?), "long?" },
        { typeof(ulong?), "ulong?" },
        { typeof(float?), "float?" },
        { typeof(double?), "double?" },
        { typeof(decimal?), "decimal?" },
        { typeof(bool?), "bool?" },
        { typeof(char?), "char?" },
    };
}