using Microsoft.CodeAnalysis.CSharp.Syntax;
using Semmle.Extraction.Kinds;

namespace Semmle.Extraction.CSharp.Entities.Expressions
{
    class PointerMemberAccess : Expression<MemberAccessExpressionSyntax>
    {
        PointerMemberAccess(ExpressionNodeInfo info) : base(info.SetKind(ExprKind.POINTER_INDIRECTION)) { }

        public static Expression Create(ExpressionNodeInfo info) => new PointerMemberAccess(info).TryPopulate();

        protected override void Populate()
        {
            Create(cx, Syntax.Expression, this, 0);

            // !! We do not currently look at the member (or store the member name).
        }
    }
}
