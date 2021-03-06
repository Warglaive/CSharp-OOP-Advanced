﻿using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
    {
        var stringBuilder = new StringBuilder($"Class under investigation: {classToInvestigate}"
            + Environment.NewLine);
        var fields = Type.GetType(classToInvestigate)
            .GetFields(BindingFlags.Instance
                      | BindingFlags.Static
                       | BindingFlags.NonPublic
                       | BindingFlags.Public);
        var instanceClass = Activator.CreateInstance(Type.GetType(classToInvestigate));

        foreach (var field in fields.Where(f => fieldsToInvestigate.Contains(f.Name)))
        {
            stringBuilder.AppendLine($"{field.Name} = {field.GetValue(instanceClass)}");
        }
        return stringBuilder.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string classToInvestigate)
    {
        var stringBuilder = new StringBuilder();
        var type = Type.GetType(classToInvestigate);

        var fields = type.GetFields(
              BindingFlags.Instance
            | BindingFlags.Static
            | BindingFlags.Public);


        foreach (var field in fields)
        {
            stringBuilder.AppendLine($"{field.Name} must be private!");
        }

        var getters = type.GetMethods(
            BindingFlags.Instance
            | BindingFlags.NonPublic);

        foreach (var property in getters
            .Where(g => g.Name.Contains("get")))
        {
            if (property.IsPrivate)
            {
                stringBuilder.AppendLine($"{property.Name} have to be public!");
            }
        }
        var setters = type.GetMethods(
            BindingFlags.Instance
            | BindingFlags.Public);

        foreach (var property in setters
            .Where(s => s.Name.Contains("set")))
        {
            if (property.IsPublic)
            {
                stringBuilder.AppendLine($"{property.Name} have to be private!");
            }
        }
        return stringBuilder.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {className}");

        var type = Type.GetType(className);
        var privateMethods = type.GetMethods(
             BindingFlags.Instance
             | BindingFlags.NonPublic);
        sb.AppendLine($"Base Class: {type.BaseType.Name}");
        foreach (var method in privateMethods)
        {
            sb.AppendLine(method.Name);
        }
        return sb.ToString().Trim();
    }
    public string CollectGettersAndSetters(string className)
    {
        var sb = new StringBuilder();

        var type = Type.GetType(className);
        var methods = type.GetMethods(BindingFlags.Instance
                                      | BindingFlags.Public
                                      | BindingFlags.NonPublic);

        var getters = methods.Where(g => g.Name.Contains("get"));
        var setters = methods.Where(s => s.Name.Contains("set"));

        foreach (var getter in getters)
        {
            sb.AppendLine($"{getter.Name} will return {getter.ReturnType}");
        }

        foreach (var setter in setters)
        {
            sb.AppendLine($"{setter.Name} will set field of {setter.GetParameters().First().ParameterType}");
        }
        return sb.ToString().Trim();
    }
}