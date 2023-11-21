¤
yC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Servicios\Properties\AssemblyInfo.cs
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
]$$) *¹’
yC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Servicios\ServicioRompecabezasFei.cs
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
{:: 
CuentaJugador;; !
cuentaJugadorRegistro;; 3
=;;4 5
new;;6 9
CuentaJugador;;: G
(;;G H
);;H I
{<< 
Correo== 
=== 
correo== #
,==# $

Contrasena>> 
=>>  

contrasena>>! +
,>>+ ,
}?? 
;?? 
	resultado@@ 
=@@ 
registro@@ $
.@@$ % 
ActualizarContrasena@@% 9
(@@9 :
correo@@: @
,@@@ A

contrasena@@B L
)@@L M
;@@M N
}AA 
catchBB 
(BB 
EntityExceptionBB "
)BB" #
{CC 
}EE 
returnGG 
	resultadoGG 
;GG 
}HH 	
publicJJ 
boolJJ 
ExisteNombreJugadorJJ '
(JJ' (
stringJJ( .
nombreJugadorJJ/ <
)JJ< =
{KK 	
ConsultasJugadorLL 
consultasJugadorLL -
=LL. /
newLL0 3
ConsultasJugadorLL4 D
(LLD E
)LLE F
;LLF G
boolMM 
	resultadoMM 
=MM 
falseMM "
;MM" #
tryOO 
{PP 
	resultadoQQ 
=QQ 
consultasJugadorQQ ,
.QQ, -
ExisteNombreJugadorQQ- @
(QQ@ A
nombreJugadorQQA N
)QQN O
;QQO P
}RR 
catchSS 
(SS 
EntityExceptionSS "
)SS" #
{TT 
}VV 
returnXX 
	resultadoXX 
;XX 
}YY 	
public[[ 
CuentaJugador[[ 
IniciarSesion[[ *
([[* +
string[[+ 1
nombreJugador[[2 ?
,[[? @
string[[A G

contrasena[[H R
)[[R S
{\\ 	
CuentaJugador]] 
cuentaRecuperada]] *
=]]+ ,
null]]- 1
;]]1 2
if__ 
(__ 
ExisteNombreJugador__ #
(__# $
nombreJugador__$ 1
)__1 2
&&__3 5
!`` 
jugadoresConectados`` $
.``$ %
ContainsKey``% 0
(``0 1
nombreJugador``1 >
)``> ?
)``? @
{aa 
trybb 
{cc 
Autenticaciondd !
autenticaciondd" /
=dd0 1
newdd2 5
Autenticaciondd6 C
(ddC D
)ddD E
;ddE F
cuentaRecuperadaee $
=ee% &
autenticacionee' 4
.ee4 5
IniciarSesionee5 B
(eeB C
nombreJugadoreeC P
,eeP Q

contrasenaeeR \
)ee\ ]
;ee] ^
ifgg 
(gg 
cuentaRecuperadagg (
!=gg) +
nullgg, 0
)gg0 1
{hh 
cuentaRecuperadaii (
.ii( )
EstadoConectividadii) ;
=ii< =%
EstadoConectividadJugadorii> W
.iiW X
	ConectadoiiX a
;iia b
cuentaRecuperadajj (
.jj( )
OperacionesContextojj) <
=jj= >
newjj? B
GestionContextojjC R
(jjR S
)jjS T
;jjT U
CuentaJugadorkk %
cuentaAutenticadakk& 7
=kk8 9
newkk: =
CuentaJugadorkk> K
{ll 
	IdJugadormm %
=mm& '
cuentaRecuperadamm( 8
.mm8 9
	IdJugadormm9 B
,mmB C
NombreJugadornn )
=nn* +
cuentaRecuperadann, <
.nn< =
NombreJugadornn= J
,nnJ K
NumeroAvataroo (
=oo) *
cuentaRecuperadaoo+ ;
.oo; <
NumeroAvataroo< H
,ooH I
EstadoConectividadpp .
=pp/ 0
cuentaRecuperadapp1 A
.ppA B
EstadoConectividadppB T
,ppT U
OperacionesContextoqq /
=qq0 1
cuentaRecuperadaqq2 B
.qqB C
OperacionesContextoqqC V
,qqV W
}rr 
;rr 
jugadoresConectadosss +
[ss+ ,
cuentaRecuperadass, <
.ss< =
NombreJugadorss= J
]ssJ K
=ssL M
cuentaAutenticadassN _
;ss_ `3
'NotificarConexionJugadorAOtrosJugadorestt ?
(tt? @
cuentaRecuperadatt@ P
.ttP Q
NombreJugadorttQ ^
,tt^ _
cuentaRecuperadauu ,
.uu, -
EstadoConectividaduu- ?
)uu? @
;uu@ A
}vv 
}ww 
catchxx 
(xx 
EntityExceptionxx &
)xx& '
{yy 
}{{ 
}|| 
return~~ 
cuentaRecuperada~~ #
;~~# $
} 	
public
 
bool
 
CerrarSesion
  
(
  !
string
! '
nombreJugador
( 5
)
5 6
{
‚‚ 	
bool
ƒƒ 
	resultado
ƒƒ 
=
ƒƒ 
false
ƒƒ "
;
ƒƒ" #
if
…… 
(
…… !
jugadoresConectados
…… #
.
……# $
ContainsKey
……$ /
(
……/ 0
nombreJugador
……0 =
)
……= >
)
……> ?
{
†† 
	resultado
‡‡ 
=
‡‡ !
jugadoresConectados
‡‡ /
.
‡‡/ 0
Remove
‡‡0 6
(
‡‡6 7
nombreJugador
‡‡7 D
)
‡‡D E
;
‡‡E F5
'NotificarConexionJugadorAOtrosJugadores
ˆˆ ;
(
ˆˆ; <
nombreJugador
‰‰ !
,
‰‰! "'
EstadoConectividadJugador
‰‰# <
.
‰‰< =
Desconectado
‰‰= I
)
‰‰I J
;
‰‰J K
}
ŠŠ 
return
ŒŒ 
	resultado
ŒŒ 
;
ŒŒ 
}
 	
}
 
public
‘‘ 

partial
‘‘ 
class
‘‘ %
ServicioRompecabezasFei
‘‘ 0
:
‘‘1 2
IServicioCorreo
‘‘3 B
{
’’ 
public
““ 
bool
““ %
ExisteCorreoElectronico
““ +
(
““+ ,
string
““, 2
correoElectronico
““3 D
)
““D E
{
”” 	
ConsultasJugador
•• 
consultasJugador
•• -
=
••. /
new
••0 3
ConsultasJugador
••4 D
(
••D E
)
••E F
;
••F G
bool
–– 
	resultado
–– 
=
–– 
false
–– "
;
––" #
try
˜˜ 
{
™™ 
	resultado
šš 
=
šš 
consultasJugador
šš ,
.
šš, -%
ExisteCorreoElectronico
šš- D
(
ššD E
correoElectronico
ššE V
)
ššV W
;
ššW X
}
›› 
catch
œœ 
(
œœ 
EntityException
œœ "
)
œœ" #
{
 
}
ŸŸ 
return
¡¡ 
	resultado
¡¡ 
;
¡¡ 
}
¢¢ 	
public
¤¤ 
bool
¤¤ !
EnviarMensajeCorreo
¤¤ '
(
¤¤' (
string
¤¤( .

encabezado
¤¤/ 9
,
¤¤9 :
string
¤¤; A
correoDestino
¤¤B O
,
¤¤O P
string
¥¥ 
asunto
¥¥ 
,
¥¥ 
string
¥¥ !
mensaje
¥¥" )
)
¥¥) *
{
¦¦ 	%
GeneradorMensajesCorreo
§§ #%
generadorMensajesCorreo
§§$ ;
=
§§< =
new
§§> A%
GeneradorMensajesCorreo
§§B Y
(
§§Y Z
)
§§Z [
;
§§[ \
bool
¨¨ 
	resultado
¨¨ 
=
¨¨ 
false
¨¨ "
;
¨¨" #
try
ªª 
{
«« 
	resultado
¬¬ 
=
¬¬ %
generadorMensajesCorreo
¬¬ 3
.
¬¬3 4
EnviarMensaje
¬¬4 A
(
¬¬A B

encabezado
­­ 
,
­­ 
correoDestino
­­  -
,
­­- .
asunto
­­/ 5
,
­­5 6
mensaje
­­7 >
)
­­> ?
;
­­? @
}
®® 
catch
¯¯ 
(
¯¯ 
EntityException
¯¯ "
)
¯¯" #
{
°° 
}
²² 
return
´´ 
	resultado
´´ 
;
´´ 
}
µµ 	
}
¶¶ 
public
ºº 

partial
ºº 
class
ºº %
ServicioRompecabezasFei
ºº 0
:
ºº1 2
IServicioSala
ºº3 @
{
»» 
private
¼¼ 
readonly
¼¼ 
List
¼¼ 
<
¼¼ 
Sala
¼¼ "
>
¼¼" #
salasActivas
¼¼$ 0
=
¼¼1 2
new
¼¼3 6
List
¼¼7 ;
<
¼¼; <
Sala
¼¼< @
>
¼¼@ A
(
¼¼A B
)
¼¼B C
;
¼¼C D
public
¾¾ 
bool
¾¾ 
CrearNuevaSala
¾¾ "
(
¾¾" #
string
¾¾# )
nombreAnfitrion
¾¾* 9
,
¾¾9 :
string
¾¾; A

codigoSala
¾¾B L
)
¾¾L M
{
¿¿ 	
GestionSala
ÀÀ 
gestionSala
ÀÀ #
=
ÀÀ$ %
new
ÀÀ& )
GestionSala
ÀÀ* 5
(
ÀÀ5 6
)
ÀÀ6 7
;
ÀÀ7 8
bool
ÁÁ #
registroSalaRealizado
ÁÁ &
=
ÁÁ' (
false
ÁÁ) .
;
ÁÁ. /
try
ÃÃ 
{
ÄÄ #
registroSalaRealizado
ÅÅ %
=
ÅÅ& '
gestionSala
ÅÅ( 3
.
ÅÅ3 4
CrearNuevaSala
ÅÅ4 B
(
ÅÅB C
nombreAnfitrion
ÆÆ #
,
ÆÆ# $

codigoSala
ÆÆ% /
)
ÆÆ/ 0
;
ÆÆ0 1
}
ÇÇ 
catch
ÈÈ 
(
ÈÈ 
EntityException
ÈÈ "
)
ÈÈ" #
{
ÉÉ 
}
ËË 
if
ÍÍ 
(
ÍÍ #
registroSalaRealizado
ÍÍ %
)
ÍÍ% &
{
ÎÎ 
Sala
ÏÏ 
salaConectada
ÏÏ "
=
ÏÏ# $
new
ÏÏ% (
Sala
ÏÏ) -
(
ÏÏ- .
)
ÏÏ. /
{
ĞĞ 

CodigoSala
ÑÑ 
=
ÑÑ  

codigoSala
ÑÑ! +
,
ÑÑ+ ,
NombreAnfitrion
ÒÒ #
=
ÒÒ$ %
nombreAnfitrion
ÒÒ& 5
,
ÒÒ5 6'
ContadorJugadoresActuales
ÓÓ -
=
ÓÓ. /
$num
ÓÓ0 1
,
ÓÓ1 2
	Jugadores
ÔÔ 
=
ÔÔ 
new
ÔÔ  #
List
ÔÔ$ (
<
ÔÔ( )
CuentaJugador
ÔÔ) 6
>
ÔÔ6 7
(
ÔÔ7 8
)
ÔÔ8 9
}
ÕÕ 
;
ÕÕ 
salasActivas
ÖÖ 
.
ÖÖ 
Add
ÖÖ  
(
ÖÖ  !
salaConectada
ÖÖ! .
)
ÖÖ. /
;
ÖÖ/ 0
}
×× 
return
ÙÙ #
registroSalaRealizado
ÙÙ (
;
ÙÙ( )
}
ÚÚ 	
public
ÜÜ 
bool
ÜÜ "
ExisteSalaDisponible
ÜÜ (
(
ÜÜ( )
string
ÜÜ) /

codigoSala
ÜÜ0 :
)
ÜÜ: ;
{
İİ 	
bool
ŞŞ 
	resultado
ŞŞ 
=
ŞŞ 
false
ŞŞ "
;
ŞŞ" #
Sala
ßß 
salaEncontrada
ßß 
=
ßß  !
salasActivas
ßß" .
.
ßß. /
FirstOrDefault
ßß/ =
(
ßß= >
sala
àà 
=>
àà 
sala
àà 
.
àà 

CodigoSala
àà '
.
àà' (
Equals
àà( .
(
àà. /

codigoSala
àà/ 9
)
àà9 :
)
àà: ;
;
àà; <
if
ââ 
(
ââ 
salaEncontrada
ââ 
!=
ââ !
null
ââ" &
&&
ââ' )
salaEncontrada
ââ* 8
.
ââ8 9!
ExisteCupoJugadores
ââ9 L
(
ââL M
)
ââM N
)
ââN O
{
ãã 
	resultado
ää 
=
ää 
true
ää  
;
ää  !
}
åå 
return
çç 
	resultado
çç 
;
çç 
}
èè 	
public
êê 
void
êê (
ConectarCuentaJugadorASala
êê .
(
êê. /
string
êê/ 5
nombreJugador
êê6 C
,
êêC D
string
êêE K

codigoSala
êêL V
,
êêV W
string
ëë 
mensajeBienvenida
ëë $
)
ëë$ %
{
ìì 	
if
íí 
(
íí !
jugadoresConectados
íí #
.
íí# $
ContainsKey
íí$ /
(
íí/ 0
nombreJugador
íí0 =
)
íí= >
)
íí> ?
{
îî !
jugadoresConectados
ïï #
[
ïï# $
nombreJugador
ïï$ 1
]
ïï1 2
.
ïï2 3!
OperacionesContexto
ïï3 F
.
ïïF G#
ContextoIServicioSala
ğğ )
=
ğğ* +
OperationContext
ğğ, <
.
ğğ< =
Current
ğğ= D
;
ğğD E
Sala
ññ 
salaEncontrada
ññ #
=
ññ$ %
salasActivas
ññ& 2
.
ññ2 3
FirstOrDefault
ññ3 A
(
ññA B
sala
òò 
=>
òò 
sala
òò  
.
òò  !

CodigoSala
òò! +
.
òò+ ,
Equals
òò, 2
(
òò2 3

codigoSala
òò3 =
)
òò= >
)
òò> ?
;
òò? @
if
ôô 
(
ôô 
salaEncontrada
ôô "
.
ôô" #!
ExisteCupoJugadores
ôô# 6
(
ôô6 7
)
ôô7 8
)
ôô8 9
{
õõ !
EnviarMensajeDeSala
öö '
(
öö' (
nombreJugador
öö( 5
,
öö5 6

codigoSala
öö7 A
,
ööA B
mensajeBienvenida
ööC T
)
ööT U
;
ööU V1
#NotificarNuevoJugadorConectadoASala
÷÷ 7
(
÷÷7 8!
jugadoresConectados
øø +
[
øø+ ,
nombreJugador
øø, 9
]
øø9 :
,
øø: ;

codigoSala
øø< F
)
øøF G
;
øøG H
}
ùù 
salaEncontrada
ûû 
.
ûû 
	Jugadores
ûû (
.
ûû( )
Add
ûû) ,
(
ûû, -!
jugadoresConectados
ûû- @
[
ûû@ A
nombreJugador
ûûA N
]
ûûN O
)
ûûO P
;
ûûP Q
salaEncontrada
üü 
.
üü '
ContadorJugadoresActuales
üü 8
++
üü8 :
;
üü: ;
}
ıı 
}
şş 	
public
€€ 
void
€€ ,
DesconectarCuentaJugadorDeSala
€€ 2
(
€€2 3
string
€€3 9
nombreJugador
€€: G
,
€€G H
string
 

codigoSala
 
,
 
string
 %
mensajeDespedida
& 6
)
6 7
{
‚‚ 	
CuentaJugador
ƒƒ %
cuentaJugadorEncontrada
ƒƒ 1
=
ƒƒ2 3
null
ƒƒ4 8
;
ƒƒ8 9
Sala
„„ 
salaEncontrada
„„ 
=
„„  !
salasActivas
„„" .
.
„„. /
FirstOrDefault
„„/ =
(
„„= >
sala
„„> B
=>
„„C E
sala
…… 
.
…… 

CodigoSala
…… 
.
……  
Equals
……  &
(
……& '

codigoSala
……' 1
)
……1 2
)
……2 3
;
……3 4
if
‡‡ 
(
‡‡ 
salaEncontrada
‡‡ 
!=
‡‡ !
null
‡‡" &
)
‡‡& '
{
ˆˆ %
cuentaJugadorEncontrada
‰‰ '
=
‰‰( )
salaEncontrada
‰‰* 8
.
‰‰8 9
	Jugadores
‰‰9 B
.
‰‰B C
FirstOrDefault
ŠŠ "
(
ŠŠ" #
cuentaJugador
ŠŠ# 0
=>
ŠŠ1 3
cuentaJugador
‹‹ !
.
‹‹! "
NombreJugador
‹‹" /
==
‹‹0 2
nombreJugador
‹‹3 @
)
‹‹@ A
;
‹‹A B
}
ŒŒ 
if
 
(
 %
cuentaJugadorEncontrada
 '
!=
( *
null
+ /
)
/ 0
{
 
if
 
(
 !
jugadoresConectados
 '
.
' (
ContainsKey
( 3
(
3 4
nombreJugador
4 A
)
A B
)
B C
{
‘‘ !
jugadoresConectados
’’ '
[
’’' (
nombreJugador
’’( 5
]
’’5 6
.
’’6 7!
OperacionesContexto
’’7 J
.
’’J K#
ContextoIServicioSala
““ -
=
““. /
null
““0 4
;
““4 5
}
”” 
salaEncontrada
–– 
.
–– 
	Jugadores
–– (
.
––( )
Remove
––) /
(
––/ 0%
cuentaJugadorEncontrada
––0 G
)
––G H
;
––H I
salaEncontrada
—— 
.
—— '
ContadorJugadoresActuales
—— 8
--
——8 :
;
——: ;
if
™™ 
(
™™ 
salaEncontrada
™™ "
.
™™" #
	EstaVacia
™™# ,
(
™™, -
)
™™- .
)
™™. /
{
šš 
salasActivas
››  
.
››  !
Remove
››! '
(
››' (
salaEncontrada
››( 6
)
››6 7
;
››7 8
}
œœ 
else
 
{
 !
EnviarMensajeDeSala
ŸŸ '
(
ŸŸ' (
nombreJugador
ŸŸ( 5
,
ŸŸ5 6

codigoSala
ŸŸ7 A
,
ŸŸA B
mensajeDespedida
ŸŸC S
)
ŸŸS T
;
ŸŸT U0
"NotificarJugadorDesconectadoDeSala
   6
(
  6 7
nombreJugador
  7 D
,
  D E

codigoSala
  F P
)
  P Q
;
  Q R
}
¡¡ 
}
¢¢ 
}
££ 	
public
¥¥ 
void
¥¥ !
EnviarMensajeDeSala
¥¥ '
(
¥¥' (
string
¥¥( .
nombreJugador
¥¥/ <
,
¥¥< =
string
¥¥> D

codigoSala
¥¥E O
,
¥¥O P
string
¦¦ 
mensaje
¦¦ 
)
¦¦ 
{
§§ 	
Sala
¨¨ 
salaEncontrada
¨¨ 
=
¨¨  !
salasActivas
¨¨" .
.
¨¨. /
FirstOrDefault
¨¨/ =
(
¨¨= >
sala
¨¨> B
=>
¨¨C E
sala
©© 
.
©© 

CodigoSala
©© 
.
©©  
Equals
©©  &
(
©©& '

codigoSala
©©' 1
)
©©1 2
)
©©2 3
;
©©3 4
foreach
«« 
(
«« 
CuentaJugador
«« "
cuentaJugador
««# 0
in
««1 3
salaEncontrada
««4 B
.
««B C
	Jugadores
««C L
)
««L M
{
¬¬ 
string
­­ 

horaActual
­­ !
=
­­" #
DateTime
­­$ ,
.
­­, -
Now
­­- 0
.
­­0 1
ToShortTimeString
­­1 B
(
­­B C
)
­­C D
;
­­D E
string
®® 
mensajeFinal
®® #
=
®®$ %

horaActual
®®& 0
+
®®1 2
$"
®®3 5
$str
®®5 6
{
®®6 7
nombreJugador
®®7 D
}
®®D E
$str
®®E G
{
®®G H
mensaje
®®H O
}
®®O P
"
®®P Q
;
®®Q R
if
°° 
(
°° 
cuentaJugador
°° !
.
°°! "!
OperacionesContexto
°°" 5
.
°°5 6#
ContextoIServicioSala
°°6 K
!=
°°L N
null
°°O S
)
°°S T
{
±± 
cuentaJugador
²² !
.
²²! "!
OperacionesContexto
²²" 5
.
²²5 6#
ContextoIServicioSala
²²6 K
.
²²K L 
GetCallbackChannel
³³ *
<
³³* +$
IServicioJuegoCallback
³³+ A
>
³³A B
(
³³B C
)
³³C D
.
³³D E"
MostrarMensajeDeSala
´´ ,
(
´´, -
mensajeFinal
´´- 9
)
´´9 :
;
´´: ;
}
µµ 
}
¶¶ 
}
·· 	
private
¹¹ 
void
¹¹ 1
#NotificarNuevoJugadorConectadoASala
¹¹ 8
(
¹¹8 9
CuentaJugador
¹¹9 F
nuevoJugador
¹¹G S
,
¹¹S T
string
ºº 

codigoSala
ºº 
)
ºº 
{
»» 	
Sala
¼¼ 
salaEncontrada
¼¼ 
=
¼¼  !
salasActivas
¼¼" .
.
¼¼. /
FirstOrDefault
¼¼/ =
(
¼¼= >
sala
¼¼> B
=>
¼¼C E
sala
½½ 
.
½½ 

CodigoSala
½½ 
.
½½  
Equals
½½  &
(
½½& '

codigoSala
½½' 1
)
½½1 2
)
½½2 3
;
½½3 4
foreach
¿¿ 
(
¿¿ 
CuentaJugador
¿¿ "
jugador
¿¿# *
in
¿¿+ -
salaEncontrada
¿¿. <
.
¿¿< =
	Jugadores
¿¿= F
)
¿¿F G
{
ÀÀ 
jugador
ÁÁ 
.
ÁÁ !
OperacionesContexto
ÁÁ +
.
ÁÁ+ ,#
ContextoIServicioSala
ÁÁ, A
.
ÁÁA B 
GetCallbackChannel
ÁÁB T
<
ÁÁT U$
IServicioJuegoCallback
ÂÂ *
>
ÂÂ* +
(
ÂÂ+ ,
)
ÂÂ, -
.
ÂÂ- .2
$NotificarNuevoJugadorConectadoEnSala
ÂÂ. R
(
ÂÂR S
nuevoJugador
ÃÃ  
)
ÃÃ  !
;
ÃÃ! "
}
ÄÄ 
}
ÅÅ 	
private
ÇÇ 
void
ÇÇ 0
"NotificarJugadorDesconectadoDeSala
ÇÇ 7
(
ÇÇ7 8
string
ÇÇ8 >
nombreJugador
ÇÇ? L
,
ÇÇL M
string
ÈÈ 

codigoSala
ÈÈ 
)
ÈÈ 
{
ÉÉ 	
Sala
ÊÊ 
salaEncontrada
ÊÊ 
=
ÊÊ  !
salasActivas
ÊÊ" .
.
ÊÊ. /
FirstOrDefault
ÊÊ/ =
(
ÊÊ= >
sala
ÊÊ> B
=>
ÊÊC E
sala
ËË 
.
ËË 

CodigoSala
ËË 
.
ËË  
Equals
ËË  &
(
ËË& '

codigoSala
ËË' 1
)
ËË1 2
)
ËË2 3
;
ËË3 4
foreach
ÍÍ 
(
ÍÍ 
CuentaJugador
ÍÍ "
jugador
ÍÍ# *
in
ÍÍ+ -
salaEncontrada
ÍÍ. <
.
ÍÍ< =
	Jugadores
ÍÍ= F
)
ÍÍF G
{
ÎÎ 
jugador
ÏÏ 
.
ÏÏ !
OperacionesContexto
ÏÏ +
.
ÏÏ+ ,#
ContextoIServicioSala
ÏÏ, A
.
ÏÏA B 
GetCallbackChannel
ÏÏB T
<
ÏÏT U$
IServicioJuegoCallback
ĞĞ *
>
ĞĞ* +
(
ĞĞ+ ,
)
ĞĞ, -
.
ĞĞ- .0
"NotificarJugadorDesconectadoDeSala
ĞĞ. P
(
ĞĞP Q
nombreJugador
ÑÑ !
)
ÑÑ! "
;
ÑÑ" #
}
ÒÒ 
}
ÓÓ 	
public
ÕÕ 
string
ÕÕ (
GenerarCodigoParaNuevaSala
ÕÕ 0
(
ÕÕ0 1
)
ÕÕ1 2
{
ÖÖ 	
return
×× 
Guid
×× 
.
×× 
NewGuid
×× 
(
××  
)
××  !
.
××! "
ToString
××" *
(
××* +
)
××+ ,
;
××, -
}
ØØ 	
public
ÚÚ 
List
ÚÚ 
<
ÚÚ 
CuentaJugador
ÚÚ !
>
ÚÚ! ".
 ObtenerJugadoresConectadosEnSala
ÚÚ# C
(
ÚÚC D
string
ÚÚD J

codigoSala
ÚÚK U
)
ÚÚU V
{
ÛÛ 	
List
ÜÜ 
<
ÜÜ 
CuentaJugador
ÜÜ 
>
ÜÜ 
jugadoresEnSala
ÜÜ  /
=
ÜÜ0 1
new
ÜÜ2 5
List
ÜÜ6 :
<
ÜÜ: ;
CuentaJugador
ÜÜ; H
>
ÜÜH I
(
ÜÜI J
)
ÜÜJ K
;
ÜÜK L
Sala
İİ 
salaEncontrada
İİ 
=
İİ  !
salasActivas
İİ" .
.
İİ. /
FirstOrDefault
İİ/ =
(
İİ= >
sala
İİ> B
=>
İİC E
sala
ŞŞ 
.
ŞŞ 

CodigoSala
ŞŞ 
.
ŞŞ  
Equals
ŞŞ  &
(
ŞŞ& '

codigoSala
ŞŞ' 1
)
ŞŞ1 2
)
ŞŞ2 3
;
ŞŞ3 4
if
àà 
(
àà 
salaEncontrada
àà 
!=
àà !
null
àà" &
)
àà& '
{
áá 
jugadoresEnSala
ââ 
=
ââ  !
salaEncontrada
ââ" 0
.
ââ0 1
	Jugadores
ââ1 :
;
ââ: ;
}
ãã 
return
åå 
jugadoresEnSala
åå "
;
åå" #
}
ææ 	
}
çç 
public
ëë 

partial
ëë 
class
ëë %
ServicioRompecabezasFei
ëë 0
:
ëë1 2 
IServicioAmistades
ëë3 E
{
ìì 
private
íí 
readonly
íí 

Dictionary
íí #
<
íí# $
string
íí$ *
,
íí* +
CuentaJugador
íí, 9
>
íí9 :!
jugadoresConectados
íí; N
=
ííO P
new
îî 

Dictionary
îî 
<
îî 
string
îî !
,
îî! "
CuentaJugador
îî# 0
>
îî0 1
(
îî1 2
)
îî2 3
;
îî3 4
private
ğğ 
void
ğğ 5
'NotificarConexionJugadorAOtrosJugadores
ğğ <
(
ğğ< =
string
ğğ= C
nombreJugador
ğğD Q
,
ğğQ R'
EstadoConectividadJugador
ññ %
estado
ññ& ,
)
ññ, -
{
òò 	
foreach
óó 
(
óó 
CuentaJugador
óó "
cuenta
óó# )
in
óó* ,!
jugadoresConectados
óó- @
.
óó@ A
Values
óóA G
)
óóG H
{
ôô 
if
õõ 
(
õõ %
ExisteAmistadConJugador
õõ +
(
õõ+ ,
nombreJugador
õõ, 9
,
õõ9 :
cuenta
õõ; A
.
õõA B
NombreJugador
õõB O
)
õõO P
&&
õõQ S9
+EsJugadorSuscritoANotififacionesDeAmistades
öö ?
(
öö? @
cuenta
öö@ F
.
ööF G
NombreJugador
ööG T
)
ööT U
)
ööU V
{
÷÷ 
cuenta
øø 
.
øø !
OperacionesContexto
øø .
.
øø. /(
ContextoIServicioAmistades
øø/ I
.
øøI J 
GetCallbackChannel
ùù *
<
ùù* +(
IServicioAmistadesCallback
ùù+ E
>
ùùE F
(
ùùF G
)
ùùG H
.
ùùH I2
$NotificarEstadoConectividadDeJugador
úú <
(
úú< =
nombreJugador
úú= J
,
úúJ K
estado
úúL R
)
úúR S
;
úúS T
}
ûû 
}
üü 
}
ıı 	
public
ÿÿ 
List
ÿÿ 
<
ÿÿ 
CuentaJugador
ÿÿ !
>
ÿÿ! "$
ObtenerAmigosDeJugador
ÿÿ# 9
(
ÿÿ9 :
string
ÿÿ: @
nombreJugador
ÿÿA N
)
ÿÿN O
{
€€ 	
GestionAmistades
 
gestionAmistades
 -
=
. /
new
0 3
GestionAmistades
4 D
(
D E
)
E F
;
F G
List
‚‚ 
<
‚‚ 
CuentaJugador
‚‚ 
>
‚‚ 
cuentasJugador
‚‚  .
=
‚‚/ 0
null
‚‚1 5
;
‚‚5 6
try
„„ 
{
…… 
cuentasJugador
†† 
=
††  
gestionAmistades
††! 1
.
††1 2$
ObtenerAmigosDeJugador
††2 H
(
††H I
nombreJugador
††I V
)
††V W
;
††W X
}
‡‡ 
catch
ˆˆ 
(
ˆˆ 
EntityException
ˆˆ "
)
ˆˆ" #
{
‰‰ 
}
‹‹ 
if
 
(
 
cuentasJugador
 
!=
 !
null
" &
)
& '
{
 
cuentasJugador
 
=
  8
*AgregarEstadoConectividadACuentasDeJugador
! K
(
K L
cuentasJugador
L Z
)
Z [
;
[ \
}
 
return
’’ 
cuentasJugador
’’ !
;
’’! "
}
““ 	
private
•• 
List
•• 
<
•• 
CuentaJugador
•• "
>
••" #8
*AgregarEstadoConectividadACuentasDeJugador
••$ N
(
••N O
List
–– 
<
–– 
CuentaJugador
–– 
>
–– 
cuentasJugador
––  .
)
––. /
{
—— 	
List
˜˜ 
<
˜˜ 
CuentaJugador
˜˜ 
>
˜˜ *
cuentasConEstadoConectividad
˜˜  <
=
˜˜= >
new
˜˜? B
List
˜˜C G
<
˜˜G H
CuentaJugador
˜˜H U
>
˜˜U V
(
˜˜V W
)
˜˜W X
;
˜˜X Y
foreach
šš 
(
šš 
CuentaJugador
šš "
cuenta
šš# )
in
šš* ,
cuentasJugador
šš- ;
)
šš; <
{
›› 
if
œœ 
(
œœ !
jugadoresConectados
œœ '
.
œœ' (
ContainsKey
œœ( 3
(
œœ3 4
cuenta
œœ4 :
.
œœ: ;
NombreJugador
œœ; H
)
œœH I
)
œœI J
{
 
cuenta
 
.
  
EstadoConectividad
 -
=
. /!
jugadoresConectados
0 C
[
C D
cuenta
D J
.
J K
NombreJugador
K X
]
X Y
.
Y Z 
EstadoConectividad
ŸŸ *
;
ŸŸ* +
}
   
else
¡¡ 
{
¢¢ 
cuenta
££ 
.
££  
EstadoConectividad
££ -
=
££. /'
EstadoConectividadJugador
££0 I
.
££I J
Desconectado
££J V
;
££V W
}
¤¤ *
cuentasConEstadoConectividad
¦¦ ,
.
¦¦, -
Add
¦¦- 0
(
¦¦0 1
cuenta
¦¦1 7
)
¦¦7 8
;
¦¦8 9
}
§§ 
return
©© *
cuentasConEstadoConectividad
©© /
;
©©/ 0
}
ªª 	
public
¬¬ 
List
¬¬ 
<
¬¬ 
CuentaJugador
¬¬ !
>
¬¬! "3
%ObtenerJugadoresConSolicitudPendiente
¬¬# H
(
¬¬H I
string
¬¬I O
nombreJugador
¬¬P ]
)
¬¬] ^
{
­­ 	
GestionAmistades
®® 
gestionAmistades
®® -
=
®®. /
new
®®0 3
GestionAmistades
®®4 D
(
®®D E
)
®®E F
;
®®F G
List
¯¯ 
<
¯¯ 
CuentaJugador
¯¯ 
>
¯¯ 
cuentasJugador
¯¯  .
=
¯¯/ 0
null
¯¯1 5
;
¯¯5 6
try
±± 
{
²² 
cuentasJugador
³³ 
=
³³  
gestionAmistades
³³! 1
.
³³1 23
%ObtenerJugadoresConSolicitudPendiente
´´ 9
(
´´9 :
nombreJugador
´´: G
)
´´G H
;
´´H I
}
µµ 
catch
¶¶ 
(
¶¶ 
EntityException
¶¶ "
)
¶¶" #
{
·· 
}
¹¹ 
if
»» 
(
»» 
cuentasJugador
»» 
!=
»» !
null
»»" &
)
»»& '
{
¼¼ 
cuentasJugador
½½ 
=
½½  8
*AgregarEstadoConectividadACuentasDeJugador
½½! K
(
½½K L
cuentasJugador
½½L Z
)
½½Z [
;
½½[ \
}
¾¾ 
return
ÀÀ 
cuentasJugador
ÀÀ !
;
ÀÀ! "
}
ÁÁ 	
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
ÄÄ "
nombreJugadorDestino
ÄÄ '
)
ÄÄ' (
{
ÅÅ 	
bool
ÆÆ  
esSolicitudEnviada
ÆÆ #
=
ÆÆ$ %
false
ÆÆ& +
;
ÆÆ+ ,
GestionAmistades
ÇÇ 
gestionAmistades
ÇÇ -
=
ÇÇ. /
new
ÇÇ0 3
GestionAmistades
ÇÇ4 D
(
ÇÇD E
)
ÇÇE F
;
ÇÇF G
try
ÉÉ 
{
ÊÊ  
esSolicitudEnviada
ËË "
=
ËË# $
gestionAmistades
ËË% 5
.
ËË5 6&
EnviarSolicitudDeAmistad
ËË6 N
(
ËËN O!
nombreJugadorOrigen
ÌÌ '
,
ÌÌ' ("
nombreJugadorDestino
ÌÌ) =
)
ÌÌ= >
;
ÌÌ> ?
}
ÍÍ 
catch
ÎÎ 
(
ÎÎ 
EntityException
ÎÎ "
)
ÎÎ" #
{
ÏÏ 
}
ÑÑ 
if
ÓÓ 
(
ÓÓ  
esSolicitudEnviada
ÓÓ "
&&
ÓÓ# %9
+EsJugadorSuscritoANotififacionesDeAmistades
ÓÓ& Q
(
ÓÓQ R"
nombreJugadorDestino
ÔÔ $
)
ÔÔ$ %
)
ÔÔ% &
{
ÕÕ !
jugadoresConectados
ÖÖ #
[
ÖÖ# $"
nombreJugadorDestino
ÖÖ$ 8
]
ÖÖ8 9
.
ÖÖ9 :!
OperacionesContexto
ÖÖ: M
.
ÖÖM N(
ContextoIServicioAmistades
×× .
.
××. / 
GetCallbackChannel
××/ A
<
××A B(
IServicioAmistadesCallback
××B \
>
××\ ]
(
××] ^
)
××^ _
.
××_ `.
 NotificarSolicitudAmistadEnviada
ØØ 4
(
ØØ4 5!
jugadoresConectados
ØØ5 H
[
ØØH I!
nombreJugadorOrigen
ØØI \
]
ØØ\ ]
)
ØØ] ^
;
ØØ^ _
}
ÙÙ 
return
ÛÛ  
esSolicitudEnviada
ÛÛ %
;
ÛÛ% &
}
ÜÜ 	
public
ŞŞ 
bool
ŞŞ '
AceptarSolicitudDeAmistad
ŞŞ -
(
ŞŞ- .
string
ŞŞ. 4!
nombreJugadorOrigen
ŞŞ5 H
,
ŞŞH I
string
ßß "
nombreJugadorDestino
ßß '
)
ßß' (
{
àà 	
bool
áá !
esSolicitudAceptada
áá $
=
áá% &
false
áá' ,
;
áá, -
GestionAmistades
ââ 
gestionAmistades
ââ -
=
ââ. /
new
ââ0 3
GestionAmistades
ââ4 D
(
ââD E
)
ââE F
;
ââF G
try
ää 
{
åå !
esSolicitudAceptada
ææ #
=
ææ$ %
gestionAmistades
ææ& 6
.
ææ6 7'
AceptarSolicitudDeAmistad
ææ7 P
(
ææP Q!
nombreJugadorOrigen
çç '
,
çç' ("
nombreJugadorDestino
çç) =
)
çç= >
;
çç> ?
}
èè 
catch
éé 
(
éé 
EntityException
éé "
)
éé" #
{
êê 
}
ìì 
if
îî 
(
îî !
esSolicitudAceptada
îî #
&&
îî$ &9
+EsJugadorSuscritoANotififacionesDeAmistades
îî' R
(
îîR S!
nombreJugadorOrigen
ïï #
)
ïï# $
)
ïï$ %
{
ğğ !
jugadoresConectados
ññ #
[
ññ# $!
nombreJugadorOrigen
ññ$ 7
]
ññ7 8
.
ññ8 9!
OperacionesContexto
ññ9 L
.
ññL M(
ContextoIServicioAmistades
òò .
.
òò. / 
GetCallbackChannel
òò/ A
<
òòA B(
IServicioAmistadesCallback
òòB \
>
òò\ ]
(
òò] ^
)
òò^ _
.
òò_ `/
!NotificarSolicitudAmistadAceptada
óó 5
(
óó5 6!
jugadoresConectados
óó6 I
[
óóI J"
nombreJugadorDestino
óóJ ^
]
óó^ _
)
óó_ `
;
óó` a
}
ôô 
return
öö !
esSolicitudAceptada
öö &
;
öö& '
}
÷÷ 	
public
ùù 
bool
ùù +
EliminarAmistadEntreJugadores
ùù 1
(
ùù1 2
string
ùù2 8
nombreJugadorA
ùù9 G
,
ùùG H
string
úú 
nombreJugadorB
úú !
)
úú! "
{
ûû 	
bool
üü  
esAmistadEliminada
üü #
=
üü$ %
false
üü& +
;
üü+ ,
GestionAmistades
ıı 
gestionAmistades
ıı -
=
ıı. /
new
ıı0 3
GestionAmistades
ıı4 D
(
ııD E
)
ııE F
;
ııF G
try
ÿÿ 
{
€€  
esAmistadEliminada
 "
=
# $
gestionAmistades
% 5
.
5 6+
EliminarAmistadEntreJugadores
6 S
(
S T
nombreJugadorA
‚‚ "
,
‚‚" #
nombreJugadorB
‚‚$ 2
)
‚‚2 3
;
‚‚3 4
}
ƒƒ 
catch
„„ 
(
„„ 
EntityException
„„ "
)
„„" #
{
…… 
}
‡‡ 
if
‰‰ 
(
‰‰  
esAmistadEliminada
‰‰ "
&&
‰‰# %9
+EsJugadorSuscritoANotififacionesDeAmistades
‰‰& Q
(
‰‰Q R
nombreJugadorB
ŠŠ 
)
ŠŠ 
)
ŠŠ  
{
‹‹ !
jugadoresConectados
ŒŒ #
[
ŒŒ# $
nombreJugadorB
ŒŒ$ 2
]
ŒŒ2 3
.
ŒŒ3 4!
OperacionesContexto
ŒŒ4 G
.
ŒŒG H(
ContextoIServicioAmistades
 .
.
. / 
GetCallbackChannel
/ A
<
A B(
IServicioAmistadesCallback
B \
>
\ ]
(
] ^
)
^ _
.
_ `'
NotificarAmistadEliminada
 -
(
- .
nombreJugadorA
. <
)
< =
;
= >
}
 
return
‘‘  
esAmistadEliminada
‘‘ %
;
‘‘% &
}
’’ 	
public
”” 
bool
”” (
RechazarSolicitudDeAmistad
”” .
(
””. /
string
””/ 5!
nombreJugadorOrigen
””6 I
,
””I J
string
•• "
nombreJugadorDestino
•• '
)
••' (
{
–– 	
GestionAmistades
—— 
gestionAmistades
—— -
=
——. /
new
——0 3
GestionAmistades
——4 D
(
——D E
)
——E F
;
——F G
bool
˜˜ 
	resultado
˜˜ 
=
˜˜ 
false
˜˜ "
;
˜˜" #
try
šš 
{
›› 
	resultado
œœ 
=
œœ 
gestionAmistades
œœ ,
.
œœ, -(
EliminarSolicitudDeAmistad
œœ- G
(
œœG H!
nombreJugadorOrigen
 '
,
' ("
nombreJugadorDestino
) =
)
= >
;
> ?
}
 
catch
ŸŸ 
(
ŸŸ 
EntityException
ŸŸ "
)
ŸŸ" #
{
   
}
¢¢ 
return
¤¤ 
	resultado
¤¤ 
;
¤¤ 
}
¥¥ 	
public
§§ 
bool
§§ &
ExisteSolicitudDeAmistad
§§ ,
(
§§, -
string
§§- 3!
nombreJugadorOrigen
§§4 G
,
§§G H
string
¨¨ "
nombreJugadorDestino
¨¨ '
)
¨¨' (
{
©© 	
GestionAmistades
ªª 
gestionAmistades
ªª -
=
ªª. /
new
ªª0 3
GestionAmistades
ªª4 D
(
ªªD E
)
ªªE F
;
ªªF G
bool
«« 
	resultado
«« 
=
«« 
false
«« "
;
««" #
try
­­ 
{
®® 
	resultado
¯¯ 
=
¯¯ 
gestionAmistades
¯¯ ,
.
¯¯, -&
ExisteSolicitudDeAmistad
¯¯- E
(
¯¯E F!
nombreJugadorOrigen
°° '
,
°°' ("
nombreJugadorDestino
°°) =
)
°°= >
;
°°> ?
}
±± 
catch
²² 
(
²² 
EntityException
²² "
)
²²" #
{
³³ 
}
µµ 
return
·· 
	resultado
·· 
;
·· 
}
¸¸ 	
public
ºº 
bool
ºº %
ExisteAmistadConJugador
ºº +
(
ºº+ ,
string
ºº, 2
nombreJugadorA
ºº3 A
,
ººA B
string
ººC I
nombreJugadorB
ººJ X
)
ººX Y
{
»» 	
GestionAmistades
¼¼ 
gestionAmistades
¼¼ -
=
¼¼. /
new
¼¼0 3
GestionAmistades
¼¼4 D
(
¼¼D E
)
¼¼E F
;
¼¼F G
bool
½½ 
	resultado
½½ 
=
½½ 
false
½½ "
;
½½" #
try
¿¿ 
{
ÀÀ 
	resultado
ÁÁ 
=
ÁÁ 
gestionAmistades
ÁÁ ,
.
ÁÁ, -%
ExisteAmistadConJugador
ÁÁ- D
(
ÁÁD E
nombreJugadorA
ÂÂ "
,
ÂÂ" #
nombreJugadorB
ÂÂ$ 2
)
ÂÂ2 3
;
ÂÂ3 4
}
ÃÃ 
catch
ÄÄ 
(
ÄÄ 
EntityException
ÄÄ "
)
ÄÄ" #
{
ÅÅ 
}
ÇÇ 
return
ÉÉ 
	resultado
ÉÉ 
;
ÉÉ 
}
ÊÊ 	
public
ÌÌ 
bool
ÌÌ 6
(SuscribirJugadorANotificacionesAmistades
ÌÌ <
(
ÌÌ< =
string
ÌÌ= C
nombreJugador
ÌÌD Q
)
ÌÌQ R
{
ÍÍ 	
bool
ÎÎ 
	resultado
ÎÎ 
=
ÎÎ 
false
ÎÎ "
;
ÎÎ" #
if
ĞĞ 
(
ĞĞ 
!
ĞĞ 9
+EsJugadorSuscritoANotififacionesDeAmistades
ĞĞ <
(
ĞĞ< =
nombreJugador
ĞĞ= J
)
ĞĞJ K
)
ĞĞK L
{
ÑÑ !
jugadoresConectados
ÒÒ #
[
ÒÒ# $
nombreJugador
ÒÒ$ 1
]
ÒÒ1 2
.
ÒÒ2 3!
OperacionesContexto
ÒÒ3 F
.
ÒÒF G(
ContextoIServicioAmistades
ÓÓ .
=
ÓÓ/ 0
OperationContext
ÓÓ1 A
.
ÓÓA B
Current
ÓÓB I
;
ÓÓI J
	resultado
ÔÔ 
=
ÔÔ 
true
ÔÔ  
;
ÔÔ  !
}
ÕÕ 
return
×× 
	resultado
×× 
;
×× 
}
ØØ 	
public
ÚÚ 
bool
ÚÚ 9
+DesuscribirJugadorDeNotificacionesAmistades
ÚÚ ?
(
ÚÚ? @
string
ÚÚ@ F
nombreJugador
ÚÚG T
)
ÚÚT U
{
ÛÛ 	
bool
ÜÜ 
	resultado
ÜÜ 
=
ÜÜ 
false
ÜÜ "
;
ÜÜ" #
if
ŞŞ 
(
ŞŞ 9
+EsJugadorSuscritoANotififacionesDeAmistades
ŞŞ ;
(
ŞŞ; <
nombreJugador
ŞŞ< I
)
ŞŞI J
)
ŞŞJ K
{
ßß !
jugadoresConectados
àà #
[
àà# $
nombreJugador
àà$ 1
]
àà1 2
.
àà2 3!
OperacionesContexto
àà3 F
.
ààF G(
ContextoIServicioAmistades
áá .
=
áá/ 0
null
áá1 5
;
áá5 6
	resultado
ââ 
=
ââ 
true
ââ  
;
ââ  !
}
ãã 
return
åå 
	resultado
åå 
;
åå 
}
ææ 	
public
èè 
bool
èè 9
+EsJugadorSuscritoANotififacionesDeAmistades
èè ?
(
èè? @
string
èè@ F
nombreJugador
èèG T
)
èèT U
{
éé 	
bool
êê 
	resultado
êê 
=
êê 
false
êê "
;
êê" #
if
ìì 
(
ìì !
jugadoresConectados
ìì #
.
ìì# $
ContainsKey
ìì$ /
(
ìì/ 0
nombreJugador
ìì0 =
)
ìì= >
&&
ìì? A!
jugadoresConectados
íí #
[
íí# $
nombreJugador
íí$ 1
]
íí1 2
.
íí2 3!
OperacionesContexto
íí3 F
.
ííF G(
ContextoIServicioAmistades
îî *
!=
îî+ -
null
îî. 2
)
îî2 3
{
ïï 
	resultado
ğğ 
=
ğğ 
true
ğğ  
;
ğğ  !
}
ññ 
return
óó 
	resultado
óó 
;
óó 
}
ôô 	
}
õõ 
public
ùù 

partial
ùù 
class
ùù %
ServicioRompecabezasFei
ùù 0
:
ùù1 2
IServicioPartida
ùù3 C
{
úú 
public
ûû 
bool
ûû 
CrearNuevaPartida
ûû %
(
ûû% &
string
ûû& ,

codigoSala
ûû- 7
)
ûû7 8
{
üü 	
GestionPartida
ıı 
gestionPartida
ıı )
=
ıı* +
new
ıı, /
GestionPartida
ıı0 >
(
ıı> ?
)
ıı? @
;
ıı@ A
bool
şş 
	resultado
şş 
=
şş 
false
şş "
;
şş" #
try
€€ 
{
 
	resultado
‚‚ 
=
‚‚ 
gestionPartida
‚‚ *
.
‚‚* +
CrearNuevaPartida
‚‚+ <
(
‚‚< =

codigoSala
‚‚= G
)
‚‚G H
;
‚‚H I
}
ƒƒ 
catch
„„ 
(
„„ 
EntityException
„„ "
)
„„" #
{
…… 
}
‡‡ 
return
‰‰ 
	resultado
‰‰ 
;
‰‰ 
}
ŠŠ 	
public
ŒŒ 
bool
ŒŒ 
FinalizarPartida
ŒŒ $
(
ŒŒ$ %
string
ŒŒ% +

codigoSala
ŒŒ, 6
,
ŒŒ6 7
CuentaJugador
 
cuentaJugador
 '
,
' (
bool
) -
	esGanador
. 7
)
7 8
{
 	
GestionPartida
 
gestionPartida
 )
=
* +
new
, /
GestionPartida
0 >
(
> ?
)
? @
;
@ A
bool
 
	resultado
 
=
 
false
 "
;
" #
try
’’ 
{
““ 
	resultado
”” 
=
”” 
gestionPartida
”” *
.
””* +
FinalizarPartida
””+ ;
(
””; <

codigoSala
•• 
,
•• 
cuentaJugador
••  -
,
••- .
	esGanador
••/ 8
)
••8 9
;
••9 :
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
˜˜ 
}
šš 
return
œœ 
	resultado
œœ 
;
œœ 
}
 	
public
ŸŸ 
bool
ŸŸ $
ExpulsarJugadorPartida
ŸŸ *
(
ŸŸ* +
string
ŸŸ+ 1

codigoSala
ŸŸ2 <
,
ŸŸ< =
string
ŸŸ> D
nombreJugador
ŸŸE R
)
ŸŸR S
{
   	
throw
¡¡ 
new
¡¡ %
NotImplementedException
¡¡ -
(
¡¡- .
)
¡¡. /
;
¡¡/ 0
}
¢¢ 	
public
¤¤ 
bool
¤¤ 
GenerarTablero
¤¤ "
(
¤¤" #
string
¤¤# )

codigoSala
¤¤* 4
)
¤¤4 5
{
¥¥ 	
throw
¦¦ 
new
¦¦ %
NotImplementedException
¦¦ -
(
¦¦- .
)
¦¦. /
;
¦¦/ 0
}
§§ 	
public
©© 
bool
©© 
IniciarPartida
©© "
(
©©" #
string
©©# )

codigoSala
©©* 4
)
©©4 5
{
ªª 	
throw
«« 
new
«« %
NotImplementedException
«« -
(
««- .
)
««. /
;
««/ 0
}
¬¬ 	
public
®® 
void
®® !
MoverPiezaPosicionX
®® '
(
®®' (
double
®®( .
	posicionX
®®/ 8
)
®®8 9
{
¯¯ 	
throw
°° 
new
°° %
NotImplementedException
°° -
(
°°- .
)
°°. /
;
°°/ 0
}
±± 	
public
³³ 
void
³³ !
MoverPiezaPosicionY
³³ '
(
³³' (
bool
³³( ,
	posicionY
³³- 6
)
³³6 7
{
´´ 	
throw
µµ 
new
µµ %
NotImplementedException
µµ -
(
µµ- .
)
µµ. /
;
µµ/ 0
}
¶¶ 	
public
¸¸ 
bool
¸¸ '
NotificarJugadorPreparado
¸¸ -
(
¸¸- .
string
¸¸. 4

codigoSala
¸¸5 ?
,
¸¸? @
string
¹¹ 
nombreJugador
¹¹  
)
¹¹  !
{
ºº 	
throw
»» 
new
»» %
NotImplementedException
»» -
(
»»- .
)
»». /
;
»»/ 0
}
¼¼ 	
public
¾¾ 
int
¾¾ *
ObtenerNumeroPartidasJugadas
¾¾ /
(
¾¾/ 0
string
¾¾0 6
nombreJugador
¾¾7 D
)
¾¾D E
{
¿¿ 	
ConsultasJugador
ÀÀ 
consultasJugador
ÀÀ -
=
ÀÀ. /
new
ÀÀ0 3
ConsultasJugador
ÀÀ4 D
(
ÀÀD E
)
ÀÀE F
;
ÀÀF G
int
ÁÁ #
numeroPartidasJugadas
ÁÁ %
=
ÁÁ& '
$num
ÁÁ( )
;
ÁÁ) *
try
ÃÃ 
{
ÄÄ #
numeroPartidasJugadas
ÅÅ %
=
ÅÅ& '
consultasJugador
ÅÅ( 8
.
ÅÅ8 93
%ObtenerNumeroPartidasJugadasDeJugador
ÆÆ 9
(
ÆÆ9 :
nombreJugador
ÆÆ: G
)
ÆÆG H
;
ÆÆH I
}
ÇÇ 
catch
ÈÈ 
(
ÈÈ 
EntityException
ÈÈ "
)
ÈÈ" #
{
ÉÉ 
}
ËË 
return
ÍÍ #
numeroPartidasJugadas
ÍÍ (
;
ÍÍ( )
}
ÎÎ 	
public
ĞĞ 
int
ĞĞ *
ObtenerNumeroPartidasGanadas
ĞĞ /
(
ĞĞ/ 0
string
ĞĞ0 6
nombreJugador
ĞĞ7 D
)
ĞĞD E
{
ÑÑ 	
ConsultasJugador
ÒÒ 
consultasJugador
ÒÒ -
=
ÒÒ. /
new
ÒÒ0 3
ConsultasJugador
ÒÒ4 D
(
ÒÒD E
)
ÒÒE F
;
ÒÒF G
int
ÓÓ #
numeroPartidasGanadas
ÓÓ %
=
ÓÓ& '
$num
ÓÓ( )
;
ÓÓ) *
try
ÕÕ 
{
ÖÖ #
numeroPartidasGanadas
×× %
=
××& '
consultasJugador
××( 8
.
××8 9*
ObtenerNumeroPartidasGanadas
ØØ 0
(
ØØ0 1
nombreJugador
ØØ1 >
)
ØØ> ?
;
ØØ? @
}
ÙÙ 
catch
ÚÚ 
(
ÚÚ 
EntityException
ÚÚ "
)
ÚÚ" #
{
ÛÛ 
}
İİ 
return
ßß #
numeroPartidasGanadas
ßß (
;
ßß( )
}
àà 	
}
áá 
}ãã 