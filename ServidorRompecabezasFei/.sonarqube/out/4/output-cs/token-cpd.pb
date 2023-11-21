ö
oC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Servicios\Properties\AssemblyInfo.cs
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
]$$) *Âú
oC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Servicios\ServicioRompecabezasFei.cs
	namespace		 	
	Servicios		
 
{

 
[ 
ServiceBehavior 
( 
ConcurrencyMode $
=% &
ConcurrencyMode' 6
.6 7
Multiple7 ?
,? @
InstanceContextMode 
= 
InstanceContextMode 1
.1 2
Single2 8
)8 9
]9 :
public 

partial 
class #
ServicioRompecabezasFei 0
:1 2
IServicioJugador3 C
{ 
public 
bool 
	Registrar 
( 
CuentaJugador +
cuentaJugador, 9
)9 :
{ 	
Registro 
registro 
= 
new  #
Registro$ ,
(, -
)- .
;. /
bool 
	resultado 
= 
false "
;" #
try 
{ 
	resultado 
= 
registro $
.$ %
	Registrar% .
(. /
cuentaJugador/ <
)< =
;= >
} 
catch 
( 
EntityException "
)" #
{ 
} 
return 
	resultado 
; 
} 	
public!! 
bool!! !
ActualizarInformacion!! )
(!!) *
string!!* 0
nombreAnterior!!1 ?
,!!? @
string"" 
nuevoNombre"" 
,"" 
int""  #
nuevoNumeroAvatar""$ 5
)""5 6
{## 	
Registro$$ 
registro$$ 
=$$ 
new$$  #
Registro$$$ ,
($$, -
)$$- .
;$$. /
bool%% 
	resultado%% 
=%% 
false%% "
;%%" #
try'' 
{(( 
	resultado)) 
=)) 
registro)) $
.))$ %!
ActualizarInformacion))% :
()): ;
nombreAnterior)); I
,))I J
nuevoNombre** 
,**  
nuevoNumeroAvatar**! 2
)**2 3
;**3 4
}++ 
catch,, 
(,, 
EntityException,, "
),," #
{-- 
}// 
return11 
	resultado11 
;11 
}22 	
public44 
bool44  
ActualizarContrasena44 (
(44( )
string44) /
correo440 6
,446 7
string448 >

contrasena44? I
)44I J
{55 	
Registro66 
registro66 
=66 
new66  #
Registro66$ ,
(66, -
)66- .
;66. /
bool77 
	resultado77 
=77 
false77 "
;77" #
try99 
{:: 
	resultado;; 
=;; 
registro;; $
.;;$ % 
ActualizarContrasena;;% 9
(;;9 :
correo;;: @
,;;@ A

contrasena;;B L
);;L M
;;;M N
}<< 
catch== 
(== 
EntityException== "
)==" #
{>> 
}@@ 
returnBB 
	resultadoBB 
;BB 
}CC 	
publicEE 
boolEE 
ExisteNombreJugadorEE '
(EE' (
stringEE( .
nombreJugadorEE/ <
)EE< =
{FF 	
ConsultasJugadorGG 
consultasJugadorGG -
=GG. /
newGG0 3
ConsultasJugadorGG4 D
(GGD E
)GGE F
;GGF G
boolHH 
	resultadoHH 
=HH 
falseHH "
;HH" #
tryJJ 
{KK 
	resultadoLL 
=LL 
consultasJugadorLL ,
.LL, -
ExisteNombreJugadorLL- @
(LL@ A
nombreJugadorLLA N
)LLN O
;LLO P
}MM 
catchNN 
(NN 
EntityExceptionNN "
)NN" #
{OO 
}QQ 
returnSS 
	resultadoSS 
;SS 
}TT 	
publicVV 
CuentaJugadorVV 
IniciarSesionVV *
(VV* +
stringVV+ 1
nombreJugadorVV2 ?
,VV? @
stringVVA G

contrasenaVVH R
)VVR S
{WW 	
CuentaJugadorXX 
cuentaRecuperadaXX *
=XX+ ,
nullXX- 1
;XX1 2
ifZZ 
(ZZ 
ExisteNombreJugadorZZ #
(ZZ# $
nombreJugadorZZ$ 1
)ZZ1 2
&&ZZ3 5
![[ 
jugadoresConectados[[ $
.[[$ %
ContainsKey[[% 0
([[0 1
nombreJugador[[1 >
)[[> ?
)[[? @
{\\ 
try]] 
{^^ 
Autenticacion__ !
autenticacion__" /
=__0 1
new__2 5
Autenticacion__6 C
(__C D
)__D E
;__E F
cuentaRecuperada`` $
=``% &
autenticacion``' 4
.``4 5
IniciarSesion``5 B
(``B C
nombreJugador``C P
,``P Q

contrasena``R \
)``\ ]
;``] ^
ifbb 
(bb 
cuentaRecuperadabb (
!=bb) +
nullbb, 0
)bb0 1
{cc 
cuentaRecuperadadd (
.dd( )
EstadoConectividaddd) ;
=dd< =%
EstadoConectividadJugadordd> W
.ddW X
	ConectadoddX a
;dda b
cuentaRecuperadaee (
.ee( )
OperacionesContextoee) <
=ee= >
newee? B
GestionContextoeeC R
(eeR S
)eeS T
;eeT U
CuentaJugadorff %
cuentaAutenticadaff& 7
=ff8 9
newff: =
CuentaJugadorff> K
{gg 
	IdJugadorhh %
=hh& '
cuentaRecuperadahh( 8
.hh8 9
	IdJugadorhh9 B
,hhB C
NombreJugadorii )
=ii* +
cuentaRecuperadaii, <
.ii< =
NombreJugadorii= J
,iiJ K
NumeroAvatarjj (
=jj) *
cuentaRecuperadajj+ ;
.jj; <
NumeroAvatarjj< H
,jjH I
EstadoConectividadkk .
=kk/ 0
cuentaRecuperadakk1 A
.kkA B
EstadoConectividadkkB T
,kkT U
OperacionesContextoll /
=ll0 1
cuentaRecuperadall2 B
.llB C
OperacionesContextollC V
,llV W
}mm 
;mm 
jugadoresConectadosnn +
[nn+ ,
cuentaRecuperadann, <
.nn< =
NombreJugadornn= J
]nnJ K
=nnL M
cuentaAutenticadannN _
;nn_ `3
'NotificarConexionJugadorAOtrosJugadoresoo ?
(oo? @
cuentaRecuperadaoo@ P
.ooP Q
NombreJugadorooQ ^
,oo^ _
cuentaRecuperadapp ,
.pp, -
EstadoConectividadpp- ?
)pp? @
;pp@ A
}qq 
}rr 
catchss 
(ss 
EntityExceptionss &
)ss& '
{tt 
}vv 
}ww 
returnyy 
cuentaRecuperadayy #
;yy# $
}zz 	
public|| 
bool|| 
CerrarSesion||  
(||  !
string||! '
nombreJugador||( 5
)||5 6
{}} 	
bool~~ 
	resultado~~ 
=~~ 
false~~ "
;~~" #
if
ÄÄ 
(
ÄÄ !
jugadoresConectados
ÄÄ #
.
ÄÄ# $
ContainsKey
ÄÄ$ /
(
ÄÄ/ 0
nombreJugador
ÄÄ0 =
)
ÄÄ= >
)
ÄÄ> ?
{
ÅÅ 
	resultado
ÇÇ 
=
ÇÇ !
jugadoresConectados
ÇÇ /
.
ÇÇ/ 0
Remove
ÇÇ0 6
(
ÇÇ6 7
nombreJugador
ÇÇ7 D
)
ÇÇD E
;
ÇÇE F5
'NotificarConexionJugadorAOtrosJugadores
ÉÉ ;
(
ÉÉ; <
nombreJugador
ÑÑ !
,
ÑÑ! "'
EstadoConectividadJugador
ÑÑ# <
.
ÑÑ< =
Desconectado
ÑÑ= I
)
ÑÑI J
;
ÑÑJ K
}
ÖÖ 
return
áá 
	resultado
áá 
;
áá 
}
àà 	
}
ââ 
public
åå 

partial
åå 
class
åå %
ServicioRompecabezasFei
åå 0
:
åå1 2
IServicioCorreo
åå3 B
{
çç 
public
éé 
bool
éé %
ExisteCorreoElectronico
éé +
(
éé+ ,
string
éé, 2
correoElectronico
éé3 D
)
ééD E
{
èè 	
ConsultasJugador
êê 
consultasJugador
êê -
=
êê. /
new
êê0 3
ConsultasJugador
êê4 D
(
êêD E
)
êêE F
;
êêF G
bool
ëë 
	resultado
ëë 
=
ëë 
false
ëë "
;
ëë" #
try
ìì 
{
îî 
	resultado
ïï 
=
ïï 
consultasJugador
ïï ,
.
ïï, -%
ExisteCorreoElectronico
ïï- D
(
ïïD E
correoElectronico
ïïE V
)
ïïV W
;
ïïW X
}
ññ 
catch
óó 
(
óó 
EntityException
óó "
)
óó" #
{
òò 
}
öö 
return
úú 
	resultado
úú 
;
úú 
}
ùù 	
public
üü 
bool
üü !
EnviarMensajeCorreo
üü '
(
üü' (
string
üü( .

encabezado
üü/ 9
,
üü9 :
string
üü; A
correoDestino
üüB O
,
üüO P
string
†† 
asunto
†† 
,
†† 
string
†† !
mensaje
††" )
)
††) *
{
°° 	%
GeneradorMensajesCorreo
¢¢ #%
generadorMensajesCorreo
¢¢$ ;
=
¢¢< =
new
¢¢> A%
GeneradorMensajesCorreo
¢¢B Y
(
¢¢Y Z
)
¢¢Z [
;
¢¢[ \
bool
££ 
	resultado
££ 
=
££ 
false
££ "
;
££" #
try
•• 
{
¶¶ 
	resultado
ßß 
=
ßß %
generadorMensajesCorreo
ßß 3
.
ßß3 4
EnviarMensaje
ßß4 A
(
ßßA B

encabezado
®® 
,
®® 
correoDestino
®®  -
,
®®- .
asunto
®®/ 5
,
®®5 6
mensaje
®®7 >
)
®®> ?
;
®®? @
}
©© 
catch
™™ 
(
™™ 
EntityException
™™ "
)
™™" #
{
´´ 
}
≠≠ 
return
ØØ 
	resultado
ØØ 
;
ØØ 
}
∞∞ 	
}
±± 
public
µµ 

partial
µµ 
class
µµ %
ServicioRompecabezasFei
µµ 0
:
µµ1 2
IServicioSala
µµ3 @
{
∂∂ 
private
∑∑ 
readonly
∑∑ 
List
∑∑ 
<
∑∑ 
Sala
∑∑ "
>
∑∑" #
salasActivas
∑∑$ 0
=
∑∑1 2
new
∑∑3 6
List
∑∑7 ;
<
∑∑; <
Sala
∑∑< @
>
∑∑@ A
(
∑∑A B
)
∑∑B C
;
∑∑C D
public
ππ 
bool
ππ 
CrearNuevaSala
ππ "
(
ππ" #
string
ππ# )
nombreAnfitrion
ππ* 9
,
ππ9 :
string
ππ; A

codigoSala
ππB L
)
ππL M
{
∫∫ 	
GestionSala
ªª 
gestionSala
ªª #
=
ªª$ %
new
ªª& )
GestionSala
ªª* 5
(
ªª5 6
)
ªª6 7
;
ªª7 8
bool
ºº #
registroSalaRealizado
ºº &
=
ºº' (
false
ºº) .
;
ºº. /
try
ææ 
{
øø #
registroSalaRealizado
¿¿ %
=
¿¿& '
gestionSala
¿¿( 3
.
¿¿3 4
CrearNuevaSala
¿¿4 B
(
¿¿B C
nombreAnfitrion
¡¡ #
,
¡¡# $

codigoSala
¡¡% /
)
¡¡/ 0
;
¡¡0 1
}
¬¬ 
catch
√√ 
(
√√ 
EntityException
√√ "
)
√√" #
{
ƒƒ 
}
∆∆ 
if
»» 
(
»» #
registroSalaRealizado
»» %
)
»»% &
{
…… 
Sala
   
salaConectada
   "
=
  # $
new
  % (
Sala
  ) -
(
  - .
)
  . /
{
ÀÀ 

CodigoSala
ÃÃ 
=
ÃÃ  

codigoSala
ÃÃ! +
,
ÃÃ+ ,
NombreAnfitrion
ÕÕ #
=
ÕÕ$ %
nombreAnfitrion
ÕÕ& 5
,
ÕÕ5 6'
ContadorJugadoresActuales
ŒŒ -
=
ŒŒ. /
$num
ŒŒ0 1
,
ŒŒ1 2
	Jugadores
œœ 
=
œœ 
new
œœ  #
List
œœ$ (
<
œœ( )
CuentaJugador
œœ) 6
>
œœ6 7
(
œœ7 8
)
œœ8 9
}
–– 
;
–– 
salasActivas
—— 
.
—— 
Add
——  
(
——  !
salaConectada
——! .
)
——. /
;
——/ 0
}
““ 
return
‘‘ #
registroSalaRealizado
‘‘ (
;
‘‘( )
}
’’ 	
public
◊◊ 
bool
◊◊ "
ExisteSalaDisponible
◊◊ (
(
◊◊( )
string
◊◊) /

codigoSala
◊◊0 :
)
◊◊: ;
{
ÿÿ 	
bool
ŸŸ 
	resultado
ŸŸ 
=
ŸŸ 
false
ŸŸ "
;
ŸŸ" #
Sala
⁄⁄ 
salaEncontrada
⁄⁄ 
=
⁄⁄  !
salasActivas
⁄⁄" .
.
⁄⁄. /
First
⁄⁄/ 4
(
⁄⁄4 5
sala
€€ 
=>
€€ 
sala
€€ 
.
€€ 

CodigoSala
€€ '
.
€€' (
Equals
€€( .
(
€€. /

codigoSala
€€/ 9
)
€€9 :
)
€€: ;
;
€€; <
if
›› 
(
›› 
!
›› 
string
›› 
.
›› 
IsNullOrEmpty
›› %
(
››% &
salaEncontrada
››& 4
.
››4 5

CodigoSala
››5 ?
)
››? @
&&
››A C
salaEncontrada
ﬁﬁ 
.
ﬁﬁ !
ExisteCupoJugadores
ﬁﬁ 2
(
ﬁﬁ2 3
)
ﬁﬁ3 4
)
ﬁﬁ4 5
{
ﬂﬂ 
	resultado
‡‡ 
=
‡‡ 
true
‡‡  
;
‡‡  !
}
·· 
return
„„ 
	resultado
„„ 
;
„„ 
}
‰‰ 	
public
ÊÊ 
void
ÊÊ (
ConectarCuentaJugadorASala
ÊÊ .
(
ÊÊ. /
string
ÊÊ/ 5
nombreJugador
ÊÊ6 C
,
ÊÊC D
string
ÊÊE K

codigoSala
ÊÊL V
,
ÊÊV W
string
ÁÁ 
mensajeBienvenida
ÁÁ $
)
ÁÁ$ %
{
ËË 	
if
ÈÈ 
(
ÈÈ !
jugadoresConectados
ÈÈ #
.
ÈÈ# $
ContainsKey
ÈÈ$ /
(
ÈÈ/ 0
nombreJugador
ÈÈ0 =
)
ÈÈ= >
)
ÈÈ> ?
{
ÍÍ !
jugadoresConectados
ÎÎ #
[
ÎÎ# $
nombreJugador
ÎÎ$ 1
]
ÎÎ1 2
.
ÎÎ2 3!
OperacionesContexto
ÎÎ3 F
.
ÎÎF G#
ContextoIServicioSala
ÏÏ )
=
ÏÏ* +
OperationContext
ÏÏ, <
.
ÏÏ< =
Current
ÏÏ= D
;
ÏÏD E
Sala
ÌÌ 
salaEncontrada
ÌÌ #
=
ÌÌ$ %
salasActivas
ÌÌ& 2
.
ÌÌ2 3
First
ÌÌ3 8
(
ÌÌ8 9
sala
ÌÌ9 =
=>
ÌÌ> @
sala
ÓÓ 
.
ÓÓ 

CodigoSala
ÓÓ #
.
ÓÓ# $
Equals
ÓÓ$ *
(
ÓÓ* +

codigoSala
ÓÓ+ 5
)
ÓÓ5 6
)
ÓÓ6 7
;
ÓÓ7 8
if
 
(
 
!
 
string
 
.
 
IsNullOrEmpty
 )
(
) *
salaEncontrada
* 8
.
8 9

CodigoSala
9 C
)
C D
&&
E G
salaEncontrada
ÒÒ "
.
ÒÒ" #!
ExisteCupoJugadores
ÒÒ# 6
(
ÒÒ6 7
)
ÒÒ7 8
)
ÒÒ8 9
{
ÚÚ !
EnviarMensajeDeSala
ÛÛ '
(
ÛÛ' (
nombreJugador
ÛÛ( 5
,
ÛÛ5 6

codigoSala
ÛÛ7 A
,
ÛÛA B
mensajeBienvenida
ÛÛC T
)
ÛÛT U
;
ÛÛU V1
#NotificarNuevoJugadorConectadoASala
ÙÙ 7
(
ÙÙ7 8!
jugadoresConectados
ıı +
[
ıı+ ,
nombreJugador
ıı, 9
]
ıı9 :
,
ıı: ;

codigoSala
ıı< F
)
ııF G
;
ııG H
}
ˆˆ 
salaEncontrada
¯¯ 
.
¯¯ 
	Jugadores
¯¯ (
.
¯¯( )
Add
¯¯) ,
(
¯¯, -!
jugadoresConectados
¯¯- @
[
¯¯@ A
nombreJugador
¯¯A N
]
¯¯N O
)
¯¯O P
;
¯¯P Q
salaEncontrada
˘˘ 
.
˘˘ '
ContadorJugadoresActuales
˘˘ 8
++
˘˘8 :
;
˘˘: ;
}
˙˙ 
}
˚˚ 	
public
˝˝ 
void
˝˝ ,
DesconectarCuentaJugadorDeSala
˝˝ 2
(
˝˝2 3
string
˝˝3 9
nombreJugador
˝˝: G
,
˝˝G H
string
˛˛ 

codigoSala
˛˛ 
,
˛˛ 
string
˛˛ %
mensajeDespedida
˛˛& 6
)
˛˛6 7
{
ˇˇ 	
CuentaJugador
ÄÄ %
cuentaJugadorEncontrada
ÄÄ 1
=
ÄÄ2 3
null
ÄÄ4 8
;
ÄÄ8 9
Sala
ÅÅ 
salaEncontrada
ÅÅ 
=
ÅÅ  !
salasActivas
ÅÅ" .
.
ÅÅ. /
First
ÅÅ/ 4
(
ÅÅ4 5
sala
ÅÅ5 9
=>
ÅÅ: <
sala
ÇÇ 
.
ÇÇ 

CodigoSala
ÇÇ 
.
ÇÇ  
Equals
ÇÇ  &
(
ÇÇ& '

codigoSala
ÇÇ' 1
)
ÇÇ1 2
)
ÇÇ2 3
;
ÇÇ3 4
if
ÑÑ 
(
ÑÑ 
!
ÑÑ 
string
ÑÑ 
.
ÑÑ 
IsNullOrEmpty
ÑÑ %
(
ÑÑ% &
salaEncontrada
ÑÑ& 4
.
ÑÑ4 5

CodigoSala
ÑÑ5 ?
)
ÑÑ? @
)
ÑÑ@ A
{
ÖÖ %
cuentaJugadorEncontrada
ÜÜ '
=
ÜÜ( )
salaEncontrada
ÜÜ* 8
.
ÜÜ8 9
	Jugadores
ÜÜ9 B
.
ÜÜB C
First
áá 
(
áá 
cuentaJugador
áá '
=>
áá( *
cuentaJugador
àà !
.
àà! "
NombreJugador
àà" /
==
àà0 2
nombreJugador
àà3 @
)
àà@ A
;
ààA B
}
ââ 
if
ãã 
(
ãã %
cuentaJugadorEncontrada
ãã '
!=
ãã' )
null
ãã* .
&&
ãã/ 1
!
ãã2 3
string
ãã3 9
.
ãã9 :
IsNullOrEmpty
ãã: G
(
ããG H%
cuentaJugadorEncontrada
åå '
.
åå' (
NombreJugador
åå( 5
)
åå5 6
)
åå6 7
{
çç 
if
éé 
(
éé !
jugadoresConectados
éé '
.
éé' (
ContainsKey
éé( 3
(
éé3 4
nombreJugador
éé4 A
)
ééA B
)
ééB C
{
èè !
jugadoresConectados
êê '
[
êê' (
nombreJugador
êê( 5
]
êê5 6
.
êê6 7!
OperacionesContexto
êê7 J
.
êêJ K#
ContextoIServicioSala
ëë -
=
ëë. /
null
ëë0 4
;
ëë4 5
}
íí 
salaEncontrada
îî 
.
îî 
	Jugadores
îî (
.
îî( )
Remove
îî) /
(
îî/ 0%
cuentaJugadorEncontrada
îî0 G
)
îîG H
;
îîH I
salaEncontrada
ïï 
.
ïï '
ContadorJugadoresActuales
ïï 8
--
ïï8 :
;
ïï: ;
if
óó 
(
óó 
salaEncontrada
óó "
.
óó" #
	EstaVacia
óó# ,
(
óó, -
)
óó- .
)
óó. /
{
òò 
salasActivas
ôô  
.
ôô  !
Remove
ôô! '
(
ôô' (
salaEncontrada
ôô( 6
)
ôô6 7
;
ôô7 8
}
öö 
else
õõ 
{
úú !
EnviarMensajeDeSala
ùù '
(
ùù' (
nombreJugador
ùù( 5
,
ùù5 6

codigoSala
ùù7 A
,
ùùA B
mensajeDespedida
ùùC S
)
ùùS T
;
ùùT U0
"NotificarJugadorDesconectadoDeSala
ûû 6
(
ûû6 7
nombreJugador
ûû7 D
,
ûûD E

codigoSala
ûûF P
)
ûûP Q
;
ûûQ R
}
üü 
}
†† 
}
°° 	
public
££ 
void
££ !
EnviarMensajeDeSala
££ '
(
££' (
string
££( .
nombreJugador
££/ <
,
££< =
string
££> D

codigoSala
££E O
,
££O P
string
§§ 
mensaje
§§ 
)
§§ 
{
•• 	
Sala
¶¶ 
salaEncontrada
¶¶ 
=
¶¶  !
salasActivas
¶¶" .
.
¶¶. /
First
¶¶/ 4
(
¶¶4 5
sala
¶¶5 9
=>
¶¶: <
sala
ßß 
.
ßß 

CodigoSala
ßß 
.
ßß  
Equals
ßß  &
(
ßß& '

codigoSala
ßß' 1
)
ßß1 2
)
ßß2 3
;
ßß3 4
if
©© 
(
©© 
!
©© 
string
©© 
.
©© 
IsNullOrEmpty
©© %
(
©©% &
salaEncontrada
©©& 4
.
©©4 5

CodigoSala
©©5 ?
)
©©? @
)
©©@ A
{
™™ 
foreach
´´ 
(
´´ 
GestionContexto
´´ ((
gestionadorContextoJugador
´´) C
in
´´D F
salaEncontrada
¨¨ "
.
¨¨" #
	Jugadores
¨¨# ,
.
¨¨, -
Select
¨¨- 3
(
¨¨3 4
cuentaJugador
¨¨4 A
=>
¨¨B D
cuentaJugador
≠≠ !
.
≠≠! "!
OperacionesContexto
≠≠" 5
)
≠≠5 6
)
≠≠6 7
{
ÆÆ 
string
ØØ 

horaActual
ØØ %
=
ØØ& '
DateTime
ØØ( 0
.
ØØ0 1
Now
ØØ1 4
.
ØØ4 5
ToShortTimeString
ØØ5 F
(
ØØF G
)
ØØG H
;
ØØH I
string
∞∞ 
mensajeFinal
∞∞ '
=
∞∞( )

horaActual
∞∞* 4
+
∞∞5 6
$"
∞∞7 9
$str
∞∞9 :
{
∞∞: ;
nombreJugador
∞∞; H
}
∞∞H I
$str
∞∞I K
{
∞∞K L
mensaje
∞∞L S
}
∞∞S T
"
∞∞T U
;
∞∞U V
if
≤≤ 
(
≤≤ (
gestionadorContextoJugador
≤≤ 2
.
≤≤2 3#
ContextoIServicioSala
≤≤3 H
!=
≤≤I K
null
≤≤L P
)
≤≤P Q
{
≥≥ (
gestionadorContextoJugador
¥¥ 2
.
¥¥2 3#
ContextoIServicioSala
¥¥3 H
.
¥¥H I 
GetCallbackChannel
µµ .
<
µµ. /$
IServicioJuegoCallback
µµ/ E
>
µµE F
(
µµF G
)
µµG H
.
µµH I"
MostrarMensajeDeSala
∂∂ 0
(
∂∂0 1
mensajeFinal
∂∂1 =
)
∂∂= >
;
∂∂> ?
}
∑∑ 
}
∏∏ 
}
ππ 
}
∫∫ 	
private
ºº 
void
ºº 1
#NotificarNuevoJugadorConectadoASala
ºº 8
(
ºº8 9
CuentaJugador
ºº9 F
nuevoJugador
ººG S
,
ººS T
string
ΩΩ 

codigoSala
ΩΩ 
)
ΩΩ 
{
ææ 	
Sala
øø 
salaEncontrada
øø 
=
øø  !
salasActivas
øø" .
.
øø. /
First
øø/ 4
(
øø4 5
sala
øø5 9
=>
øø: <
sala
¿¿ 
.
¿¿ 

CodigoSala
¿¿ 
.
¿¿  
Equals
¿¿  &
(
¿¿& '

codigoSala
¿¿' 1
)
¿¿1 2
)
¿¿2 3
;
¿¿3 4
if
¬¬ 
(
¬¬ 
!
¬¬ 
string
¬¬ 
.
¬¬ 
IsNullOrEmpty
¬¬ %
(
¬¬% &
salaEncontrada
¬¬& 4
.
¬¬4 5

CodigoSala
¬¬5 ?
)
¬¬? @
)
¬¬@ A
{
√√ 
foreach
ƒƒ 
(
ƒƒ 
CuentaJugador
ƒƒ &
jugador
ƒƒ' .
in
ƒƒ/ 1
salaEncontrada
ƒƒ2 @
.
ƒƒ@ A
	Jugadores
ƒƒA J
)
ƒƒJ K
{
≈≈ 
jugador
∆∆ 
.
∆∆ !
OperacionesContexto
∆∆ /
.
∆∆/ 0#
ContextoIServicioSala
∆∆0 E
.
∆∆E F 
GetCallbackChannel
∆∆F X
<
∆∆X Y$
IServicioJuegoCallback
«« .
>
««. /
(
««/ 0
)
««0 1
.
««1 22
$NotificarNuevoJugadorConectadoEnSala
««2 V
(
««V W
nuevoJugador
»» $
)
»»$ %
;
»»% &
}
…… 
}
   
}
ÀÀ 	
private
ÕÕ 
void
ÕÕ 0
"NotificarJugadorDesconectadoDeSala
ÕÕ 7
(
ÕÕ7 8
string
ÕÕ8 >
nombreJugador
ÕÕ? L
,
ÕÕL M
string
ŒŒ 

codigoSala
ŒŒ 
)
ŒŒ 
{
œœ 	
Sala
–– 
salaEncontrada
–– 
=
––  !
salasActivas
––" .
.
––. /
First
––/ 4
(
––4 5
sala
––5 9
=>
––: <
sala
—— 
.
—— 

CodigoSala
—— 
.
——  
Equals
——  &
(
——& '

codigoSala
——' 1
)
——1 2
)
——2 3
;
——3 4
if
”” 
(
”” 
!
”” 
string
”” 
.
”” 
IsNullOrEmpty
”” %
(
””% &
salaEncontrada
””& 4
.
””4 5

CodigoSala
””5 ?
)
””? @
)
””@ A
{
‘‘ 
foreach
’’ 
(
’’ 
CuentaJugador
’’ &
jugador
’’' .
in
’’/ 1
salaEncontrada
’’2 @
.
’’@ A
	Jugadores
’’A J
)
’’J K
{
÷÷ 
jugador
◊◊ 
.
◊◊ !
OperacionesContexto
◊◊ /
.
◊◊/ 0#
ContextoIServicioSala
◊◊0 E
.
◊◊E F 
GetCallbackChannel
◊◊F X
<
◊◊X Y$
IServicioJuegoCallback
ÿÿ .
>
ÿÿ. /
(
ÿÿ/ 0
)
ÿÿ0 1
.
ÿÿ1 20
"NotificarJugadorDesconectadoDeSala
ÿÿ2 T
(
ÿÿT U
nombreJugador
ŸŸ %
)
ŸŸ% &
;
ŸŸ& '
}
⁄⁄ 
}
€€ 
}
‹‹ 	
public
ﬁﬁ 
string
ﬁﬁ (
GenerarCodigoParaNuevaSala
ﬁﬁ 0
(
ﬁﬁ0 1
)
ﬁﬁ1 2
{
ﬂﬂ 	
return
‡‡ 
Guid
‡‡ 
.
‡‡ 
NewGuid
‡‡ 
(
‡‡  
)
‡‡  !
.
‡‡! "
ToString
‡‡" *
(
‡‡* +
)
‡‡+ ,
;
‡‡, -
}
·· 	
public
„„ 
List
„„ 
<
„„ 
CuentaJugador
„„ !
>
„„! ".
 ObtenerJugadoresConectadosEnSala
„„# C
(
„„C D
string
„„D J

codigoSala
„„K U
)
„„U V
{
‰‰ 	
List
ÂÂ 
<
ÂÂ 
CuentaJugador
ÂÂ 
>
ÂÂ 
jugadoresEnSala
ÂÂ  /
=
ÂÂ0 1
new
ÂÂ2 5
List
ÂÂ6 :
<
ÂÂ: ;
CuentaJugador
ÂÂ; H
>
ÂÂH I
(
ÂÂI J
)
ÂÂJ K
;
ÂÂK L
Sala
ÊÊ 
salaEncontrada
ÊÊ 
=
ÊÊ  !
salasActivas
ÊÊ" .
.
ÊÊ. /
First
ÊÊ/ 4
(
ÊÊ4 5
sala
ÊÊ5 9
=>
ÊÊ: <
sala
ÁÁ 
.
ÁÁ 

CodigoSala
ÁÁ 
.
ÁÁ  
Equals
ÁÁ  &
(
ÁÁ& '

codigoSala
ÁÁ' 1
)
ÁÁ1 2
)
ÁÁ2 3
;
ÁÁ3 4
if
ÈÈ 
(
ÈÈ 
!
ÈÈ 
string
ÈÈ 
.
ÈÈ 
IsNullOrEmpty
ÈÈ %
(
ÈÈ% &
salaEncontrada
ÈÈ& 4
.
ÈÈ4 5

CodigoSala
ÈÈ5 ?
)
ÈÈ? @
)
ÈÈ@ A
{
ÍÍ 
jugadoresEnSala
ÎÎ 
=
ÎÎ  !
salaEncontrada
ÎÎ" 0
.
ÎÎ0 1
	Jugadores
ÎÎ1 :
;
ÎÎ: ;
}
ÏÏ 
return
ÓÓ 
jugadoresEnSala
ÓÓ "
;
ÓÓ" #
}
ÔÔ 	
}
 
public
ÙÙ 

partial
ÙÙ 
class
ÙÙ %
ServicioRompecabezasFei
ÙÙ 0
:
ÙÙ1 2 
IServicioAmistades
ÙÙ3 E
{
ıı 
private
ˆˆ 
readonly
ˆˆ 

Dictionary
ˆˆ #
<
ˆˆ# $
string
ˆˆ$ *
,
ˆˆ* +
CuentaJugador
ˆˆ, 9
>
ˆˆ9 :!
jugadoresConectados
ˆˆ; N
=
ˆˆO P
new
˜˜ 

Dictionary
˜˜ 
<
˜˜ 
string
˜˜ !
,
˜˜! "
CuentaJugador
˜˜# 0
>
˜˜0 1
(
˜˜1 2
)
˜˜2 3
;
˜˜3 4
private
˘˘ 
void
˘˘ 5
'NotificarConexionJugadorAOtrosJugadores
˘˘ <
(
˘˘< =
string
˘˘= C
nombreJugador
˘˘D Q
,
˘˘Q R'
EstadoConectividadJugador
˙˙ %
estado
˙˙& ,
)
˙˙, -
{
˚˚ 	
foreach
¸¸ 
(
¸¸ 
CuentaJugador
¸¸ "
cuenta
¸¸# )
in
¸¸* ,!
jugadoresConectados
¸¸- @
.
¸¸@ A
Values
¸¸A G
)
¸¸G H
{
˝˝ 
if
˛˛ 
(
˛˛ %
ExisteAmistadConJugador
˛˛ +
(
˛˛+ ,
nombreJugador
˛˛, 9
,
˛˛9 :
cuenta
˛˛; A
.
˛˛A B
NombreJugador
˛˛B O
)
˛˛O P
&&
˛˛Q S9
+EsJugadorSuscritoANotififacionesDeAmistades
ˇˇ ?
(
ˇˇ? @
cuenta
ˇˇ@ F
.
ˇˇF G
NombreJugador
ˇˇG T
)
ˇˇT U
)
ˇˇU V
{
ÄÄ 
cuenta
ÅÅ 
.
ÅÅ !
OperacionesContexto
ÅÅ .
.
ÅÅ. /(
ContextoIServicioAmistades
ÅÅ/ I
.
ÅÅI J 
GetCallbackChannel
ÇÇ *
<
ÇÇ* +(
IServicioAmistadesCallback
ÇÇ+ E
>
ÇÇE F
(
ÇÇF G
)
ÇÇG H
.
ÇÇH I2
$NotificarEstadoConectividadDeJugador
ÉÉ <
(
ÉÉ< =
nombreJugador
ÉÉ= J
,
ÉÉJ K
estado
ÉÉL R
)
ÉÉR S
;
ÉÉS T
}
ÑÑ 
}
ÖÖ 
}
ÜÜ 	
public
àà 
List
àà 
<
àà 
CuentaJugador
àà !
>
àà! "$
ObtenerAmigosDeJugador
àà# 9
(
àà9 :
string
àà: @
nombreJugador
ààA N
)
ààN O
{
ââ 	
GestionAmistades
ää 
gestionAmistades
ää -
=
ää. /
new
ää0 3
GestionAmistades
ää4 D
(
ääD E
)
ääE F
;
ääF G
List
ãã 
<
ãã 
CuentaJugador
ãã 
>
ãã 
cuentasJugador
ãã  .
=
ãã/ 0
null
ãã1 5
;
ãã5 6
try
çç 
{
éé 
cuentasJugador
èè 
=
èè  
gestionAmistades
èè! 1
.
èè1 2$
ObtenerAmigosDeJugador
èè2 H
(
èèH I
nombreJugador
èèI V
)
èèV W
;
èèW X
}
êê 
catch
ëë 
(
ëë 
EntityException
ëë "
)
ëë" #
{
íí 
}
îî 
if
ññ 
(
ññ 
cuentasJugador
ññ 
!=
ññ !
null
ññ" &
)
ññ& '
{
óó 
cuentasJugador
òò 
=
òò  8
*AgregarEstadoConectividadACuentasDeJugador
òò! K
(
òòK L
cuentasJugador
òòL Z
)
òòZ [
;
òò[ \
}
ôô 
return
õõ 
cuentasJugador
õõ !
;
õõ! "
}
úú 	
private
ûû 
List
ûû 
<
ûû 
CuentaJugador
ûû "
>
ûû" #8
*AgregarEstadoConectividadACuentasDeJugador
ûû$ N
(
ûûN O
List
üü 
<
üü 
CuentaJugador
üü 
>
üü 
cuentasJugador
üü  .
)
üü. /
{
†† 	
List
°° 
<
°° 
CuentaJugador
°° 
>
°° *
cuentasConEstadoConectividad
°°  <
=
°°= >
new
°°? B
List
°°C G
<
°°G H
CuentaJugador
°°H U
>
°°U V
(
°°V W
)
°°W X
;
°°X Y
foreach
££ 
(
££ 
CuentaJugador
££ "
cuenta
££# )
in
££* ,
cuentasJugador
££- ;
)
££; <
{
§§ 
if
•• 
(
•• !
jugadoresConectados
•• '
.
••' (
ContainsKey
••( 3
(
••3 4
cuenta
••4 :
.
••: ;
NombreJugador
••; H
)
••H I
)
••I J
{
¶¶ 
cuenta
ßß 
.
ßß  
EstadoConectividad
ßß -
=
ßß. /!
jugadoresConectados
ßß0 C
[
ßßC D
cuenta
ßßD J
.
ßßJ K
NombreJugador
ßßK X
]
ßßX Y
.
ßßY Z 
EstadoConectividad
®® *
;
®®* +
}
©© 
else
™™ 
{
´´ 
cuenta
¨¨ 
.
¨¨  
EstadoConectividad
¨¨ -
=
¨¨. /'
EstadoConectividadJugador
¨¨0 I
.
¨¨I J
Desconectado
¨¨J V
;
¨¨V W
}
≠≠ *
cuentasConEstadoConectividad
ØØ ,
.
ØØ, -
Add
ØØ- 0
(
ØØ0 1
cuenta
ØØ1 7
)
ØØ7 8
;
ØØ8 9
}
∞∞ 
return
≤≤ *
cuentasConEstadoConectividad
≤≤ /
;
≤≤/ 0
}
≥≥ 	
public
µµ 
List
µµ 
<
µµ 
CuentaJugador
µµ !
>
µµ! "3
%ObtenerJugadoresConSolicitudPendiente
µµ# H
(
µµH I
string
µµI O
nombreJugador
µµP ]
)
µµ] ^
{
∂∂ 	
GestionAmistades
∑∑ 
gestionAmistades
∑∑ -
=
∑∑. /
new
∑∑0 3
GestionAmistades
∑∑4 D
(
∑∑D E
)
∑∑E F
;
∑∑F G
List
∏∏ 
<
∏∏ 
CuentaJugador
∏∏ 
>
∏∏ 
cuentasJugador
∏∏  .
=
∏∏/ 0
null
∏∏1 5
;
∏∏5 6
try
∫∫ 
{
ªª 
cuentasJugador
ºº 
=
ºº  
gestionAmistades
ºº! 1
.
ºº1 23
%ObtenerJugadoresConSolicitudPendiente
ΩΩ 9
(
ΩΩ9 :
nombreJugador
ΩΩ: G
)
ΩΩG H
;
ΩΩH I
}
ææ 
catch
øø 
(
øø 
EntityException
øø "
)
øø" #
{
¿¿ 
}
¬¬ 
if
ƒƒ 
(
ƒƒ 
cuentasJugador
ƒƒ 
!=
ƒƒ !
null
ƒƒ" &
)
ƒƒ& '
{
≈≈ 
cuentasJugador
∆∆ 
=
∆∆  8
*AgregarEstadoConectividadACuentasDeJugador
∆∆! K
(
∆∆K L
cuentasJugador
∆∆L Z
)
∆∆Z [
;
∆∆[ \
}
«« 
return
…… 
cuentasJugador
…… !
;
……! "
}
   	
public
ÃÃ 
bool
ÃÃ &
EnviarSolicitudDeAmistad
ÃÃ ,
(
ÃÃ, -
string
ÃÃ- 3!
nombreJugadorOrigen
ÃÃ4 G
,
ÃÃG H
string
ÕÕ "
nombreJugadorDestino
ÕÕ '
)
ÕÕ' (
{
ŒŒ 	
bool
œœ  
esSolicitudEnviada
œœ #
=
œœ$ %
false
œœ& +
;
œœ+ ,
GestionAmistades
–– 
gestionAmistades
–– -
=
––. /
new
––0 3
GestionAmistades
––4 D
(
––D E
)
––E F
;
––F G
try
““ 
{
””  
esSolicitudEnviada
‘‘ "
=
‘‘# $
gestionAmistades
‘‘% 5
.
‘‘5 6&
EnviarSolicitudDeAmistad
‘‘6 N
(
‘‘N O!
nombreJugadorOrigen
’’ '
,
’’' ("
nombreJugadorDestino
’’) =
)
’’= >
;
’’> ?
}
÷÷ 
catch
◊◊ 
(
◊◊ 
EntityException
◊◊ "
)
◊◊" #
{
ÿÿ 
}
⁄⁄ 
if
‹‹ 
(
‹‹  
esSolicitudEnviada
‹‹ "
&&
‹‹# %9
+EsJugadorSuscritoANotififacionesDeAmistades
‹‹& Q
(
‹‹Q R"
nombreJugadorDestino
›› $
)
››$ %
)
››% &
{
ﬁﬁ !
jugadoresConectados
ﬂﬂ #
[
ﬂﬂ# $"
nombreJugadorDestino
ﬂﬂ$ 8
]
ﬂﬂ8 9
.
ﬂﬂ9 :!
OperacionesContexto
ﬂﬂ: M
.
ﬂﬂM N(
ContextoIServicioAmistades
‡‡ .
.
‡‡. / 
GetCallbackChannel
‡‡/ A
<
‡‡A B(
IServicioAmistadesCallback
‡‡B \
>
‡‡\ ]
(
‡‡] ^
)
‡‡^ _
.
‡‡_ `.
 NotificarSolicitudAmistadEnviada
·· 4
(
··4 5!
jugadoresConectados
··5 H
[
··H I!
nombreJugadorOrigen
··I \
]
··\ ]
)
··] ^
;
··^ _
}
‚‚ 
return
‰‰  
esSolicitudEnviada
‰‰ %
;
‰‰% &
}
ÂÂ 	
public
ÁÁ 
bool
ÁÁ '
AceptarSolicitudDeAmistad
ÁÁ -
(
ÁÁ- .
string
ÁÁ. 4!
nombreJugadorOrigen
ÁÁ5 H
,
ÁÁH I
string
ËË "
nombreJugadorDestino
ËË '
)
ËË' (
{
ÈÈ 	
bool
ÍÍ !
esSolicitudAceptada
ÍÍ $
=
ÍÍ% &
false
ÍÍ' ,
;
ÍÍ, -
GestionAmistades
ÎÎ 
gestionAmistades
ÎÎ -
=
ÎÎ. /
new
ÎÎ0 3
GestionAmistades
ÎÎ4 D
(
ÎÎD E
)
ÎÎE F
;
ÎÎF G
try
ÌÌ 
{
ÓÓ !
esSolicitudAceptada
ÔÔ #
=
ÔÔ$ %
gestionAmistades
ÔÔ& 6
.
ÔÔ6 7'
AceptarSolicitudDeAmistad
ÔÔ7 P
(
ÔÔP Q!
nombreJugadorOrigen
 '
,
' ("
nombreJugadorDestino
) =
)
= >
;
> ?
}
ÒÒ 
catch
ÚÚ 
(
ÚÚ 
EntityException
ÚÚ "
)
ÚÚ" #
{
ÛÛ 
}
ıı 
if
˜˜ 
(
˜˜ !
esSolicitudAceptada
˜˜ #
&&
˜˜$ &9
+EsJugadorSuscritoANotififacionesDeAmistades
˜˜' R
(
˜˜R S!
nombreJugadorOrigen
¯¯ #
)
¯¯# $
)
¯¯$ %
{
˘˘ !
jugadoresConectados
˙˙ #
[
˙˙# $!
nombreJugadorOrigen
˙˙$ 7
]
˙˙7 8
.
˙˙8 9!
OperacionesContexto
˙˙9 L
.
˙˙L M(
ContextoIServicioAmistades
˚˚ .
.
˚˚. / 
GetCallbackChannel
˚˚/ A
<
˚˚A B(
IServicioAmistadesCallback
˚˚B \
>
˚˚\ ]
(
˚˚] ^
)
˚˚^ _
.
˚˚_ `/
!NotificarSolicitudAmistadAceptada
¸¸ 5
(
¸¸5 6!
jugadoresConectados
¸¸6 I
[
¸¸I J"
nombreJugadorDestino
¸¸J ^
]
¸¸^ _
)
¸¸_ `
;
¸¸` a
}
˝˝ 
return
ˇˇ !
esSolicitudAceptada
ˇˇ &
;
ˇˇ& '
}
ÄÄ 	
public
ÇÇ 
bool
ÇÇ +
EliminarAmistadEntreJugadores
ÇÇ 1
(
ÇÇ1 2
string
ÇÇ2 8
nombreJugadorA
ÇÇ9 G
,
ÇÇG H
string
ÉÉ 
nombreJugadorB
ÉÉ !
)
ÉÉ! "
{
ÑÑ 	
bool
ÖÖ  
esAmistadEliminada
ÖÖ #
=
ÖÖ$ %
false
ÖÖ& +
;
ÖÖ+ ,
GestionAmistades
ÜÜ 
gestionAmistades
ÜÜ -
=
ÜÜ. /
new
ÜÜ0 3
GestionAmistades
ÜÜ4 D
(
ÜÜD E
)
ÜÜE F
;
ÜÜF G
try
àà 
{
ââ  
esAmistadEliminada
ää "
=
ää# $
gestionAmistades
ää% 5
.
ää5 6+
EliminarAmistadEntreJugadores
ää6 S
(
ääS T
nombreJugadorA
ãã "
,
ãã" #
nombreJugadorB
ãã$ 2
)
ãã2 3
;
ãã3 4
}
åå 
catch
çç 
(
çç 
EntityException
çç "
)
çç" #
{
éé 
}
êê 
if
íí 
(
íí  
esAmistadEliminada
íí "
&&
íí# %9
+EsJugadorSuscritoANotififacionesDeAmistades
íí& Q
(
ííQ R
nombreJugadorB
ìì 
)
ìì 
)
ìì  
{
îî !
jugadoresConectados
ïï #
[
ïï# $
nombreJugadorB
ïï$ 2
]
ïï2 3
.
ïï3 4!
OperacionesContexto
ïï4 G
.
ïïG H(
ContextoIServicioAmistades
ññ .
.
ññ. / 
GetCallbackChannel
ññ/ A
<
ññA B(
IServicioAmistadesCallback
ññB \
>
ññ\ ]
(
ññ] ^
)
ññ^ _
.
ññ_ `'
NotificarAmistadEliminada
óó -
(
óó- .
nombreJugadorA
óó. <
)
óó< =
;
óó= >
}
òò 
return
öö  
esAmistadEliminada
öö %
;
öö% &
}
õõ 	
public
ùù 
bool
ùù (
RechazarSolicitudDeAmistad
ùù .
(
ùù. /
string
ùù/ 5!
nombreJugadorOrigen
ùù6 I
,
ùùI J
string
ûû "
nombreJugadorDestino
ûû '
)
ûû' (
{
üü 	
GestionAmistades
†† 
gestionAmistades
†† -
=
††. /
new
††0 3
GestionAmistades
††4 D
(
††D E
)
††E F
;
††F G
bool
°° 
	resultado
°° 
=
°° 
false
°° "
;
°°" #
try
££ 
{
§§ 
	resultado
•• 
=
•• 
gestionAmistades
•• ,
.
••, -(
EliminarSolicitudDeAmistad
••- G
(
••G H!
nombreJugadorOrigen
¶¶ '
,
¶¶' ("
nombreJugadorDestino
¶¶) =
)
¶¶= >
;
¶¶> ?
}
ßß 
catch
®® 
(
®® 
EntityException
®® "
)
®®" #
{
©© 
}
´´ 
return
≠≠ 
	resultado
≠≠ 
;
≠≠ 
}
ÆÆ 	
public
∞∞ 
bool
∞∞ &
ExisteSolicitudDeAmistad
∞∞ ,
(
∞∞, -
string
∞∞- 3!
nombreJugadorOrigen
∞∞4 G
,
∞∞G H
string
±± "
nombreJugadorDestino
±± '
)
±±' (
{
≤≤ 	
GestionAmistades
≥≥ 
gestionAmistades
≥≥ -
=
≥≥. /
new
≥≥0 3
GestionAmistades
≥≥4 D
(
≥≥D E
)
≥≥E F
;
≥≥F G
bool
¥¥ 
	resultado
¥¥ 
=
¥¥ 
false
¥¥ "
;
¥¥" #
try
∂∂ 
{
∑∑ 
	resultado
∏∏ 
=
∏∏ 
gestionAmistades
∏∏ ,
.
∏∏, -&
ExisteSolicitudDeAmistad
∏∏- E
(
∏∏E F!
nombreJugadorOrigen
ππ '
,
ππ' ("
nombreJugadorDestino
ππ) =
)
ππ= >
;
ππ> ?
}
∫∫ 
catch
ªª 
(
ªª 
EntityException
ªª "
)
ªª" #
{
ºº 
}
ææ 
return
¿¿ 
	resultado
¿¿ 
;
¿¿ 
}
¡¡ 	
public
√√ 
bool
√√ %
ExisteAmistadConJugador
√√ +
(
√√+ ,
string
√√, 2
nombreJugadorA
√√3 A
,
√√A B
string
√√C I
nombreJugadorB
√√J X
)
√√X Y
{
ƒƒ 	
GestionAmistades
≈≈ 
gestionAmistades
≈≈ -
=
≈≈. /
new
≈≈0 3
GestionAmistades
≈≈4 D
(
≈≈D E
)
≈≈E F
;
≈≈F G
bool
∆∆ 
	resultado
∆∆ 
=
∆∆ 
false
∆∆ "
;
∆∆" #
try
»» 
{
…… 
	resultado
   
=
   
gestionAmistades
   ,
.
  , -%
ExisteAmistadConJugador
  - D
(
  D E
nombreJugadorA
ÀÀ "
,
ÀÀ" #
nombreJugadorB
ÀÀ$ 2
)
ÀÀ2 3
;
ÀÀ3 4
}
ÃÃ 
catch
ÕÕ 
(
ÕÕ 
EntityException
ÕÕ "
)
ÕÕ" #
{
ŒŒ 
}
–– 
return
““ 
	resultado
““ 
;
““ 
}
”” 	
public
’’ 
bool
’’ 6
(SuscribirJugadorANotificacionesAmistades
’’ <
(
’’< =
string
’’= C
nombreJugador
’’D Q
)
’’Q R
{
÷÷ 	
bool
◊◊ 
	resultado
◊◊ 
=
◊◊ 
false
◊◊ "
;
◊◊" #
if
ŸŸ 
(
ŸŸ 
!
ŸŸ 9
+EsJugadorSuscritoANotififacionesDeAmistades
ŸŸ <
(
ŸŸ< =
nombreJugador
ŸŸ= J
)
ŸŸJ K
)
ŸŸK L
{
⁄⁄ !
jugadoresConectados
€€ #
[
€€# $
nombreJugador
€€$ 1
]
€€1 2
.
€€2 3!
OperacionesContexto
€€3 F
.
€€F G(
ContextoIServicioAmistades
‹‹ .
=
‹‹/ 0
OperationContext
‹‹1 A
.
‹‹A B
Current
‹‹B I
;
‹‹I J
	resultado
›› 
=
›› 
true
››  
;
››  !
}
ﬁﬁ 
return
‡‡ 
	resultado
‡‡ 
;
‡‡ 
}
·· 	
public
„„ 
bool
„„ 9
+DesuscribirJugadorDeNotificacionesAmistades
„„ ?
(
„„? @
string
„„@ F
nombreJugador
„„G T
)
„„T U
{
‰‰ 	
bool
ÂÂ 
	resultado
ÂÂ 
=
ÂÂ 
false
ÂÂ "
;
ÂÂ" #
if
ÁÁ 
(
ÁÁ 9
+EsJugadorSuscritoANotififacionesDeAmistades
ÁÁ ;
(
ÁÁ; <
nombreJugador
ÁÁ< I
)
ÁÁI J
)
ÁÁJ K
{
ËË !
jugadoresConectados
ÈÈ #
[
ÈÈ# $
nombreJugador
ÈÈ$ 1
]
ÈÈ1 2
.
ÈÈ2 3!
OperacionesContexto
ÈÈ3 F
.
ÈÈF G(
ContextoIServicioAmistades
ÍÍ .
=
ÍÍ/ 0
null
ÍÍ1 5
;
ÍÍ5 6
	resultado
ÎÎ 
=
ÎÎ 
true
ÎÎ  
;
ÎÎ  !
}
ÏÏ 
return
ÓÓ 
	resultado
ÓÓ 
;
ÓÓ 
}
ÔÔ 	
public
ÒÒ 
bool
ÒÒ 9
+EsJugadorSuscritoANotififacionesDeAmistades
ÒÒ ?
(
ÒÒ? @
string
ÒÒ@ F
nombreJugador
ÒÒG T
)
ÒÒT U
{
ÚÚ 	
bool
ÛÛ 
	resultado
ÛÛ 
=
ÛÛ 
false
ÛÛ "
;
ÛÛ" #
if
ıı 
(
ıı !
jugadoresConectados
ıı #
.
ıı# $
ContainsKey
ıı$ /
(
ıı/ 0
nombreJugador
ıı0 =
)
ıı= >
&&
ıı? A!
jugadoresConectados
ˆˆ #
[
ˆˆ# $
nombreJugador
ˆˆ$ 1
]
ˆˆ1 2
.
ˆˆ2 3!
OperacionesContexto
ˆˆ3 F
.
ˆˆF G(
ContextoIServicioAmistades
˜˜ *
!=
˜˜+ -
null
˜˜. 2
)
˜˜2 3
{
¯¯ 
	resultado
˘˘ 
=
˘˘ 
true
˘˘  
;
˘˘  !
}
˙˙ 
return
¸¸ 
	resultado
¸¸ 
;
¸¸ 
}
˝˝ 	
}
˛˛ 
public
ÇÇ 

partial
ÇÇ 
class
ÇÇ %
ServicioRompecabezasFei
ÇÇ 0
:
ÇÇ1 2
IServicioPartida
ÇÇ3 C
{
ÉÉ 
public
ÑÑ 
bool
ÑÑ 
CrearNuevaPartida
ÑÑ %
(
ÑÑ% &
string
ÑÑ& ,

codigoSala
ÑÑ- 7
)
ÑÑ7 8
{
ÖÖ 	
GestionPartida
ÜÜ 
gestionPartida
ÜÜ )
=
ÜÜ* +
new
ÜÜ, /
GestionPartida
ÜÜ0 >
(
ÜÜ> ?
)
ÜÜ? @
;
ÜÜ@ A
bool
áá 
	resultado
áá 
=
áá 
false
áá "
;
áá" #
try
ââ 
{
ää 
	resultado
ãã 
=
ãã 
gestionPartida
ãã *
.
ãã* +
CrearNuevaPartida
ãã+ <
(
ãã< =

codigoSala
ãã= G
)
ããG H
;
ããH I
}
åå 
catch
çç 
(
çç 
EntityException
çç "
)
çç" #
{
éé 
}
êê 
return
íí 
	resultado
íí 
;
íí 
}
ìì 	
public
ïï 
bool
ïï 
FinalizarPartida
ïï $
(
ïï$ %
string
ïï% +

codigoSala
ïï, 6
,
ïï6 7
CuentaJugador
ññ 
cuentaJugador
ññ '
,
ññ' (
bool
ññ) -
	esGanador
ññ. 7
)
ññ7 8
{
óó 	
GestionPartida
òò 
gestionPartida
òò )
=
òò* +
new
òò, /
GestionPartida
òò0 >
(
òò> ?
)
òò? @
;
òò@ A
bool
ôô 
	resultado
ôô 
=
ôô 
false
ôô "
;
ôô" #
try
õõ 
{
úú 
	resultado
ùù 
=
ùù 
gestionPartida
ùù *
.
ùù* +
FinalizarPartida
ùù+ ;
(
ùù; <

codigoSala
ûû 
,
ûû 
cuentaJugador
ûû  -
,
ûû- .
	esGanador
ûû/ 8
)
ûû8 9
;
ûû9 :
}
üü 
catch
†† 
(
†† 
EntityException
†† "
)
††" #
{
°° 
}
££ 
return
•• 
	resultado
•• 
;
•• 
}
¶¶ 	
public
®® 
bool
®® $
ExpulsarJugadorPartida
®® *
(
®®* +
string
®®+ 1

codigoSala
®®2 <
,
®®< =
string
®®> D
nombreJugador
®®E R
)
®®R S
{
©© 	
throw
™™ 
new
™™ %
NotImplementedException
™™ -
(
™™- .
)
™™. /
;
™™/ 0
}
´´ 	
public
≠≠ 
bool
≠≠ 
GenerarTablero
≠≠ "
(
≠≠" #
string
≠≠# )

codigoSala
≠≠* 4
)
≠≠4 5
{
ÆÆ 	
throw
ØØ 
new
ØØ %
NotImplementedException
ØØ -
(
ØØ- .
)
ØØ. /
;
ØØ/ 0
}
∞∞ 	
public
≤≤ 
bool
≤≤ 
IniciarPartida
≤≤ "
(
≤≤" #
string
≤≤# )

codigoSala
≤≤* 4
)
≤≤4 5
{
≥≥ 	
throw
¥¥ 
new
¥¥ %
NotImplementedException
¥¥ -
(
¥¥- .
)
¥¥. /
;
¥¥/ 0
}
µµ 	
public
∑∑ 
void
∑∑ !
MoverPiezaPosicionX
∑∑ '
(
∑∑' (
double
∑∑( .
	posicionX
∑∑/ 8
)
∑∑8 9
{
∏∏ 	
throw
ππ 
new
ππ %
NotImplementedException
ππ -
(
ππ- .
)
ππ. /
;
ππ/ 0
}
∫∫ 	
public
ºº 
void
ºº !
MoverPiezaPosicionY
ºº '
(
ºº' (
bool
ºº( ,
	posicionY
ºº- 6
)
ºº6 7
{
ΩΩ 	
throw
ææ 
new
ææ %
NotImplementedException
ææ -
(
ææ- .
)
ææ. /
;
ææ/ 0
}
øø 	
public
¡¡ 
bool
¡¡ '
NotificarJugadorPreparado
¡¡ -
(
¡¡- .
string
¡¡. 4

codigoSala
¡¡5 ?
,
¡¡? @
string
¬¬ 
nombreJugador
¬¬  
)
¬¬  !
{
√√ 	
throw
ƒƒ 
new
ƒƒ %
NotImplementedException
ƒƒ -
(
ƒƒ- .
)
ƒƒ. /
;
ƒƒ/ 0
}
≈≈ 	
public
«« 
int
«« *
ObtenerNumeroPartidasJugadas
«« /
(
««/ 0
string
««0 6
nombreJugador
««7 D
)
««D E
{
»» 	
ConsultasJugador
…… 
consultasJugador
…… -
=
……. /
new
……0 3
ConsultasJugador
……4 D
(
……D E
)
……E F
;
……F G
int
   #
numeroPartidasJugadas
   %
=
  & '
$num
  ( )
;
  ) *
try
ÃÃ 
{
ÕÕ #
numeroPartidasJugadas
ŒŒ %
=
ŒŒ& '
consultasJugador
ŒŒ( 8
.
ŒŒ8 93
%ObtenerNumeroPartidasJugadasDeJugador
œœ 9
(
œœ9 :
nombreJugador
œœ: G
)
œœG H
;
œœH I
}
–– 
catch
—— 
(
—— 
EntityException
—— "
)
——" #
{
““ 
}
‘‘ 
return
÷÷ #
numeroPartidasJugadas
÷÷ (
;
÷÷( )
}
◊◊ 	
public
ŸŸ 
int
ŸŸ *
ObtenerNumeroPartidasGanadas
ŸŸ /
(
ŸŸ/ 0
string
ŸŸ0 6
nombreJugador
ŸŸ7 D
)
ŸŸD E
{
⁄⁄ 	
ConsultasJugador
€€ 
consultasJugador
€€ -
=
€€. /
new
€€0 3
ConsultasJugador
€€4 D
(
€€D E
)
€€E F
;
€€F G
int
‹‹ #
numeroPartidasGanadas
‹‹ %
=
‹‹& '
$num
‹‹( )
;
‹‹) *
try
ﬁﬁ 
{
ﬂﬂ #
numeroPartidasGanadas
‡‡ %
=
‡‡& '
consultasJugador
‡‡( 8
.
‡‡8 9*
ObtenerNumeroPartidasGanadas
·· 0
(
··0 1
nombreJugador
··1 >
)
··> ?
;
··? @
}
‚‚ 
catch
„„ 
(
„„ 
EntityException
„„ "
)
„„" #
{
‰‰ 
}
ÊÊ 
return
ËË #
numeroPartidasGanadas
ËË (
;
ËË( )
}
ÈÈ 	
}
ÍÍ 
}ÏÏ 