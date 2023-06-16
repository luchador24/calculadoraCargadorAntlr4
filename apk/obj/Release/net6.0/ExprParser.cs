//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\rherr\source\repos\apk\apk\Expr.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace apk {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class ExprParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		MULT=1, DIV=2, RES=3, SUM=4, PARDER=5, PARIZQ=6, NEWLINE=7, INT=8;
	public const int
		RULE_prog = 0, RULE_expr = 1;
	public static readonly string[] ruleNames = {
		"prog", "expr"
	};

	private static readonly string[] _LiteralNames = {
		null, "'*'", "'/'", "'-'", "'+'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MULT", "DIV", "RES", "SUM", "PARDER", "PARIZQ", "NEWLINE", "INT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Expr.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static ExprParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public ExprParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public ExprParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] NEWLINE() { return GetTokens(ExprParser.NEWLINE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE(int i) {
			return GetToken(ExprParser.NEWLINE, i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(Context, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 9;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==PARDER || _la==INT) {
				{
				{
				State = 4;
				expr(0);
				State = 5;
				Match(NEWLINE);
				}
				}
				State = 11;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public IToken _INT;
		public ExprContext _expr;
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(ExprParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARDER() { return GetToken(ExprParser.PARDER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PARIZQ() { return GetToken(ExprParser.PARIZQ, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MULT() { return GetToken(ExprParser.MULT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV() { return GetToken(ExprParser.DIV, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUM() { return GetToken(ExprParser.SUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RES() { return GetToken(ExprParser.RES, 0); }
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case INT:
				{
				State = 13;
				_localctx._INT = Match(INT);
				Console.WriteLine("Token Encontrado: "+ (_localctx._INT!=null?_localctx._INT.Text:null));
				}
				break;
			case PARDER:
				{
				State = 15;
				Match(PARDER);
				State = 16;
				_localctx._expr = expr(0);
				State = 17;
				Match(PARIZQ);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 35;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 33;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
					case 1:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 21;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 22;
						_localctx.op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==MULT || _la==DIV) ) {
							_localctx.op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 23;
						_localctx._expr = expr(6);
						if(Convert.ToInt32((_localctx._expr!=null?TokenStream.GetText(_localctx._expr.Start,_localctx._expr.Stop):null))<0) NotifyErrorListeners("Los valores numericos deben ser mayores a 0");
						}
						break;
					case 2:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 26;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 27;
						_localctx.op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==RES || _la==SUM) ) {
							_localctx.op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 28;
						_localctx._expr = expr(5);
						Console.WriteLine("Token Encontrado: "+ (_localctx.op!=null?_localctx.op.Text:null));
						}
						break;
					case 3:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 31;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 32;
						Match(PARIZQ);
						}
						break;
					}
					} 
				}
				State = 37;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 5);
		case 1: return Precpred(Context, 4);
		case 2: return Precpred(Context, 1);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,8,39,2,0,7,0,2,1,7,1,1,0,1,0,1,0,5,0,8,8,0,10,0,12,0,11,9,0,1,1,1,
		1,1,1,1,1,1,1,1,1,1,1,3,1,20,8,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
		1,1,1,1,1,5,1,34,8,1,10,1,12,1,37,9,1,1,1,0,1,2,2,0,2,0,2,1,0,1,2,1,0,
		3,4,41,0,9,1,0,0,0,2,19,1,0,0,0,4,5,3,2,1,0,5,6,5,7,0,0,6,8,1,0,0,0,7,
		4,1,0,0,0,8,11,1,0,0,0,9,7,1,0,0,0,9,10,1,0,0,0,10,1,1,0,0,0,11,9,1,0,
		0,0,12,13,6,1,-1,0,13,14,5,8,0,0,14,20,6,1,-1,0,15,16,5,5,0,0,16,17,3,
		2,1,0,17,18,5,6,0,0,18,20,1,0,0,0,19,12,1,0,0,0,19,15,1,0,0,0,20,35,1,
		0,0,0,21,22,10,5,0,0,22,23,7,0,0,0,23,24,3,2,1,6,24,25,6,1,-1,0,25,34,
		1,0,0,0,26,27,10,4,0,0,27,28,7,1,0,0,28,29,3,2,1,5,29,30,6,1,-1,0,30,34,
		1,0,0,0,31,32,10,1,0,0,32,34,5,6,0,0,33,21,1,0,0,0,33,26,1,0,0,0,33,31,
		1,0,0,0,34,37,1,0,0,0,35,33,1,0,0,0,35,36,1,0,0,0,36,3,1,0,0,0,37,35,1,
		0,0,0,4,9,19,33,35
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace apk
