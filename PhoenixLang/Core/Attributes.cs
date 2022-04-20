﻿using System.Xml;

namespace PhoenixLang.Core;

public static class Attributes
{ 
    public static string? GetAttributeValue(XmlNode node, string attributeName)
    {
        var attributeValue = node.Attributes?[attributeName]?.Value;
        return attributeValue;
    }

    public static void AttributeNullLog(string attributeName)
    {
        Exception.ThrowException($"The attribute {attributeName} is null.");
        Environment.Exit(1);
    }
}