﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgebraGeometry;
using CSharpLogic;
using ExprGenerator;
using NUnit.Framework;
using starPadSDK.MathExpr;

namespace ExprGeneratorTest
{
    [TestFixture]
    public class Test
    {
        public void Test1()
        {
            //x+1=1 simulation

            //var x = new Var('x');            
            //var rhs = new Term(Expression.Substract, )
        }

        [Test]
        public void Test_Line_1()
        {
            var line = new Line(3.0, 1.0, 1.0);
            line.Label = "A";
            var lineSymbol = new LineSymbol(line);
            string str = lineSymbol.ToString();

            Assert.True(str.Equals("A(3x+y+1=0)"));

            Expr expr = lineSymbol.ToExpr();



        }

        [Test]
        public void Test_Point_1()
        {
            var point = new Point(1.0, 2.0);
            var pointSymbol = new PointSymbol(point);
            string str = pointSymbol.ToString();
            Assert.True(str.Equals("(1,2)"));
            Expr expr = pointSymbol.ToExpr();

            var str1 = expr.ToString();
            Assert.True(str.Equals("(1,2)"));
        }
    }
}