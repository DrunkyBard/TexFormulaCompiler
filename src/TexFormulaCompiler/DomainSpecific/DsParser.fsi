// Signature file for parser generated by fsyacc
module DsParser
type token = 
  | EOF
  | EQ
  | LT
  | LE
  | GT
  | GE
  | NEQ
  | AND
  | OR
  | FOR
  | WITH
  | SELECT
  | WHERE
  | ID of (string)
  | STRING of (string)
  | INT of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_EQ
    | TOKEN_LT
    | TOKEN_LE
    | TOKEN_GT
    | TOKEN_GE
    | TOKEN_NEQ
    | TOKEN_AND
    | TOKEN_OR
    | TOKEN_FOR
    | TOKEN_WITH
    | TOKEN_SELECT
    | TOKEN_WHERE
    | TOKEN_ID
    | TOKEN_STRING
    | TOKEN_INT
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_value
    | NONTERM_whereStatement
    | NONTERM_operation
    | NONTERM_operationType
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (QueryStatement.Statement) 
