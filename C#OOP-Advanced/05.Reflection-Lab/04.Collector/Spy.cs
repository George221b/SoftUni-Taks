using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string CollectGettersAndSetters(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        StringBuilder sb = new StringBuilder();

        foreach (MethodInfo getMethod in methods.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{getMethod.Name} will return {getMethod.ReturnType}");
        }
        foreach (MethodInfo setMethod in methods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{setMethod.Name} will set field of {setMethod.GetParameters().First().ParameterType}");
        }

        return sb.ToString().TrimEnd();
    }

    public string RevealPrivateMethods(string investigatedClass)
    {
        Type typeClass = Type.GetType(investigatedClass);

        MethodInfo[] privateMethods = typeClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {investigatedClass}");
        sb.AppendLine($"Base Class: {typeClass.BaseType.Name}");

        foreach (MethodInfo method in privateMethods)
        {
            sb.AppendLine($"{method.Name}");
        }

        return sb.ToString().TrimEnd();
    }

    public string AnalyzeAcessModifiers(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        foreach (FieldInfo fieldInfo in fields)
        {
            sb.AppendLine($"{fieldInfo.Name} must be private!");
        }
        foreach (MethodInfo nonPublicMethod in classNonPublicMethods.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{nonPublicMethod.Name} have to be public!");
        }
        foreach (MethodInfo publicMethod in classPublicMethods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{publicMethod.Name} have to be private!");
        }

        return sb.ToString().TrimEnd();
    }

    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(
            BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {investigatedClass}");

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        foreach (FieldInfo field in classFields
            .Where(f => requestedFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().TrimEnd();
    }
}