﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Collections;
using System.Reflection;
using CshComplex;

namespace ComplexExpressionCs
{

    public class ComplexExpressionParser
    {
        private Expression Expr;
        private List<string> varNameList;
        private ParameterExpression varParam;
        private Expression<Func<Complex[], Complex>> lambda;
        public Func<Complex[], Complex> runnable;
        private static List<string> funcList;
        private static List<string> funcList2;

        static ComplexExpressionParser()
        {
            funcList = new List<string>();
            funcList.Add("Log");
            funcList.Add("Exp");
            funcList.Add("Sin");
            funcList.Add("Cos");

            funcList2 = new List<String>();
            funcList2.Add("Pow");
        }

        public ComplexExpressionParser(string s, params string[] varNames)
        {
            varNameList = new List<string>();
            foreach (string name in varNames) varNameList.Add(name);
            varParam = Expression.Parameter(typeof(Complex[]), "varArray");
            int i = 0;
            Expr = GetExpr(s, ref i, '\0');
            lambda = Expression.Lambda<Func<Complex[], Complex>>(Expr, varParam);
            runnable = lambda.Compile();
        }

        public Complex Run(params Complex[] vars)
        {
            return runnable(vars);
        }

        public Expression GetExpr(string str, ref int i, char ctrm)
        {
            Expression tempExpr = null;
            bool plus = true;
            bool init = true;
            do
            {
                if (init)
                {
                    SkipWhiteSpace(str, ref i, ctrm);
                    if (i == str.Length || str[i] == ctrm) throw new Exception("+, -, or Term Expected");
                    if (str[i] == '+') i++;
                    else if (str[i] == '-')
                    {
                        plus = false;
                        i++;
                    }
                }
                SkipWhiteSpace(str, ref i, ctrm);
                if (i == str.Length || str[i] == ctrm) throw new Exception("Term Expected");
                Expression nextTerm = GetTerm(str, ref i, ctrm);
                if (nextTerm == null) throw new Exception("Null Term");
                if (init)
                {
                    if (plus) tempExpr = nextTerm;
                    else tempExpr = Expression.Negate(nextTerm);
                    init = false;
                }
                else if (plus) tempExpr = Expression.Add(tempExpr, nextTerm);
                else tempExpr = Expression.Subtract(tempExpr, nextTerm);
                SkipWhiteSpace(str, ref i, ctrm);
                if (i == str.Length || str[i] == ctrm) break;
                if (str[i] == '+') plus = true;
                else if (str[i] == '-') plus = false;
                else throw new Exception(" '+' or '-' expected ");
                i++;
            } while (true);
            if (ctrm != '\0' && (i == str.Length || str[i] != ctrm)) throw new Exception("Expression terminator expected");
            return tempExpr;
        }

        private Expression GetTerm(string str, ref int i, char ctrm)
        {
            Expression tempTerm = null;
            bool init = true;
            bool mult = true;
            do
            {
                SkipWhiteSpace(str, ref i, ctrm);
                if (i == str.Length || str[i] == ctrm) throw new Exception("Factor Expected");
                Expression nextFact = GetFact(str, ref i, ctrm);
                if (nextFact == null) throw new Exception("Null Factor");
                if (init)
                {
                    tempTerm = nextFact;
                    init = false;
                }
                else if (mult) tempTerm = Expression.Multiply(tempTerm, nextFact);
                else tempTerm = Expression.Divide(tempTerm, nextFact);
                SkipWhiteSpace(str, ref i, ctrm);
                if (i == str.Length || str[i] == ctrm || str[i] == '+' || str[i] == '-') break;
                if (str[i] == '*') mult = true;
                else if (str[i] == '/') mult = false;
                else throw new Exception("'*' or '/' expected");
                i++;
            } while (true);
            return tempTerm;
        }

        private Expression GetFact(string str, ref int i, char ctrm)
        {
            SkipWhiteSpace(str, ref i, ctrm);
            if (i == str.Length || str[i] == ctrm) return null;
            if (char.IsDigit(str, i) || str[i] == '.')
            {
                string numString = GetNumberString(str, ref i, ctrm);
                double real = double.Parse(numString);
                return Expression.Constant(new Complex(real, 0.0), typeof(Complex));
            }
            if (str[i] == '[')
            {
                string numString;
                i++;
                SkipWhiteSpace(str, ref i, ctrm);
                if (i == str.Length || (!char.IsDigit(str,i) && !(str[i]=='.'))) 
                    throw new Exception("Real component of complex number expected");
                numString = GetNumberString(str, ref i, ctrm);
                double real = double.Parse(numString);
                SkipWhiteSpace(str, ref i, ctrm);
                if (i == str.Length || str[i] != ',') throw new Exception("Comma expected in complex number");
                i++;
                SkipWhiteSpace(str, ref i, ctrm);
                if (i == str.Length || (!char.IsDigit(str, i) && !(str[i] == '.')))
                    throw new Exception("Imaginary component of complex number expected");
                numString = GetNumberString(str, ref i, ctrm);
                double imag = double.Parse(numString);
                SkipWhiteSpace(str, ref i, ctrm);
                if (i == str.Length || str[i] != ']') throw new Exception("']' expected at end of complex number");
                i++;
                return Expression.Constant(new Complex(real, imag), typeof(Complex));
            }
            if (str[i] == '(')
            {
                i++;
                Expression tempFact = GetExpr(str, ref i, ')');
                i++;
                return tempFact;
            }
            if (char.IsLetter(str[i]))
            {
                string name = GetName(str, ref i, ctrm);
                int index = varNameList.IndexOf(name);
                if (index >= 0)
                {
                    ConstantExpression indexExpr = Expression.Constant(index, typeof(int));
                    return Expression.ArrayIndex(varParam, indexExpr);
                }
                if (funcList.Contains(name))
                {
                    if (i == str.Length || str[i] == ctrm || str[i] != '(') throw new Exception("'(' expected for function call");
                    i++;
                    Expression argExpr = GetExpr(str, ref i, ')');
                    i++;
                    return Expression.Call(typeof(Complex).GetMethod(name), argExpr);
                }
                if (funcList2.Contains(name))
                {
                    if (i == str.Length || str[i] == ctrm || str[i] != '(') throw new Exception("'(' expected for function call");
                    i++;
                    Expression argExpr1 = GetExpr(str, ref i, ',');
                    i++;
                    Expression argExpr2 = GetExpr(str, ref i, ')');
                    i++;
                    return Expression.Call(typeof(Complex).GetMethod(name), argExpr1, argExpr2);
                }
                throw new Exception("Name: " + name + " not found.");
            }
            throw new Exception("No factor found");
        }

        private void SkipWhiteSpace(string str, ref int i, char ctrm)
        {
            if (i < str.Length) i += str.Length - i - str.Substring(i).TrimStart(null).Length;
        }

        private string GetNumberString(string str, ref int i, char ctrm)
        {
            StringBuilder sb = new StringBuilder();
            bool decPt = false;
            while (i < str.Length && (char.IsDigit(str, i) || (str[i] == '.' && !decPt)))
            {
                sb = sb.Append(str[i]);
                if (str[i] == '.') decPt = true;
                i++;
            }
            if (i < str.Length && str[i] == 'e')
            {
                sb.Append('e');
                i++;
                if (i == str.Length || (str[i] != '+' && str[i] != '-')) throw new Exception("+ or - expected for exponent");
                sb.Append(str[i]);
                i++;
                if (i == str.Length || !char.IsDigit(str, i)) throw new Exception("First digit of exponent expected");
                sb.Append(str[i]);
                i++;
                if (i == str.Length || !char.IsDigit(str, i)) throw new Exception("Second digit of exponent expected");
                sb.Append(str[i]);
                i++;
            }
            return sb.ToString();
        }

        private string GetName(string str, ref int i, char ctrm)
        {
            StringBuilder sb = new StringBuilder();
            while (i < str.Length && str[i] != ctrm && char.IsLetterOrDigit(str, i))
            {
                sb.Append(str[i]);
                i++;
            }
            return sb.ToString();
        }


    }

}
