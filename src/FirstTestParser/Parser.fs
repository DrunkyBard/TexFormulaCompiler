// Implementation file for parser generated by fsyacc
module SqlParser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open Microsoft.FSharp.Text.Lexing
open Microsoft.FSharp.Text.Parsing.ParseHelpers
# 1 "Parser.fsy"

open SqlQuery
open System
open Microsoft.FSharp.Text.Lexing

# 12 "Parser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | EOF
  | DOT
  | COMMA
  | EQ
  | LT
  | LE
  | GT
  | GE
  | NEQ
  | ASC
  | DESC
  | AND
  | OR
  | ON
  | JOIN
  | INNER
  | LEFT
  | RIGHT
  | SELECT
  | FROM
  | WHERE
  | ORDER
  | BY
  | BOOL of (bool)
  | STRING of (string)
  | INT of (int)
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_EOF
    | TOKEN_DOT
    | TOKEN_COMMA
    | TOKEN_EQ
    | TOKEN_LT
    | TOKEN_LE
    | TOKEN_GT
    | TOKEN_GE
    | TOKEN_NEQ
    | TOKEN_ASC
    | TOKEN_DESC
    | TOKEN_AND
    | TOKEN_OR
    | TOKEN_ON
    | TOKEN_JOIN
    | TOKEN_INNER
    | TOKEN_LEFT
    | TOKEN_RIGHT
    | TOKEN_SELECT
    | TOKEN_FROM
    | TOKEN_WHERE
    | TOKEN_ORDER
    | TOKEN_BY
    | TOKEN_BOOL
    | TOKEN_STRING
    | TOKEN_INT
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | EOF  -> 0 
  | DOT  -> 1 
  | COMMA  -> 2 
  | EQ  -> 3 
  | LT  -> 4 
  | LE  -> 5 
  | GT  -> 6 
  | GE  -> 7 
  | NEQ  -> 8 
  | ASC  -> 9 
  | DESC  -> 10 
  | AND  -> 11 
  | OR  -> 12 
  | ON  -> 13 
  | JOIN  -> 14 
  | INNER  -> 15 
  | LEFT  -> 16 
  | RIGHT  -> 17 
  | SELECT  -> 18 
  | FROM  -> 19 
  | WHERE  -> 20 
  | ORDER  -> 21 
  | BY  -> 22 
  | BOOL _ -> 23 
  | STRING _ -> 24 
  | INT _ -> 25 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_EOF 
  | 1 -> TOKEN_DOT 
  | 2 -> TOKEN_COMMA 
  | 3 -> TOKEN_EQ 
  | 4 -> TOKEN_LT 
  | 5 -> TOKEN_LE 
  | 6 -> TOKEN_GT 
  | 7 -> TOKEN_GE 
  | 8 -> TOKEN_NEQ 
  | 9 -> TOKEN_ASC 
  | 10 -> TOKEN_DESC 
  | 11 -> TOKEN_AND 
  | 12 -> TOKEN_OR 
  | 13 -> TOKEN_ON 
  | 14 -> TOKEN_JOIN 
  | 15 -> TOKEN_INNER 
  | 16 -> TOKEN_LEFT 
  | 17 -> TOKEN_RIGHT 
  | 18 -> TOKEN_SELECT 
  | 19 -> TOKEN_FROM 
  | 20 -> TOKEN_WHERE 
  | 21 -> TOKEN_ORDER 
  | 22 -> TOKEN_BY 
  | 23 -> TOKEN_BOOL 
  | 24 -> TOKEN_STRING 
  | 25 -> TOKEN_INT 
  | 28 -> TOKEN_end_of_input
  | 26 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 28 
let _fsyacc_tagOfErrorTerminal = 26

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | EOF  -> "EOF" 
  | DOT  -> "DOT" 
  | COMMA  -> "COMMA" 
  | EQ  -> "EQ" 
  | LT  -> "LT" 
  | LE  -> "LE" 
  | GT  -> "GT" 
  | GE  -> "GE" 
  | NEQ  -> "NEQ" 
  | ASC  -> "ASC" 
  | DESC  -> "DESC" 
  | AND  -> "AND" 
  | OR  -> "OR" 
  | ON  -> "ON" 
  | JOIN  -> "JOIN" 
  | INNER  -> "INNER" 
  | LEFT  -> "LEFT" 
  | RIGHT  -> "RIGHT" 
  | SELECT  -> "SELECT" 
  | FROM  -> "FROM" 
  | WHERE  -> "WHERE" 
  | ORDER  -> "ORDER" 
  | BY  -> "BY" 
  | BOOL _ -> "BOOL" 
  | STRING _ -> "STRING" 
  | INT _ -> "INT" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | EOF  -> (null : System.Object) 
  | DOT  -> (null : System.Object) 
  | COMMA  -> (null : System.Object) 
  | EQ  -> (null : System.Object) 
  | LT  -> (null : System.Object) 
  | LE  -> (null : System.Object) 
  | GT  -> (null : System.Object) 
  | GE  -> (null : System.Object) 
  | NEQ  -> (null : System.Object) 
  | ASC  -> (null : System.Object) 
  | DESC  -> (null : System.Object) 
  | AND  -> (null : System.Object) 
  | OR  -> (null : System.Object) 
  | ON  -> (null : System.Object) 
  | JOIN  -> (null : System.Object) 
  | INNER  -> (null : System.Object) 
  | LEFT  -> (null : System.Object) 
  | RIGHT  -> (null : System.Object) 
  | SELECT  -> (null : System.Object) 
  | FROM  -> (null : System.Object) 
  | WHERE  -> (null : System.Object) 
  | ORDER  -> (null : System.Object) 
  | BY  -> (null : System.Object) 
  | BOOL _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | STRING _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | INT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; 1us; 1us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; 4us; |]
let _fsyacc_action_rows = 3
let _fsyacc_actionTableElements = [|1us; 32768us; 11us; 2us; 0us; 49152us; 0us; 16385us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 2us; 3us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 1us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; 16385us; |]
let _fsyacc_reductions ()  =    [| 
# 219 "Parser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : Int32)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (Microsoft.FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : '_startstart));
# 228 "Parser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 24 "Parser.fsy"
                                 1
                   )
# 24 "Parser.fsy"
                 : Int32));
|]
# 239 "Parser.fs"
let tables () : Microsoft.FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:Microsoft.FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 29;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = (tables ()).Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : Int32 =
    Microsoft.FSharp.Core.Operators.unbox ((tables ()).Interpret(lexer, lexbuf, 0))