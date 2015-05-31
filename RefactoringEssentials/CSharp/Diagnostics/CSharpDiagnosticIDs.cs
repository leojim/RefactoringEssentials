namespace RefactoringEssentials.CSharp.Diagnostics
{
    public static class CSharpDiagnosticIDs
    {
        public const string PartialTypeWithSinglePartDiagnosticID = "RECS0001";
        public const string ConvertClosureToMethodDiagnosticID = "RECS0002";
        public const string BaseMethodCallWithDefaultParameterDiagnosticID = "RECS0003";
        public const string EmptyConstructorAnalyzerID = "RECS0004";
        public const string EmptyDestructorAnalyzerID = "RECS0005";
        public const string EmptyNamespaceAnalyzerID = "RECS0006";
        public const string EnumUnderlyingTypeIsIntAnalyzerID = "RECS0007";
        public const string SealedMemberInSealedClassAnalyzerID = "RECS0008";
        public const string NonPublicMethodWithTestAttributeAnalyzerID = "RECS0009";
        public const string ConvertConditionalTernaryToNullCoalescingAnalyzerID = "RECS0010";
        public const string ConvertIfStatementToConditionalTernaryExpressionAnalyzerID = "RECS0011";
        public const string ConvertIfStatementToSwitchStatementAnalyzerID = "RECS0012";
        public const string ConvertNullableToShortFormAnalyzerID = "RECS0013";
        public const string ConvertToStaticTypeAnalyzerID = "RECS0014";
        public const string InvokeAsExtensionMethodAnalyzerID = "RECS0015";
        public const string BitwiseOperatorOnEnumWithoutFlagsAnalyzerID = "RECS0016";
        public const string CompareNonConstrainedGenericWithNullAnalyzerID = "RECS0017";
        public const string CompareOfFloatsByEqualityOperatorAnalyzerID = "RECS0018";
        public const string ConditionalTernaryEqualBranchAnalyzerID = "RECS0019";
        public const string DelegateSubtractionAnalyzerID = "RECS0020";
        public const string DoNotCallOverridableMethodsInConstructorAnalyzerID = "RECS0021";
        public const string EmptyGeneralCatchClauseAnalyzerID = "RECS0022";
        public const string EventUnsubscriptionViaAnonymousDelegateAnalyzerID = "RECS0023";
        public const string LongLiteralEndingLowerLAnalyzerID = "RECS0024";
        public const string NonReadonlyReferencedInGetHashCodeAnalyzerID = "RECS0025";
        public const string ObjectCreationAsStatementAnalyzerID = "RECS0026";
        public const string OperatorIsCanBeUsedAnalyzerID = "RECS0027";
        public const string OptionalParameterRefOutAnalyzerID = "RECS0028";
        public const string ValueParameterNotUsedAnalyzerID = "RECS0029";
        public const string AccessToStaticMemberViaDerivedTypeAnalyzerID = "RECS0030";
        public const string BaseMemberHasParamsAnalyzerID = "RECS0031";
        public const string ConvertIfDoToWhileAnalyzerID = "RECS0032";
        public const string ConvertIfToOrExpressionAnalyzerID = "RECS0033";
        public const string EmptyEmbeddedStatementAnalyzerID = "RECS0034";
        public const string PossibleMistakenCallToGetTypeAnalyzerID = "RECS0035";
        public const string ReplaceWithFirstOrDefaultAnalyzerID = "RECS0036";
        public const string ReplaceWithLastOrDefaultAnalyzerID = "RECS0037";
        public const string ReplaceWithOfTypeAnalyzerID = "RECS0038";
        public const string ReplaceWithOfTypeAnyAnalyzerID = "RECS0039";
        public const string ReplaceWithOfTypeCountAnalyzerID = "RECS0040";
        public const string ReplaceWithOfTypeFirstAnalyzerID = "RECS0041";
        public const string ReplaceWithOfTypeFirstOrDefaultAnalyzerID = "RECS0042";
        public const string ReplaceWithOfTypeLastAnalyzerID = "RECS0043";
        public const string ReplaceWithOfTypeLastOrDefaultAnalyzerID = "RECS0044";
        public const string ReplaceWithOfTypeLongCountAnalyzerID = "RECS0045";
        public const string ReplaceWithOfTypeSingleAnalyzerID = "RECS0046";
        public const string ReplaceWithOfTypeSingleOrDefaultAnalyzerID = "RECS0047";
        public const string ReplaceWithOfTypeWhereAnalyzerID = "RECS0048";
        public const string ReplaceWithSimpleAssignmentAnalyzerID = "RECS0049";
        public const string ReplaceWithSingleCallToAnyAnalyzerID = "RECS0050";
        public const string ReplaceWithSingleCallToCountAnalyzerID = "RECS0051";
        public const string ReplaceWithSingleCallToFirstAnalyzerID = "RECS0052";
        public const string ReplaceWithSingleCallToFirstOrDefaultAnalyzerID = "RECS0053";
        public const string ReplaceWithSingleCallToLastAnalyzerID = "RECS0054";
        public const string ReplaceWithSingleCallToLastOrDefaultAnalyzerID = "RECS0055";
        public const string ReplaceWithSingleCallToLongCountAnalyzerID = "RECS0056";
        public const string ReplaceWithSingleCallToSingleAnalyzerID = "RECS0057";
        public const string ReplaceWithSingleCallToSingleOrDefaultAnalyzerID = "RECS0058";
        public const string SimplifyConditionalTernaryExpressionAnalyzerID = "RECS0059";
        public const string StringIndexOfIsCultureSpecificAnalyzerID = "RECS0060";
        public const string StringEndsWithIsCultureSpecificAnalyzerID = "RECS0061";
        public const string StringLastIndexOfIsCultureSpecificAnalyzerID = "RECS0062";
        public const string StringStartsWithIsCultureSpecificAnalyzerID = "RECS0063";
        public const string StringCompareToIsCultureSpecificAnalyzerID = "RECS0064";
        public const string ConditionIsAlwaysTrueOrFalseAnalyzerID = "RECS0065";
        public const string DoubleNegationOperatorAnalyzerID = "RECS0066";
        public const string EmptyStatementAnalyzerID = "RECS0067";
        public const string ForStatementConditionIsTrueAnalyzerID = "RECS0068";
        public const string RedundantAnonymousTypePropertyNameAnalyzerID = "RECS0069";
        public const string RedundantArgumentNameAnalyzerID = "RECS0070";
        public const string RedundantAttributeParenthesesAnalyzerID = "RECS0071";
        public const string RedundantBaseQualifierAnalyzerID = "RECS0072";
        public const string RedundantCaseLabelAnalyzerID = "RECS0073";
        public const string RedundantEmptyDefaultSwitchBranchAnalyzerID = "RECS0074";
        public const string RedundantTernaryExpressionAnalyzerID = "RECS0075";
        public const string RemoveRedundantOrStatementAnalyzerID = "RECS0076";
        public const string NegativeRelationalExpressionAnalyzerID = "RECS0077";
        public const string RedundantExplicitArrayCreationAnalyzerID = "RECS0078";
        public const string RedundantLogicalConditionalExpressionOperandAnalyzerID = "RECS0079";
        public const string AdditionalOfTypeAnalyzerID = "RECS0080";
        public const string XmlDocAnalyzerID = "RECS0081";
        public const string ParameterHidesMemberAnalyzerID = "RECS0082";
        public const string NotImplementedExceptionAnalyzerID = "RECS0083";
        public const string RedundantAssignmentAnalyzerID = "RECS0084";
        public const string ArrayCreationCanBeReplacedWithArrayInitializerAnalyzerID = "RECS0085";
        public const string RedundantEnumerableCastCallAnalyzerID = "RECS0086";
        public const string SimplifyLinqExpressionAnalyzerID = "RECS0087";
        public const string EqualExpressionComparisonAnalyzerID = "RECS0088";
        public const string PolymorphicFieldLikeEventInvocationAnalyzerID = "RECS0089";
        public const string ForCanBeConvertedToForeachAnalyzerID = "RECS0090";
        public const string SuggestUseVarKeywordEvidentAnalyzerID = "RECS0091";
        public const string FieldCanBeMadeReadOnlyAnalyzerID = "RECS0092";
        public const string ConvertIfToAndExpressionAnalyzerID = "RECS0093";
        public const string RedundantLambdaParameterTypeAnalyzerID = "RECS0094";
        public const string LockThisAnalyzerID = "RECS0095";
        public const string UnusedTypeParameterAnalyzerID = "RECS0096";
        public const string MemberCanBeMadeStaticAnalyzerID = "RECS0097";
        public const string ConstantNullCoalescingConditionAnalyzerID = "RECS0098";
        public const string ParameterOnlyAssignedAnalyzerID = "RECS0099";
        public const string RedundantComparisonWithNullAnalyzerID = "RECS0100";
        public const string RedundantExtendsListEntryAnalyzerID = "RECS0101";
        public const string ParameterCanBeDeclaredWithBaseTypeAnalyzerID = "RECS0102";
        public const string RedundantExplicitArraySizeAnalyzerID = "RECS0103";
        public const string RedundantObjectCreationArgumentListAnalyzerID = "RECS0104";
        public const string CanBeReplacedWithTryCastAndCheckForNullAnalyzerID = "RECS0105";
        public const string RedundantToStringCallAnalyzerID = "RECS0106";
        public const string RedundantToStringCallAnalyzer_ValueTypesID = "RECS0107";
        public const string StaticFieldInGenericTypeAnalyzerID = "RECS0108";
        public const string RedundantCatchClauseAnalyzerID = "RECS0109";
        public const string ConstantConditionAnalyzerID = "RECS0110";
        public const string PossibleAssignmentToReadonlyFieldAnalyzerID = "RECS0111";
        public const string StaticEventSubscriptionAnalyzerID = "RECS0112";
        public const string RedundantCommaInArrayInitializerAnalyzerID = "RECS0113";
        public const string UseMethodIsInstanceOfTypeAnalyzerID = "RECS0114";
        public const string UnassignedReadonlyFieldAnalyzerID = "RECS0115";
        public const string UseMethodAnyAnalyzerID = "RECS0116";
        public const string LocalVariableHidesMemberAnalyzerID = "RECS0117";
        public const string RedundantEmptyFinallyBlockAnalyzerID = "RECS0118";
        public const string StringCompareIsCultureSpecificAnalyzerID = "RECS0119";
        public const string PublicConstructorInAbstractClassAnalyzerID = "RECS0120";
        public const string RedundantBoolCompareAnalyzerID = "RECS0121";
        public const string RedundantDefaultFieldInitializerAnalyzerID = "RECS0122";
        public const string RedundantStringToCharArrayCallAnalyzerID = "RECS0123";
        public const string OptionalParameterHierarchyMismatchAnalyzerID = "RECS0124";
        public const string CheckNamespaceAnalyzerID = "RECS0125";
        public const string RedundantBaseConstructorCallAnalyzerID = "RECS0126";
        public const string ReplaceWithStringIsNullOrEmptyAnalyzerID = "RECS0127";
        public const string UnusedAnonymousMethodSignatureAnalyzerID = "RECS0128";
        public const string RedundantInternalAnalyzerID = "RECS0129";
        public const string ForControlVariableIsNeverModifiedAnalyzerID = "RECS0130";
        public const string ReferenceEqualsWithValueTypeAnalyzerID = "RECS0131";
        public const string ConvertToLambdaExpressionAnalyzerID = "RECS0132";
        public const string BaseMethodParameterNameMismatchAnalyzerID = "RECS0133";
        public const string RedundantCheckBeforeAssignmentAnalyzerID = "RECS0134";
        public const string FunctionNeverReturnsAnalyzerID = "RECS0135";
        public const string PartialMethodParameterNameMismatchAnalyzerID = "RECS0136";
        public const string MethodOverloadWithOptionalParameterAnalyzerID = "RECS0137";
        public const string RedundantExplicitNullableCreationAnalyzerID = "RECS0138";
        public const string PossibleMultipleEnumerationAnalyzerID = "RECS0139";
        public const string RedundantLambdaSignatureParenthesesAnalyzerID = "RECS0140";
        public const string RedundantArgumentDefaultValueAnalyzerID = "RECS0141";
        public const string UseArrayCreationExpressionAnalyzerID = "RECS0142";
        public const string NotResolvedInTextAnalyzerID = "RECS0143";
        public const string RedundantObjectOrCollectionInitializerAnalyzerID = "RECS0144";
        public const string RedundantPrivateAnalyzerID = "RECS0145";
        public const string MemberHidesStaticFromOuterClassAnalyzerID = "RECS0146";
        public const string RedundantIfElseBlockAnalyzerID = "RECS0147";
        public const string UseIsOperatorAnalyzerID = "RECS0148";
        public const string CallToObjectEqualsViaBaseAnalyzerID = "RECS0149";
        public const string RedundantToStringCallForValueTypesAnalyzerID = "RECS0150";
        public const string RedundantParamsAnalyzerID = "RECS0151";
        public const string ConvertIfStatementToNullCoalescingExpressionAnalyzerID = "RECS0152";
        public const string ConvertToConstantAnalyzerID = "RECS0153";
        public const string UnusedParameterAnalyzerID = "RECS0154";
        public const string FormatStringProblemAnalyzerID = "RECS0155";
        public const string LocalVariableNotUsedAnalyzerID = "RECS0156";
        public const string ThreadStaticAtInstanceFieldAnalyzerID = "RECS0157";
        public const string RedundantUnsafeContextAnalyzerID = "RECS0158";
        public const string RedundantOverriddenMemberAnalyzerID = "RECS0159";
        public const string RewriteIfReturnToReturnAnalyzerID = "RECS0160";
        public const string ConvertToAutoPropertyAnalyzerID = "RECS0161";
        public const string NotResolvedInTextAnalyzer_SwapID = "RECS0162";
        public const string NameOfSuggestionAnalyzerID = "RECS0163";
        public const string RedundantDelegateCreationAnalyzerID = "RECS0164";
    }
}