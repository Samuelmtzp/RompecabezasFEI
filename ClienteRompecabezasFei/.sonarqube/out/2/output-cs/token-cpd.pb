»
lC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Seguridad\EncriptadorContrasena.cs
	namespace 	
Security
 
{ 
public 

class !
EncriptadorContrasena &
{ 
public		 
static		 
string		 
CalcularHashSha512		 /
(		/ 0
string		0 6
entrada		7 >
)		> ?
{

 	
var  
contrasenaEncriptada $
=% &
$str' )
;) *
using 
( 
SHA512 
sha512  
=! "
SHA512# )
.) *
Create* 0
(0 1
)1 2
)2 3
{ 
byte 
[ 
] 
hash 
= 
sha512 $
.$ %
ComputeHash% 0
(0 1
Encoding1 9
.9 :
UTF8: >
.> ?
GetBytes? G
(G H
entradaH O
)O P
)P Q
;Q R 
contrasenaEncriptada $
=% &
BitConverter' 3
.3 4
ToString4 <
(< =
hash= A
)A B
. 
Replace 
( 
$str  
,  !
string" (
.( )
Empty) .
). /
. 
ToLowerInvariant %
(% &
)& '
;' (
} 
return  
contrasenaEncriptada '
;' (
} 	
} 
} ™
nC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Seguridad\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str $
)$ %
]% &
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str &
)& '
]' (
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *¼8
eC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Seguridad\ValidadorDatos.cs
	namespace 	
	Seguridad
 
{ 
public 

class 
ValidadorDatos 
{ 
private 
const 
int &
MaximoCaracteresContrasena 4
=5 6
$num7 9
;9 :
private		 
const		 
int		 "
MaximoCaracteresCorreo		 0
=		1 2
$num		3 5
;		5 6
private

 
const

 
int

 )
MaximoCaracteresNombreJugador

 7
=

8 9
$num

: <
;

< =
private 
const 
int 3
'MilisegundosMaximosParaExpresionRegular A
=B C
$numD G
;G H
private 
const 
string 
PatronContrasena -
=. /
$str0 `
;` a
private 
const 
string 
PatronNombreJugador 0
=1 2
$str3 W
;W X
private 
const 
string 
PatronCorreo )
=* +
$str, I
;I J
public 
static 
bool .
"ExisteLongitudExcedidaEnContrasena =
(= >
string> D

contrasenaE O
)O P
{ 	
bool 
camposExcedidos  
=! "
false# (
;( )
if 
( 

contrasena 
. 
Length !
>" #&
MaximoCaracteresContrasena$ >
)> ?
{ 
camposExcedidos 
=  !
true" &
;& '
} 
return 
camposExcedidos "
;" #
} 	
public 
static 
bool *
ExisteLongitudExcedidaEnCorreo 9
(9 :
string: @
correoA G
)G H
{ 	
bool 
camposExcedidos  
=! "
false# (
;( )
if   
(   
correo   
.   
Length   
>   "
MaximoCaracteresCorreo    6
)  6 7
{!! 
camposExcedidos"" 
=""  !
true""" &
;""& '
}## 
return%% 
camposExcedidos%% "
;%%" #
}&& 	
public(( 
static(( 
bool(( 1
%ExisteLongitudExcedidaEnNombreJugador(( @
(((@ A
string((A G
nombreJugador((H U
)((U V
{)) 	
bool** 
camposExcedidos**  
=**! "
false**# (
;**( )
if,, 
(,, 
nombreJugador,, 
.,, 
Length,, $
>,,% &)
MaximoCaracteresNombreJugador,,' D
),,D E
{-- 
camposExcedidos.. 
=..  !
true.." &
;..& '
}// 
return11 
camposExcedidos11 "
;11" #
}22 	
public44 
static44 
bool44 4
(ExistenCaracteresInvalidosParaContrasena44 C
(44C D
string44D J

contrasena44K U
)44U V
{55 	
bool66 
contrasenaInvalida66 #
=66$ %
false66& +
;66+ ,
if88 
(88 
Regex88 
.88 
IsMatch88 
(88 

contrasena88 (
,88( )
PatronContrasena88* :
,88: ;
RegexOptions88< H
.88H I
None88I M
,88M N
TimeSpan99 
.99 
FromMilliseconds99 )
(99) *3
'MilisegundosMaximosParaExpresionRegular99* Q
)99Q R
)99R S
==99T V
false99W \
)99\ ]
{:: 
contrasenaInvalida;; "
=;;# $
true;;% )
;;;) *
}<< 
return>> 
contrasenaInvalida>> %
;>>% &
}?? 	
publicAA 
staticAA 
boolAA 7
+ExistenCaracteresInvalidosParaNombreJugadorAA F
(AAF G
stringAAG M
nombreJugadorAAN [
)AA[ \
{BB 	
boolCC 
	resultadoCC 
=CC 
falseCC "
;CC" #
ifEE 
(EE 
RegexEE 
.EE 
IsMatchEE 
(EE 
nombreJugadorEE +
,EE+ ,
PatronNombreJugadorEE- @
,EE@ A
RegexOptionsEEB N
.EEN O
NoneEEO S
,EES T
TimeSpanFF 
.FF 
FromMillisecondsFF )
(FF) *3
'MilisegundosMaximosParaExpresionRegularFF* Q
)FFQ R
)FFR S
==FFT V
falseFFW \
)FF\ ]
{GG 
	resultadoHH 
=HH 
trueHH  
;HH  !
}II 
returnKK 
	resultadoKK 
;KK 
}LL 	
publicNN 
staticNN 
boolNN 0
$ExistenCaracteresInvalidosParaCorreoNN ?
(NN? @
stringNN@ F
correoNNG M
)NNM N
{OO 	
boolPP 
	resultadoPP 
=PP 
falsePP "
;PP" #
ifRR 
(RR 
RegexRR 
.RR 
IsMatchRR 
(RR 
correoRR $
,RR$ %
PatronCorreoRR& 2
,RR2 3
RegexOptionsRR4 @
.RR@ A
NoneRRA E
,RRE F
TimeSpanSS 
.SS 
FromMillisecondsSS )
(SS) *3
'MilisegundosMaximosParaExpresionRegularSS* Q
)SSQ R
)SSR S
==SST V
falseSSW \
)SS\ ]
{TT 
	resultadoUU 
=UU 
trueUU  
;UU  !
}VV 
returnXX 
	resultadoXX 
;XX 
}YY 	
public[[ 
static[[ 
bool[[ 
EsCadenaVacia[[ (
([[( )
string[[) /
cadena[[0 6
)[[6 7
{\\ 	
bool]] 
	resultado]] 
=]] 
false]] "
;]]" #
if__ 
(__ 
string__ 
.__ 
IsNullOrWhiteSpace__ )
(__) *
cadena__* 0
)__0 1
)__1 2
{`` 
	resultadoaa 
=aa 
trueaa  
;aa  !
}bb 
returndd 
	resultadodd 
;dd 
}ee 	
publicgg 
staticgg 
boolgg '
ExisteCoincidenciaEnCadenasgg 6
(gg6 7
stringgg7 =
cadenaAgg> E
,ggE F
stringggG M
cadenaBggN U
)ggU V
{hh 	
boolii 
	resultadoii 
=ii 
falseii "
;ii" #
ifkk 
(kk 
cadenaAkk 
==kk 
cadenaBkk "
)kk" #
{ll 
	resultadomm 
=mm 
truemm  
;mm  !
}nn 
returnpp 
	resultadopp 
;pp 
}qq 	
}rr 
}ss 