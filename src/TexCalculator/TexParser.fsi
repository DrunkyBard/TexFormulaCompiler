// Signature file for parser generated by fsyacc
module TexParser
type token = 
  | EOF
  | PI
  | EULERNUM
  | FRAC
  | SQRT
  | SUM
  | PROD
  | INTEGRAL
  | TIMES
  | INFTY
  | TO
  | LIM
  | BMOD
  | PLUS
  | SUB
  | MUL
  | DIV
  | LSQBRACE
  | RSQBRACE
  | LPAREN
  | RPAREN
  | LCURLY
  | RCURLY
  | EXCL
  | CARET
  | EQ
  | UNDERSCORE
  | SLASH
  | COMMA
  | MMREFVAL of (string list)
  | MREFVAL of (string)
  | SREFVAL of (string)
  | ID of (string)
  | DIFF of (string)
  | INT of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_PI
    | TOKEN_EULERNUM
    | TOKEN_FRAC
    | TOKEN_SQRT
    | TOKEN_SUM
    | TOKEN_PROD
    | TOKEN_INTEGRAL
    | TOKEN_TIMES
    | TOKEN_INFTY
    | TOKEN_TO
    | TOKEN_LIM
    | TOKEN_BMOD
    | TOKEN_PLUS
    | TOKEN_SUB
    | TOKEN_MUL
    | TOKEN_DIV
    | TOKEN_LSQBRACE
    | TOKEN_RSQBRACE
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_LCURLY
    | TOKEN_RCURLY
    | TOKEN_EXCL
    | TOKEN_CARET
    | TOKEN_EQ
    | TOKEN_UNDERSCORE
    | TOKEN_SLASH
    | TOKEN_COMMA
    | TOKEN_MMREFVAL
    | TOKEN_MREFVAL
    | TOKEN_SREFVAL
    | TOKEN_ID
    | TOKEN_DIFF
    | TOKEN_INT
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_expression
    | NONTERM_constant
    | NONTERM_sum
    | NONTERM_prod
    | NONTERM_fact
    | NONTERM_frac
    | NONTERM_power
    | NONTERM_integral
    | NONTERM_limit
    | NONTERM_refValue
    | NONTERM_lowPriorityBinaryOperator
    | NONTERM_mediumPriorityBinaryOperator
    | NONTERM_highPriorityFunction
    | NONTERM_mediumPriorityBinaryExpression
    | NONTERM_lowPriorityBinaryExpression
    | NONTERM_argumentSet
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (TexAst.Expr) 
