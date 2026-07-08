using Microsoft.CodeAnalysis.Classification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace EnhancedSemanticColorizer
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.FieldFormat)]
    [Name(Constants.FieldFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "field name")]
    internal sealed class SemanticFieldFormat : ClassificationFormatDefinition
    {
        public SemanticFieldFormat()
        {
            DisplayName = "Semantic Field";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.EnumFieldFormat)]
    [Name(Constants.EnumFieldFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "enum member name")]
    internal sealed class SemanticEnumFieldFormat : ClassificationFormatDefinition
    {
        public SemanticEnumFieldFormat()
        {
            DisplayName = "Semantic Enum Field";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ExtensionMethodFormat)]
    [Name(Constants.ExtensionMethodFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "extension method name")]
    [Order(After = "method name")]
    internal sealed class SemanticExtensionMethodFormat : ClassificationFormatDefinition
    {
        public SemanticExtensionMethodFormat()
        {
            DisplayName = "Semantic Extension Method";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.StaticMethodFormat)]
    [Name(Constants.StaticMethodFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "method name")]
    internal sealed class SemanticStaticMethodFormat : ClassificationFormatDefinition
    {
        public SemanticStaticMethodFormat()
        {
            DisplayName = "Semantic Static Method";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.NormalMethodFormat)]
    [Name(Constants.NormalMethodFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "method name")]
    internal sealed class SemanticNormalMethodFormat : ClassificationFormatDefinition
    {
        public SemanticNormalMethodFormat()
        {
            DisplayName = "Semantic Normal Method";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.LocalFunctionFormat)]
    [Name(Constants.LocalFunctionFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "method name")]
    internal sealed class SemanticLocalFunctionFormat : ClassificationFormatDefinition
    {
        public SemanticLocalFunctionFormat()
        {
            DisplayName = "Semantic Local Function";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ConstructorFormat)]
    [Name(Constants.ConstructorFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    internal sealed class SemanticConstructorFormat : ClassificationFormatDefinition
    {
        public SemanticConstructorFormat()
        {
            DisplayName = "Semantic Constructor";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.ParameterFormat)]
    [Name(Constants.ParameterFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "parameter name")]
    internal sealed class SemanticParameterFormat : ClassificationFormatDefinition
    {
        public SemanticParameterFormat()
        {
            DisplayName = "Semantic Parameter";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.NamespaceFormat)]
    [Name(Constants.NamespaceFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    internal sealed class SemanticNamespaceFormat : ClassificationFormatDefinition
    {
        public SemanticNamespaceFormat()
        {
            DisplayName = "Semantic Namespace";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.PropertyFormat)]
    [Name(Constants.PropertyFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "property name")]
    internal sealed class SemanticPropertyFormat : ClassificationFormatDefinition
    {
        public SemanticPropertyFormat()
        {
            DisplayName = "Semantic Property";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.LocalDeclarationFormat)]
    [Name(Constants.LocalDeclarationFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "local name")]
    internal sealed class SemanticLocalDeclarationFormat : ClassificationFormatDefinition
    {
        public SemanticLocalDeclarationFormat()
        {
            DisplayName = "Semantic Local Variable Declaration";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.LocalUsageFormat)]
    [Name(Constants.LocalUsageFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "local name")]
    internal sealed class SemanticLocalUsageFormat : ClassificationFormatDefinition
    {
        public SemanticLocalUsageFormat()
        {
            DisplayName = "Semantic Local Variable Usage";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.TypeSpecialFormat)]
    [Name(Constants.TypeSpecialFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    internal sealed class SemanticTypeSpecialFormat : ClassificationFormatDefinition
    {
        public SemanticTypeSpecialFormat()
        {
            DisplayName = "Semantic Special Type";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.EventFormat)]
    [Name(Constants.EventFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "event name")]
    internal sealed class SemanticEventFormat : ClassificationFormatDefinition
    {
        public SemanticEventFormat()
        {
            DisplayName = "Semantic Event";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.BuiltInMethodFormat)]
    [Name(Constants.BuiltInMethodFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "method name")]
    internal sealed class SemanticBuiltInMethodFormat : ClassificationFormatDefinition
    {
        public SemanticBuiltInMethodFormat()
        {
            DisplayName = "Semantic BuiltIn Method";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.DeclarationMethodFormat)]
    [Name(Constants.DeclarationMethodFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "method name")]
    internal sealed class SemanticDeclarationMethodFormat : ClassificationFormatDefinition
    {
        public SemanticDeclarationMethodFormat()
        {
            DisplayName = "Semantic Declaration Method";
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.CallMethodFormat)]
    [Name(Constants.CallMethodFormat)]
    [UserVisible(true)]
    [Order(After = ClassificationTypeNames.Identifier)]
    [Order(After = "method name")]
    internal sealed class SemanticCallMethodFormat : ClassificationFormatDefinition
    {
        public SemanticCallMethodFormat()
        {
            DisplayName = "Semantic Call Method";
        }
    }
}