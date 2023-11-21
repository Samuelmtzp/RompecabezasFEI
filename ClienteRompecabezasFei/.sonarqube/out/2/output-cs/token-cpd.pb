Å
vC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Seguridad\EncriptadorContrasena.cs
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
} £
xC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Seguridad\Properties\AssemblyInfo.cs
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
]$$) *Û1
oC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Seguridad\ValidadorDatos.cs
	namespace 	
	Seguridad
 
{ 
public 

class 
ValidadorDatos 
{ 
private 
const 
int &
MaximoCaracteresContrasena 4
=5 6
$num7 9
;9 :
private 
const 
int "
MaximoCaracteresCorreo 0
=1 2
$num3 5
;5 6
private		 
const		 
int		 )
MaximoCaracteresNombreJugador		 7
=		8 9
$num		: <
;		< =
private

 
const

 
string

 
PatronContrasena

 -
=

. /
$str

0 `
;

` a
private 
const 
string 
PatronNombreJugador 0
=1 2
$str3 W
;W X
private 
const 
string 
PatronCorreo )
=* +
$str, I
;I J
public 
static 
bool .
"ExisteLongitudExcedidaEnContrasena =
(= >
string> D

contrasenaE O
)O P
{ 	
bool 
camposExcedidos  
=! "
false# (
;( )
if 
( 

contrasena 
. 
Length !
>" #&
MaximoCaracteresContrasena$ >
)> ?
{ 
camposExcedidos 
=  !
true" &
;& '
} 
return 
camposExcedidos "
;" #
} 	
public 
static 
bool *
ExisteLongitudExcedidaEnCorreo 9
(9 :
string: @
correoA G
)G H
{ 	
bool 
camposExcedidos  
=! "
false# (
;( )
if 
( 
correo 
. 
Length 
> "
MaximoCaracteresCorreo  6
)6 7
{ 
camposExcedidos   
=    !
true  " &
;  & '
}!! 
return## 
camposExcedidos## "
;##" #
}$$ 	
public&& 
static&& 
bool&& 1
%ExisteLongitudExcedidaEnNombreJugador&& @
(&&@ A
string&&A G
nombreJugador&&H U
)&&U V
{'' 	
bool(( 
camposExcedidos((  
=((! "
false((# (
;((( )
if** 
(** 
nombreJugador** 
.** 
Length** $
>**% &)
MaximoCaracteresNombreJugador**' D
)**D E
{++ 
camposExcedidos,, 
=,,  !
true,," &
;,,& '
}-- 
return// 
camposExcedidos// "
;//" #
}00 	
public22 
static22 
bool22 4
(ExistenCaracteresInvalidosParaContrasena22 C
(22C D
string22D J

contrasena22K U
)22U V
{33 	
bool44 
contrasenaInvalida44 #
=44$ %
false44& +
;44+ ,
if66 
(66 
Regex66 
.66 
IsMatch66 
(66 

contrasena66 (
,66( )
PatronContrasena66* :
)66: ;
==66< >
false66? D
)66D E
{77 
contrasenaInvalida88 "
=88# $
true88% )
;88) *
}99 
return;; 
contrasenaInvalida;; %
;;;% &
}<< 	
public>> 
static>> 
bool>> 7
+ExistenCaracteresInvalidosParaNombreJugador>> F
(>>F G
string>>G M
nombreJugador>>N [
)>>[ \
{?? 	
bool@@ 
	resultado@@ 
=@@ 
false@@ "
;@@" #
ifBB 
(BB 
RegexBB 
.BB 
IsMatchBB 
(BB 
nombreJugadorBB +
,BB+ ,
PatronNombreJugadorBB- @
)BB@ A
==BBB D
falseBBE J
)BBJ K
{CC 
	resultadoDD 
=DD 
trueDD  
;DD  !
}EE 
returnGG 
	resultadoGG 
;GG 
}HH 	
publicJJ 
staticJJ 
boolJJ 0
$ExistenCaracteresInvalidosParaCorreoJJ ?
(JJ? @
stringJJ@ F
correoJJG M
)JJM N
{KK 	
boolLL 
	resultadoLL 
=LL 
falseLL "
;LL" #
ifNN 
(NN 
RegexNN 
.NN 
IsMatchNN 
(NN 
correoNN $
,NN$ %
PatronCorreoNN& 2
)NN2 3
==NN4 6
falseNN7 <
)NN< =
{OO 
	resultadoPP 
=PP 
truePP  
;PP  !
}QQ 
returnSS 
	resultadoSS 
;SS 
}TT 	
publicVV 
staticVV 
boolVV 
EsCadenaVaciaVV (
(VV( )
stringVV) /
cadenaVV0 6
)VV6 7
{WW 	
boolXX 
	resultadoXX 
=XX 
falseXX "
;XX" #
ifZZ 
(ZZ 
stringZZ 
.ZZ 
IsNullOrWhiteSpaceZZ )
(ZZ) *
cadenaZZ* 0
)ZZ0 1
)ZZ1 2
{[[ 
	resultado\\ 
=\\ 
true\\  
;\\  !
}]] 
return__ 
	resultado__ 
;__ 
}`` 	
publicbb 
staticbb 
boolbb '
ExisteCoincidenciaEnCadenasbb 6
(bb6 7
stringbb7 =
cadenaAbb> E
,bbE F
stringbbG M
cadenaBbbN U
)bbU V
{cc 	
booldd 
	resultadodd 
=dd 
falsedd "
;dd" #
ifff 
(ff 
cadenaAff 
==ff 
cadenaBff "
)ff" #
{gg 
	resultadohh 
=hh 
truehh  
;hh  !
}ii 
returnkk 
	resultadokk 
;kk 
}ll 	
}mm 
}nn 