�
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaAjustesPartida.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class  
PaginaAjustesPartida -
:. /
Page0 4
{ 
public  
PaginaAjustesPartida #
(# $
)$ %
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
} 
} ��
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioAmistades.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

class 
ServicioAmistades "
{		 
public

 
static

 
CuentaJugador

 #
[

# $
]

$ %"
ObtenerAmigosDeJugador

& <
(

< =
string

= C
nombreJugador

D Q
)

Q R
{ 	#
ServicioAmistadesClient #
cliente$ +
=, -
new. 1#
ServicioAmistadesClient2 I
(I J
new 
InstanceContext #
(# $
new$ '
PaginaAmistades( 7
(7 8
false8 =
)= >
)> ?
)? @
;@ A
CuentaJugador 
[ 
] 
amigosObtenidos +
=, -
null. 2
;2 3
try 
{ 
amigosObtenidos 
=  !
cliente" )
.) *"
ObtenerAmigosDeJugador* @
(@ A
nombreJugadorA N
)N O
;O P
cliente 
. 
Close 
( 
) 
;  
} 
catch 
( %
EndpointNotFoundException ,
	excepcion- 6
)6 7
{ 

MessageBox 
. 
Show 
(  

Properties  *
.* +
	Resources+ 4
.4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE :
,: ;

Properties< F
.F G
	ResourcesG P
.P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO 9
,9 :
MessageBoxButton $
.$ %
OK% '
,' (
MessageBoxImage) 8
.8 9
Error9 >
)> ?
;? @
cliente 
. 
Abort 
( 
) 
;  
} 
catch 
( /
#CommunicationObjectFaultedException 6
	excepcion7 @
)@ A
{ 

MessageBox!! 
.!! 
Show!! 
(!!  

Properties!!  *
.!!* +
	Resources!!+ 4
.!!4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE"" :
,"": ;

Properties""< F
.""F G
	Resources""G P
.""P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO## 9
,##9 :
MessageBoxButton$$ $
.$$$ %
OK$$% '
,$$' (
MessageBoxImage$$) 8
.$$8 9
Error$$9 >
)$$> ?
;$$? @
cliente%% 
.%% 
Abort%% 
(%% 
)%% 
;%%  
}&& 
catch'' 
('' 
TimeoutException'' #
	excepcion''$ -
)''- .
{(( 

MessageBox** 
.** 
Show** 
(**  

Properties**  *
.*** +
	Resources**+ 4
.**4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE++ :
,++: ;

Properties++< F
.++F G
	Resources++G P
.++P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,, 9
,,,9 :
MessageBoxButton-- $
.--$ %
OK--% '
,--' (
MessageBoxImage--) 8
.--8 9
Error--9 >
)--> ?
;--? @
cliente.. 
... 
Abort.. 
(.. 
).. 
;..  
}// 
return11 
amigosObtenidos11 "
;11" #
}22 	
public44 
static44 
CuentaJugador44 #
[44# $
]44$ %1
%ObtenerJugadoresConSolicitudPendiente44& K
(44K L
string44L R
nombreJugador44S `
)44` a
{55 	#
ServicioAmistadesClient66 #
cliente66$ +
=66, -
new66. 1#
ServicioAmistadesClient662 I
(66I J
new77 
InstanceContext77 #
(77# $
new77$ '
PaginaAmistades77( 7
(777 8
false778 =
)77= >
)77> ?
)77? @
;77@ A
CuentaJugador88 
[88 
]88 
amigosObtenidos88 +
=88, -
null88. 2
;882 3
try:: 
{;; 
amigosObtenidos<< 
=<<  !
cliente<<" )
.<<) *1
%ObtenerJugadoresConSolicitudPendiente<<* O
(<<O P
nombreJugador== !
)==! "
;==" #
cliente>> 
.>> 
Close>> 
(>> 
)>> 
;>>  
}?? 
catch@@ 
(@@ %
EndpointNotFoundException@@ ,
	excepcion@@- 6
)@@6 7
{AA 

MessageBoxCC 
.CC 
ShowCC 
(CC  

PropertiesCC  *
.CC* +
	ResourcesCC+ 4
.CC4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEDD :
,DD: ;

PropertiesDD< F
.DDF G
	ResourcesDDG P
.DDP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOEE 9
,EE9 :
MessageBoxButtonFF $
.FF$ %
OKFF% '
,FF' (
MessageBoxImageFF) 8
.FF8 9
ErrorFF9 >
)FF> ?
;FF? @
clienteGG 
.GG 
AbortGG 
(GG 
)GG 
;GG  
}HH 
catchII 
(II /
#CommunicationObjectFaultedExceptionII 6
	excepcionII7 @
)II@ A
{JJ 

MessageBoxLL 
.LL 
ShowLL 
(LL  

PropertiesLL  *
.LL* +
	ResourcesLL+ 4
.LL4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEMM :
,MM: ;

PropertiesMM< F
.MMF G
	ResourcesMMG P
.MMP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULONN 9
,NN9 :
MessageBoxButtonOO $
.OO$ %
OKOO% '
,OO' (
MessageBoxImageOO) 8
.OO8 9
ErrorOO9 >
)OO> ?
;OO? @
clientePP 
.PP 
AbortPP 
(PP 
)PP 
;PP  
}QQ 
catchRR 
(RR 
TimeoutExceptionRR #
	excepcionRR$ -
)RR- .
{SS 

MessageBoxUU 
.UU 
ShowUU 
(UU  

PropertiesUU  *
.UU* +
	ResourcesUU+ 4
.UU4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEVV :
,VV: ;

PropertiesVV< F
.VVF G
	ResourcesVVG P
.VVP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOWW 9
,WW9 :
MessageBoxButtonXX $
.XX$ %
OKXX% '
,XX' (
MessageBoxImageXX) 8
.XX8 9
ErrorXX9 >
)XX> ?
;XX? @
clienteYY 
.YY 
AbortYY 
(YY 
)YY 
;YY  
}ZZ 
return\\ 
amigosObtenidos\\ "
;\\" #
}]] 	
public__ 
static__ 
bool__ "
ExisteSolicitudAmistad__ 1
(__1 2
string__2 8
nombreJugadorOrigen__9 L
,__L M
string``  
nombreJugadorDestino`` '
)``' (
{aa 	#
ServicioAmistadesClientbb #
clientebb$ +
=bb, -
newbb. 1#
ServicioAmistadesClientbb2 I
(bbI J
newcc 
InstanceContextcc #
(cc# $
newcc$ '
PaginaAmistadescc( 7
(cc7 8
falsecc8 =
)cc= >
)cc> ?
)cc? @
;cc@ A
booldd "
existeSolicitudAmistaddd '
=dd( )
falsedd* /
;dd/ 0
tryff 
{gg "
existeSolicitudAmistadhh &
=hh' (
clientehh) 0
.hh0 1$
ExisteSolicitudDeAmistadhh1 I
(hhI J
nombreJugadorOrigenii '
,ii' ( 
nombreJugadorDestinoii) =
)ii= >
;ii> ?
clientejj 
.jj 
Closejj 
(jj 
)jj 
;jj  
}kk 
catchll 
(ll %
EndpointNotFoundExceptionll ,
	excepcionll- 6
)ll6 7
{mm 

MessageBoxoo 
.oo 
Showoo 
(oo  

Propertiesoo  *
.oo* +
	Resourcesoo+ 4
.oo4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEpp :
,pp: ;

Propertiespp< F
.ppF G
	ResourcesppG P
.ppP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOqq 9
,qq9 :
MessageBoxButtonrr $
.rr$ %
OKrr% '
,rr' (
MessageBoxImagerr) 8
.rr8 9
Errorrr9 >
)rr> ?
;rr? @
clientess 
.ss 
Abortss 
(ss 
)ss 
;ss  
}tt 
catchuu 
(uu /
#CommunicationObjectFaultedExceptionuu 6
	excepcionuu7 @
)uu@ A
{vv 

MessageBoxxx 
.xx 
Showxx 
(xx  

Propertiesxx  *
.xx* +
	Resourcesxx+ 4
.xx4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEyy :
,yy: ;

Propertiesyy< F
.yyF G
	ResourcesyyG P
.yyP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOzz 9
,zz9 :
MessageBoxButton{{ $
.{{$ %
OK{{% '
,{{' (
MessageBoxImage{{) 8
.{{8 9
Error{{9 >
){{> ?
;{{? @
cliente|| 
.|| 
Abort|| 
(|| 
)|| 
;||  
}}} 
catch~~ 
(~~ 
TimeoutException~~ #
	excepcion~~$ -
)~~- .
{ 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
return
�� $
existeSolicitudAmistad
�� )
;
��) *
}
�� 	
public
�� 
static
�� 
bool
�� %
ExisteAmistadConJugador
�� 2
(
��2 3
string
��3 9
nombreJugadorA
��: H
,
��H I
string
��J P
nombreJugadorB
��Q _
)
��_ `
{
�� 	%
ServicioAmistadesClient
�� #
cliente
��$ +
=
��, -
new
��. 1%
ServicioAmistadesClient
��2 I
(
��I J
new
�� 
InstanceContext
�� #
(
��# $
new
��$ '
PaginaAmistades
��( 7
(
��7 8
false
��8 =
)
��= >
)
��> ?
)
��? @
;
��@ A
bool
�� $
existeSolicitudAmistad
�� '
=
��( )
false
��* /
;
��/ 0
try
�� 
{
�� $
existeSolicitudAmistad
�� &
=
��' (
cliente
��) 0
.
��0 1&
ExisteSolicitudDeAmistad
��1 I
(
��I J
nombreJugadorA
�� "
,
��" #
nombreJugadorB
��$ 2
)
��2 3
;
��3 4
cliente
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
return
�� $
existeSolicitudAmistad
�� )
;
��) *
}
�� 	
public
�� 
static
�� 
bool
�� (
RechazarSolicitudDeAmistad
�� 5
(
��5 6
string
��6 <!
nombreJugadorOrigen
��= P
,
��P Q
string
�� "
nombreJugadorDestino
�� '
)
��' (
{
�� 	%
ServicioAmistadesClient
�� #
cliente
��$ +
=
��, -
new
��. 1%
ServicioAmistadesClient
��2 I
(
��I J
new
�� 
InstanceContext
�� #
(
��# $
new
��$ '
PaginaAmistades
��( 7
(
��7 8
false
��8 =
)
��= >
)
��> ?
)
��? @
;
��@ A
bool
��  
solicitudRechazada
�� #
=
��$ %
false
��& +
;
��+ ,
try
�� 
{
��  
solicitudRechazada
�� "
=
��# $
cliente
��% ,
.
��, -(
RechazarSolicitudDeAmistad
��- G
(
��G H!
nombreJugadorOrigen
�� '
,
��' ("
nombreJugadorDestino
��) =
)
��= >
;
��> ?
cliente
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
return
��  
solicitudRechazada
�� %
;
��% &
}
�� 	
}
�� 
}�� �5
C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioCorreo.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

class 
ServicioCorreo 
{		 
public

 
static

 
bool

 +
EnviarMensajeACorreoElectronico

 :
(

: ;
string

; A

encabezado

B L
,

L M
string 
correoDestino  
,  !
string" (
asunto) /
,/ 0
string1 7
mensaje8 ?
)? @
{ 	 
ServicioCorreoClient  
cliente! (
=) *
new+ . 
ServicioCorreoClient/ C
(C D
)D E
;E F
bool 
	resultado 
= 
false "
;" #
try 
{ 
cliente 
. 
EnviarMensajeCorreo +
(+ ,

encabezado, 6
,6 7
correoDestino8 E
,E F
asuntoG M
,M N
mensajeO V
)V W
;W X
cliente 
. 
Close 
( 
) 
;  
} 
catch 
( %
EndpointNotFoundException ,
	excepcion- 6
)6 7
{ 

MessageBox 
. 
Show 
(  

Properties  *
.* +
	Resources+ 4
.4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE :
,: ;

Properties< F
.F G
	ResourcesG P
.P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO 9
,9 :
MessageBoxButton $
.$ %
OK% '
,' (
MessageBoxImage) 8
.8 9
Error9 >
)> ?
;? @
cliente 
. 
Abort 
( 
) 
;  
} 
catch 
( /
#CommunicationObjectFaultedException 6
	excepcion7 @
)@ A
{ 

MessageBox!! 
.!! 
Show!! 
(!!  

Properties!!  *
.!!* +
	Resources!!+ 4
.!!4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE"" :
,"": ;

Properties""< F
.""F G
	Resources""G P
.""P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO## 9
,##9 :
MessageBoxButton$$ $
.$$$ %
OK$$% '
,$$' (
MessageBoxImage$$) 8
.$$8 9
Error$$9 >
)$$> ?
;$$? @
cliente%% 
.%% 
Abort%% 
(%% 
)%% 
;%%  
}&& 
catch'' 
('' 
TimeoutException'' #
	excepcion''$ -
)''- .
{(( 

MessageBox** 
.** 
Show** 
(**  

Properties**  *
.*** +
	Resources**+ 4
.**4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE++ :
,++: ;

Properties++< F
.++F G
	Resources++G P
.++P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,, 9
,,,9 :
MessageBoxButton-- $
.--$ %
OK--% '
,--' (
MessageBoxImage--) 8
.--8 9
Error--9 >
)--> ?
;--? @
cliente.. 
... 
Abort.. 
(.. 
).. 
;..  
}// 
return11 
	resultado11 
;11 
}22 	
public44 
static44 
bool44 #
ExisteCorreoElectronico44 2
(442 3
string443 9
correoElectronico44: K
)44K L
{55 	 
ServicioCorreoClient66  
cliente66! (
=66) *
new66+ . 
ServicioCorreoClient66/ C
(66C D
)66D E
;66E F
bool77 
	resultado77 
=77 
false77 "
;77" #
try99 
{:: 
	resultado;; 
=;; 
cliente;; #
.;;# $#
ExisteCorreoElectronico;;$ ;
(;;; <
correoElectronico;;< M
);;M N
;;;N O
cliente<< 
.<< 
Close<< 
(<< 
)<< 
;<<  
}== 
catch>> 
(>> %
EndpointNotFoundException>> ,
	excepcion>>- 6
)>>6 7
{?? 

MessageBoxAA 
.AA 
ShowAA 
(AA  

PropertiesAA  *
.AA* +
	ResourcesAA+ 4
.AA4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEBB :
,BB: ;

PropertiesBB< F
.BBF G
	ResourcesBBG P
.BBP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOCC 9
,CC9 :
MessageBoxButtonDD $
.DD$ %
OKDD% '
,DD' (
MessageBoxImageDD) 8
.DD8 9
ErrorDD9 >
)DD> ?
;DD? @
clienteEE 
.EE 
AbortEE 
(EE 
)EE 
;EE  
}FF 
catchGG 
(GG /
#CommunicationObjectFaultedExceptionGG 6
	excepcionGG7 @
)GG@ A
{HH 

MessageBoxJJ 
.JJ 
ShowJJ 
(JJ  

PropertiesJJ  *
.JJ* +
	ResourcesJJ+ 4
.JJ4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEKK :
,KK: ;

PropertiesKK< F
.KKF G
	ResourcesKKG P
.KKP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOLL 9
,LL9 :
MessageBoxButtonMM $
.MM$ %
OKMM% '
,MM' (
MessageBoxImageMM) 8
.MM8 9
ErrorMM9 >
)MM> ?
;MM? @
clienteNN 
.NN 
AbortNN 
(NN 
)NN 
;NN  
}OO 
catchPP 
(PP 
TimeoutExceptionPP #
	excepcionPP$ -
)PP- .
{QQ 

MessageBoxSS 
.SS 
ShowSS 
(SS  

PropertiesSS  *
.SS* +
	ResourcesSS+ 4
.SS4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJETT :
,TT: ;

PropertiesTT< F
.TTF G
	ResourcesTTG P
.TTP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOUU 9
,UU9 :
MessageBoxButtonVV $
.VV$ %
OKVV% '
,VV' (
MessageBoxImageVV) 8
.VV8 9
ErrorVV9 >
)VV> ?
;VV? @
clienteWW 
.WW 
AbortWW 
(WW 
)WW 
;WW  
}XX 
returnZZ 
	resultadoZZ 
;ZZ 
}[[ 	
}\\ 
}]] ׮
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioJugador.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

class 
ServicioJugador  
{		 
public

 
static

 
bool

 
RegistrarJugador

 +
(

+ ,
CuentaJugador

, 9
cuentaJugador

: G
)

G H
{ 	!
ServicioJugadorClient !
cliente" )
=* +
new, /!
ServicioJugadorClient0 E
(E F
)F G
;G H
bool 
	resultado 
= 
false "
;" #
try 
{ 
	resultado 
= 
cliente #
.# $
	Registrar$ -
(- .
cuentaJugador. ;
); <
;< =
cliente 
. 
Close 
( 
) 
;  
} 
catch 
( %
EndpointNotFoundException ,
	excepcion- 6
)6 7
{ 

MessageBox 
. 
Show 
(  

Properties  *
.* +
	Resources+ 4
.4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE :
,: ;

Properties< F
.F G
	ResourcesG P
.P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO 9
,9 :
MessageBoxButton $
.$ %
OK% '
,' (
MessageBoxImage) 8
.8 9
Error9 >
)> ?
;? @
cliente 
. 
Abort 
( 
) 
;  
} 
catch 
( /
#CommunicationObjectFaultedException 6
	excepcion7 @
)@ A
{ 

MessageBox   
.   
Show   
(    

Properties    *
.  * +
	Resources  + 4
.  4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE!! :
,!!: ;

Properties!!< F
.!!F G
	Resources!!G P
.!!P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO"" 9
,""9 :
MessageBoxButton## $
.##$ %
OK##% '
,##' (
MessageBoxImage##) 8
.##8 9
Error##9 >
)##> ?
;##? @
cliente$$ 
.$$ 
Abort$$ 
($$ 
)$$ 
;$$  
}%% 
catch&& 
(&& 
TimeoutException&& #
	excepcion&&$ -
)&&- .
{'' 

MessageBox)) 
.)) 
Show)) 
())  

Properties))  *
.))* +
	Resources))+ 4
.))4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE** :
,**: ;

Properties**< F
.**F G
	Resources**G P
.**P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO++ 9
,++9 :
MessageBoxButton,, $
.,,$ %
OK,,% '
,,,' (
MessageBoxImage,,) 8
.,,8 9
Error,,9 >
),,> ?
;,,? @
cliente-- 
.-- 
Abort-- 
(-- 
)-- 
;--  
}.. 
return00 
	resultado00 
;00 
}11 	
public33 
static33 
CuentaJugador33 #
IniciarSesion33$ 1
(331 2
string332 8
nombreJugador339 F
,33F G
string33H N

contrasena33O Y
)33Y Z
{44 	!
ServicioJugadorClient55 !
cliente55" )
=55* +
new55, /!
ServicioJugadorClient550 E
(55E F
)55F G
;55G H
CuentaJugador66 $
cuentaJugadorAutenticada66 2
=663 4
null665 9
;669 :
try88 
{99 $
cuentaJugadorAutenticada:: (
=::) *
cliente::+ 2
.::2 3
IniciarSesion::3 @
(::@ A
nombreJugador::A N
,::N O

contrasena::P Z
)::Z [
;::[ \
cliente;; 
.;; 
Close;; 
(;; 
);; 
;;;  
}<< 
catch== 
(== %
EndpointNotFoundException== ,
	excepcion==- 6
)==6 7
{>> 

MessageBox@@ 
.@@ 
Show@@ 
(@@  

Properties@@  *
.@@* +
	Resources@@+ 4
.@@4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEAA :
,AA: ;

PropertiesAA< F
.AAF G
	ResourcesAAG P
.AAP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOBB 9
,BB9 :
MessageBoxButtonCC $
.CC$ %
OKCC% '
,CC' (
MessageBoxImageCC) 8
.CC8 9
ErrorCC9 >
)CC> ?
;CC? @
clienteDD 
.DD 
AbortDD 
(DD 
)DD 
;DD  
}EE 
catchFF 
(FF /
#CommunicationObjectFaultedExceptionFF 6
	excepcionFF7 @
)FF@ A
{GG 

MessageBoxII 
.II 
ShowII 
(II  

PropertiesII  *
.II* +
	ResourcesII+ 4
.II4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEJJ :
,JJ: ;

PropertiesJJ< F
.JJF G
	ResourcesJJG P
.JJP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOKK 9
,KK9 :
MessageBoxButtonLL $
.LL$ %
OKLL% '
,LL' (
MessageBoxImageLL) 8
.LL8 9
ErrorLL9 >
)LL> ?
;LL? @
clienteMM 
.MM 
AbortMM 
(MM 
)MM 
;MM  
}NN 
catchOO 
(OO /
#CommunicationObjectAbortedExceptionOO 6
	excepcionOO7 @
)OO@ A
{PP 

MessageBoxRR 
.RR 
ShowRR 
(RR  

PropertiesRR  *
.RR* +
	ResourcesRR+ 4
.RR4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJESS :
,SS: ;

PropertiesSS< F
.SSF G
	ResourcesSSG P
.SSP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOTT 9
,TT9 :
MessageBoxButtonUU $
.UU$ %
OKUU% '
,UU' (
MessageBoxImageUU) 8
.UU8 9
ErrorUU9 >
)UU> ?
;UU? @
clienteVV 
.VV 
AbortVV 
(VV 
)VV 
;VV  
}WW 
catchXX 
(XX "
CommunicationExceptionXX )
	excepcionXX* 3
)XX3 4
{YY 

MessageBox[[ 
.[[ 
Show[[ 
([[  

Properties[[  *
.[[* +
	Resources[[+ 4
.[[4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE\\ :
,\\: ;

Properties\\< F
.\\F G
	Resources\\G P
.\\P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO]] 9
,]]9 :
MessageBoxButton^^ $
.^^$ %
OK^^% '
,^^' (
MessageBoxImage^^) 8
.^^8 9
Error^^9 >
)^^> ?
;^^? @
cliente__ 
.__ 
Abort__ 
(__ 
)__ 
;__  
}`` 
catchaa 
(aa 
TimeoutExceptionaa #
	excepcionaa$ -
)aa- .
{bb 

MessageBoxdd 
.dd 
Showdd 
(dd  

Propertiesdd  *
.dd* +
	Resourcesdd+ 4
.dd4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEee :
,ee: ;

Propertiesee< F
.eeF G
	ResourceseeG P
.eeP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOff 9
,ff9 :
MessageBoxButtongg $
.gg$ %
OKgg% '
,gg' (
MessageBoxImagegg) 8
.gg8 9
Errorgg9 >
)gg> ?
;gg? @
clientehh 
.hh 
Aborthh 
(hh 
)hh 
;hh  
}ii 
returnkk $
cuentaJugadorAutenticadakk +
;kk+ ,
}ll 	
publicnn 
staticnn 
boolnn 
CerrarSesionnn '
(nn' (
stringnn( .
nombreJugadornn/ <
)nn< =
{oo 	!
ServicioJugadorClientpp !
clientepp" )
=pp* +
newpp, /!
ServicioJugadorClientpp0 E
(ppE F
)ppF G
;ppG H
boolqq 
	resultadoqq 
=qq 
falseqq "
;qq" #
tryss 
{tt 
	resultadouu 
=uu 
clienteuu #
.uu# $
CerrarSesionuu$ 0
(uu0 1
nombreJugadoruu1 >
)uu> ?
;uu? @
clientevv 
.vv 
Closevv 
(vv 
)vv 
;vv  
}ww 
catchxx 
(xx %
EndpointNotFoundExceptionxx ,
	excepcionxx- 6
)xx6 7
{yy 

MessageBox{{ 
.{{ 
Show{{ 
({{  

Properties{{  *
.{{* +
	Resources{{+ 4
.{{4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE|| :
,||: ;

Properties||< F
.||F G
	Resources||G P
.||P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO}} 9
,}}9 :
MessageBoxButton~~ $
.~~$ %
OK~~% '
,~~' (
MessageBoxImage~~) 8
.~~8 9
Error~~9 >
)~~> ?
;~~? @
cliente 
. 
Abort 
( 
) 
;  
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
static
�� 
bool
�� "
ActualizarContrasena
�� /
(
��/ 0
string
��0 6
correo
��7 =
,
��= >
string
��? E
nuevaContrasena
��F U
)
��U V
{
�� 	#
ServicioJugadorClient
�� !
cliente
��" )
=
��* +
new
��, /#
ServicioJugadorClient
��0 E
(
��E F
)
��F G
;
��G H
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� 
cliente
�� #
.
��# $"
ActualizarContrasena
��$ 8
(
��8 9
correo
��9 ?
,
��? @
nuevaContrasena
��A P
)
��P Q
;
��Q R
cliente
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
static
�� 
bool
�� #
ActualizarInformacion
�� 0
(
��0 1
string
��1 7
nombreAnterior
��8 F
,
��F G
string
��H N
nuevoNombre
��O Z
,
��Z [
int
�� 
nuevoNumeroAvatar
�� !
)
��! "
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" ##
ServicioJugadorClient
�� !
cliente
��" )
=
��* +
new
��, /#
ServicioJugadorClient
��0 E
(
��E F
)
��F G
;
��G H
try
�� 
{
�� 
	resultado
�� 
=
�� 
cliente
�� #
.
��# $#
ActualizarInformacion
��$ 9
(
��9 :
nombreAnterior
��: H
,
��H I
nuevoNombre
�� 
,
��  
nuevoNumeroAvatar
��! 2
)
��2 3
;
��3 4
cliente
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
static
�� 
bool
�� !
ExisteNombreJugador
�� .
(
��. /
string
��/ 5
nombreJugador
��6 C
)
��C D
{
�� 	#
ServicioJugadorClient
�� !
cliente
��" )
=
��* +
new
��, /#
ServicioJugadorClient
��0 E
(
��E F
)
��F G
;
��G H
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� 
cliente
�� #
.
��# $!
ExisteNombreJugador
��$ 7
(
��7 8
nombreJugador
��8 E
)
��E F
;
��F G
cliente
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
cliente
�� 
.
�� 
Abort
�� 
(
�� 
)
�� 
;
��  
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
}
�� 
}�� �c
}C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioSala.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

class 
ServicioSala 
{		 
public

 
static

 
bool

  
ExisteSalaDisponible

 /
(

/ 0
string

0 6
idSala

7 =
)

= >
{ 	
bool 
hayDisponibilidad "
=# $
false% *
;* +
ServicioSalaClient 
cliente &
=' (
new) ,
ServicioSalaClient- ?
(? @
new@ C
InstanceContext 
(  
new  #

PaginaSala$ .
(. /
)/ 0
)0 1
)1 2
;2 3
try 
{ 
hayDisponibilidad !
=" #
cliente$ +
.+ , 
ExisteSalaDisponible, @
(@ A
idSalaA G
)G H
;H I
cliente 
. 
Abort 
( 
) 
;  
} 
catch 
( %
EndpointNotFoundException ,
	excepcion- 6
)6 7
{ 

MessageBox 
. 
Show 
(  

Properties  *
.* +
	Resources+ 4
.4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE :
,: ;

Properties< F
.F G
	ResourcesG P
.P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO 9
,9 :
MessageBoxButton $
.$ %
OK% '
,' (
MessageBoxImage) 8
.8 9
Error9 >
)> ?
;? @
} 
catch 
( /
#CommunicationObjectFaultedException 6
	excepcion7 @
)@ A
{ 

MessageBox   
.   
Show   
(    

Properties    *
.  * +
	Resources  + 4
.  4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE!! :
,!!: ;

Properties!!< F
.!!F G
	Resources!!G P
.!!P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO"" 9
,""9 :
MessageBoxButton## $
.##$ %
OK##% '
,##' (
MessageBoxImage##) 8
.##8 9
Error##9 >
)##> ?
;##? @
}$$ 
catch%% 
(%% 
TimeoutException%% #
	excepcion%%$ -
)%%- .
{&& 

MessageBox(( 
.(( 
Show(( 
(((  

Properties((  *
.((* +
	Resources((+ 4
.((4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE)) :
,)): ;

Properties))< F
.))F G
	Resources))G P
.))P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO** 9
,**9 :
MessageBoxButton++ $
.++$ %
OK++% '
,++' (
MessageBoxImage++) 8
.++8 9
Error++9 >
)++> ?
;++? @
},, 
return.. 
hayDisponibilidad.. $
;..$ %
}// 	
public11 
static11 
bool11 
CrearNuevaSala11 )
(11) *
string11* 0
nombreAnfitrion111 @
,11@ A
string11B H

codigoSala11I S
)11S T
{22 	
ServicioSalaClient33 
cliente33 &
=33' (
new33) ,
ServicioSalaClient33- ?
(33? @
new33@ C
InstanceContext33D S
(33S T
new44 

PaginaSala44 
(44 
)44  
)44  !
)44! "
;44" #
bool55 
	resultado55 
=55 
false55 "
;55" #
try77 
{88 
	resultado:: 
=:: 
cliente:: #
.::# $
CrearNuevaSala::$ 2
(::2 3
nombreAnfitrion::3 B
,::B C

codigoSala::D N
)::N O
;::O P
cliente;; 
.;; 
Close;; 
(;; 
);; 
;;;  
}<< 
catch== 
(== %
EndpointNotFoundException== ,
	excepcion==- 6
)==6 7
{>> 

MessageBox@@ 
.@@ 
Show@@ 
(@@  

Properties@@  *
.@@* +
	Resources@@+ 4
.@@4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEAA :
,AA: ;

PropertiesAA< F
.AAF G
	ResourcesAAG P
.AAP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOBB 9
,BB9 :
MessageBoxButtonCC $
.CC$ %
OKCC% '
,CC' (
MessageBoxImageCC) 8
.CC8 9
ErrorCC9 >
)CC> ?
;CC? @
}DD 
catchEE 
(EE /
#CommunicationObjectFaultedExceptionEE 6
	excepcionEE7 @
)EE@ A
{FF 

MessageBoxHH 
.HH 
ShowHH 
(HH  

PropertiesHH  *
.HH* +
	ResourcesHH+ 4
.HH4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEII :
,II: ;

PropertiesII< F
.IIF G
	ResourcesIIG P
.IIP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOJJ 9
,JJ9 :
MessageBoxButtonKK $
.KK$ %
OKKK% '
,KK' (
MessageBoxImageKK) 8
.KK8 9
ErrorKK9 >
)KK> ?
;KK? @
}LL 
catchMM 
(MM 
TimeoutExceptionMM #
	excepcionMM$ -
)MM- .
{NN 

MessageBoxPP 
.PP 
ShowPP 
(PP  

PropertiesPP  *
.PP* +
	ResourcesPP+ 4
.PP4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEQQ :
,QQ: ;

PropertiesQQ< F
.QQF G
	ResourcesQQG P
.QQP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULORR 9
,RR9 :
MessageBoxButtonSS $
.SS$ %
OKSS% '
,SS' (
MessageBoxImageSS) 8
.SS8 9
ErrorSS9 >
)SS> ?
;SS? @
}TT 
returnVV 
	resultadoVV 
;VV 
}WW 	
publicYY 
staticYY 
stringYY &
GenerarCodigoParaNuevaSalaYY 7
(YY7 8
)YY8 9
{ZZ 	
ServicioSalaClient[[ 
cliente[[ &
=[[' (
new[[) ,
ServicioSalaClient[[- ?
([[? @
new[[@ C
InstanceContext[[D S
([[S T
new\\ 

PaginaSala\\ 
(\\ 
)\\  
)\\  !
)\\! "
;\\" #
string]] 

codigoSala]] 
=]] 
null]]  $
;]]$ %
try__ 
{`` 

codigoSalaaa 
=aa 
clienteaa $
.aa$ %&
GenerarCodigoParaNuevaSalaaa% ?
(aa? @
)aa@ A
;aaA B
clientebb 
.bb 
Closebb 
(bb 
)bb 
;bb  
}cc 
catchdd 
(dd %
EndpointNotFoundExceptiondd ,
	excepciondd- 6
)dd6 7
{ee 

MessageBoxgg 
.gg 
Showgg 
(gg  

Propertiesgg  *
.gg* +
	Resourcesgg+ 4
.gg4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEhh :
,hh: ;

Propertieshh< F
.hhF G
	ResourceshhG P
.hhP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOii 9
,ii9 :
MessageBoxButtonjj $
.jj$ %
OKjj% '
,jj' (
MessageBoxImagejj) 8
.jj8 9
Errorjj9 >
)jj> ?
;jj? @
}kk 
catchll 
(ll /
#CommunicationObjectFaultedExceptionll 6
	excepcionll7 @
)ll@ A
{mm 

MessageBoxoo 
.oo 
Showoo 
(oo  

Propertiesoo  *
.oo* +
	Resourcesoo+ 4
.oo4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEpp :
,pp: ;

Propertiespp< F
.ppF G
	ResourcesppG P
.ppP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOqq 9
,qq9 :
MessageBoxButtonrr $
.rr$ %
OKrr% '
,rr' (
MessageBoxImagerr) 8
.rr8 9
Errorrr9 >
)rr> ?
;rr? @
}ss 
catchtt 
(tt 
TimeoutExceptiontt #
	excepciontt$ -
)tt- .
{uu 

MessageBoxww 
.ww 
Showww 
(ww  

Propertiesww  *
.ww* +
	Resourcesww+ 4
.ww4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJExx :
,xx: ;

Propertiesxx< F
.xxF G
	ResourcesxxG P
.xxP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOyy 9
,yy9 :
MessageBoxButtonzz $
.zz$ %
OKzz% '
,zz' (
MessageBoxImagezz) 8
.zz8 9
Errorzz9 >
)zz> ?
;zz? @
}{{ 
return}} 

codigoSala}} 
;}} 
}~~ 	
public
�� 
static
�� 
CuentaJugador
�� #
[
��# $
]
��$ %.
 ObtenerJugadoresConectadosEnSala
��& F
(
��F G
string
��G M

codigoSala
��N X
)
��X Y
{
�� 	 
ServicioSalaClient
�� 
cliente
�� &
=
��' (
new
��) , 
ServicioSalaClient
��- ?
(
��? @
new
��@ C
InstanceContext
��D S
(
��S T
new
�� 

PaginaSala
�� 
(
�� 
)
��  
)
��  !
)
��! "
;
��" #
CuentaJugador
�� 
[
�� 
]
�� 
jugadoresEnSala
�� +
=
��, -
null
��. 2
;
��2 3
try
�� 
{
�� 
jugadoresEnSala
�� 
=
��  !
cliente
��" )
.
��) *.
 ObtenerJugadoresConectadosEnSala
��* J
(
��J K

codigoSala
��K U
)
��U V
;
��V W
cliente
�� 
.
�� 
Close
�� 
(
�� 
)
�� 
;
��  
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
}
�� 
return
�� 
jugadoresEnSala
�� "
;
��" #
}
�� 	
}
�� 
}�� �6
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioPartida.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

class 
ServicioPartida  
{		 
public

 
static

 
int

 (
ObtenerNumeroPartidasJugadas

 6
(

6 7
string

7 =
nombreJugador

> K
)

K L
{ 	!
ServicioPartidaClient !
cliente" )
=* +
new, /!
ServicioPartidaClient0 E
(E F
new 
InstanceContext #
(# $
new$ '
PaginaPartida( 5
(5 6
)6 7
)7 8
)8 9
;9 :
int 
	resultado 
= 
$num 
; 
try 
{ 
	resultado 
= 
cliente #
.# $(
ObtenerNumeroPartidasJugadas$ @
(@ A
nombreJugadorA N
)N O
;O P
cliente 
. 
Close 
( 
) 
;  
} 
catch 
( %
EndpointNotFoundException ,
	excepcion- 6
)6 7
{ 

MessageBox 
. 
Show 
(  

Properties  *
.* +
	Resources+ 4
.4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE :
,: ;

Properties< F
.F G
	ResourcesG P
.P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO 9
,9 :
MessageBoxButton $
.$ %
OK% '
,' (
MessageBoxImage) 8
.8 9
Error9 >
)> ?
;? @
cliente 
. 
Abort 
( 
) 
;  
} 
catch 
( /
#CommunicationObjectFaultedException 6
	excepcion7 @
)@ A
{ 

MessageBox!! 
.!! 
Show!! 
(!!  

Properties!!  *
.!!* +
	Resources!!+ 4
.!!4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE"" :
,"": ;

Properties""< F
.""F G
	Resources""G P
.""P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO## 9
,##9 :
MessageBoxButton$$ $
.$$$ %
OK$$% '
,$$' (
MessageBoxImage$$) 8
.$$8 9
Error$$9 >
)$$> ?
;$$? @
cliente%% 
.%% 
Abort%% 
(%% 
)%% 
;%%  
}&& 
catch'' 
('' 
TimeoutException'' #
	excepcion''$ -
)''- .
{(( 

MessageBox** 
.** 
Show** 
(**  

Properties**  *
.*** +
	Resources**+ 4
.**4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE++ :
,++: ;

Properties++< F
.++F G
	Resources++G P
.++P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,, 9
,,,9 :
MessageBoxButton-- $
.--$ %
OK--% '
,--' (
MessageBoxImage--) 8
.--8 9
Error--9 >
)--> ?
;--? @
cliente.. 
... 
Abort.. 
(.. 
).. 
;..  
}// 
return11 
	resultado11 
;11 
}22 	
public44 
static44 
int44 (
ObtenerNumeroPartidasGanadas44 6
(446 7
string447 =
nombreJugador44> K
)44K L
{55 	!
ServicioPartidaClient66 !
cliente66" )
=66* +
new66, /!
ServicioPartidaClient660 E
(66E F
new77 
InstanceContext77 #
(77# $
new77$ '
PaginaPartida77( 5
(775 6
)776 7
)777 8
)778 9
;779 :
int88 
	resultado88 
=88 
$num88 
;88 
try:: 
{;; 
	resultado<< 
=<< 
cliente<< #
.<<# $(
ObtenerNumeroPartidasGanadas<<$ @
(<<@ A
nombreJugador<<A N
)<<N O
;<<O P
cliente== 
.== 
Close== 
(== 
)== 
;==  
}>> 
catch?? 
(?? %
EndpointNotFoundException?? ,
	excepcion??- 6
)??6 7
{@@ 

MessageBoxBB 
.BB 
ShowBB 
(BB  

PropertiesBB  *
.BB* +
	ResourcesBB+ 4
.BB4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJECC :
,CC: ;

PropertiesCC< F
.CCF G
	ResourcesCCG P
.CCP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULODD 9
,DD9 :
MessageBoxButtonEE $
.EE$ %
OKEE% '
,EE' (
MessageBoxImageEE) 8
.EE8 9
ErrorEE9 >
)EE> ?
;EE? @
clienteFF 
.FF 
AbortFF 
(FF 
)FF 
;FF  
}GG 
catchHH 
(HH /
#CommunicationObjectFaultedExceptionHH 6
	excepcionHH7 @
)HH@ A
{II 

MessageBoxKK 
.KK 
ShowKK 
(KK  

PropertiesKK  *
.KK* +
	ResourcesKK+ 4
.KK4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJELL :
,LL: ;

PropertiesLL< F
.LLF G
	ResourcesLLG P
.LLP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOMM 9
,MM9 :
MessageBoxButtonNN $
.NN$ %
OKNN% '
,NN' (
MessageBoxImageNN) 8
.NN8 9
ErrorNN9 >
)NN> ?
;NN? @
clienteOO 
.OO 
AbortOO 
(OO 
)OO 
;OO  
}PP 
catchQQ 
(QQ 
TimeoutExceptionQQ #
	excepcionQQ$ -
)QQ- .
{RR 

MessageBoxTT 
.TT 
ShowTT 
(TT  

PropertiesTT  *
.TT* +
	ResourcesTT+ 4
.TT4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEUU :
,UU: ;

PropertiesUU< F
.UUF G
	ResourcesUUG P
.UUP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOVV 9
,VV9 :
MessageBoxButtonWW $
.WW$ %
OKWW% '
,WW' (
MessageBoxImageWW) 8
.WW8 9
ErrorWW9 >
)WW> ?
;WW? @
clienteXX 
.XX 
AbortXX 
(XX 
)XX 
;XX  
}YY 
return[[ 
	resultado[[ 
;[[ 
}\\ 	
}]] 
}^^ �
oC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\App.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class 
App 
: 
Application *
{		 
private

 
readonly

 
List

 
<

 
string

 $
>

$ %
idiomasDisponibles

& 8
;

8 9
private 
string 
idiomaActual #
;# $
private 
bool 
musicaActiva !
;! "
SoundPlayer 
reproductorMusica %
;% &
public 
string 
IdiomaActual "
{ 	
get 
{ 
return 
idiomaActual %
;% &
}' (
private 
set 
{ 
Thread 
. 
CurrentThread $
.$ %
CurrentUICulture% 5
=6 7
new8 ;
System< B
.B C
Globalization !
.! "
CultureInfo" -
(- .
value. 3
)3 4
;4 5
idiomaActual 
= 
value $
;$ %
} 
} 	
public 
bool 
MusicaActiva  
{ 	
get 
{ 
return 
musicaActiva #
;# $
} 
set   
{!! 
musicaActiva"" 
="" 
value"" $
;""$ %
}## 
}$$ 	
public&& 
static&& 
new&& 
App&& 
Current&& %
{'' 	
get(( 
{)) 
return** 
(** 
App** 
)** 
Application** (
.**( )
Current**) 0
;**0 1
}++ 
},, 	
App.. 
(.. 
).. 
{// 	
idiomasDisponibles00 
=00  
new00! $
List00% )
<00) *
string00* 0
>000 1
(001 2
)002 3
{11 
$str22 
,22 
$str33 
}44 
;44 
IdiomaActual55 
=55 
idiomasDisponibles55 -
[55- .
$num55. /
]55/ 0
;550 1
}66 	
public88 
void88 
CambiarIdioma88 !
(88! "
string88" (
nuevoIdioma88) 4
)884 5
{99 	
IdiomaActual:: 
=:: 
nuevoIdioma:: &
;::& '
};; 	
public== 
void== 
EstadoMusica==  
(==  !
bool==! %
musicaActivada==& 4
)==4 5
{>> 	
if?? 
(?? 
musicaActivada?? 
)?? 
{@@ 
reproductorMusicaAA !
.AA! "
PlayLoopingAA" -
(AA- .
)AA. /
;AA/ 0
musicaActivaBB 
=BB 
trueBB #
;BB# $
}CC 
elseDD 
{EE 
reproductorMusicaFF !
.FF! "
StopFF" &
(FF& '
)FF' (
;FF( )
musicaActivaGG 
=GG 
falseGG $
;GG$ %
}HH 
}II 	
	protectedKK 
overrideKK 
voidKK 
	OnStartupKK  )
(KK) *
StartupEventArgsKK* :
eventoKK; A
)KKA B
{LL 	
reproductorMusicaMM 
=MM 
newMM  #
SoundPlayerMM$ /
(MM/ 0
RompecabezasFeiMM0 ?
.MM? @

PropertiesMM@ J
.MMJ K
ResourceSonidosNN 
.NN  !
MusicaRompecabezasFeiNN  5
)NN5 6
;NN6 7
EstadoMusicaOO 
(OO 
falseOO 
)OO 
;OO  
}PP 	
}QQ 
}RR �E
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaActualizacionContrasena.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public		 

partial		 
class		 )
PaginaActualizacionContrasena		 6
:		7 8
Page		9 =
{

 
public )
PaginaActualizacionContrasena ,
(, -
)- .
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void '
IrAPaginaInformacionJugador 0
(0 1
object1 7
objetoOrigen8 D
,D E 
MouseButtonEventArgsF Z
evento[ a
)a b
{ 	
VentanaPrincipal 
. 
CambiarPagina *
(* +
new+ .$
PaginaInformacionJugador/ G
(G H
)H I
)I J
;J K
} 	
private 
void  
ActualizarContrasena )
() *
object* 0
objetoOrigen1 =
,= >
RoutedEventArgs? N
eventoO U
)U V
{ 	
string 
contrasenaActual #
=$ %
Dominio& -
.- .
CuentaJugador. ;
.; <
Actual< B
.B C

ContrasenaC M
;M N
string 
contrasenaAnterior %
=& '"
cuadroContrasenaActual( >
.> ?
Password? G
;G H
string 
nuevaContrasena "
=# $!
cuadroNuevaContrasena% :
.: ;
Password; C
;C D
string "
confirmacionContrasena )
=* +(
cuadroConfirmacionContrasena, H
.H I
PasswordI Q
;Q R
if 
( 
ValidadorDatos 
. '
ExisteCoincidenciaEnCadenas :
(: ;
contrasenaAnterior; M
,M N
contrasenaActualO _
)_ `
)` a
{ 
if 
( 
! 
ValidadorDatos #
.# $'
ExisteCoincidenciaEnCadenas$ ?
(? @
contrasenaAnterior@ R
,R S
nuevaContrasena #
)# $
)$ %
{   
if!! 
(!! 
!!! !
ExistenDatosInvalidos!! .
(!!. /
nuevaContrasena!!/ >
,!!> ?"
confirmacionContrasena!!@ V
)!!V W
)!!W X
{"" 
string## 
correoJugador## ,
=##- .
Dominio##/ 6
.##6 7
CuentaJugador##7 D
.##D E
Actual##E K
.##K L
Correo##L R
;##R S
string$$ "
nuevaContrasenaCifrada$$ 5
=$$6 7!
EncriptadorContrasena$$8 M
.$$M N
CalcularHashSha512%% .
(%%. /
nuevaContrasena%%/ >
)%%> ?
;%%? @
bool&& "
actualizacionRealizada&& 3
=&&4 5
	Servicios&&6 ?
.&&? @
ServicioJugador&&@ O
.&&O P 
ActualizarContrasena'' 0
(''0 1
correoJugador''1 >
,''> ?"
nuevaContrasenaCifrada''@ V
)''V W
;''W X
if)) 
()) "
actualizacionRealizada)) 2
)))2 3
{** 

MessageBox++ &
.++& '
Show++' +
(+++ ,
$str++, P
+++Q R
$str,,  ?
,,,? @
$str--  G
,--G H
MessageBoxButton..  0
...0 1
OK..1 3
)..3 4
;..4 5
Dominio// #
.//# $
CuentaJugador//$ 1
.//1 2
Actual//2 8
.//8 9

Contrasena//9 C
=//D E
nuevaContrasena//F U
;//U V
VentanaPrincipal00 ,
.00, -
CambiarPagina00- :
(00: ;
new00; >$
PaginaInformacionJugador00? W
(00W X
)00X Y
)00Y Z
;00Z [
}11 
else22 
{33 

MessageBox44 &
.44& '
Show44' +
(44+ ,
$str44, b
,44b c
$str55  A
,55A B
MessageBoxButton55C S
.55S T
OK55T V
)55V W
;55W X
}66 
}77 
}88 
}99 
}:: 	
private<< 
bool<< !
ExistenDatosInvalidos<< *
(<<* +
string<<+ 1
nuevaContrasena<<2 A
,<<A B
string== "
confirmacionContrasena== )
)==) *
{>> 	
bool?? 
hayDatosInvalidos?? "
=??# $
false??% *
;??* +
ifAA 
(AA 
ValidadorDatosAA 
.AA 4
(ExistenCaracteresInvalidosParaContrasenaAA G
(AAG H
nuevaContrasenaAAH W
)AAW X
)AAX Y
{BB 

MessageBoxCC 
.CC 
ShowCC 
(CC  

PropertiesCC  *
.CC* +
	ResourcesCC+ 4
.CC4 56
*ETIQUETA_VALIDACION_MENSAJECONTRASENANUEVACC5 _
,CC_ `

PropertiesDD 
.DD 
	ResourcesDD (
.DD( )2
&ETIQUETA_VALIDACION_CONTRASENAINVALIDADD) O
,DDO P
MessageBoxButtonEE $
.EE$ %
OKEE% '
)EE' (
;EE( )
hayDatosInvalidosFF !
=FF" #
trueFF$ (
;FF( )
}GG 
ifII 
(II 
ValidadorDatosII 
.II .
"ExisteLongitudExcedidaEnContrasenaII A
(IIA B"
cuadroContrasenaActualJJ &
.JJ& '
PasswordJJ' /
)JJ/ 0
)JJ0 1
{KK 

MessageBoxLL 
.LL 
ShowLL 
(LL  

PropertiesLL  *
.LL* +
	ResourcesLL+ 4
.LL4 52
&ETIQUETA_VALIDACION_CONTRASENAEXCEDIDALL5 [
,LL[ \

PropertiesMM 
.MM  
	ResourcesMM  )
.MM) *0
$ETIQUETA_VALIDACION_LONGITUDEXCEDIDAMM* N
,MMN O
MessageBoxButtonNN %
.NN% &
OKNN& (
)NN( )
;NN) *
hayDatosInvalidosOO !
=OO" #
trueOO$ (
;OO( )
}PP 
ifRR 
(RR 
ExistenCamposVaciosRR #
(RR# $
)RR$ %
)RR% &
{SS 

MessageBoxTT 
.TT 
ShowTT 
(TT  

PropertiesTT  *
.TT* +
	ResourcesTT+ 4
.TT4 53
'ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOSTT5 \
,TT\ ]

PropertiesUU 
.UU 
	ResourcesUU '
.UU' (,
 ETIQUETA_VALIDACION_CAMPOSVACIOSUU( H
,UUH I
MessageBoxButtonVV #
.VV# $
OKVV$ &
)VV& '
;VV' (
hayDatosInvalidosWW !
=WW" #
trueWW$ (
;WW( )
}XX 
ifZZ 
(ZZ 
!ZZ 
ValidadorDatosZZ 
.ZZ  '
ExisteCoincidenciaEnCadenasZZ  ;
(ZZ; <
nuevaContrasenaZZ< K
,ZZK L"
confirmacionContrasena[[ &
)[[& '
)[[' (
{\\ 

MessageBox]] 
.]] 
Show]] 
(]]  

Properties]]  *
.]]* +
	Resources]]+ 4
.]]4 5:
.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE^^ B
,^^B C

Properties^^D N
.^^N O
	Resources^^O X
.^^X Y3
'ETIQUETA_VALIDACION_CONTRASENADIFERENTE__ ;
,__; <
MessageBoxButton__= M
.__M N
OK__N P
)__P Q
;__Q R
}`` 
returnbb 
hayDatosInvalidosbb $
;bb$ %
}cc 	
privateee 
boolee 
ExistenCamposVaciosee (
(ee( )
)ee) *
{ff 	
boolgg 
	resultadogg 
=gg 
falsegg "
;gg" #
ifii 
(ii 
ValidadorDatosii 
.ii 
EsCadenaVaciaii ,
(ii, -"
cuadroContrasenaActualii- C
.iiC D
PasswordiiD L
)iiL M
||iiN P
ValidadorDatosjj 
.jj 
EsCadenaVaciajj ,
(jj, -!
cuadroNuevaContrasenajj- B
.jjB C
PasswordjjC K
)jjK L
||jjM O
ValidadorDatoskk 
.kk 
EsCadenaVaciakk ,
(kk, -(
cuadroConfirmacionContrasenakk- I
.kkI J
PasswordkkJ R
)kkR S
)kkS T
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
}ss �b
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaActualizacionInformacion.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public		 

partial		 
class		 *
PaginaActualizacionInformacion		 7
:		8 9
Page		: >
{

 
private 
bool 
nombreModificado %
;% &
public *
PaginaActualizacionInformacion -
(- .
string. 4
nombreJugador5 B
,B C
intD G
numeroAvatarH T
)T U
{ 	
InitializeComponent 
(  
)  !
;! "
MostrarDatosEdicion 
(  
nombreJugador  -
,- .
numeroAvatar/ ;
); <
;< =
} 	
private 
void 
MostrarDatosEdicion (
(( )
string) /
nombreJugador0 =
,= >
int? B
numeroAvatarC O
)O P
{ 	$
cuadroTextoNombreUsuario $
.$ %
Text% )
=* +
nombreJugador, 9
;9 :
imagenAvatarActual 
. 
Tag "
=# $
Convert% ,
., -
ToInt16- 4
(4 5
numeroAvatar5 A
)A B
;B C
imagenAvatarActual 
. 
Source %
=& '

Utilidades( 2
.2 3
GeneradorImagenes3 D
.D E%
GenerarFuenteImagenAvatar )
() *
numeroAvatar* 6
)6 7
;7 8
} 	
private 
void '
IrAPaginaInformacionJugador 0
(0 1
object1 7
controlOrigen8 E
,E F 
MouseButtonEventArgs  
evento! '
)' (
{ 	
VentanaPrincipal 
. 
CambiarPagina *
(* +
new+ .$
PaginaInformacionJugador/ G
(G H
)H I
)I J
;J K
} 	
private!! 
void!! -
!GuardarModificacionesDatosJugador!! 6
(!!6 7
object!!7 =
objetoOrigen!!> J
,!!J K
RoutedEventArgs"" 
evento"" "
)""" #
{## 	
string$$ 
nombreAnterior$$ !
=$$" #
Dominio$$$ +
.$$+ ,
CuentaJugador$$, 9
.$$9 :
Actual$$: @
.$$@ A
NombreJugador$$A N
;$$N O
string%% 
nuevoNombre%% 
=%%  $
cuadroTextoNombreUsuario%%! 9
.%%9 :
Text%%: >
.%%> ?
Trim%%? C
(%%C D
)%%D E
;%%E F
int&& 
nuevoNumeroAvatar&& !
=&&" #
Convert&&$ +
.&&+ ,
ToInt32&&, 3
(&&3 4
imagenAvatarActual&&4 F
.&&F G
Tag&&G J
)&&J K
;&&K L
bool'' 
esNombreDiferente'' "
=''# $0
$ExistenModificacionesEnNombreJugador''% I
(''I J
nuevoNombre''J U
)''U V
;''V W
bool(( 
esAvatarDiferente(( "
=((# $/
#ExistenModificacionesEnNumeroAvatar((% H
(((H I
nuevoNumeroAvatar((I Z
)((Z [
;(([ \
if** 
(** 
!** 
esNombreDiferente** "
&&**# %
!**& '
esAvatarDiferente**' 8
)**8 9
{++ 
VentanaPrincipal,,  
.,,  !
CambiarPagina,,! .
(,,. /
new,,/ 2$
PaginaInformacionJugador,,3 K
(,,K L
),,L M
),,M N
;,,N O
}-- 
if// 
(// 
esNombreDiferente// !
||//" $
esAvatarDiferente//% 6
)//6 7
{00 
if11 
(11 
!11 2
&ExistenDatosInvalidosParaActualizacion11 ;
(11; <
)11< =
)11= >
{22 
if33 
(33 
!33 
	Servicios33 "
.33" #
ServicioJugador33# 2
.332 3
ExisteNombreJugador333 F
(33F G
nuevoNombre33G R
)33R S
)33S T
{44 
bool55 "
actualizacionRealizada55 3
=554 5
	Servicios556 ?
.55? @
ServicioJugador55@ O
.55O P!
ActualizarInformacion66 1
(661 2
nombreAnterior662 @
,66@ A
nuevoNombre66B M
,66M N
nuevoNumeroAvatar66O `
)66` a
;66a b
if88 
(88 "
actualizacionRealizada88 2
)882 3
{99 

MessageBox:: &
.::& '
Show::' +
(::+ ,

Properties::, 6
.::6 7
	Resources::7 @
.::@ AB
6ETIQUETA_ACTUALIZACIONINFORMACION_MENSAJEACTUALIZACION;;  V
,;;V W

Properties<<  *
.<<* +
	Resources<<+ 4
.<<4 5D
8ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONREALIZADA==  X
,==X Y
MessageBoxButton>>  0
.>>0 1
OK>>1 3
)>>3 4
;>>4 5
Dominio?? #
.??# $
CuentaJugador??$ 1
.??1 2
Actual??2 8
.??8 9
NumeroAvatar??9 E
=??F G
nuevoNumeroAvatar??H Y
;??Y Z
Dominio@@ #
.@@# $
CuentaJugador@@$ 1
.@@1 2
Actual@@2 8
.@@8 9
NombreJugador@@9 F
=@@G H
nuevoNombre@@I T
;@@T U
DominioAA #
.AA# $
CuentaJugadorAA$ 1
.AA1 2
ActualAA2 8
.AA8 9
FuenteImagenAvatarAA9 K
=AAL M

UtilidadesAAN X
.AAX Y
GeneradorImagenesBB  1
.BB1 2%
GenerarFuenteImagenAvatarBB2 K
(BBK L
nuevoNumeroAvatarBBL ]
)BB] ^
;BB^ _
VentanaPrincipalCC ,
.CC, -
CambiarPaginaCC- :
(CC: ;
newCC; >$
PaginaInformacionJugadorCC? W
(CCW X
)CCX Y
)CCY Z
;CCZ [
}DD 
elseEE 
{FF 

MessageBoxGG &
.GG& '
ShowGG' +
(GG+ ,

PropertiesGG, 6
.GG6 7
	ResourcesGG7 @
.GG@ AF
:ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONNOREALIZADAHH  Z
,HHZ [

PropertiesII  *
.II* +
	ResourcesII+ 4
.II4 5@
4ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACIONJJ  T
,JJT U
MessageBoxButtonKK  0
.KK0 1
OKKK1 3
)KK3 4
;KK4 5
}LL 
}MM 
elseNN 
{OO 

MessageBoxPP "
.PP" #
ShowPP# '
(PP' (

PropertiesQQ &
.QQ& '
	ResourcesQQ' 0
.QQ0 1@
4ETIQUETA_ACTUALIZACIONINFORMACION_NOMBRENODISPONIBLERR P
,RRP Q

PropertiesSS &
.SS& '
	ResourcesSS' 0
.SS0 1@
4ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACIONTT P
,TTP Q
MessageBoxButtonUU ,
.UU, -
OKUU- /
)UU/ 0
;UU0 1
}VV 
}WW 
}XX 
}YY 	
private[[ 
void[[ )
NavegarAPaginaSeleccionAvatar[[ 2
([[2 3
object[[3 9
objetoOrigen[[: F
,[[F G
RoutedEventArgs[[H W
evento[[X ^
)[[^ _
{\\ 	!
PaginaSeleccionAvatar]] !!
paginaSeleccionAvatar]]" 7
=]]8 9
new]]: =!
PaginaSeleccionAvatar]]> S
(]]S T
Convert^^ 
.^^ 
ToInt32^^ 
(^^  
imagenAvatarActual^^  2
.^^2 3
Tag^^3 6
)^^6 7
,^^7 8$
cuadroTextoNombreUsuario^^9 Q
.^^Q R
Text^^R V
)^^V W
;^^W X
VentanaPrincipal__ 
.__ *
CambiarPaginaGuardandoAnterior__ ;
(__; <!
paginaSeleccionAvatar__< Q
)__Q R
;__R S
}`` 	
privatebb 
boolbb /
#ExistenModificacionesEnNumeroAvatarbb 8
(bb8 9
intbb9 <
nuevoNumeroAvatarbb= N
)bbN O
{cc 	
booldd 
	resultadodd 
=dd 
truedd !
;dd! "
ifff 
(ff 
Dominioff 
.ff 
CuentaJugadorff %
.ff% &
Actualff& ,
.ff, -
NumeroAvatarff- 9
.ff9 :
Equalsff: @
(ff@ A
nuevoNumeroAvatarffA R
)ffR S
)ffS T
{gg 
	resultadohh 
=hh 
falsehh !
;hh! "
}ii 
returnkk 
	resultadokk 
;kk 
}ll 	
privatenn 
boolnn 0
$ExistenModificacionesEnNombreJugadornn 9
(nn9 :
stringnn: @
nuevoNombreJugadornnA S
)nnS T
{oo 	
nombreModificadopp 
=pp 
truepp #
;pp# $
ifrr 
(rr 
Dominiorr 
.rr 
CuentaJugadorrr %
.rr% &
Actualrr& ,
.rr, -
NombreJugadorrr- :
.rr: ;
Equalsrr; A
(rrA B
nuevoNombreJugadorrrB T
)rrT U
)rrU V
{ss 
nombreModificadott  
=tt! "
falsett# (
;tt( )
}uu 
returnww 
nombreModificadoww #
;ww# $
}xx 	
privatezz 
boolzz 2
&ExistenDatosInvalidosParaActualizacionzz ;
(zz; <
)zz< =
{{{ 	
bool|| 
datosInvalidos|| 
=||  !
false||" '
;||' (
if~~ 
(~~ 
ValidadorDatos~~ 
.~~ 
EsCadenaVacia~~ ,
(~~, -$
cuadroTextoNombreUsuario~~- E
.~~E F
Text~~F J
)~~J K
)~~K L
{ 
datosInvalidos
�� 
=
��  
true
��! %
;
��% &

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 55
'ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS
��5 \
,
��\ ]

Properties
�� 
.
�� 
	Resources
�� (
.
��( ).
 ETIQUETA_VALIDACION_CAMPOSVACIOS
��) I
,
��I J
MessageBoxButton
�� $
.
��$ %
OK
��% '
)
��' (
;
��( )
}
�� 
if
�� 
(
�� 
ValidadorDatos
�� 
.
�� 3
%ExisteLongitudExcedidaEnNombreJugador
�� D
(
��D E&
cuadroTextoNombreUsuario
�� (
.
��( )
Text
��) -
)
��- .
)
��. /
{
�� 
datosInvalidos
�� 
=
��  
true
��! %
;
��% &

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 58
*ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS
��5 _
,
��_ `

Properties
�� 
.
�� 
	Resources
�� (
.
��( )1
#ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS
��) L
,
��L M
MessageBoxButton
�� $
.
��$ %
OK
��% '
)
��' (
;
��( )
}
�� 
if
�� 
(
�� 
ValidadorDatos
�� 
.
�� 9
+ExistenCaracteresInvalidosParaNombreJugador
�� J
(
��J K&
cuadroTextoNombreUsuario
�� (
.
��( )
Text
��) -
)
��- .
)
��. /
{
�� 
datosInvalidos
�� 
=
��  
true
��! %
;
��% &

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
�� 
.
�� 
	Resources
�� (
.
��( )>
0ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO
��) Y
,
��Y Z

Properties
�� 
.
�� 
	Resources
�� (
.
��( )7
)ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO
��) R
,
��R S
MessageBoxButton
�� $
.
��$ %
OK
��% '
)
��' (
;
��( )
}
�� 
return
�� 
datosInvalidos
�� !
;
��! "
}
�� 	
}
�� 
}�� �2
yC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaAjustes.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public		 

partial		 
class		 
PaginaAjustes		 &
:		' (
Page		) -
{

 
private 
string 
idioma 
; 
private 
bool )
hayMusicaActivadaInicialmente 2
;2 3
private 
const 
string 
IdiomaIngles )
=* +
$str, 3
;3 4
private 
const 
string 
IdiomaEspanol *
=+ ,
$str- 4
;4 5
public 
PaginaAjustes 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void &
InicializarSeleccionIdioma /
(/ 0
)0 1
{ 	
if 
( 
App 
. 
Current 
. 
IdiomaActual (
==) +
IdiomaIngles, 8
)8 9
{ 
cajaOpcionesIdioma "
." #
SelectedIndex# 0
=1 2
(3 4
int4 7
)7 8
Idioma8 >
.> ?
Ingles? E
;E F
} 
else 
{ 
cajaOpcionesIdioma "
." #
SelectedIndex# 0
=1 2
(3 4
int4 7
)7 8
Idioma8 >
.> ?
Espanol? F
;F G
} 
} 	
private!! 
void!! &
InicializarSeleccionMusica!! /
(!!/ 0
)!!0 1
{"" 	
if## 
(## 
App## 
.## 
Current## 
.## 
MusicaActiva## (
)##( )
{$$ )
hayMusicaActivadaInicialmente%% -
=%%. /
true%%0 4
;%%4 5
botonCambioMusica&& !
.&&! "
	IsChecked&&" +
=&&, -
true&&. 2
;&&2 3
}'' 
else(( 
{)) )
hayMusicaActivadaInicialmente** -
=**. /
false**0 5
;**5 6
botonCambioMusica++ !
.++! "
	IsChecked++" +
=++, -
false++. 3
;++3 4
},, 
}-- 	
private// 
void// !
RefrescarPaginaActual// *
(//* +
)//+ ,
{00 	
VentanaPrincipal11 
.11 
CambiarPagina11 *
(11* +
new11+ .
PaginaAjustes11/ <
(11< =
)11= >
)11> ?
;11? @
}22 	
private44 
void44 (
InicializarOpcionesDeAjustes44 1
(441 2
object442 8
objetoOrigen449 E
,44E F
RoutedEventArgs44G V
evento44W ]
)44] ^
{55 	&
InicializarSeleccionIdioma66 &
(66& '
)66' (
;66( )&
InicializarSeleccionMusica77 &
(77& '
)77' (
;77( )
}88 	
private:: 
void:: 
SeleccionarIdioma:: &
(::& '
object::' -
controlOrigen::. ;
,::; <%
SelectionChangedEventArgs::= V
evento::W ]
)::] ^
{;; 	
if<< 
(<< 
cajaOpcionesIdioma<< "
.<<" #
SelectedIndex<<# 0
==<<1 3
(<<4 5
int<<5 8
)<<8 9
Idioma<<9 ?
.<<? @
Ingles<<@ F
)<<F G
{== 
idioma>> 
=>> 
IdiomaIngles>> %
;>>% &
}?? 
else@@ 
{AA 
idiomaBB 
=BB 
IdiomaEspanolBB &
;BB& '
}CC 
}DD 	
privateFF 
voidFF 
IrAPaginaAnteriorFF &
(FF& '
objectFF' -
objetoOrigenFF. :
,FF: ; 
MouseButtonEventArgsFF< P
eventoFFQ W
)FFW X
{GG 	
ifHH 
(HH 
typeofHH 
(HH 
PaginaInicioSesionHH )
)HH) *
.HH* +
IsInstanceOfTypeHH+ ;
(HH; <
VentanaPrincipalHH< L
.HHL M
PaginaAnteriorHHM [
)HH[ \
)HH\ ]
{II 
VentanaPrincipalJJ  
.JJ  !
CambiarPaginaJJ! .
(JJ. /
newJJ/ 2
PaginaInicioSesionJJ3 E
(JJE F
)JJF G
)JJG H
;JJH I
}KK 
elseLL 
{MM 
VentanaPrincipalNN  
.NN  !
CambiarPaginaNN! .
(NN. /
newNN/ 2
PaginaMenuPrincipalNN3 F
(NNF G
)NNG H
)NNH I
;NNI J
}OO 
}PP 	
privateRR 
voidRR )
CajaDeOpcionesDeIdiomaCerradaRR 2
(RR2 3
objectRR3 9
objetoOrigenRR: F
,RRF G
	EventArgsRRH Q
eventoRRR X
)RRX Y
{SS 	
AppTT 
.TT 
CurrentTT 
.TT 
CambiarIdiomaTT %
(TT% &
idiomaTT& ,
)TT, -
;TT- .!
RefrescarPaginaActualUU !
(UU! "
)UU" #
;UU# $
}VV 	
privateXX 
voidXX 
ActivarMusicaXX "
(XX" #
objectXX# )
objetoOrigenXX* 6
,XX6 7
RoutedEventArgsXX8 G
eventoXXH N
)XXN O
{YY 	
ifZZ 
(ZZ 
!ZZ )
hayMusicaActivadaInicialmenteZZ .
)ZZ. /
{[[ 
App\\ 
.\\ 
Current\\ 
.\\ 
EstadoMusica\\ (
(\\( )
true\\) -
)\\- .
;\\. /
}]] 
}^^ 	
private`` 
void`` 
DesactivarMusica`` %
(``% &
object``& ,
objetoOrigen``- 9
,``9 :
RoutedEventArgs``; J
evento``K Q
)``Q R
{aa 	
Appbb 
.bb 
Currentbb 
.bb 
EstadoMusicabb $
(bb$ %
falsebb% *
)bb* +
;bb+ ,
}cc 	
}dd 
}ee ��
{C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaAmistades.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class 
PaginaAmistades (
:) *
Page+ /
,/ 0&
IServicioAmistadesCallback1 K
{ 
private  
ObservableCollection $
<$ %
Dominio% ,
., -
CuentaJugador- :
>: ;
cuentasDeAmigos< K
;K L
private  
ObservableCollection $
<$ %
Dominio% ,
., -
CuentaJugador- :
>: ; 
cuentasDeSolicitudes< P
;P Q
private #
ServicioAmistadesClient '$
clienteServicioAmistades( @
;@ A
public  
ObservableCollection #
<# $
Dominio$ +
.+ ,
CuentaJugador, 9
>9 :
CuentasDeAmigos; J
{ 	
get 
{ 
return 
cuentasDeAmigos (
;( )
}* +
set 
{ 
cuentasDeAmigos !
=" #
value$ )
;) *
}+ ,
} 	
public  
ObservableCollection #
<# $
Dominio$ +
.+ ,
CuentaJugador, 9
>9 : 
CuentasDeSolicitudes; O
{ 	
get 
{ 
return  
cuentasDeSolicitudes -
;- .
}/ 0
set 
{  
cuentasDeSolicitudes &
=' (
value) .
;. /
}0 1
} 	
public 
PaginaAmistades 
( 
bool #
inicializarDatos$ 4
)4 5
{   	
if!! 
(!! 
inicializarDatos!!  
)!!  !
{"" 
InitializeComponent## #
(### $
)##$ %
;##% &
listaAmigos$$ 
.$$ 
DataContext$$ '
=$$( )
this$$* .
;$$. /
listaSolicitudes%%  
.%%  !
DataContext%%! ,
=%%- .
this%%/ 3
;%%3 4$
clienteServicioAmistades&& (
=&&) *
new&&+ .#
ServicioAmistadesClient&&/ F
(&&F G
new&&G J
InstanceContext&&K Z
(&&Z [
this&&[ _
)&&_ `
)&&` a
;&&a b
CargarAmigosJugador'' #
(''# $
)''$ %
;''% &0
$CargarJugadoresConSolicitudPendiente(( 4
(((4 5
)((5 6
;((6 7+
SuscribirJugadorANotificaciones)) /
())/ 0
)))0 1
;))1 2
}** 
}++ 	
private-- 
void-- 
CargarAmigosJugador-- (
(--( )
)--) *
{.. 	
cuentasDeAmigos// 
=// 
new// ! 
ObservableCollection//" 6
<//6 7
Dominio//7 >
.//> ?
CuentaJugador//? L
>//L M
(//M N
)//N O
;//O P
CuentaJugador00 
[00 
]00 
amigosObtenidos00 +
=00, -
	Servicios00. 7
.007 8
ServicioAmistades008 I
.00I J"
ObtenerAmigosDeJugador11 &
(11& '
Dominio11' .
.11. /
CuentaJugador11/ <
.11< =
Actual11= C
.11C D
NombreJugador11D Q
)11Q R
;11R S
if33 
(33 
amigosObtenidos33 
!=33  "
null33# '
&&33( *
amigosObtenidos33+ :
.33: ;
Count33; @
(33@ A
)33A B
>33C D
$num33E F
)33F G
{44 
foreach55 
(55 
CuentaJugador55 &
amigo55' ,
in55- /
amigosObtenidos550 ?
)55? @
{66 
Dominio77 
.77 
CuentaJugador77 )
cuentaAmigo77* 5
=776 7
new778 ;
Dominio77< C
.77C D
CuentaJugador77D Q
{88 
NombreJugador99 %
=99& '
amigo99( -
.99- .
NombreJugador99. ;
,99; <
NumeroAvatar:: $
=::% &
amigo::' ,
.::, -
NumeroAvatar::- 9
,::9 :
FuenteImagenAvatar;; *
=;;+ ,

Utilidades;;- 7
.;;7 8
GeneradorImagenes;;8 I
.;;I J%
GenerarFuenteImagenAvatar<< 5
(<<5 6
amigo<<6 ;
.<<; <
NumeroAvatar<<< H
)<<H I
,<<I J#
ColorEstadoConectividad== /
===0 1/
#ObtenerColorSegunEstadoConectividad==2 U
(==U V
amigo>> !
.>>! "
EstadoConectividad>>" 4
)>>4 5
,>>5 6
}?? 
;?? 
cuentasDeAmigos@@ #
.@@# $
Add@@$ '
(@@' (
cuentaAmigo@@( 3
)@@3 4
;@@4 5
}AA 
}BB 
}CC 	
privateEE 
voidEE 0
$CargarJugadoresConSolicitudPendienteEE 9
(EE9 :
)EE: ;
{FF 	 
cuentasDeSolicitudesGG  
=GG! "
newGG# & 
ObservableCollectionGG' ;
<GG; <
DominioGG< C
.GGC D
CuentaJugadorGGD Q
>GGQ R
(GGR S
)GGS T
;GGT U
CuentaJugadorHH 
[HH 
]HH 
jugadoresObtenidosHH .
=HH/ 0
	ServiciosHH1 :
.HH: ;
ServicioAmistadesHH; L
.HHL M1
%ObtenerJugadoresConSolicitudPendienteII 5
(II5 6
DominioII6 =
.II= >
CuentaJugadorII> K
.IIK L
ActualIIL R
.IIR S
NombreJugadorIIS `
)II` a
;IIa b
ifKK 
(KK 
jugadoresObtenidosKK "
!=KK# %
nullKK& *
&&KK+ -
jugadoresObtenidosKK. @
.KK@ A
CountKKA F
(KKF G
)KKG H
>KKI J
$numKKK L
)KKL M
{LL 
foreachMM 
(MM 
CuentaJugadorMM &
jugadorMM' .
inMM/ 1
jugadoresObtenidosMM2 D
)MMD E
{NN 
DominioOO 
.OO 
CuentaJugadorOO )
cuentaSolicitudOO* 9
=OO: ;
newOO< ?
DominioOO@ G
.OOG H
CuentaJugadorOOH U
{PP 
NombreJugadorQQ %
=QQ& '
jugadorQQ( /
.QQ/ 0
NombreJugadorQQ0 =
,QQ= >
NumeroAvatarRR $
=RR% &
jugadorRR' .
.RR. /
NumeroAvatarRR/ ;
,RR; <
FuenteImagenAvatarSS *
=SS+ ,

UtilidadesSS- 7
.SS7 8
GeneradorImagenesSS8 I
.SSI J%
GenerarFuenteImagenAvatarTT 5
(TT5 6
jugadorTT6 =
.TT= >
NumeroAvatarTT> J
)TTJ K
,TTK L#
ColorEstadoConectividadUU /
=UU0 1/
#ObtenerColorSegunEstadoConectividadUU2 U
(UUU V
jugadorVV #
.VV# $
EstadoConectividadVV$ 6
)VV6 7
,VV7 8
}WW 
;WW  
cuentasDeSolicitudesXX (
.XX( )
AddXX) ,
(XX, -
cuentaSolicitudXX- <
)XX< =
;XX= >
}YY 
}ZZ 
}[[ 	
private]] 
void]] +
SuscribirJugadorANotificaciones]] 4
(]]4 5
)]]5 6
{^^ 	
try__ 
{`` $
clienteServicioAmistadesaa (
.aa( )4
(SuscribirJugadorANotificacionesAmistadesaa) Q
(aaQ R
Dominiobb 
.bb 
CuentaJugadorbb (
.bb( )
Actualbb) /
.bb/ 0
NombreJugadorbb0 =
)bb= >
;bb> ?
}cc 
catchdd 
(dd %
EndpointNotFoundExceptiondd ,
	excepciondd- 6
)dd6 7
{ee 

MessageBoxgg 
.gg 
Showgg 
(gg  

Propertiesgg  *
.gg* +
	Resourcesgg+ 4
.gg4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEhh :
,hh: ;

Propertieshh< F
.hhF G
	ResourceshhG P
.hhP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOii 9
,ii9 :
MessageBoxButtonjj $
.jj$ %
OKjj% '
,jj' (
MessageBoxImagejj) 8
.jj8 9
Errorjj9 >
)jj> ?
;jj? @$
clienteServicioAmistadeskk (
.kk( )
Abortkk) .
(kk. /
)kk/ 0
;kk0 1
}ll 
catchmm 
(mm /
#CommunicationObjectFaultedExceptionmm 6
	excepcionmm7 @
)mm@ A
{nn 

MessageBoxpp 
.pp 
Showpp 
(pp  

Propertiespp  *
.pp* +
	Resourcespp+ 4
.pp4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEqq :
,qq: ;

Propertiesqq< F
.qqF G
	ResourcesqqG P
.qqP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOrr 9
,rr9 :
MessageBoxButtonss $
.ss$ %
OKss% '
,ss' (
MessageBoxImagess) 8
.ss8 9
Errorss9 >
)ss> ?
;ss? @$
clienteServicioAmistadestt (
.tt( )
Aborttt) .
(tt. /
)tt/ 0
;tt0 1
}uu 
catchvv 
(vv 
TimeoutExceptionvv #
	excepcionvv$ -
)vv- .
{ww 

MessageBoxyy 
.yy 
Showyy 
(yy  

Propertiesyy  *
.yy* +
	Resourcesyy+ 4
.yy4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEzz :
,zz: ;

Propertieszz< F
.zzF G
	ResourceszzG P
.zzP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO{{ 9
,{{9 :
MessageBoxButton|| $
.||$ %
OK||% '
,||' (
MessageBoxImage||) 8
.||8 9
Error||9 >
)||> ?
;||? @$
clienteServicioAmistades}} (
.}}( )
Abort}}) .
(}}. /
)}}/ 0
;}}0 1
}~~ 
} 	
private
�� 
SolidColorBrush
�� 1
#ObtenerColorSegunEstadoConectividad
��  C
(
��C D'
EstadoConectividadJugador
�� %
estado
��& ,
)
��, -
{
�� 	
SolidColorBrush
�� 
color
�� !
;
��! "
switch
�� 
(
�� 
estado
�� 
)
�� 
{
�� 
case
�� '
EstadoConectividadJugador
�� .
.
��. /
	Conectado
��/ 8
:
��8 9
color
�� 
=
�� 
Brushes
�� #
.
��# $
Green
��$ )
;
��) *
break
�� 
;
�� 
case
�� '
EstadoConectividadJugador
�� .
.
��. /
	EnPartida
��/ 8
:
��8 9
color
�� 
=
�� 
Brushes
�� #
.
��# $
Red
��$ '
;
��' (
break
�� 
;
�� 
default
�� 
:
�� 
color
�� 
=
�� 
Brushes
�� #
.
��# $
Gray
��$ (
;
��( )
break
�� 
;
�� 
}
�� 
return
�� 
color
�� 
;
�� 
}
�� 	
private
�� 
bool
�� (
EsElNombreDelJugadorActual
�� /
(
��/ 0
)
��0 1
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
string
�� "
nombreJugadorDestino
�� '
=
��( )0
"cuadroTextoNombreUsuarioInvitacion
��* L
.
��L M
Text
��M Q
;
��Q R
if
�� 
(
�� 
Dominio
�� 
.
�� 
CuentaJugador
�� %
.
��% &
Actual
��& ,
.
��, -
NombreJugador
��- :
.
��: ;
Equals
��; A
(
��A B"
nombreJugadorDestino
��B V
)
��V W
)
��W X
{
�� 
	resultado
�� 
=
�� 
true
��  
;
��  !

MessageBox
�� 
.
�� 
Show
�� 
(
��  
$str
��  O
+
��P Q
$str
�� I
,
��I J
$str
�� :
,
��: ;
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
private
�� 
bool
�� &
ExisteSolicitudDeAmistad
�� -
(
��- .
)
��. /
{
�� 	
string
�� !
nombreJugadorOrigen
�� &
=
��' (
Dominio
��) 0
.
��0 1
CuentaJugador
��1 >
.
��> ?
Actual
��? E
.
��E F
NombreJugador
��F S
;
��S T
string
�� "
nombreJugadorDestino
�� '
=
��( )0
"cuadroTextoNombreUsuarioInvitacion
��* L
.
��L M
Text
��M Q
;
��Q R
bool
�� '
existeSolicitudSinAceptar
�� *
=
��+ ,
	Servicios
��- 6
.
��6 7
ServicioAmistades
��7 H
.
��H I$
ExisteSolicitudAmistad
�� &
(
��& '!
nombreJugadorOrigen
��' :
,
��: ;"
nombreJugadorDestino
��< P
)
��P Q
;
��Q R
if
�� 
(
�� '
existeSolicitudSinAceptar
�� )
)
��) *
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  
$str
��  S
+
��T U
$str
�� Y
,
��Y Z
$str
�� :
,
��: ;
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
}
�� 
return
�� '
existeSolicitudSinAceptar
�� ,
;
��, -
}
�� 	
private
�� 
bool
�� %
ExisteAmistadConJugador
�� ,
(
��, -
)
��- .
{
�� 	
string
�� !
nombreJugadorOrigen
�� &
=
��' (
Dominio
��) 0
.
��0 1
CuentaJugador
��1 >
.
��> ?
Actual
��? E
.
��E F
NombreJugador
��F S
;
��S T
string
�� "
nombreJugadorDestino
�� '
=
��( )0
"cuadroTextoNombreUsuarioInvitacion
��* L
.
��L M
Text
��M Q
;
��Q R
bool
�� 
existeAmistad
�� 
=
��  
	Servicios
��! *
.
��* +
ServicioAmistades
��+ <
.
��< =%
ExisteAmistadConJugador
��= T
(
��T U!
nombreJugadorOrigen
�� #
,
��# $"
nombreJugadorDestino
��% 9
)
��9 :
;
��: ;
if
�� 
(
�� 
existeAmistad
�� 
)
�� 
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  
$str
��  S
+
��T U
$str
�� /
,
��/ 0
$str
��1 W
,
��W X
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
}
�� 
return
�� 
existeAmistad
��  
;
��  !
}
�� 	
private
�� 
void
�� $
IrAPaginaMenuPrincipal
�� +
(
��+ ,
object
��, 2
objetoOrigen
��3 ?
,
��? @"
MouseButtonEventArgs
��A U
evento
��V \
)
��\ ]
{
�� 	
VentanaPrincipal
�� 
.
�� 
CambiarPagina
�� *
(
��* +
new
��+ .!
PaginaMenuPrincipal
��/ B
(
��B C
)
��C D
)
��D E
;
��E F
}
�� 	
private
�� 
void
�� &
EnviarSolicitudDeAmistad
�� -
(
��- .
object
��. 4
objetoOrigen
��5 A
,
��A B
RoutedEventArgs
��C R
evento
��S Y
)
��Y Z
{
�� 	
if
�� 
(
�� 
!
�� (
EsElNombreDelJugadorActual
�� +
(
��+ ,
)
��, -
&&
��. 0
	Servicios
��1 :
.
��: ;
ServicioJugador
��; J
.
��J K!
ExisteNombreJugador
�� #
(
��# $0
"cuadroTextoNombreUsuarioInvitacion
��$ F
.
��F G
Text
��G K
)
��K L
&&
��M O
!
�� &
ExisteSolicitudDeAmistad
�� )
(
��) *
)
��* +
&&
��, .
!
��/ 0%
ExisteAmistadConJugador
��0 G
(
��G H
)
��H I
)
��I J
{
�� 
string
�� !
nombreJugadorOrigen
�� *
=
��+ ,
Dominio
��- 4
.
��4 5
CuentaJugador
��5 B
.
��B C
Actual
��C I
.
��I J
NombreJugador
��J W
;
��W X
string
�� "
nombreJugadorDestino
�� +
=
��, -0
"cuadroTextoNombreUsuarioInvitacion
��. P
.
��P Q
Text
��Q U
;
��U V
bool
�� %
envioSolicitudRealizado
�� ,
=
��- .
false
��/ 4
;
��4 5
try
�� 
{
�� %
envioSolicitudRealizado
�� +
=
��, -&
clienteServicioAmistades
��. F
.
��F G&
EnviarSolicitudDeAmistad
�� 0
(
��0 1!
nombreJugadorOrigen
��1 D
,
��D E"
nombreJugadorDestino
��F Z
)
��Z [
;
��[ \
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� 0
	excepcion
��1 :
)
��: ;
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $

Properties
��$ .
.
��. /
	Resources
��/ 8
.
��8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� >
,
��> ?

Properties
��@ J
.
��J K
	Resources
��K T
.
��T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� =
,
��= >
MessageBoxButton
�� (
.
��( )
OK
��) +
,
��+ ,
MessageBoxImage
��- <
.
��< =
Error
��= B
)
��B C
;
��C D&
clienteServicioAmistades
�� ,
.
��, -
Abort
��- 2
(
��2 3
)
��3 4
;
��4 5
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� :
	excepcion
��; D
)
��D E
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $

Properties
��$ .
.
��. /
	Resources
��/ 8
.
��8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� >
,
��> ?

Properties
��@ J
.
��J K
	Resources
��K T
.
��T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� =
,
��= >
MessageBoxButton
�� (
.
��( )
OK
��) +
,
��+ ,
MessageBoxImage
��- <
.
��< =
Error
��= B
)
��B C
;
��C D&
clienteServicioAmistades
�� ,
.
��, -
Abort
��- 2
(
��2 3
)
��3 4
;
��4 5
}
�� 
catch
�� 
(
�� 
TimeoutException
�� '
	excepcion
��( 1
)
��1 2
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $

Properties
��$ .
.
��. /
	Resources
��/ 8
.
��8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� >
,
��> ?

Properties
��@ J
.
��J K
	Resources
��K T
.
��T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� =
,
��= >
MessageBoxButton
�� (
.
��( )
OK
��) +
,
��+ ,
MessageBoxImage
��- <
.
��< =
Error
��= B
)
��B C
;
��C D&
clienteServicioAmistades
�� ,
.
��, -
Abort
��- 2
(
��2 3
)
��3 4
;
��4 5
}
�� 
if
�� 
(
�� %
envioSolicitudRealizado
�� +
)
��+ ,
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $
$str
��$ Y
,
��Y Z
$str
�� 6
,
��6 7
MessageBoxButton
�� (
.
��( )
OK
��) +
,
��+ ,
MessageBoxImage
��- <
.
��< =
Information
��= H
)
��H I
;
��I J
}
�� 
else
�� 
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $
$str
��$ Y
,
��Y Z
$str
�� >
,
��> ?
MessageBoxButton
�� (
.
��( )
OK
��) +
,
��+ ,
MessageBoxImage
��- <
.
��< =
Error
��= B
)
��B C
;
��C D
}
�� 
}
�� 
}
�� 	
private
�� 
void
�� 
EliminarAmigo
�� "
(
��" #
object
��# )
objetoOrigen
��* 6
,
��6 7
RoutedEventArgs
��8 G
evento
��H N
)
��N O
{
�� 	
var
�� 

filaActual
�� 
=
�� 
(
�� 
ListBoxItem
�� )
)
��) *
listaAmigos
��* 5
.
��5 6"
ContainerFromElement
��6 J
(
��J K
(
�� 
Button
�� 
)
�� 
objetoOrigen
�� $
)
��$ %
;
��% &

filaActual
�� 
.
�� 

IsSelected
�� !
=
��" #
true
��$ (
;
��( )
var
�� !
jugadorSeleccionado
�� #
=
��$ %
(
��& '
Dominio
��' .
.
��. /
CuentaJugador
��/ <
)
��< =
listaAmigos
��= H
.
��H I
SelectedItem
��I U
;
��U V
string
�� 
nombreJugadorA
�� !
=
��" #
Dominio
��$ +
.
��+ ,
CuentaJugador
��, 9
.
��9 :
Actual
��: @
.
��@ A
NombreJugador
��A N
;
��N O
string
�� 
nombreJugadorB
�� !
=
��" #!
jugadorSeleccionado
��$ 7
.
��7 8
NombreJugador
��8 E
;
��E F
bool
�� "
eliminacionRealizada
�� %
=
��& '
false
��( -
;
��- .
try
�� 
{
�� "
eliminacionRealizada
�� $
=
��% &&
clienteServicioAmistades
��' ?
.
��? @+
EliminarAmistadEntreJugadores
�� 1
(
��1 2
nombreJugadorA
��2 @
,
��@ A
nombreJugadorB
��B P
)
��P Q
;
��Q R
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
if
�� 
(
�� "
eliminacionRealizada
�� $
)
��$ %
{
�� 
cuentasDeAmigos
�� 
.
��  
Remove
��  &
(
��& '!
jugadorSeleccionado
��' :
)
��: ;
;
��; <
}
�� 
else
�� 
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  
$str
��  Y
,
��Y Z
$str
�� -
,
��- .
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
}
�� 
}
�� 	
private
�� 
void
�� '
AceptarSolicitudDeAmistad
�� .
(
��. /
object
��/ 5
objetoOrigen
��6 B
,
��B C
RoutedEventArgs
�� 
evento
�� "
)
��" #
{
�� 	
var
�� 

filaActual
�� 
=
�� 
(
�� 
ListBoxItem
�� )
)
��) *
listaSolicitudes
��* :
.
��: ;"
ContainerFromElement
��; O
(
��O P
(
�� 
Button
�� 
)
�� 
objetoOrigen
�� $
)
��$ %
;
��% &

filaActual
�� 
.
�� 

IsSelected
�� !
=
��" #
true
��$ (
;
��( )
var
�� !
jugadorSeleccionado
�� #
=
��$ %
(
��& '
Dominio
��' .
.
��. /
CuentaJugador
��/ <
)
��< =
listaSolicitudes
��= M
.
��M N
SelectedItem
��N Z
;
��Z [
bool
�� 
solicitudAceptada
�� "
=
��# $
false
��% *
;
��* +
if
�� 
(
�� !
jugadorSeleccionado
�� #
!=
��$ &
null
��' +
)
��+ ,
{
�� 
string
�� !
nombreJugadorOrigen
�� *
=
��+ ,!
jugadorSeleccionado
��- @
.
��@ A
NombreJugador
��A N
;
��N O
string
�� "
nombreJugadorDestino
�� +
=
��, -
Dominio
��. 5
.
��5 6
CuentaJugador
��6 C
.
��C D
Actual
��D J
.
��J K
NombreJugador
��K X
;
��X Y
try
�� 
{
�� 
solicitudAceptada
�� %
=
��& '&
clienteServicioAmistades
��( @
.
��@ A'
AceptarSolicitudDeAmistad
��A Z
(
��Z [!
nombreJugadorOrigen
�� +
,
��+ ,"
nombreJugadorDestino
��- A
)
��A B
;
��B C
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� 0
	excepcion
��1 :
)
��: ;
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $

Properties
��$ .
.
��. /
	Resources
��/ 8
.
��8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� >
,
��> ?

Properties
��@ J
.
��J K
	Resources
��K T
.
��T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� =
,
��= >
MessageBoxButton
�� (
.
��( )
OK
��) +
,
��+ ,
MessageBoxImage
��- <
.
��< =
Error
��= B
)
��B C
;
��C D&
clienteServicioAmistades
�� ,
.
��, -
Abort
��- 2
(
��2 3
)
��3 4
;
��4 5
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� :
	excepcion
��; D
)
��D E
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $

Properties
��$ .
.
��. /
	Resources
��/ 8
.
��8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� >
,
��> ?

Properties
��@ J
.
��J K
	Resources
��K T
.
��T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� =
,
��= >
MessageBoxButton
�� (
.
��( )
OK
��) +
,
��+ ,
MessageBoxImage
��- <
.
��< =
Error
��= B
)
��B C
;
��C D&
clienteServicioAmistades
�� ,
.
��, -
Abort
��- 2
(
��2 3
)
��3 4
;
��4 5
}
�� 
catch
�� 
(
�� 
TimeoutException
�� '
	excepcion
��( 1
)
��1 2
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $

Properties
��$ .
.
��. /
	Resources
��/ 8
.
��8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� >
,
��> ?

Properties
��@ J
.
��J K
	Resources
��K T
.
��T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� =
,
��= >
MessageBoxButton
�� (
.
��( )
OK
��) +
,
��+ ,
MessageBoxImage
��- <
.
��< =
Error
��= B
)
��B C
;
��C D&
clienteServicioAmistades
�� ,
.
��, -
Abort
��- 2
(
��2 3
)
��3 4
;
��4 5
}
�� 
}
�� 
if
�� 
(
�� 
solicitudAceptada
�� !
)
��! "
{
�� "
cuentasDeSolicitudes
�� $
.
��$ %
Remove
��% +
(
��+ ,!
jugadorSeleccionado
��, ?
)
��? @
;
��@ A
cuentasDeAmigos
�� 
.
��  
Add
��  #
(
��# $!
jugadorSeleccionado
��$ 7
)
��7 8
;
��8 9
}
�� 
else
�� 
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  
$str
��  ^
,
��^ _
$str
�� ;
,
��; <
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @
}
�� 
}
�� 	
private
�� 
void
�� (
RechazarSolicitudDeAmistad
�� /
(
��/ 0
object
��0 6
objetoOrigen
��7 C
,
��C D
RoutedEventArgs
��E T
evento
��U [
)
��[ \
{
�� 	
var
�� 

filaActual
�� 
=
�� 
(
�� 
ListBoxItem
�� )
)
��) *
listaSolicitudes
��* :
.
��: ;"
ContainerFromElement
��; O
(
��O P
(
�� 
Button
�� 
)
�� 
objetoOrigen
�� $
)
��$ %
;
��% &

filaActual
�� 
.
�� 

IsSelected
�� !
=
��" #
true
��$ (
;
��( )
var
�� !
jugadorSeleccionado
�� #
=
��$ %
(
��& '
Dominio
��' .
.
��. /
CuentaJugador
��/ <
)
��< =
listaSolicitudes
��= M
.
��M N
SelectedItem
��N Z
;
��Z [
string
�� !
nombreJugadorOrigen
�� &
=
��' (!
jugadorSeleccionado
��) <
.
��< =
NombreJugador
��= J
;
��J K
string
�� "
nombreJugadorDestino
�� '
=
��( )
Dominio
��* 1
.
��1 2
CuentaJugador
��2 ?
.
��? @
Actual
��@ F
.
��F G
NombreJugador
��G T
;
��T U
bool
��  
solicitudRechazada
�� #
=
��$ %
false
��& +
;
��+ ,
try
�� 
{
��  
solicitudRechazada
�� "
=
��# $&
clienteServicioAmistades
��% =
.
��= >(
RechazarSolicitudDeAmistad
��> X
(
��X Y!
nombreJugadorOrigen
�� '
,
��' ("
nombreJugadorDestino
��) =
)
��= >
;
��> ?
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
if
�� 
(
��  
solicitudRechazada
�� "
)
��" #
{
�� "
cuentasDeSolicitudes
�� $
.
��$ %
Remove
��% +
(
��+ ,!
jugadorSeleccionado
��, ?
)
��? @
;
��@ A
}
�� 
else
�� 
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  
$str
��  _
,
��_ `
$str
�� <
,
��< =
MessageBoxButton
�� %
.
��% &
OK
��& (
,
��( )
MessageBoxImage
��* 9
.
��9 :
Error
��: ?
)
��? @
;
��@ A
}
�� 
}
�� 	
public
�� 
void
�� 2
$NotificarEstadoConectividadDeJugador
�� 8
(
��8 9
string
��9 ?
nombreJugador
��@ M
,
��M N'
EstadoConectividadJugador
�� %
estado
��& ,
)
��, -
{
�� 	
if
�� 
(
�� 
cuentasDeAmigos
�� 
!=
��  "
null
��# '
)
��' (
{
�� 
var
�� %
cuentaAmigoModificacion
�� +
=
��, -
cuentasDeAmigos
��. =
.
��= >
Where
��> C
(
��C D
amigo
��D I
=>
��J L
amigo
�� 
.
�� 
NombreJugador
�� '
==
��( *
nombreJugador
��+ 8
)
��8 9
.
��9 :
FirstOrDefault
��: H
(
��H I
)
��I J
;
��J K
cuentasDeAmigos
�� 
.
��  
Remove
��  &
(
��& '%
cuentaAmigoModificacion
��' >
)
��> ?
;
��? @
if
�� 
(
�� %
cuentaAmigoModificacion
�� +
!=
��, .
null
��/ 3
)
��3 4
{
�� %
cuentaAmigoModificacion
�� +
.
��+ ,%
ColorEstadoConectividad
��, C
=
��D E1
#ObtenerColorSegunEstadoConectividad
�� ;
(
��; <
estado
��< B
)
��B C
;
��C D
}
�� 
cuentasDeAmigos
�� 
.
��  
Insert
��  &
(
��& '
$num
��' (
,
��( )%
cuentaAmigoModificacion
��* A
)
��A B
;
��B C
}
�� 
}
�� 	
public
�� 
void
�� .
 NotificarSolicitudAmistadEnviada
�� 4
(
��4 5
CuentaJugador
��5 B"
cuentaNuevaSolicitud
��C W
)
��W X
{
�� 	
if
�� 
(
�� "
cuentasDeSolicitudes
�� $
!=
��% '
null
��( ,
)
��, -
{
�� "
cuentasDeSolicitudes
�� $
.
��$ %
Add
��% (
(
��( )
new
��) ,
Dominio
��- 4
.
��4 5
CuentaJugador
��5 B
{
�� 
NombreJugador
�� !
=
��" #"
cuentaNuevaSolicitud
��$ 8
.
��8 9
NombreJugador
��9 F
,
��F G
NumeroAvatar
��  
=
��! ""
cuentaNuevaSolicitud
��# 7
.
��7 8
NumeroAvatar
��8 D
,
��D E 
FuenteImagenAvatar
�� &
=
��' (

Utilidades
��) 3
.
��3 4
GeneradorImagenes
��4 E
.
��E F'
GenerarFuenteImagenAvatar
�� 1
(
��1 2"
cuentaNuevaSolicitud
��2 F
.
��F G
NumeroAvatar
��G S
)
��S T
,
��T U%
ColorEstadoConectividad
�� +
=
��, -1
#ObtenerColorSegunEstadoConectividad
��. Q
(
��Q R"
cuentaNuevaSolicitud
�� ,
.
��, - 
EstadoConectividad
��- ?
)
��? @
}
�� 
)
�� 
;
�� 
}
�� 
}
�� 	
public
�� 
void
�� /
!NotificarSolicitudAmistadAceptada
�� 5
(
��5 6
CuentaJugador
��6 C
cuentaNuevoAmigo
��D T
)
��T U
{
�� 	
if
�� 
(
�� 
cuentasDeAmigos
�� 
!=
��  "
null
��# '
)
��' (
{
�� 
var
�� &
solicitudAmistadResidual
�� ,
=
��- ."
cuentasDeSolicitudes
��/ C
.
��C D
Where
��D I
(
��I J
cuentaSolicitud
��J Y
=>
��Z \
cuentaSolicitud
�� #
.
��# $
NombreJugador
��$ 1
==
��2 4
cuentaNuevoAmigo
�� $
.
��$ %
NombreJugador
��% 2
)
��2 3
.
��3 4
FirstOrDefault
��4 B
(
��B C
)
��C D
;
��D E
if
�� 
(
�� &
solicitudAmistadResidual
�� ,
!=
��- /
null
��0 4
)
��4 5
{
�� "
cuentasDeSolicitudes
�� (
.
��( )
Remove
��) /
(
��/ 0&
solicitudAmistadResidual
��0 H
)
��H I
;
��I J
}
�� 
cuentasDeAmigos
�� 
.
��  
Add
��  #
(
��# $
new
��$ '
Dominio
��( /
.
��/ 0
CuentaJugador
��0 =
{
�� 
NombreJugador
�� !
=
��" #
cuentaNuevoAmigo
��$ 4
.
��4 5
NombreJugador
��5 B
,
��B C
NumeroAvatar
��  
=
��! "
cuentaNuevoAmigo
��# 3
.
��3 4
NumeroAvatar
��4 @
,
��@ A 
FuenteImagenAvatar
�� &
=
��' (

Utilidades
��) 3
.
��3 4
GeneradorImagenes
��4 E
.
��E F'
GenerarFuenteImagenAvatar
�� 1
(
��1 2
cuentaNuevoAmigo
��2 B
.
��B C
NumeroAvatar
��C O
)
��O P
,
��P Q%
ColorEstadoConectividad
�� +
=
��, -1
#ObtenerColorSegunEstadoConectividad
��. Q
(
��Q R
cuentaNuevoAmigo
�� (
.
��( ) 
EstadoConectividad
��) ;
)
��; <
}
�� 
)
�� 
;
�� 
}
�� 
}
�� 	
public
�� 
void
�� '
NotificarAmistadEliminada
�� -
(
��- .
string
��. 4$
nombreAmigoEliminacion
��5 K
)
��K L
{
�� 	
if
�� 
(
�� 
cuentasDeAmigos
�� 
!=
��  "
null
��# '
)
��' (
{
�� 
var
�� $
cuentaAmigoEliminacion
�� *
=
��+ ,
cuentasDeAmigos
��- <
.
��< =
Where
��= B
(
��B C
amigo
��C H
=>
��I K
amigo
�� 
.
�� 
NombreJugador
�� '
==
��( *$
nombreAmigoEliminacion
��+ A
)
��A B
.
��B C
FirstOrDefault
��C Q
(
��Q R
)
��R S
;
��S T
if
�� 
(
�� $
cuentaAmigoEliminacion
�� *
!=
��+ -
null
��. 2
)
��2 3
{
�� 
cuentasDeAmigos
�� #
.
��# $
Remove
��$ *
(
��* +$
cuentaAmigoEliminacion
��+ A
)
��A B
;
��B C
}
�� 
}
�� 
}
�� 	
private
�� 
void
�� 0
"DesuscribirJugadorDeNotificaciones
�� 7
(
��7 8
object
��8 >
objetoOrigen
��? K
,
��K L
RoutedEventArgs
�� 
evento
�� "
)
��" #
{
�� 	
try
�� 
{
�� &
clienteServicioAmistades
�� (
.
��( )9
+DesuscribirJugadorDeNotificacionesAmistades
��) T
(
��T U
Dominio
�� 
.
�� 
CuentaJugador
�� )
.
��) *
Actual
��* 0
.
��0 1
NombreJugador
��1 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Close
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @&
clienteServicioAmistades
�� (
.
��( )
Abort
��) .
(
��. /
)
��/ 0
;
��0 1
}
�� 
}
�� 	
}
�� 
}�� �
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaModificacionJugadoresSala.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class +
PaginaModificacionJugadoresSala 8
:9 :
Page; ?
{ 
public +
PaginaModificacionJugadoresSala .
(. /
)/ 0
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
} 
} �.
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaCodigoRestablecimientoContrasena.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public		 

partial		 
class		 2
&PaginaCodigoRestablecimientoContrasena		 ?
:		@ A
Page		B F
{

 
private 
readonly 
string 
correoDestino  -
;- .
public 2
&PaginaCodigoRestablecimientoContrasena 5
(5 6
string6 <
correoDestino= J
)J K
{ 	
InitializeComponent 
(  
)  !
;! "
this 
. 
correoDestino 
=  
correoDestino! .
;. /
EnviarCodigo 
( 
) 
; 
} 	
private 
void 
EnviarCodigo !
(! "
)" #
{ 	
bool "
envioDeCodigoRealizado '
=( )#
GestionadorCodigoCorreo* A
.A B2
&EnviarNuevoCodigoDeVerificacionACorreo 6
(6 7
correoDestino7 D
,D E

PropertiesF P
.P Q
	ResourcesQ Z
.Z [2
&ETIQUETA_CODIGO_CODIGORESTABLECIMIENTO 6
,6 7

Properties8 B
.B C
	ResourcesC L
.L M)
ETIQUETA_RECUPERACION_MENSAJE -
+. /
$"0 2
$str2 3
{3 4#
GestionadorCodigoCorreo4 K
.K L
CodigoGeneradoL Z
}Z [
"[ \
)\ ]
;] ^
if 
( 
! "
envioDeCodigoRealizado '
)' (
{ 

MessageBox 
. 
Show 
(  

Properties  *
.* +
	Resources+ 4
.4 5,
 ETIQUETA_CODIGO_MENSAJENOENVIADO <
,< =

Properties> H
.H I
	ResourcesI R
.R S+
ETIQUETA_CODIGO_CODIGONOENVIADO ;
,; <
MessageBoxButton   ,
.  , -
OK  - /
,  / 0
MessageBoxImage  1 @
.  @ A
Error  A F
)  F G
;  G H
}!! 
}"" 	
private$$ 
void$$ !
IrAPaginaInicioSesion$$ *
($$* +
object$$+ 1
objetoOrigen$$2 >
,$$> ?
RoutedEventArgs$$@ O
evento$$P V
)$$V W
{%% 	
VentanaPrincipal&& 
.&& 
CambiarPagina&& *
(&&* +
new&&+ .
PaginaInicioSesion&&/ A
(&&A B
)&&B C
)&&C D
;&&D E
}'' 	
private)) 
void)) /
#IrAPaginaRestablecimientoContrasena)) 8
())8 9
object))9 ?
objetoOrigen))@ L
,))L M
RoutedEventArgs** 
evento** "
)**" #
{++ 	
string,, 
codigoVerificacion,, %
=,,& '-
!cuadroTextoCodigoRestablecimiento,,( I
.,,I J
Text,,J N
;,,N O
if.. 
(.. 
!.. 
ValidadorDatos.. 
...  
EsCadenaVacia..  -
(..- .
codigoVerificacion... @
)..@ A
)..A B
{// 
bool00 &
codigoVerificacionCoincide00 /
=000 1
ValidadorDatos002 @
.00@ A'
ExisteCoincidenciaEnCadenas00A \
(00\ ]
codigoVerificacion11 &
,11& '#
GestionadorCodigoCorreo11( ?
.11? @
CodigoGenerado11@ N
)11N O
;11O P
if33 
(33 &
codigoVerificacionCoincide33 .
)33. /
{44 
VentanaPrincipal55 $
.55$ %
CambiarPagina55% 2
(552 3
new553 6,
 PaginaRestablecimientoContrasena557 W
(55W X
correoDestino66 %
)66% &
)66& '
;66' (
}77 
else88 
{99 

MessageBox:: 
.:: 
Show:: #
(::# $

Properties::$ .
.::. /
	Resources::/ 8
.::8 93
'ETIQUETA_CODIGO_MENSAJECODIGONOCOINCIDE::9 `
,::` a

Properties;; "
.;;" #
	Resources;;# ,
.;;, -,
 ETIQUETA_CODIGO_CODIGONOCOINCIDE;;- M
,;;M N
MessageBoxButton<< (
.<<( )
OK<<) +
)<<+ ,
;<<, -
}== 
}>> 
}?? 	
privateAA 
voidAA *
AceptarSoloCaracteresNumericosAA 3
(AA3 4
objectAA4 :
objetoOrigenAA; G
,AAG H 
TextChangedEventArgsBB  
eventoBB! '
)BB' (
{CC 	
ifDD 
(DD 
objetoOrigenDD 
isDD 
TextBoxDD  '-
!cuadroTextoCodigoRestablecimientoDD( I
)DDI J
{EE 
stringFF 
textoFF 
=FF -
!cuadroTextoCodigoRestablecimientoFF @
.FF@ A
TextFFA E
=FFF G
newFFH K
stringFFL R
(FFR S-
!cuadroTextoCodigoRestablecimientoGG 5
.GG5 6
TextGG6 :
.GG: ;
WhereGG; @
(GG@ A
charGGA E
.GGE F
IsDigitGGF M
)GGM N
.GGN O
ToArrayGGO V
(GGV W
)GGW X
)GGX Y
;GGY Z-
!cuadroTextoCodigoRestablecimientoHH 1
.HH1 2

CaretIndexHH2 <
=HH= >-
!cuadroTextoCodigoRestablecimientoII 5
.II5 6
TextII6 :
.II: ;
LengthII; A
;IIA B-
!cuadroTextoCodigoRestablecimientoJJ 1
.JJ1 2
TextJJ2 6
=JJ7 8
textoJJ9 >
;JJ> ?
}KK 
}LL 	
}MM 
}NN �!
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaInformacionJugador.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class $
PaginaInformacionJugador 1
:2 3
Page4 8
{		 
public

 $
PaginaInformacionJugador

 '
(

' (
)

( )
{ 	
InitializeComponent 
(  
)  !
;! "
CargarDatosJugador 
( 
)  
;  !
} 	
public 
void 
CargarDatosJugador &
(& '
)' (
{ 	!
etiquetaNombreJugador !
.! "
Content" )
=* +
Dominio, 3
.3 4
CuentaJugador4 A
.A B
ActualB H
.H I
NombreJugadorI V
;V W
imagenAvatarJugador 
.  
Source  &
=' (
Dominio) 0
.0 1
CuentaJugador1 >
.> ?
Actual? E
.E F
FuenteImagenAvatarF X
;X Y"
MostrarPartidasJugadas "
(" #
)# $
;$ %"
MostrarPartidasGanadas "
(" #
)# $
;$ %
} 	
private 
void "
MostrarPartidasJugadas +
(+ ,
), -
{ 	&
cuadroTextoPartidasJugadas &
.& '
Text' +
=, -
Convert. 5
.5 6
ToString6 >
(> ?
	Servicios? H
.H I
ServicioPartidaI X
.X Y(
ObtenerNumeroPartidasJugadas ,
(, -
Dominio- 4
.4 5
CuentaJugador5 B
.B C
ActualC I
.I J
NombreJugadorJ W
)W X
)X Y
;Y Z
} 	
private 
void "
MostrarPartidasGanadas +
(+ ,
), -
{ 	&
cuadroTextoPartidasGanadas   &
.  & '
Text  ' +
=  , -
Convert  . 5
.  5 6
ToString  6 >
(  > ?
	Servicios  ? H
.  H I
ServicioPartida  I X
.  X Y(
ObtenerNumeroPartidasGanadas!! ,
(!!, -
Dominio!!- 4
.!!4 5
CuentaJugador!!5 B
.!!B C
Actual!!C I
.!!I J
NombreJugador!!J W
)!!W X
)!!X Y
;!!Y Z
}"" 	
private$$ 
void$$ ,
 IrAPaginaActualizacionContrasena$$ 5
($$5 6
object$$6 <
objetoOrigen$$= I
,$$I J
RoutedEventArgs$$K Z
evento$$[ a
)$$a b
{%% 	
VentanaPrincipal&& 
.&& 
CambiarPagina&& *
(&&* +
new&&+ .)
PaginaActualizacionContrasena&&/ L
(&&L M
)&&M N
)&&N O
;&&O P
}'' 	
private)) 
void)) -
!IrAPaginaActualizacionInformacion)) 6
())6 7
object))7 =
objetoOrigen))> J
,))J K
RoutedEventArgs))L [
evento))\ b
)))b c
{** 	
VentanaPrincipal++ 
.++ 
CambiarPagina++ *
(++* +
new+++ .*
PaginaActualizacionInformacion++/ M
(++M N
Dominio,, 
.,, 
CuentaJugador,, %
.,,% &
Actual,,& ,
.,,, -
NombreJugador,,- :
,,,: ;
Dominio-- 
.-- 
CuentaJugador-- %
.--% &
Actual--& ,
.--, -
NumeroAvatar--- 9
)--9 :
)--: ;
;--; <
}.. 	
private00 
void00 "
IrAPaginaMenuPrincipal00 +
(00+ ,
object00, 2
objetoOrigen003 ?
,00? @ 
MouseButtonEventArgs00A U
evento00V \
)00\ ]
{11 	
VentanaPrincipal22 
.22 
CambiarPagina22 *
(22* +
new22+ .
PaginaMenuPrincipal22/ B
(22B C
)22C D
)22D E
;22E F
}33 	
}44 
}55 �Y
~C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaInicioSesion.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class 
PaginaInicioSesion +
:, -
Page. 2
{ 
public 
PaginaInicioSesion !
(! "
)" #
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void %
IniciarSesionComoInvitado .
(. /
object/ 5
objetoOrigen6 B
,B C
RoutedEventArgsD S
eventoT Z
)Z [
{ 	
int 
numeroAleatorio 
=  !
new" %
Random& ,
(, -
)- .
.. /
Next/ 3
(3 4
)4 5
;5 6
Dominio 
. 
CuentaJugador !
.! "
Actual" (
=) *
new+ .
Dominio/ 6
.6 7
CuentaJugador7 D
(D E
)E F
{ 
NombreJugador 
= 

Properties  *
.* +
	Resources+ 4
.4 5%
ETIQUETA_GENERAL_INVITADO5 N
+O P
numeroAleatorio #
,# $

EsInvitado 
= 
true !
,! "
}   
;   
VentanaPrincipal!! 
.!! 
CambiarPagina!! *
(!!* +
new!!+ .
PaginaMenuPrincipal!!/ B
(!!B C
)!!C D
)!!D E
;!!E F
}## 	
private%% 
void%% +
IrAPaginaRecuperacionContrasena%% 4
(%%4 5
object%%5 ;
objetoOrigen%%< H
,%%H I 
MouseButtonEventArgs&&  
evento&&! '
)&&' (
{'' 	
VentanaPrincipal(( 
.(( 
CambiarPagina(( *
(((* +
new((+ .(
PaginaRecuperacionContrasena((/ K
(((K L
)((L M
)((M N
;((N O
})) 	
private++ 
void++ $
IrAPaginaRegistroJugador++ -
(++- .
object++. 4
objetoOrigen++5 A
,++A B 
MouseButtonEventArgs++C W
evento++X ^
)++^ _
{,, 	
VentanaPrincipal-- 
.-- 
CambiarPagina-- *
(--* +
new--+ .!
PaginaRegistroJugador--/ D
(--D E
)--E F
)--F G
;--G H
}.. 	
private00 
void00 
IrAPaginaAjustes00 %
(00% &
object00& ,
objetoOrigen00- 9
,009 : 
MouseButtonEventArgs00; O
evento00P V
)00V W
{11 	
VentanaPrincipal22 
.22 *
CambiarPaginaGuardandoAnterior22 ;
(22; <
new22< ?
PaginaAjustes22@ M
(22M N
)22N O
)22O P
;22P Q
}33 	
private55 
void55 
IniciarSesion55 "
(55" #
object55# )
objetoOrigen55* 6
,556 7
RoutedEventArgs558 G
evento55H N
)55N O
{66 	
string77 
nombreJugador77  
=77! "$
cuadroTextoNombreUsuario77# ;
.77; <
Text77< @
;77@ A
string88 

contrasena88 
=88 &
cuadroContrasenaContrasena88  :
.88: ;
Password88; C
;88C D
if:: 
(:: 
!:: 
ValidadorDatos:: 
.::  
EsCadenaVacia::  -
(::- .
nombreJugador::. ;
)::; <
&&::= ?
!;; 
ValidadorDatos;; 
.;;  
EsCadenaVacia;;  -
(;;- .

contrasena;;. 8
);;8 9
);;9 :
{<< 
if== 
(== 
!== !
ExistenDatosInvalidos== *
(==* +
nombreJugador==+ 8
,==8 9

contrasena==: D
)==D E
)==E F
{>> 
CuentaJugador?? !$
cuentaJugadorAutenticada??" :
=??; <
	Servicios@@ !
.@@! "
ServicioJugador@@" 1
.@@1 2
IniciarSesion@@2 ?
(@@? @
nombreJugador@@@ M
,@@M N!
EncriptadorContrasenaAA -
.AA- .
CalcularHashSha512AA. @
(AA@ A

contrasenaAAA K
)AAK L
)AAL M
;AAM N
ifCC 
(CC $
cuentaJugadorAutenticadaCC 0
!=CC1 3
nullCC4 8
)CC8 9
{DD 
DominioEE 
.EE  
CuentaJugadorEE  -
.EE- .
ActualEE. 4
=EE5 6
newEE7 :
DominioEE; B
.EEB C
CuentaJugadorEEC P
{FF 

ContrasenaGG &
=GG' ($
cuentaJugadorAutenticadaGG) A
.GGA B

ContrasenaGGB L
,GGL M
CorreoHH "
=HH# $$
cuentaJugadorAutenticadaHH% =
.HH= >
CorreoHH> D
,HHD E
NombreJugadorII )
=II* +$
cuentaJugadorAutenticadaII, D
.IID E
NombreJugadorIIE R
,IIR S
NumeroAvatarJJ (
=JJ) *$
cuentaJugadorAutenticadaJJ+ C
.JJC D
NumeroAvatarJJD P
,JJP Q

EsInvitadoKK &
=KK' (
falseKK) .
,KK. /
FuenteImagenAvatarLL .
=LL/ 0

UtilidadesLL1 ;
.LL; <
GeneradorImagenesLL< M
.LLM N%
GenerarFuenteImagenAvatarMM  9
(MM9 :$
cuentaJugadorAutenticadaMM: R
.MMR S
NumeroAvatarMMS _
)MM_ `
}NN 
;NN 
VentanaPrincipalOO (
.OO( )
CambiarPaginaOO) 6
(OO6 7
newOO7 :
PaginaMenuPrincipalOO; N
(OON O
)OOO P
)OOP Q
;OOQ R
}PP 
elseQQ 
{RR 

MessageBoxSS "
.SS" #
ShowSS# '
(SS' (

PropertiesSS( 2
.SS2 3
	ResourcesSS3 <
.SS< =:
.ETIQUETA_INICIOSESION_MENSAJEINICIOSESIONERRORTT J
,TTJ K

PropertiesUU &
.UU& '
	ResourcesUU' 0
.UU0 17
+ETIQUETA_INICIOSESION_INICIOSESIONCANCELADOUU1 \
,UU\ ]
MessageBoxButtonVV ,
.VV, -
OKVV- /
,VV/ 0
MessageBoxImageVV1 @
.VV@ A
ErrorVVA F
)VVF G
;VVG H
}WW 
}XX 
elseYY 
{ZZ 

MessageBox[[ 
.[[ 
Show[[ #
([[# $

Properties[[$ .
.[[. /
	Resources[[/ 8
.[[8 96
*ETIQUETA_VALIDACION_MENSAJECAMPOSINVALIDOS\\ B
,\\B C

Properties\\D N
.\\N O
	Resources\\O X
.\\X Y/
#ETIQUETA_VALIDACION_CAMPOSINVALIDOS]] ;
,]]; <
MessageBoxButton]]= M
.]]M N
OK]]N P
,]]P Q
MessageBoxImage^^ '
.^^' (
Error^^( -
)^^- .
;^^. /
}__ 
}`` 
elseaa 
{bb 

MessageBoxcc 
.cc 
Showcc 
(cc  

Propertiescc  *
.cc* +
	Resourcescc+ 4
.cc4 50
$ETIQUETA_GENERAL_MENSAJECAMPOSVACIOScc5 Y
,ccY Z

Propertiesdd 
.dd 
	Resourcesdd (
.dd( ),
 ETIQUETA_VALIDACION_CAMPOSVACIOSdd) I
,ddI J
MessageBoxButtonee $
.ee$ %
OKee% '
,ee' (
MessageBoxImageee) 8
.ee8 9
Erroree9 >
)ee> ?
;ee? @
}ff 
}gg 	
privateii 
boolii !
ExistenDatosInvalidosii *
(ii* +
stringii+ 1
nombreJugadorii2 ?
,ii? @
stringiiA G

contrasenaiiH R
)iiR S
{jj 	
boolkk 
hayCamposInvalidoskk #
=kk$ %
falsekk& +
;kk+ ,
ifmm 
(mm 
ValidadorDatosmm 
.mm 4
(ExistenCaracteresInvalidosParaContrasenamm G
(mmG H

contrasenammH R
)mmR S
)mmS T
{nn 

MessageBoxoo 
.oo 
Showoo 
(oo  

Propertiesoo  *
.oo* +
	Resourcesoo+ 4
.oo4 59
-ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDApp A
,ppA B

PropertiesppC M
.ppM N
	ResourcesppN W
.ppW X2
&ETIQUETA_VALIDACION_CONTRASENAINVALIDAqq :
,qq: ;
MessageBoxButtonqq< L
.qqL M
OKqqM O
)qqO P
;qqP Q
hayCamposInvalidosrr "
=rr# $
truerr% )
;rr) *
}ss 
ifuu 
(uu 
ValidadorDatosuu 
.uu 7
+ExistenCaracteresInvalidosParaNombreJugadoruu J
(uuJ K
nombreJugadoruuK X
)uuX Y
)uuY Z
{vv 

MessageBoxww 
.ww 
Showww 
(ww  

Propertiesww  *
.ww* +
	Resourcesww+ 4
.ww4 5<
0ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDOxx D
,xxD E

PropertiesxxF P
.xxP Q
	ResourcesxxQ Z
.xxZ [5
)ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDOyy =
,yy= >
MessageBoxButtonyy? O
.yyO P
OKyyP R
)yyR S
;yyS T
hayCamposInvalidoszz "
=zz# $
truezz% )
;zz) *
}{{ 
if}} 
(}} &
ExistenLongitudesExcedidas}} *
(}}* +
nombreJugador}}+ 8
,}}8 9

contrasena}}: D
)}}D E
)}}E F
{~~ 

MessageBox 
. 
Show 
(  

Properties  *
.* +
	Resources+ 4
.4 57
+ETIQUETA_VALIDACION_MENSAJELONGITUDEXCEDIDA5 `
,` a

Properties
�� 
.
�� 
	Resources
�� '
.
��' (1
#ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS
��( K
,
��K L
MessageBoxButton
��M ]
.
��] ^
OK
��^ `
)
��` a
;
��a b
}
�� 
return
��  
hayCamposInvalidos
�� %
;
��% &
}
�� 	
private
�� 
bool
�� (
ExistenLongitudesExcedidas
�� /
(
��/ 0
string
��0 6
nombreJugador
��7 D
,
��D E
string
��F L

contrasena
��M W
)
��W X
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
if
�� 
(
�� 
ValidadorDatos
�� 
.
�� 3
%ExisteLongitudExcedidaEnNombreJugador
�� D
(
��D E
nombreJugador
��E R
)
��R S
||
��T V
ValidadorDatos
�� 
.
�� 0
"ExisteLongitudExcedidaEnContrasena
�� A
(
��A B

contrasena
��B L
)
��L M
)
��M N
{
�� 
	resultado
�� 
=
�� 
true
��  
;
��  !
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
}
�� 
}�� �/
C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaMenuPrincipal.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class 
PaginaMenuPrincipal ,
:- .
Page/ 3
{ 
public		 
PaginaMenuPrincipal		 "
(		" #
)		# $
{

 	
InitializeComponent 
(  
)  !
;! "
if 
( 
! 
Dominio 
. 
CuentaJugador &
.& '
Actual' -
.- .

EsInvitado. 8
)8 9
{ ,
 MostrarOpcionesJugadorRegistrado 0
(0 1
)1 2
;2 3
} 
} 	
private 
void ,
 MostrarOpcionesJugadorRegistrado 5
(5 6
)6 7
{ 	
etiquetaMisAmigos 
. 

Visibility (
=) *

Visibility+ 5
.5 6
Visible6 =
;= >
etiquetaMiPerfil 
. 

Visibility '
=( )

Visibility* 4
.4 5
Visible5 <
;< =
imagenAvatarUsuario 
.  

Visibility  *
=+ ,

Visibility- 7
.7 8
Visible8 ?
;? @
imagenMisAmigos 
. 

Visibility &
=' (

Visibility) 3
.3 4
Visible4 ;
;; <
imagenAvatarUsuario 
.  
Source  &
=' (
Dominio) 0
.0 1
CuentaJugador1 >
.> ?
Actual? E
.E F
FuenteImagenAvatarF X
;X Y
} 	
private 
void 
CrearNuevaSala #
(# $
object$ *
objetoOrigen+ 7
,7 8
RoutedEventArgs9 H
eventoI O
)O P
{ 	

PaginaSala 

paginaSala !
=" #
new$ '

PaginaSala( 2
{ 
EsAnfitrion   
=   
true   "
}!! 
;!! 

paginaSala"" 
."" 
UnirseASala"" "
(""" #
)""# $
;""$ %
VentanaPrincipal## 
.## 
CambiarPagina## *
(##* +

paginaSala##+ 5
)##5 6
;##6 7
}$$ 	
private&& 
void&& 
IrAPaginaUnirseSala&& (
(&&( )
object&&) /
objetoOrigen&&0 <
,&&< =
RoutedEventArgs&&> M
evento&&N T
)&&T U
{'' 	
VentanaPrincipal(( 
.(( 
CambiarPagina(( *
(((* +
new((+ .
PaginaUnirseSala((/ ?
(((? @
)((@ A
)((A B
;((B C
})) 	
private++ 
void++ 
IrAPaginaAmistades++ '
(++' (
object++( .
objetoOrigen++/ ;
,++; < 
MouseButtonEventArgs++= Q
evento++R X
)++X Y
{,, 	
VentanaPrincipal-- 
.-- 
CambiarPagina-- *
(--* +
new--+ .
PaginaAmistades--/ >
(--> ?
true--? C
)--C D
)--D E
;--E F
}.. 	
private00 
void00 
CerrarSesion00 !
(00! "
object00" (
objetoOrigen00) 5
,005 6 
MouseButtonEventArgs007 K
evento00L R
)00R S
{11 	
MessageBoxResult22 '
resultadoOpcionCerrarSesion22 8
=229 :

MessageBox22; E
.22E F
Show22F J
(22J K

Properties33 
.33 
	Resources33 $
.33$ %)
ETIQUETA_CERRARSESION_MENSAJE33% B
,33B C

Properties44 
.44 
	Resources44 $
.44$ %(
ETIQUETA_CERRARSESION_TITULO44% A
,44A B
MessageBoxButton55  
.55  !
YesNo55! &
,55& '
MessageBoxImage55( 7
.557 8
Question558 @
)55@ A
;55A B
if77 
(77 '
resultadoOpcionCerrarSesion77 +
==77, .
MessageBoxResult77/ ?
.77? @
Yes77@ C
)77C D
{88 
	Servicios99 
.99 
ServicioJugador99 )
.99) *
CerrarSesion99* 6
(996 7
Dominio997 >
.99> ?
CuentaJugador99? L
.99L M
Actual99M S
.99S T
NombreJugador99T a
)99a b
;99b c
Dominio:: 
.:: 
CuentaJugador:: %
.::% &
Actual::& ,
=::- .
null::/ 3
;::3 4
VentanaPrincipal;;  
.;;  !
CambiarPagina;;! .
(;;. /
new;;/ 2
PaginaInicioSesion;;3 E
(;;E F
);;F G
);;G H
;;;H I
}<< 
}== 	
private?? 
void?? '
IrAPaginaInformacionJugador?? 0
(??0 1
object??1 7
objetoOrigen??8 D
,??D E 
MouseButtonEventArgs??F Z
evento??[ a
)??a b
{@@ 	
VentanaPrincipalAA 
.AA 
CambiarPaginaAA *
(AA* +
newAA+ .$
PaginaInformacionJugadorAA/ G
(AAG H
)AAH I
)AAI J
;AAJ K
}BB 	
privateDD 
voidDD 
IrAPaginaAjustesDD %
(DD% &
objectDD& ,
objetoOrigenDD- 9
,DD9 : 
MouseButtonEventArgsDD; O
eventoDDP V
)DDV W
{EE 	
VentanaPrincipalFF 
.FF *
CambiarPaginaGuardandoAnteriorFF ;
(FF; <
newFF< ?
PaginaAjustesFF@ M
(FFM N
)FFN O
)FFO P
;FFP Q
}GG 	
}HH 
}II ��
yC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaPartida.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class 
PaginaPartida &
:' (
Page) -
,- .$
IServicioPartidaCallback/ G
{ 
private 
bool 
cursorSostienePieza (
;( )
private 
readonly 
Tablero  
tablero! (
;( )
private 
Point !
posicionInicialCursor +
;+ ,
private 
Pieza 
piezaActual !
;! "
private  
ObservableCollection $
<$ %
Dominio% ,
., -
CuentaJugador- :
>: ;
jugadoresPartida< L
;L M
public  
ObservableCollection #
<# $
Dominio$ +
.+ ,
CuentaJugador, 9
>9 :
JugadoresPartida; K
{ 	
get 
{ 
return 
jugadoresPartida )
;) *
}+ ,
set 
{ 
jugadoresPartida "
=# $
value% *
;* +
}, -
} 	
public   
PaginaPartida   
(   
)   
{!! 	
}"" 	
public$$ 
PaginaPartida$$ 
($$ 

Dificultad$$ '

dificultad$$( 2
,$$2 3
int$$4 7$
numeroImagenRompecabezas$$8 P
)$$P Q
{%% 	
InitializeComponent&& 
(&&  
)&&  !
;&&! "
tablero'' 
='' 
new'' 
Tablero'' !
{(( 

Dificultad)) 
=)) 

dificultad)) '
,))' (
Piezas** 
=** 
new** 
List** !
<**! "
Pieza**" '
>**' (
(**( )
)**) *
,*** +
Celdas++ 
=++ 
new++ 
List++ !
<++! "
Celda++" '
>++' (
(++( )
)++) *
,++* +$
NumeroImagenRompecabezas,, (
=,,) *$
numeroImagenRompecabezas,,+ C
}-- 
;-- 
jugadoresPartida.. 
=.. 
new.. " 
ObservableCollection..# 7
<..7 8
Dominio..8 ?
...? @
CuentaJugador..@ M
>..M N
(..N O
)..O P
;..P Q!
listaJugadoresPartida// !
.//! "
DataContext//" -
=//. /
this//0 4
;//4 5
}00 	
private22 
void22 "
CargarJugadoresPartida22 +
(22+ ,
)22, -
{33 	
}55 	
private77 
void77 
CrearTablero77 !
(77! "
)77" #
{88 	
tablero99 
.99 
AnchoDeCelda99  
=99! "
tableroRompecabezas99# 6
.996 7
ActualWidth997 B
/99C D
tablero99E L
.99L M
TotalColumnas99M Z
;99Z [
tablero:: 
.:: 
AlturaDeCelda:: !
=::" #
tableroRompecabezas::$ 7
.::7 8
ActualHeight::8 D
/::E F
tablero::G N
.::N O

TotalFilas::O Y
;::Y Z
bool;; #
pintarCeldaConColorGris;; (
;;;( )
bool<< 0
$pintarCeldaConColorGrisAlIniciarFila<< 5
=<<6 7
true<<8 <
;<<< =
for>> 
(>> 
int>> 
fila>> 
=>> 
$num>> 
;>> 
fila>> #
<>>$ %
tablero>>& -
.>>- .

TotalFilas>>. 8
;>>8 9
fila>>: >
++>>> @
)>>@ A
{?? #
pintarCeldaConColorGris@@ '
=@@( )0
$pintarCeldaConColorGrisAlIniciarFila@@* N
;@@N O
forAA 
(AA 
intAA 
columnaAA  
=AA! "
$numAA# $
;AA$ %
columnaAA& -
<AA. /
tableroAA0 7
.AA7 8
TotalColumnasAA8 E
;AAE F
columnaAAG N
++AAN P
)AAP Q
{BB 
CeldaCC 
celdaCC 
=CC  !
newCC" %
CeldaCC& +
{DD 
FilaEE 
=EE 
filaEE #
,EE# $
ColumnaFF 
=FF  !
columnaFF" )
,FF) *
AreaGG 
=GG 
newGG "
	RectangleGG# ,
{HH 
WidthII !
=II" #
tableroII$ +
.II+ ,
AnchoDeCeldaII, 8
,II8 9
HeightJJ "
=JJ# $
tableroJJ% ,
.JJ, -
AlturaDeCeldaJJ- :
,JJ: ;
StrokeKK "
=KK# $
BrushesKK% ,
.KK, -
BlackKK- 2
,KK2 3
StrokeThicknessLL +
=LL, -
$numLL. 1
}MM 
}NN 
;NN 
ifPP 
(PP #
pintarCeldaConColorGrisPP /
)PP/ 0
{QQ 
celdaRR 
.RR 
AreaRR "
.RR" #
FillRR# '
=RR( )
BrushesRR* 1
.RR1 2
	LightGrayRR2 ;
;RR; <#
pintarCeldaConColorGrisSS /
=SS0 1
falseSS2 7
;SS7 8
}TT 
elseUU 
{VV 
celdaWW 
.WW 
AreaWW "
.WW" #
FillWW# '
=WW( )
BrushesWW* 1
.WW1 2
	AliceBlueWW2 ;
;WW; <#
pintarCeldaConColorGrisXX /
=XX0 1
trueXX2 6
;XX6 7
}YY 
if[[ 
([[ 
columna[[ 
+[[  !
$num[[" #
==[[$ &
tablero[[' .
.[[. /
TotalColumnas[[/ <
)[[< =
{\\ 
if]] 
(]] 0
$pintarCeldaConColorGrisAlIniciarFila]] @
)]]@ A
{^^ 0
$pintarCeldaConColorGrisAlIniciarFila__ @
=__A B
false__C H
;__H I
}`` 
elseaa 
{bb 0
$pintarCeldaConColorGrisAlIniciarFilacc @
=ccA B
trueccC G
;ccG H
}dd 
}ee 
doublegg 
	posicionXgg $
=gg% &
columnagg' .
*gg/ 0
tablerogg1 8
.gg8 9
AnchoDeCeldagg9 E
;ggE F
doublehh 
	posicionYhh $
=hh% &
filahh' +
*hh, -
tablerohh. 5
.hh5 6
AlturaDeCeldahh6 C
;hhC D
Canvasii 
.ii 
SetLeftii "
(ii" #
celdaii# (
.ii( )
Areaii) -
,ii- .
	posicionXii/ 8
)ii8 9
;ii9 :
Canvasjj 
.jj 
SetTopjj !
(jj! "
celdajj" '
.jj' (
Areajj( ,
,jj, -
	posicionYjj. 7
)jj7 8
;jj8 9
tableroRompecabezaskk '
.kk' (
Childrenkk( 0
.kk0 1
Addkk1 4
(kk4 5
celdakk5 :
.kk: ;
Areakk; ?
)kk? @
;kk@ A
tableroll 
.ll 
Celdasll "
.ll" #
Addll# &
(ll& '
celdall' ,
)ll, -
;ll- .
}mm 
}nn 
}oo 	
privateqq 
voidqq "
RecortarImagenEnPiezasqq +
(qq+ ,
BitmapImageqq, 7 
fuenteImagenOriginalqq8 L
)qqL M
{rr 	
intss 
anchoRecortess 
=ss 
(ss  
intss  #
)ss# $
(ss$ % 
fuenteImagenOriginalss% 9
.ss9 :
Widthss: ?
/ss@ A
tablerossB I
.ssI J
TotalColumnasssJ W
)ssW X
;ssX Y
inttt 
alturaRecortett 
=tt 
(tt  !
inttt! $
)tt$ %
(tt% & 
fuenteImagenOriginaltt& :
.tt: ;
Heighttt; A
/ttB C
tablerottD K
.ttK L

TotalFilasttL V
)ttV W
;ttW X
forvv 
(vv 
intvv 
filavv 
=vv 
$numvv 
;vv 
filavv #
<vv$ %
tablerovv& -
.vv- .

TotalFilasvv. 8
;vv8 9
filavv: >
++vv> @
)vv@ A
{ww 
forxx 
(xx 
intxx 
columnaxx  
=xx! "
$numxx# $
;xx$ %
columnaxx& -
<xx. /
tableroxx0 7
.xx7 8
TotalColumnasxx8 E
;xxE F
columnaxxG N
++xxN P
)xxP Q
{yy 
	Int32Rectzz 
areaRecortezz )
=zz* +
newzz, /
	Int32Rectzz0 9
(zz9 :
columnazz: A
*zzB C
anchoRecortezzD P
,zzP Q
filazzR V
*zzW X
alturaRecorte{{ %
,{{% &
anchoRecorte{{' 3
,{{3 4
alturaRecorte{{5 B
){{B C
;{{C D
Pieza|| 

nuevaPieza|| $
=||% &
new||' *
Pieza||+ 0
{}} 
Ancho~~ 
=~~ 
tablero~~  '
.~~' (
AnchoDeCelda~~( 4
,~~4 5
Alto 
= 
tablero &
.& '
AlturaDeCelda' 4
,4 5
EstaDentroDeCelda
�� )
=
��* +
false
��, 1
,
��1 2
FilaCorrecta
�� $
=
��% &
fila
��' +
,
��+ ,
ColumnaCorrecta
�� '
=
��( )
columna
��* 1
}
�� 
;
�� 

nuevaPieza
�� 
.
�� $
EstablecerFuenteImagen
�� 5
(
��5 6"
fuenteImagenOriginal
��6 J
,
��J K
areaRecorte
��L W
)
��W X
;
��X Y

nuevaPieza
�� 
.
�� 
Borde
�� $
=
��% &(
GenerarNuevoBordeParaPieza
��' A
(
��A B
)
��B C
;
��C D

nuevaPieza
�� 
.
�� 3
%EstablecerEstiloDePiezaSinSeleccionar
�� D
(
��D E
)
��E F
;
��F G
tablero
�� 
.
�� 
Piezas
�� "
.
��" #
Add
��# &
(
��& '

nuevaPieza
��' 1
)
��1 2
;
��2 3
}
�� 
}
�� 
}
�� 	
private
�� 
Border
�� (
GenerarNuevoBordeParaPieza
�� 1
(
��1 2
)
��2 3
{
�� 	
Border
�� 
bordeImagen
�� 
=
��  
new
��! $
Border
��% +
(
��+ ,
)
��, -
;
��- .
bordeImagen
�� 
.
�� !
MouseLeftButtonDown
�� +
+=
��, .
SeleccionarPieza
��/ ?
;
��? @
bordeImagen
�� 
.
�� 
	MouseMove
�� !
+=
��" $

MoverPieza
��% /
;
��/ 0
bordeImagen
�� 
.
�� 
MouseLeftButtonUp
�� )
+=
��* ,
SoltarPieza
��- 8
;
��8 9
return
�� 
bordeImagen
�� 
;
�� 
}
�� 	
private
�� 
void
�� )
MostrarPiezasAleatoriamente
�� 0
(
��0 1
)
��1 2
{
�� 	
Random
�� 
	aleatorio
�� 
=
�� 
new
�� "
Random
��# )
(
��) *
)
��* +
;
��+ ,
foreach
�� 
(
�� 
Pieza
�� 
pieza
��  
in
��! #
tablero
��$ +
.
��+ ,
Piezas
��, 2
)
��2 3
{
�� 
double
�� 
anchoTablero
�� #
=
��$ %!
tableroRompecabezas
��& 9
.
��9 :
ActualWidth
��: E
;
��E F
double
�� 
alturaTablero
�� $
=
��% &!
tableroRompecabezas
��' :
.
��: ;
ActualHeight
��; G
;
��G H
double
�� 
	posicionX
��  
=
��! "
	aleatorio
��# ,
.
��, -

NextDouble
��- 7
(
��7 8
)
��8 9
*
��: ;
(
�� 
anchoTablero
�� !
-
��" #
pieza
��$ )
.
��) *
Imagen
��* 0
.
��0 1
Width
��1 6
)
��6 7
;
��7 8
double
�� 
	posicionY
��  
=
��! "
	aleatorio
��# ,
.
��, -

NextDouble
��- 7
(
��7 8
)
��8 9
*
��: ;
(
�� 
alturaTablero
�� "
-
��# $
pieza
��% *
.
��* +
Imagen
��+ 1
.
��1 2
Height
��2 8
)
��8 9
;
��9 :
Canvas
�� 
.
�� 
SetLeft
�� 
(
�� 
pieza
�� $
.
��$ %
Borde
��% *
,
��* +
	posicionX
��, 5
)
��5 6
;
��6 7
Canvas
�� 
.
�� 
SetTop
�� 
(
�� 
pieza
�� #
.
��# $
Borde
��$ )
,
��) *
	posicionY
��+ 4
)
��4 5
;
��5 6!
tableroRompecabezas
�� #
.
��# $
Children
��$ ,
.
��, -
Add
��- 0
(
��0 1
pieza
��1 6
.
��6 7
Borde
��7 <
)
��< =
;
��= >
}
�� 
}
�� 	
private
�� 
void
�� <
.SobreponerEnTableroPiezasFaltantesDePosicionar
�� C
(
��C D
)
��D E
{
�� 	
foreach
�� 
(
�� 
Pieza
�� 
pieza
��  
in
��! #
tablero
��$ +
.
��+ ,
Piezas
��, 2
)
��2 3
{
�� 
if
�� 
(
�� 
!
�� 
pieza
�� 
.
�� 
EstaDentroDeCelda
�� ,
)
��, -
{
�� !
tableroRompecabezas
�� '
.
��' (
Children
��( 0
.
��0 1
Remove
��1 7
(
��7 8
pieza
��8 =
.
��= >
Borde
��> C
)
��C D
;
��D E!
tableroRompecabezas
�� '
.
��' (
Children
��( 0
.
��0 1
Add
��1 4
(
��4 5
pieza
��5 :
.
��: ;
Borde
��; @
)
��@ A
;
��A B
}
�� 
}
�� 
}
�� 	
private
�� 
bool
�� -
EsPosicionValidaParaPiezaActual
�� 4
(
��4 5
double
��5 ;
nuevaPosicionX
��< J
,
��J K
double
�� 
nuevaPosicionY
�� !
)
��! "
{
�� 	
bool
�� 
esPosicionValida
�� !
=
��" #
false
��$ )
;
��) *
if
�� 
(
�� 
(
�� 
nuevaPosicionX
�� 
+
��  !
piezaActual
��" -
.
��- .5
'ObtenerDiferenciaAnchoEntreImagenYBorde
��. U
(
��U V
)
��V W
)
��W X
>=
��Y [
$num
��\ ]
&&
��^ `
(
�� 
nuevaPosicionY
�� 
+
��  !
piezaActual
��" -
.
��- .6
(ObtenerDiferenciaAlturaEntreImagenYBorde
��. V
(
��V W
)
��W X
)
��X Y
>=
��Z \
$num
��] ^
&&
��_ a
(
�� 
piezaActual
�� 
.
�� 
Ancho
�� "
+
��# $
nuevaPosicionX
��% 3
<=
��4 6!
tableroRompecabezas
��7 J
.
��J K
ActualWidth
��K V
)
��V W
&&
��X Z
(
�� 
piezaActual
�� 
.
�� 
Alto
�� !
+
��" #
nuevaPosicionY
��$ 2
<=
��3 5!
tableroRompecabezas
��6 I
.
��I J
ActualHeight
��J V
)
��V W
)
��W X
{
�� 
esPosicionValida
��  
=
��! "
true
��# '
;
��' (
}
�� 
return
�� 
esPosicionValida
�� #
;
��# $
}
�� 	
private
�� 
Pieza
�� ,
BuscarPiezaPertenecienteABorde
�� 4
(
��4 5
Border
��5 ;
borde
��< A
)
��A B
{
�� 	
var
�� 
piezasEncontradas
�� !
=
��" #
tablero
��$ +
.
��+ ,
Piezas
��, 2
.
��2 3
Where
��3 8
(
��8 9
pieza
��9 >
=>
��? A
pieza
��B G
.
��G H
Borde
��H M
.
��M N
Equals
��N T
(
��T U
borde
��U Z
)
��Z [
)
��[ \
;
��\ ]
Pieza
�� 
piezaEncontrada
�� !
=
��" #
new
��$ '
Pieza
��( -
(
��- .
)
��. /
;
��/ 0
if
�� 
(
�� 
piezasEncontradas
�� !
.
��! "
Any
��" %
(
��% &
)
��& '
)
��' (
{
�� 
piezaEncontrada
�� 
=
��  !
piezasEncontradas
��" 3
.
��3 4
First
��4 9
(
��9 :
)
��: ;
;
��; <
}
�� 
return
�� 
piezaEncontrada
�� "
;
��" #
}
�� 	
private
�� 
Celda
�� +
BuscarCeldaPertenecienteAArea
�� 3
(
��3 4
	Rectangle
��4 =
	areaCelda
��> G
)
��G H
{
�� 	
var
�� 
celdasEncontradas
�� !
=
��" #
tablero
��$ +
.
��+ ,
Celdas
��, 2
.
��2 3
Where
��3 8
(
��8 9
celda
��9 >
=>
��? A
celda
��B G
.
��G H
Area
��H L
.
��L M
Equals
��M S
(
��S T
	areaCelda
��T ]
)
��] ^
)
��^ _
;
��_ `
Celda
�� 
celdaEncontrada
�� !
=
��" #
new
��$ '
Celda
��( -
(
��- .
)
��. /
;
��/ 0
if
�� 
(
�� 
celdasEncontradas
�� !
.
��! "
Any
��" %
(
��% &
)
��& '
)
��' (
{
�� 
celdaEncontrada
�� 
=
��  !
celdasEncontradas
��" 3
.
��3 4
First
��4 9
(
��9 :
)
��: ;
;
��; <
}
�� 
return
�� 
celdaEncontrada
�� "
;
��" #
}
�� 	
private
�� 
void
�� 3
%PosicionarPiezaEnCeldaCorrespondiente
�� :
(
��: ;
Point
��; @
posicion
��A I
)
��I J
{
�� 	
foreach
�� 
(
�� 
	UIElement
�� 
control
�� &
in
��' )!
tableroRompecabezas
��* =
.
��= >
Children
��> F
)
��F G
{
�� 
if
�� 
(
�� 
control
�� 
is
�� 
	Rectangle
�� (
	areaCelda
��) 2
)
��2 3
{
�� 
double
�� 
posicionXMinima
�� *
=
��+ ,
Canvas
��- 3
.
��3 4
GetLeft
��4 ;
(
��; <
	areaCelda
��< E
)
��E F
;
��F G
double
�� 
posicionYMinima
�� *
=
��+ ,
Canvas
��- 3
.
��3 4
GetTop
��4 :
(
��: ;
	areaCelda
��; D
)
��D E
;
��E F
double
�� 
posicionXMaxima
�� *
=
��+ ,
posicionXMinima
��- <
+
��= >
	areaCelda
��? H
.
��H I
Width
��I N
;
��N O
double
�� 
posicionYMaxima
�� *
=
��+ ,
posicionYMinima
��- <
+
��= >
	areaCelda
��? H
.
��H I
Height
��I O
;
��O P
if
�� 
(
�� 
posicion
��  
.
��  !
X
��! "
>=
��# %
posicionXMinima
��& 5
&&
��6 8
posicion
��  
.
��  !
X
��! "
<=
��# %
posicionXMaxima
��& 5
&&
��6 8
posicion
��  
.
��  !
Y
��! "
>=
��# %
posicionYMinima
��& 5
&&
��6 8
posicion
��  
.
��  !
Y
��! "
<=
��# %
posicionYMaxima
��& 5
)
��5 6
{
�� 
Celda
�� 
celda
�� #
=
��$ %+
BuscarCeldaPertenecienteAArea
��& C
(
��C D
	areaCelda
��D M
)
��M N
;
��N O
if
�� 
(
�� 
celda
�� !
.
��! "
Fila
��" &
==
��' )
piezaActual
��* 5
.
��5 6
FilaCorrecta
��6 B
&&
��C E
celda
�� !
.
��! "
Columna
��" )
==
��* ,
piezaActual
��- 8
.
��8 9
ColumnaCorrecta
��9 H
)
��H I
{
�� 
Canvas
�� "
.
��" #
SetLeft
��# *
(
��* +
piezaActual
��+ 6
.
��6 7
Borde
��7 <
,
��< =
posicionXMinima
��> M
)
��M N
;
��N O
Canvas
�� "
.
��" #
SetTop
��# )
(
��) *
piezaActual
��* 5
.
��5 6
Borde
��6 ;
,
��; <
posicionYMinima
��= L
)
��L M
;
��M N
piezaActual
�� '
.
��' (
EstaDentroDeCelda
��( 9
=
��: ;
true
��< @
;
��@ A<
.SobreponerEnTableroPiezasFaltantesDePosicionar
�� J
(
��J K
)
��K L
;
��L M
break
�� !
;
��! "
}
�� 
}
�� 
}
�� 
}
�� 
}
�� 	
private
�� 
void
�� -
RemoverEventoVentanaDesactivada
�� 4
(
��4 5
)
��5 6
{
�� 	
VentanaPrincipal
�� 
ventanaPrincipal
�� -
=
��. /
(
��0 1
VentanaPrincipal
��1 A
)
��A B
Window
��B H
.
��H I
	GetWindow
��I R
(
��R S
this
��S W
)
��W X
;
��X Y
ventanaPrincipal
�� 
.
�� 
Deactivated
�� (
-=
��) +,
SoltarPiezaAlDesactivarVentana
��, J
;
��J K
}
�� 	
private
�� 
void
��  
CargarDatosPartida
�� '
(
��' (
object
��( .
objetoOrigen
��/ ;
,
��; <
RoutedEventArgs
��= L
evento
��M S
)
��S T
{
�� 	
VentanaPrincipal
�� 
ventanaPrincipal
�� -
=
��. /
(
��0 1
VentanaPrincipal
��1 A
)
��A B
Window
��B H
.
��H I
	GetWindow
��I R
(
��R S
this
��S W
)
��W X
;
��X Y
ventanaPrincipal
�� 
.
�� 
Deactivated
�� (
+=
��) +,
SoltarPiezaAlDesactivarVentana
��, J
;
��J K
CrearTablero
�� 
(
�� 
)
�� 
;
�� 
}
�� 	
private
�� 
void
�� ,
SoltarPiezaAlDesactivarVentana
�� 3
(
��3 4
object
��4 :
objetoOrigen
��; G
,
��G H
	EventArgs
��I R
evento
��S Y
)
��Y Z
{
�� 	!
cursorSostienePieza
�� 
=
��  !
false
��" '
;
��' (
if
�� 
(
�� 
piezaActual
�� 
!=
�� 
null
�� #
&&
��$ &
!
��' (
piezaActual
��( 3
.
��3 4
EstaDentroDeCelda
��4 E
)
��E F
{
�� 
piezaActual
�� 
.
�� 3
%EstablecerEstiloDePiezaSinSeleccionar
�� A
(
��A B
)
��B C
;
��C D
}
�� 
}
�� 	
private
�� 
void
�� $
IrPaginaAjustesPartida
�� +
(
��+ ,
object
��, 2
objetoOrigen
��3 ?
,
��? @"
MouseButtonEventArgs
��A U
evento
��V \
)
��\ ]
{
�� 	
}
�� 	
private
�� 
void
�� 
IniciarJuego
�� !
(
��! "
object
��" (
objetoOrigen
��) 5
,
��5 6
RoutedEventArgs
��7 F
evento
��G M
)
��M N
{
�� 	
botonIniciar
�� 
.
�� 
	IsEnabled
�� "
=
��# $
false
��% *
;
��* +
BitmapImage
�� "
fuenteImagenOriginal
�� ,
=
��- .

Utilidades
��/ 9
.
��9 :
GeneradorImagenes
��: K
.
��K L-
GenerarFuenteImagenRompecabezas
�� /
(
��/ 0
tablero
��0 7
.
��7 8&
NumeroImagenRompecabezas
��8 P
)
��P Q
;
��Q R$
RecortarImagenEnPiezas
�� "
(
��" #"
fuenteImagenOriginal
��# 7
)
��7 8
;
��8 9)
MostrarPiezasAleatoriamente
�� '
(
��' (
)
��( )
;
��) *
}
�� 	
private
�� 
void
�� 
SeleccionarPieza
�� %
(
��% &
object
��& ,
objetoOrigen
��- 9
,
��9 :"
MouseButtonEventArgs
��; O
evento
��P V
)
��V W
{
�� 	
piezaActual
�� 
=
�� ,
BuscarPiezaPertenecienteABorde
�� 8
(
��8 9
(
��9 :
Border
��: @
)
��@ A
objetoOrigen
��A M
)
��M N
;
��N O
if
�� 
(
�� 
!
�� 
piezaActual
�� 
.
�� 
EstaDentroDeCelda
�� .
)
��. /
{
�� !
tableroRompecabezas
�� #
.
��# $
Children
��$ ,
.
��, -
Remove
��- 3
(
��3 4
piezaActual
��4 ?
.
��? @
Borde
��@ E
)
��E F
;
��F G!
tableroRompecabezas
�� #
.
��# $
Children
��$ ,
.
��, -
Add
��- 0
(
��0 1
piezaActual
��1 <
.
��< =
Borde
��= B
)
��B C
;
��C D
piezaActual
�� 
.
�� 1
#EstablecerEstiloDePiezaSeleccionada
�� ?
(
��? @
)
��@ A
;
��A B#
posicionInicialCursor
�� %
=
��& '
evento
��( .
.
��. /
GetPosition
��/ :
(
��: ;!
tableroRompecabezas
��; N
)
��N O
;
��O P
piezaActual
�� 
.
�� 
Borde
�� !
.
��! "
CaptureMouse
��" .
(
��. /
)
��/ 0
;
��0 1!
cursorSostienePieza
�� #
=
��$ %
true
��& *
;
��* +
}
�� 
}
�� 	
private
�� 
void
�� 

MoverPieza
�� 
(
��  
object
��  &
objetoOrigen
��' 3
,
��3 4
MouseEventArgs
��5 C
evento
��D J
)
��J K
{
�� 	
if
�� 
(
�� !
cursorSostienePieza
�� #
)
��# $
{
�� 
piezaActual
�� 
=
�� ,
BuscarPiezaPertenecienteABorde
�� <
(
��< =
(
��= >
Border
��> D
)
��D E
objetoOrigen
��E Q
)
��Q R
;
��R S
Point
�� "
posicionActualCursor
�� *
=
��+ ,
evento
��- 3
.
��3 4
GetPosition
��4 ?
(
��? @!
tableroRompecabezas
��@ S
)
��S T
;
��T U
double
�� !
diferenciaPosicionX
�� *
=
��+ ,"
posicionActualCursor
��- A
.
��A B
X
��B C
-
��D E#
posicionInicialCursor
��F [
.
��[ \
X
��\ ]
;
��] ^
double
�� !
diferenciaPosicionY
�� *
=
��+ ,"
posicionActualCursor
��- A
.
��A B
Y
��B C
-
��D E#
posicionInicialCursor
��F [
.
��[ \
Y
��\ ]
;
��] ^
double
�� 
nuevaPosicionX
�� %
=
��& '
Canvas
��( .
.
��. /
GetLeft
��/ 6
(
��6 7
piezaActual
��7 B
.
��B C
Borde
��C H
)
��H I
+
��J K!
diferenciaPosicionX
��L _
;
��_ `
double
�� 
nuevaPosicionY
�� %
=
��& '
Canvas
��( .
.
��. /
GetTop
��/ 5
(
��5 6
piezaActual
��6 A
.
��A B
Borde
��B G
)
��G H
+
��I J!
diferenciaPosicionY
��K ^
;
��^ _
if
�� 
(
�� -
EsPosicionValidaParaPiezaActual
�� 3
(
��3 4
nuevaPosicionX
��4 B
,
��B C
nuevaPosicionY
��D R
)
��R S
)
��S T
{
�� 
Canvas
�� 
.
�� 
SetLeft
�� "
(
��" #
piezaActual
��# .
.
��. /
Borde
��/ 4
,
��4 5
Canvas
�� 
.
�� 
GetLeft
�� &
(
��& '
piezaActual
��' 2
.
��2 3
Borde
��3 8
)
��8 9
+
��: ;!
diferenciaPosicionX
��< O
)
��O P
;
��P Q
Canvas
�� 
.
�� 
SetTop
�� !
(
��! "
piezaActual
��" -
.
��- .
Borde
��. 3
,
��3 4
Canvas
�� 
.
�� 
GetTop
�� %
(
��% &
piezaActual
��& 1
.
��1 2
Borde
��2 7
)
��7 8
+
��9 :!
diferenciaPosicionY
��; N
)
��N O
;
��O P#
posicionInicialCursor
�� )
=
��* +"
posicionActualCursor
��, @
;
��@ A
}
�� 
}
�� 
}
�� 	
private
�� 
void
�� 
SoltarPieza
��  
(
��  !
object
��! '
objetoOrigen
��( 4
,
��4 5"
MouseButtonEventArgs
��6 J
evento
��K Q
)
��Q R
{
�� 	
if
�� 
(
�� !
cursorSostienePieza
�� #
)
��# $
{
�� 
piezaActual
�� 
.
�� 
Borde
�� !
.
��! "!
ReleaseMouseCapture
��" 5
(
��5 6
)
��6 7
;
��7 8!
cursorSostienePieza
�� #
=
��$ %
false
��& +
;
��+ ,
piezaActual
�� 
=
�� ,
BuscarPiezaPertenecienteABorde
�� <
(
��< =
(
��= >
Border
��> D
)
��D E
objetoOrigen
��E Q
)
��Q R
;
��R S
piezaActual
�� 
.
�� 
Borde
�� !
.
��! "
BorderBrush
��" -
=
��. /
Brushes
��0 7
.
��7 8
Transparent
��8 C
;
��C D
Point
�� 
posicionActual
�� $
=
��% &
evento
��' -
.
��- .
GetPosition
��. 9
(
��9 :!
tableroRompecabezas
��: M
)
��M N
;
��N O
piezaActual
�� 
.
�� 3
%EstablecerEstiloDePiezaSinSeleccionar
�� A
(
��A B
)
��B C
;
��C D3
%PosicionarPiezaEnCeldaCorrespondiente
�� 5
(
��5 6
posicionActual
��6 D
)
��D E
;
��E F
if
�� 
(
�� 
tablero
�� 
.
�� &
EsRompecabezasCompletado
�� 4
(
��4 5
)
��5 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� #
(
��# $

Properties
��$ .
.
��. /
	Resources
��/ 8
.
��8 9.
 ETIQUETA_PARTIDA_JUEGOFINALIZADO
��9 Y
)
��Y Z
;
��Z [-
RemoverEventoVentanaDesactivada
�� 3
(
��3 4
)
��4 5
;
��5 6
VentanaPrincipal
�� $
.
��$ %
CambiarPagina
��% 2
(
��2 3
new
��3 6
PaginaResultados
��7 G
(
��G H
)
��H I
)
��I J
;
��J K
}
�� 
}
�� 
}
�� 	
public
�� 
void
�� ,
ActualizarNuevaPosicionDePieza
�� 2
(
��2 3
double
��3 9
	posicionX
��: C
,
��C D
double
��E K
	posicionY
��L U
)
��U V
{
�� 	
throw
�� 
new
�� %
NotImplementedException
�� -
(
��- .
)
��. /
;
��/ 0
}
�� 	
}
�� 
}�� �
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRecuperacionContrasena.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class (
PaginaRecuperacionContrasena 5
:6 7
Page8 <
{		 
public

 (
PaginaRecuperacionContrasena

 +
(

+ ,
)

, -
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void /
#IrAPaginaRestablecimientoContrasena 8
(8 9
object9 ?
objetoOrigen@ L
,L M
RoutedEventArgs 
evento "
)" #
{ 	
string 
correo 
= 
cuadroTextoCorreo -
.- .
Text. 2
;2 3
if 
( 
! 
ValidadorDatos 
.  0
$ExistenCaracteresInvalidosParaCorreo  D
(D E
correoE K
)K L
)L M
{ 
if 
( 
	Servicios 
. 
ServicioCorreo ,
., -#
ExisteCorreoElectronico- D
(D E
correoE K
)K L
)L M
{ 2
&PaginaCodigoRestablecimientoContrasena :2
&paginaCodigoRestablecimientoContrasena >
=? @
newA D2
&PaginaCodigoRestablecimientoContrasena >
(> ?
correo? E
)E F
;F G
VentanaPrincipal $
.$ %
CambiarPagina% 2
(2 32
&paginaCodigoRestablecimientoContrasena3 Y
)Y Z
;Z [
} 
else 
{ 

MessageBox 
. 
Show #
(# $

Properties$ .
.. /
	Resources/ 8
.8 9C
7ETIQUETA_RECUPERACIONCONTRASENA_MENSAJECORREOINEXISTENE   O
,  O P

Properties  Q [
.  [ \
	Resources!! !
.!!! "=
1ETIQUETA_RECUPERACIONCONTRASENA_CORREOINEXISTENTE!!" S
,!!S T
MessageBoxButton"" (
.""( )
OK"") +
)""+ ,
;"", -
}## 
}$$ 
else%% 
{&& 

MessageBox'' 
.'' 
Show'' 
(''  

Properties''  *
.''* +
	Resources''+ 4
.''4 55
)ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO''5 ^
,''^ _

Properties(( 
.(( 
	Resources(( (
.((( ).
"ETIQUETA_VALIDACION_CORREOINVALIDO(() K
,((K L
MessageBoxButton((M ]
.((] ^
OK((^ `
)((` a
;((a b
})) 
}** 	
private,, 
void,, !
IrAPaginaInicioSesion,, *
(,,* +
object,,+ 1
objetoOrigen,,2 >
,,,> ? 
MouseButtonEventArgs,,@ T
evento,,U [
),,[ \
{-- 	
VentanaPrincipal.. 
... 
CambiarPagina.. *
(..* +
new..+ .
PaginaInicioSesion../ A
(..A B
)..B C
)..C D
;..D E
}// 	
}00 
}11 �o
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRegistroJugador.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public		 

partial		 
class		 !
PaginaRegistroJugador		 .
:		/ 0
Page		1 5
{

 
public !
PaginaRegistroJugador $
($ %
)% &
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
public !
PaginaRegistroJugador $
($ %
int% (
numeroAvatar) 5
,5 6
string7 =
nombreJugador> K
,K L
string 
correo 
, 
string !

contrasena" ,
,, -
string. 4"
confirmacionContrasena5 K
)K L
{ 	
InitializeComponent 
(  
)  !
;! "
CargarDatosEdicion 
( 
numeroAvatar +
,+ ,
nombreJugador- :
,: ;
correo< B
,B C

contrasena 
, "
confirmacionContrasena 2
)2 3
;3 4
} 	
private 
void 
CargarDatosEdicion '
(' (
int( +
numeroAvatar, 8
,8 9
string: @
nombreJugadorA N
,N O
string 
correo 
, 
string !

contrasena" ,
,, -
string. 4"
confirmacionContrasena5 K
)K L
{ 	$
cuadroTextoNombreJugador $
.$ %
Text% )
=* +
nombreJugador, 9
;9 :(
cuadroTextoCorreoElectronico (
.( )
Text) -
=. /
correo0 6
;6 7&
cuadroContrasenaContrasena &
.& '
Password' /
=0 1

contrasena2 <
;< =2
&cuadroContrasenaConfirmacionContrasena 2
.2 3
Password3 ;
=< ="
confirmacionContrasena> T
;T U
imagenAvatarActual 
. 
Source %
=& '

Utilidades( 2
.2 3
GeneradorImagenes3 D
.D E%
GenerarFuenteImagenAvatar   )
(  ) *
numeroAvatar  * 6
)  6 7
;  7 8
imagenAvatarActual!! 
.!! 
Tag!! "
=!!# $
Convert!!% ,
.!!, -
ToInt16!!- 4
(!!4 5
numeroAvatar!!5 A
)!!A B
;!!B C
}"" 	
private$$ 
void$$ !
IrAPaginaInicioSesion$$ *
($$* +
object$$+ 1
objetoOrigen$$2 >
,$$> ? 
MouseButtonEventArgs$$@ T
evento$$U [
)$$[ \
{%% 	
VentanaPrincipal&& 
.&& 
CambiarPagina&& *
(&&* +
new&&+ .
PaginaInicioSesion&&/ A
(&&A B
)&&B C
)&&C D
;&&D E
}'' 	
private)) 
void)) $
IrAPaginaSeleccionAvatar)) -
())- .
object)). 4
objetoOrigen))5 A
,))A B
RoutedEventArgs))C R
evento))S Y
)))Y Z
{** 	
VentanaPrincipal++ 
.++ *
CambiarPaginaGuardandoAnterior++ ;
(++; <
new++< ?!
PaginaSeleccionAvatar++@ U
(++U V
Convert,, 
.,, 
ToInt32,, 
(,,  
imagenAvatarActual,,  2
.,,2 3
Tag,,3 6
),,6 7
,,,7 8$
cuadroTextoNombreJugador,,9 Q
.,,Q R
Text,,R V
,,,V W(
cuadroTextoCorreoElectronico-- ,
.--, -
Text--- 1
,--1 2&
cuadroContrasenaContrasena--3 M
.--M N
Password--N V
,--V W2
&cuadroContrasenaConfirmacionContrasena.. 6
...6 7
Password..7 ?
)..? @
)..@ A
;..A B
}// 	
private11 
void11 '
IrAPaginaVerificacionCorreo11 0
(110 1
object111 7
objetoOrigen118 D
,11D E
RoutedEventArgs11F U
evento11V \
)11\ ]
{22 	
string33 
nombreJugador33  
=33! "$
cuadroTextoNombreJugador33# ;
.33; <
Text33< @
;33@ A
string44 
correo44 
=44 (
cuadroTextoCorreoElectronico44 8
.448 9
Text449 =
.44= >
ToLower44> E
(44E F
)44F G
;44G H
string55 

contrasena55 
=55 &
cuadroContrasenaContrasena55  :
.55: ;
Password55; C
;55C D
int66 
numeroAvatar66 
=66 
Convert66 &
.66& '
ToInt3266' .
(66. /
imagenAvatarActual66/ A
.66A B
Tag66B E
)66E F
;66F G
if88 
(88 
!88 "
ExistenCamposInvalidos88 '
(88' (
)88( )
)88) *
{99 
if:: 
(:: 
!:: 
	Servicios:: 
.:: 
ServicioJugador:: .
.::. /
ExisteNombreJugador::/ B
(::B C
nombreJugador::C P
)::P Q
)::Q R
{;; 
if<< 
(<< 
!<< 
	Servicios<< "
.<<" #
ServicioCorreo<<# 1
.<<1 2#
ExisteCorreoElectronico<<2 I
(<<I J
correo<<J P
)<<P Q
)<<Q R
{== 
Dominio>> 
.>>  
CuentaJugador>>  -
jugadorRegistro>>. =
=>>> ?
new>>@ C
Dominio>>D K
.>>K L
CuentaJugador>>L Y
{?? 
NombreJugador@@ )
=@@* +
nombreJugador@@, 9
,@@9 :
CorreoAA "
=AA# $
correoAA% +
,AA+ ,

ContrasenaBB &
=BB' (

contrasenaBB) 3
,BB3 4
NumeroAvatarCC (
=CC) *
numeroAvatarCC+ 7
,CC7 8
}DD 
;DD 
VentanaPrincipalEE (
.EE( )
CambiarPaginaEE) 6
(EE6 7
newEE7 :$
PaginaVerificacionCorreoEE; S
(EES T
jugadorRegistroFF +
)FF+ ,
)FF, -
;FF- .
}GG 
elseHH 
{II 
}KK 
}LL 
elseMM 
{NN 
}PP 
}QQ 
}RR 	
privateTT 
boolTT "
ExistenCamposInvalidosTT +
(TT+ ,
)TT, -
{UU 	
boolVV 
hayCamposInvalidosVV #
=VV$ %
falseVV& +
;VV+ ,
ifXX 
(XX 
ExistenCamposVaciosXX #
(XX# $
)XX$ %
)XX% &
{YY 

MessageBoxZZ 
.ZZ 
ShowZZ 
(ZZ  

PropertiesZZ  *
.ZZ* +
	ResourcesZZ+ 4
.ZZ4 53
'ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS[[ ;
,[[; <

Properties[[= G
.[[G H
	Resources[[H Q
.[[Q R,
 ETIQUETA_VALIDACION_CAMPOSVACIOS\\ 4
,\\4 5
MessageBoxButton\\6 F
.\\F G
OK\\G I
)\\I J
;\\J K
hayCamposInvalidos]] "
=]]# $
true]]% )
;]]) *
}^^ 
if`` 
(`` 
ValidadorDatos`` 
.`` 7
+ExistenCaracteresInvalidosParaNombreJugador`` J
(``J K$
cuadroTextoNombreJugadoraa (
.aa( )
Textaa) -
)aa- .
)aa. /
{bb 

MessageBoxcc 
.cc 
Showcc 
(cc  

Propertiescc  *
.cc* +
	Resourcescc+ 4
.cc4 5<
0ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDOdd D
,ddD E

PropertiesddF P
.ddP Q
	ResourcesddQ Z
.ddZ [5
)ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDOee =
,ee= >
MessageBoxButtonee? O
.eeO P
OKeeP R
)eeR S
;eeS T
hayCamposInvalidosff "
=ff# $
trueff% )
;ff) *
}gg 
ifii 
(ii 
ValidadorDatosii 
.ii 0
$ExistenCaracteresInvalidosParaCorreoii C
(iiC D(
cuadroTextoCorreoElectronicojj ,
.jj, -
Textjj- 1
)jj1 2
)jj2 3
{kk 

MessageBoxll 
.ll 
Showll 
(ll  

Propertiesll  *
.ll* +
	Resourcesll+ 4
.ll4 55
)ETIQUETA_VALIDACION_MENSAJECORREOINVALIDOmm =
,mm= >

Propertiesmm? I
.mmI J
	ResourcesmmJ S
.mmS T.
"ETIQUETA_VALIDACION_CORREOINVALIDOnn 6
,nn6 7
MessageBoxButtonnn8 H
.nnH I
OKnnI K
)nnK L
;nnL M
hayCamposInvalidosoo "
=oo# $
trueoo% )
;oo) *
}pp 
ifrr 
(rr 
ValidadorDatosrr 
.rr 4
(ExistenCaracteresInvalidosParaContrasenarr G
(rrG H&
cuadroContrasenaContrasenass *
.ss* +
Passwordss+ 3
)ss3 4
)ss4 5
{tt 

MessageBoxuu 
.uu 
Showuu 
(uu  

Propertiesuu  *
.uu* +
	Resourcesuu+ 4
.uu4 59
-ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDAvv A
,vvA B

PropertiesvvC M
.vvM N
	ResourcesvvN W
.vvW X2
&ETIQUETA_VALIDACION_CONTRASENAINVALIDAww :
,ww: ;
MessageBoxButtonww< L
.wwL M
OKwwM O
)wwO P
;wwP Q
hayCamposInvalidosxx "
=xx# $
truexx% )
;xx) *
}yy 
if{{ 
({{ &
ExistenLongitudesExcedidas{{ *
({{* +
){{+ ,
){{, -
{|| 

MessageBox}} 
.}} 
Show}} 
(}}  

Properties}}  *
.}}* +
	Resources}}+ 4
.}}4 56
*ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS~~ >
,~~> ?

Properties~~@ J
.~~J K
	Resources~~K T
.~~T U/
#ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS 7
,7 8
MessageBoxButton9 I
.I J
OKJ L
)L M
;M N 
hayCamposInvalidos
�� "
=
��# $
true
��% )
;
��) *
}
�� 
if
�� 
(
�� 
!
�� 
ValidadorDatos
�� 
.
��  )
ExisteCoincidenciaEnCadenas
��  ;
(
��; <(
cuadroContrasenaContrasena
��< V
.
��V W
Password
��W _
,
��_ `4
&cuadroContrasenaConfirmacionContrasena
�� 6
.
��6 7
Password
��7 ?
)
��? @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 5<
.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE
�� B
,
��B C

Properties
��D N
.
��N O
	Resources
��O X
.
��X Y5
'ETIQUETA_VALIDACION_CONTRASENADIFERENTE
�� ;
,
��; <
MessageBoxButton
��= M
.
��M N
OK
��N P
)
��P Q
;
��Q R 
hayCamposInvalidos
�� "
=
��# $
true
��% )
;
��) *
}
�� 
return
��  
hayCamposInvalidos
�� %
;
��% &
}
�� 	
private
�� 
bool
�� !
ExistenCamposVacios
�� (
(
��( )
)
��) *
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
if
�� 
(
�� 
ValidadorDatos
�� 
.
�� 
EsCadenaVacia
�� ,
(
��, -&
cuadroTextoNombreJugador
��- E
.
��E F
Text
��F J
)
��J K
||
�� 
ValidadorDatos
�� !
.
��! "
EsCadenaVacia
��" /
(
��/ 0*
cuadroTextoCorreoElectronico
��0 L
.
��L M
Text
��M Q
)
��Q R
||
�� 
ValidadorDatos
�� !
.
��! "
EsCadenaVacia
��" /
(
��/ 0(
cuadroContrasenaContrasena
��0 J
.
��J K
Password
��K S
)
��S T
||
�� 
ValidadorDatos
�� !
.
��! "
EsCadenaVacia
��" /
(
��/ 04
&cuadroContrasenaConfirmacionContrasena
��0 V
.
��V W
Password
��W _
)
��_ `
)
��` a
{
�� 
	resultado
�� 
=
�� 
true
��  
;
��  !
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
private
�� 
bool
�� (
ExistenLongitudesExcedidas
�� /
(
��/ 0
)
��0 1
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
if
�� 
(
�� 
ValidadorDatos
�� 
.
�� 3
%ExisteLongitudExcedidaEnNombreJugador
�� D
(
��D E&
cuadroTextoNombreJugador
�� (
.
��( )
Text
��) -
)
��- .
||
��/ 1
ValidadorDatos
�� 
.
�� ,
ExisteLongitudExcedidaEnCorreo
�� =
(
��= >*
cuadroTextoCorreoElectronico
�� ,
.
��, -
Text
��- 1
)
��1 2
||
��3 5
ValidadorDatos
�� 
.
�� 0
"ExisteLongitudExcedidaEnContrasena
�� A
(
��A B(
cuadroContrasenaContrasena
�� *
.
��* +
Password
��+ 3
)
��3 4
)
��4 5
{
�� 
	resultado
�� 
=
�� 
true
��  
;
��  !
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
}
�� 
}�� �
|C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaResultados.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class 
PaginaResultados )
:* +
Page, 0
{ 
public 
PaginaResultados 
(  
)  !
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
IrAPaginaSala "
(" #
object# )
objetoOrigen* 6
,6 7
RoutedEventArgs8 G
eventoH N
)N O
{ 	

PaginaSala 

paginaSala !
=" #
new$ '

PaginaSala( 2
(2 3
)3 4
;4 5
VentanaPrincipal 
. 
CambiarPagina *
(* +

paginaSala+ 5
)5 6
;6 7
} 	
} 
}   �&
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRestablecimientoContrasena.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class ,
 PaginaRestablecimientoContrasena 9
:: ;
Page< @
{		 
private

 
readonly

 
string

 
correo

  &
;

& '
public ,
 PaginaRestablecimientoContrasena /
(/ 0
string0 6
correo7 =
)= >
{ 	
InitializeComponent 
(  
)  !
;! "
this 
. 
correo 
= 
correo  
;  !
} 	
private 
void  
ActualizarContrasena )
() *
object* 0
objetoOrigen1 =
,= >
RoutedEventArgs? N
eventoO U
)U V
{ 	
string 

contrasena 
= !
cuadroContrasenaNueva  5
.5 6
Password6 >
.> ?
ToString? G
(G H
)H I
;I J
if 
( 
!  
EsContrasenaInvalida %
(% &

contrasena& 0
)0 1
)1 2
{ 
if 
( 
ValidadorDatos "
." #'
ExisteCoincidenciaEnCadenas# >
(> ?!
cuadroContrasenaNueva? T
.T U
PasswordU ]
,] ^*
cuadroConfirmarNuevaContrasena 2
.2 3
Password3 ;
); <
)< =
{ 
string 
contrasenaCifrada ,
=- .!
EncriptadorContrasena/ D
.D E
CalcularHashSha512 *
(* +

contrasena+ 5
)5 6
;6 7
bool "
actualizacionRealizada /
=0 1
	Servicios2 ;
.; <
ServicioJugador< K
.K L 
ActualizarContrasena ,
(, -
correo- 3
,3 4
contrasenaCifrada5 F
)F G
;G H
if   
(   "
actualizacionRealizada   .
)  . /
{!! 

MessageBox"" "
.""" #
Show""# '
(""' (

Properties""( 2
.""2 3
	Resources""3 <
.""< =B
6ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENAACTUALIZADA## R
,##R S

Properties##T ^
.##^ _
	Resources$$ %
.$$% &<
0ETIQUETA_RESTABLECIMIENTO_CONTRASENARESTABLECIDA$$& V
,$$V W
MessageBoxButton%% ,
.%%, -
OK%%- /
)%%/ 0
;%%0 1
VentanaPrincipal&& (
.&&( )
CambiarPagina&&) 6
(&&6 7
new&&7 :
PaginaInicioSesion&&; M
(&&M N
)&&N O
)&&O P
;&&P Q
}'' 
else(( 
{)) 

MessageBox** "
.**" #
Show**# '
(**' (

Properties**( 2
.**2 3
	Resources**3 <
.**< =E
9ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENANORESTABLECIDA++ U
,++U V

Properties++W a
.++a b
	Resources,, %
.,,% &>
2ETIQUETA_RESTABLECIMIENTO_CONTRASENANORESTABLECIDA,,& X
,,,X Y
MessageBoxButton-- ,
.--, -
OK--- /
)--/ 0
;--0 1
}.. 
}// 
else00 
{11 

MessageBox22 
.22 
Show22 #
(22# $

Properties22$ .
.22. /
	Resources22/ 8
.228 9:
.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE33 F
,33F G

Properties44 "
.44" #
	Resources44# ,
.44, -3
'ETIQUETA_VALIDACION_CONTRASENADIFERENTE44- T
,44T U
MessageBoxButton55 (
.55( )
OK55) +
)55+ ,
;55, -
}66 
}77 
}88 	
private:: 
bool::  
EsContrasenaInvalida:: )
(::) *
string::* 0

contrasena::1 ;
)::; <
{;; 	
bool<< 
camposInvalidos<<  
=<<! "
false<<# (
;<<( )
if>> 
(>> 
ValidadorDatos>> 
.>> .
"ExisteLongitudExcedidaEnContrasena>> A
(>>A B

contrasena>>B L
)>>L M
||>>N P
ValidadorDatos?? 
.?? 4
(ExistenCaracteresInvalidosParaContrasena?? G
(??G H

contrasena??H R
)??R S
)??S T
{@@ 
camposInvalidosAA 
=AA  !
trueAA" &
;AA& '
}BB 
returnDD 
camposInvalidosDD "
;DD" #
}EE 	
}FF 
}GG ��
vC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaSala.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
[ 
CallbackBehavior 
( 
ConcurrencyMode %
=& '
ConcurrencyMode( 7
.7 8
Multiple8 @
)@ A
]A B
public 

partial 
class 

PaginaSala #
:$ %
Page& *
,* +!
IServicioSalaCallback, A
{ 
private 
string 

codigoSala !
;! "
private 
bool 
esAnfitrion  
;  !
private 
ServicioSalaClient " 
clienteServicioJuego# 7
;7 8
private  
ObservableCollection $
<$ %
Dominio% ,
., -
CuentaJugador- :
>: ;
jugadoresEnSala< K
;K L
public 
string 

CodigoSala  
{ 	
get 
{ 
return 

codigoSala #
;# $
}% &
set 
{ 

codigoSala 
= 
value $
;$ %
}& '
} 	
public 
bool 
EsAnfitrion 
{ 	
get 
{ 
return 
esAnfitrion $
;$ %
}& '
set 
{ 
esAnfitrion 
= 
value  %
;% &
}' (
} 	
public!!  
ObservableCollection!! #
<!!# $
Dominio!!$ +
.!!+ ,
CuentaJugador!!, 9
>!!9 :
JugadoresEnSala!!; J
{"" 	
get## 
{## 
return## 
jugadoresEnSala## (
;##( )
}##* +
set$$ 
{$$ 
jugadoresEnSala$$ !
=$$" #
value$$$ )
;$$) *
}$$+ ,
}%% 	
public'' 

PaginaSala'' 
('' 
)'' 
{(( 	
InitializeComponent)) 
())  
)))  !
;))! "
jugadoresEnSala** 
=** 
new** ! 
ObservableCollection**" 6
<**6 7
Dominio**7 >
.**> ?
CuentaJugador**? L
>**L M
(**M N
)**N O
;**O P
listaJugadoresSala++ 
.++ 
DataContext++ *
=+++ ,
this++- 1
;++1 2
},, 	
private.. 
void.. "
IrAPaginaMenuPrincipal.. +
(..+ ,
object.., 2
objetoOrigen..3 ?
,..? @ 
MouseButtonEventArgs..A U
evento..V \
)..\ ]
{// 	$
FinalizarConexionConSala00 $
(00$ %
)00% &
;00& '
VentanaPrincipal11 
.11 
CambiarPagina11 *
(11* +
new11+ .
PaginaMenuPrincipal11/ B
(11B C
)11C D
)11D E
;11E F
}22 	
private44 
void44 ,
 CopiarCodigoDeSalaEnPortapapeles44 5
(445 6
object446 <
objetoOrigen44= I
,44I J
RoutedEventArgs55 
evento55 "
)55" #
{66 	
	Clipboard77 
.77 
SetText77 
(77 

codigoSala77 (
)77( )
;77) *
}88 	
private:: 
void:: %
EnviarMensajeEnChatDeSala:: .
(::. /
object::/ 5
objetoOrigen::6 B
,::B C
RoutedEventArgs::D S
evento::T Z
)::Z [
{;; 	
if<< 
(<< 
!<< 
ValidadorDatos<< 
.<<  
EsCadenaVacia<<  -
(<<- .%
cuadroTextoMensajeUsuario<<. G
.<<G H
Text<<H L
.<<L M
Trim<<M Q
(<<Q R
)<<R S
)<<S T
)<<T U
{==  
clienteServicioJuego>> $
.>>$ %
EnviarMensajeDeSala>>% 8
(>>8 9
Dominio>>9 @
.>>@ A
CuentaJugador>>A N
.>>N O
Actual?? 
.?? 
NombreJugador?? (
,??( )

codigoSala??* 4
,??4 5%
cuadroTextoMensajeUsuario??6 O
.??O P
Text??P T
)??T U
;??U V%
cuadroTextoMensajeUsuario@@ )
.@@) *
Clear@@* /
(@@/ 0
)@@0 1
;@@1 2
}AA 
}BB 	
privateDD 
voidDD )
IrAPaginaCreacionNuevaPartidaDD 2
(DD2 3
objectDD3 9
objetoOrigenDD: F
,DDF G
RoutedEventArgsDDH W
eventoDDX ^
)DD^ _
{EE 	&
PaginaCreacionNuevaPartidaFF &&
paginaCreacionNuevaPartidaFF' A
=FFB C
newGG &
PaginaCreacionNuevaPartidaGG .
(GG. /
)GG/ 0
;GG0 1&
paginaCreacionNuevaPartidaHH &
.HH& '

CodigoSalaHH' 1
=HH2 3

codigoSalaHH4 >
;HH> ?
VentanaPrincipalII 
.II 
CambiarPaginaII *
(II* +&
paginaCreacionNuevaPartidaII+ E
)IIE F
;IIF G
}JJ 	
publicLL 
voidLL 
UnirseASalaLL 
(LL  
)LL  !
{MM 	 
clienteServicioJuegoNN  
=NN! "
newNN# &
ServicioSalaClientNN' 9
(NN9 :
newNN: =
InstanceContextNN> M
(NNM N
thisNNN R
)NNR S
)NNS T
;NNT U
ifPP 
(PP 
esAnfitrionPP 
)PP 
{QQ 
botonNuevaPartidaRR !
.RR! "

VisibilityRR" ,
=RR- .

VisibilityRR/ 9
.RR9 :
VisibleRR: A
;RRA B
CrearNuevaSalaSS 
(SS 
)SS  
;SS  !
}TT 
elseUU 
{VV 
botonNuevaPartidaWW !
.WW! "

VisibilityWW" ,
=WW- .

VisibilityWW/ 9
.WW9 :
HiddenWW: @
;WW@ A!
CargarJugadoresEnSalaXX %
(XX% &
)XX& '
;XX' (
}YY 
etiquetaCodigoSala[[ 
.[[ 
Content[[ &
=[[' (

codigoSala[[) 3
;[[3 4&
ConectarCuentaJugadorASala\\ &
(\\& '
Dominio\\' .
.\\. /
CuentaJugador\\/ <
.\\< =
Actual\\= C
.\\C D
NombreJugador\\D Q
)\\Q R
;\\R S
jugadoresEnSala]] 
.]] 
Add]] 
(]]  
Dominio]]  '
.]]' (
CuentaJugador]]( 5
.]]5 6
Actual]]6 <
)]]< =
;]]= >
}^^ 	
private`` 
void`` &
ConectarCuentaJugadorASala`` /
(``/ 0
string``0 6
nombreJugador``7 D
)``D E
{aa 	
trybb 
{cc  
clienteServicioJuegodd $
.dd$ %&
ConectarCuentaJugadorASaladd% ?
(dd? @
nombreJugadordd@ M
,ddM N

codigoSalaee 
,ee 

Propertiesee  *
.ee* +
	Resourcesee+ 4
.ee4 5+
ETIQUETA_MENSAJESALA_BIENVENIDAee5 T
)eeT U
;eeU V
}ff 
catchgg 
(gg %
EndpointNotFoundExceptiongg ,
	excepciongg- 6
)gg6 7
{hh 

MessageBoxjj 
.jj 
Showjj 
(jj  

Propertiesjj  *
.jj* +
	Resourcesjj+ 4
.jj4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEkk :
,kk: ;

Propertieskk< F
.kkF G
	ResourceskkG P
.kkP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOll 9
,ll9 :
MessageBoxButtonmm $
.mm$ %
OKmm% '
,mm' (
MessageBoxImagemm) 8
.mm8 9
Errormm9 >
)mm> ?
;mm? @ 
clienteServicioJuegonn $
.nn$ %
Abortnn% *
(nn* +
)nn+ ,
;nn, -
}oo 
catchpp 
(pp /
#CommunicationObjectFaultedExceptionpp 6
	excepcionpp7 @
)pp@ A
{qq 

MessageBoxss 
.ss 
Showss 
(ss  

Propertiesss  *
.ss* +
	Resourcesss+ 4
.ss4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEtt :
,tt: ;

Propertiestt< F
.ttF G
	ResourcesttG P
.ttP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOuu 9
,uu9 :
MessageBoxButtonvv $
.vv$ %
OKvv% '
,vv' (
MessageBoxImagevv) 8
.vv8 9
Errorvv9 >
)vv> ?
;vv? @ 
clienteServicioJuegoww $
.ww$ %
Abortww% *
(ww* +
)ww+ ,
;ww, -
}xx 
catchyy 
(yy 
TimeoutExceptionyy #
	excepcionyy$ -
)yy- .
{zz 

MessageBox|| 
.|| 
Show|| 
(||  

Properties||  *
.||* +
	Resources||+ 4
.||4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE}} :
,}}: ;

Properties}}< F
.}}F G
	Resources}}G P
.}}P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO~~ 9
,~~9 :
MessageBoxButton $
.$ %
OK% '
,' (
MessageBoxImage) 8
.8 9
Error9 >
)> ?
;? @"
clienteServicioJuego
�� $
.
��$ %
Abort
��% *
(
��* +
)
��+ ,
;
��, -
}
�� 
}
�� 	
private
�� 
void
�� #
CargarJugadoresEnSala
�� *
(
��* +
)
��+ ,
{
�� 	
CuentaJugador
�� 
[
�� 
]
�� "
jugadoresRecuperados
�� 0
=
��1 2
	Servicios
��3 <
.
��< =
ServicioSala
��= I
.
��I J.
 ObtenerJugadoresConectadosEnSala
�� 0
(
��0 1

codigoSala
��1 ;
)
��; <
;
��< =
foreach
�� 
(
�� 
CuentaJugador
�� "
jugador
��# *
in
��+ -"
jugadoresRecuperados
��. B
)
��B C
{
�� 
jugadoresEnSala
�� 
.
��  
Add
��  #
(
��# $
new
��$ '
Dominio
��( /
.
��/ 0
CuentaJugador
��0 =
{
�� 
NombreJugador
�� !
=
��" #
jugador
��$ +
.
��+ ,
NombreJugador
��, 9
,
��9 : 
FuenteImagenAvatar
�� &
=
��' (

Utilidades
��) 3
.
��3 4
GeneradorImagenes
��4 E
.
��E F'
GenerarFuenteImagenAvatar
�� 1
(
��1 2
jugador
��2 9
.
��9 :
NumeroAvatar
��: F
)
��F G
}
�� 
)
�� 
;
�� 
}
�� 
}
�� 	
private
�� 
void
�� 
CrearNuevaSala
�� #
(
��# $
)
��$ %
{
�� 	

codigoSala
�� 
=
�� 
	Servicios
�� "
.
��" #
ServicioSala
��# /
.
��/ 0(
GenerarCodigoParaNuevaSala
��0 J
(
��J K
)
��K L
;
��L M
if
�� 
(
�� 

codigoSala
�� 
!=
�� 
null
�� "
)
��" #
{
�� 
	Servicios
�� 
.
�� 
ServicioSala
�� &
.
��& '
CrearNuevaSala
��' 5
(
��5 6
Dominio
��6 =
.
��= >
CuentaJugador
��> K
.
��K L
Actual
�� 
.
�� 
NombreJugador
�� (
,
��( )

codigoSala
��* 4
)
��4 5
;
��5 6
}
�� 
}
�� 	
private
�� 
void
�� &
FinalizarConexionConSala
�� -
(
��- .
)
��. /
{
�� 	
try
�� 
{
�� "
clienteServicioJuego
�� $
.
��$ %,
DesconectarCuentaJugadorDeSala
��% C
(
��C D
Dominio
��D K
.
��K L
CuentaJugador
�� !
.
��! "
Actual
��" (
.
��( )
NombreJugador
��) 6
,
��6 7

codigoSala
��8 B
,
��B C

Properties
�� 
.
�� 
	Resources
�� (
.
��( ),
ETIQUETA_MENSAJESALA_DESPEDIDA
��) G
)
��G H
;
��H I"
clienteServicioJuego
�� $
.
��$ %
Close
��% *
(
��* +
)
��+ ,
;
��, -
}
�� 
catch
�� 
(
�� '
EndpointNotFoundException
�� ,
	excepcion
��- 6
)
��6 7
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @"
clienteServicioJuego
�� $
.
��$ %
Abort
��% *
(
��* +
)
��+ ,
;
��, -
}
�� 
catch
�� 
(
�� 1
#CommunicationObjectFaultedException
�� 6
	excepcion
��7 @
)
��@ A
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @"
clienteServicioJuego
�� $
.
��$ %
Abort
��% *
(
��* +
)
��+ ,
;
��, -
}
�� 
catch
�� 
(
�� 
TimeoutException
�� #
	excepcion
��$ -
)
��- .
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  

Properties
��  *
.
��* +
	Resources
��+ 4
.
��4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
�� :
,
��: ;

Properties
��< F
.
��F G
	Resources
��G P
.
��P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
�� 9
,
��9 :
MessageBoxButton
�� $
.
��$ %
OK
��% '
,
��' (
MessageBoxImage
��) 8
.
��8 9
Error
��9 >
)
��> ?
;
��? @"
clienteServicioJuego
�� $
.
��$ %
Abort
��% *
(
��* +
)
��+ ,
;
��, -
}
�� "
clienteServicioJuego
��  
=
��! "
null
��# '
;
��' (
}
�� 	
private
�� 
void
�� &
ModificarJugadoresEnSala
�� -
(
��- .
object
��. 4
objetoOrigen
��5 A
,
��A B"
MouseButtonEventArgs
��  
evento
��! '
)
��' (
{
�� 	
}
�� 	
public
�� 
void
�� "
MostrarMensajeDeSala
�� (
(
��( )
string
��) /
mensaje
��0 7
)
��7 8
{
�� 	!
cuadroTextoMensajes
�� 
.
��  

AppendText
��  *
(
��* +
mensaje
��+ 2
+
��3 4
$str
��5 9
)
��9 :
;
��: ;
}
�� 	
public
�� 
void
�� 2
$NotificarNuevoJugadorConectadoEnSala
�� 8
(
��8 9
CuentaJugador
��9 F
nuevoJugador
��G S
)
��S T
{
�� 	
if
�� 
(
�� 
jugadoresEnSala
�� 
!=
��  "
null
��# '
)
��' (
{
�� 
Dominio
�� 
.
�� 
CuentaJugador
�� % 
nuevaCuentaJugador
��& 8
=
��9 :
new
��; >
Dominio
��? F
.
��F G
CuentaJugador
��G T
{
��  
FuenteImagenAvatar
�� &
=
��' (

Utilidades
��) 3
.
��3 4
GeneradorImagenes
��4 E
.
��E F'
GenerarFuenteImagenAvatar
�� 1
(
��1 2
nuevoJugador
��2 >
.
��> ?
NumeroAvatar
��? K
)
��K L
,
��L M
NombreJugador
�� !
=
��" #
nuevoJugador
��$ 0
.
��0 1
NombreJugador
��1 >
}
�� 
;
�� 
jugadoresEnSala
�� 
.
��  
Add
��  #
(
��# $ 
nuevaCuentaJugador
��$ 6
)
��6 7
;
��7 8
}
�� 
}
�� 	
public
�� 
void
�� 0
"NotificarJugadorDesconectadoDeSala
�� 6
(
��6 7
string
��7 =
nombreJugador
��> K
)
��K L
{
�� 	
if
�� 
(
�� 
jugadoresEnSala
�� 
!=
��  "
null
��# '
)
��' (
{
�� 
Dominio
�� 
.
�� 
CuentaJugador
�� %%
cuentaJugadorEncontrada
��& =
=
��> ?
jugadoresEnSala
�� #
.
��# $
Where
��$ )
(
��) *
jugador
��* 1
=>
��2 4
jugador
��5 <
.
��< =
NombreJugador
��= J
==
��K M
nombreJugador
�� !
)
��! "
.
��" #
FirstOrDefault
��# 1
(
��1 2
)
��2 3
;
��3 4
if
�� 
(
�� %
cuentaJugadorEncontrada
�� +
!=
��, .
null
��/ 3
)
��3 4
{
�� 
jugadoresEnSala
�� #
.
��# $
Remove
��$ *
(
��* +%
cuentaJugadorEncontrada
��+ B
)
��B C
;
��C D
}
�� 
}
�� 
}
�� 	
}
�� 
}�� �+
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaSeleccionAvatar.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public		 

partial		 
class		 !
PaginaSeleccionAvatar		 .
:		/ 0
Page		1 5
{

 
private 
readonly 
string 
nombreJugador  -
;- .
private 
readonly 
string 
correo  &
;& '
private 
readonly 
string 

contrasena  *
;* +
private 
readonly 
string "
confirmacionContrasena  6
;6 7
private 
int 
numeroAvatar  
;  !
public !
PaginaSeleccionAvatar $
($ %
int% (
numeroAvatar) 5
,5 6
string7 =
nombreJugador> K
)K L
{ 	
InitializeComponent 
(  
)  !
;! "
this 
. 
nombreJugador 
=  
nombreJugador! .
;. /
this 
. 
numeroAvatar 
= 
numeroAvatar  ,
;, -%
MostrarImagenAvatarActual %
(% &
)& '
;' (
} 	
public !
PaginaSeleccionAvatar $
($ %
int% (
numeroAvatar) 5
,5 6
string7 =
nombreJugador> K
,K L
string 
correo 
, 
string !

contrasena" ,
,, -
string. 4"
confirmacionContrasena5 K
)K L
{ 	
InitializeComponent 
(  
)  !
;! "
this 
. 
nombreJugador 
=  
nombreJugador! .
;. /
this 
. 
correo 
= 
correo  
;  !
this 
. 

contrasena 
= 

contrasena (
;( )
this   
.   
numeroAvatar   
=   
numeroAvatar    ,
;  , -
this!! 
.!! "
confirmacionContrasena!! '
=!!( )"
confirmacionContrasena!!* @
;!!@ A%
MostrarImagenAvatarActual"" %
(""% &
)""& '
;""' (
}## 	
private%% 
void%% %
MostrarImagenAvatarActual%% .
(%%. /
)%%/ 0
{&& 	
imagenAvatarActual'' 
.'' 
Source'' %
=''& '

Utilidades''( 2
.''2 3
GeneradorImagenes''3 D
.''D E%
GenerarFuenteImagenAvatar(( )
((() *
numeroAvatar((* 6
)((6 7
;((7 8
})) 	
private++ 
void++ "
SeleccionarNuevoAvatar++ +
(+++ ,
object++, 2
objetoOrigen++3 ?
,++? @ 
MouseButtonEventArgs++A U
evento++V \
)++\ ]
{,, 	
Image-- 
imagenSeleccionada-- $
=--% &
objetoOrigen--' 3
as--4 6
Image--7 <
;--< =
imagenAvatarActual.. 
... 
Source.. %
=..& '
imagenSeleccionada..( :
...: ;
Source..; A
;..A B
imagenAvatarActual// 
.// 
Tag// "
=//# $
imagenSeleccionada//% 7
.//7 8
Tag//8 ;
;//; <
numeroAvatar00 
=00 
Convert00 "
.00" #
ToInt3200# *
(00* +
imagenSeleccionada00+ =
.00= >
Tag00> A
)00A B
;00B C
}11 	
private33 
void33 
IrAPaginaAnterior33 &
(33& '
object33' -
objetoOrigen33. :
,33: ;
RoutedEventArgs33< K
evento33L R
)33R S
{44 	
if55 
(55 
typeof55 
(55 !
PaginaRegistroJugador55 ,
)55, -
.55- .
IsInstanceOfType55. >
(55> ?
VentanaPrincipal55? O
.55O P
PaginaAnterior55P ^
)55^ _
)55_ `
{66 !
PaginaRegistroJugador77 %!
paginaRegistroUsuario77& ;
=77< =
new77> A!
PaginaRegistroJugador77B W
(77W X
numeroAvatar88  
,88  !
nombreJugador88" /
,88/ 0
correo881 7
,887 8

contrasena889 C
,88C D"
confirmacionContrasena88E [
)88[ \
;88\ ]
VentanaPrincipal99  
.99  !
CambiarPagina99! .
(99. /!
paginaRegistroUsuario99/ D
)99D E
;99E F
}:: 
else;; 
{<< *
PaginaActualizacionInformacion== .*
paginaActualizacionInformacion==/ M
===N O
new>> *
PaginaActualizacionInformacion>> :
(>>: ;
nombreJugador>>; H
,>>H I
numeroAvatar>>J V
)>>V W
;>>W X
VentanaPrincipal??  
.??  !
CambiarPagina??! .
(??. /*
paginaActualizacionInformacion??/ M
)??M N
;??N O
}@@ 
}AA 	
}BB 
}CC �=
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaCreacionNuevaPartida.xaml.cs
	namespace 	
RompecabezasFei
 
{		 
public

 

partial

 
class

 &
PaginaCreacionNuevaPartida

 3
:

4 5
Page

6 :
{ 
private  
ObservableCollection $
<$ %
ImagenRompecabezas% 7
>7 8 
imagenesRompecabezas9 M
;M N
private 
Border #
bordeImagenSeleccionada .
;. /
private 

Dificultad 

dificultad %
;% &
private 
int 
numeroImagen  
;  !
private 
string 

codigoSala !
;! "
public  
ObservableCollection #
<# $
ImagenRompecabezas$ 6
>6 7 
ImagenesRompecabezas8 L
{ 	
get 
{ 
return  
imagenesRompecabezas -
;- .
}/ 0
set 
{  
imagenesRompecabezas &
=' (
value) .
;. /
}0 1
} 	
public 
string 

CodigoSala  
{ 	
get 
{ 
return 

codigoSala #
;# $
}% &
set 
{ 

codigoSala 
= 
value $
;$ %
}& '
} 	
public &
PaginaCreacionNuevaPartida )
() *
)* +
{ 	
InitializeComponent   
(    
)    !
;  ! ")
MostrarImagenesDeRompecabezas!! )
(!!) *
)!!* +
;!!+ ,

dificultad"" 
="" 

Dificultad"" #
.""# $
Facil""$ )
;"") *%
cuadroSeleccionDificultad## %
.##% &
SelectedIndex##& 3
=##4 5
(##6 7
int##7 :
)##: ;

dificultad##; E
;##E F
numeroImagen$$ 
=$$ 
$num$$ 
;$$ '
galeriaImagenesRompecabezas%% '
.%%' (
DataContext%%( 3
=%%4 5
this%%6 :
;%%: ;
}&& 	
private(( 
void(( )
MostrarImagenesDeRompecabezas(( 2
(((2 3
)((3 4
{)) 	 
imagenesRompecabezas**  
=**! "
new**# & 
ObservableCollection**' ;
<**; <
ImagenRompecabezas**< N
>**N O
(**O P
)**P Q
;**Q R
for,, 
(,, 
int,, 
indiceImagen,, !
=,," #
$num,,$ %
;,,% &
indiceImagen,,' 3
<=,,4 6
$num,,7 9
;,,9 :
indiceImagen,,< H
++,,H J
),,J K
{--  
imagenesRompecabezas.. $
...$ %
Add..% (
(..( )
new..) ,
ImagenRompecabezas..- ?
{// 
Ruta00 
=00 
$"00 
$str00 5
{005 6
indiceImagen006 B
}00B C
$str00C G
"00G H
,00H I
NumeroImagen11  
=11! "
indiceImagen11# /
}22 
)22 
;22 
}33 
}44 	
private66 
void66 '
MostrarPreseleccionDeImagen66 0
(660 1
object661 7
objetoOrigen668 D
,66D E
MouseEventArgs66F T
evento66U [
)66[ \
{77 	
Border88 
borde88 
=88 
objetoOrigen88 '
as88( *
Border88+ 1
;881 2
if:: 
(:: 
borde:: 
!=:: #
bordeImagenSeleccionada:: 0
)::0 1
{;; 
borde<< 
.<< 
BorderBrush<< !
=<<" #
new<<$ '
SolidColorBrush<<( 7
(<<7 8
Colors<<8 >
.<<> ?
Red<<? B
)<<B C
;<<C D
}== 
}>> 	
private@@ 
void@@ '
OcultarPreseleccionDeImagen@@ 0
(@@0 1
object@@1 7
objetoOrigen@@8 D
,@@D E
MouseEventArgs@@F T
evento@@U [
)@@[ \
{AA 	
BorderBB 
bordeBB 
=BB 
objetoOrigenBB '
asBB( *
BorderBB+ 1
;BB1 2
ifDD 
(DD 
bordeDD 
!=DD #
bordeImagenSeleccionadaDD 0
)DD0 1
{EE 
ImagenRompecabezasFF "
imagenFF# )
=FF* +
bordeFF, 1
.FF1 2
DataContextFF2 =
asFF> @
ImagenRompecabezasFFA S
;FFS T
bordeGG 
.GG 
BorderBrushGG !
=GG" #
newGG$ '
SolidColorBrushGG( 7
(GG7 8
imagenGG8 >
.GG> ?
ColorDeBordeGG? K
)GGK L
;GGL M
}HH 
}II 	
privateKK 
voidKK 
SeleccionarImagenKK &
(KK& '
objectKK' -
objetoOrigenKK. :
,KK: ; 
MouseButtonEventArgsKK< P
eventoKKQ W
)KKW X
{LL 	
BorderMM 
bordeMM 
=MM 
objetoOrigenMM '
asMM( *
BorderMM+ 1
;MM1 2
ifOO 
(OO #
bordeImagenSeleccionadaOO '
!=OO( *
nullOO+ /
)OO/ 0
{PP #
bordeImagenSeleccionadaQQ '
.QQ' (
BorderBrushQQ( 3
=QQ4 5
newQQ6 9
SolidColorBrushQQ: I
(QQI J
ColorsQQJ P
.QQP Q
TransparentQQQ \
)QQ\ ]
;QQ] ^
}RR 
ImagenRompecabezasTT 
imagenTT %
=TT& '
bordeTT( -
.TT- .
DataContextTT. 9
asTT: <
ImagenRompecabezasTT= O
;TTO P
numeroImagenUU 
=UU 
imagenUU !
.UU! "
NumeroImagenUU" .
;UU. /#
bordeImagenSeleccionadaVV #
=VV$ %
bordeVV& +
;VV+ ,
bordeWW 
.WW 
BorderBrushWW 
=WW 
newWW  #
SolidColorBrushWW$ 3
(WW3 4
ColorsWW4 :
.WW: ;
GreenWW; @
)WW@ A
;WWA B
}XX 	
privateZZ 
voidZZ 
IrAPaginaSalaZZ "
(ZZ" #
objectZZ# )
objetoOrigenZZ* 6
,ZZ6 7 
MouseButtonEventArgsZZ8 L
eventoZZM S
)ZZS T
{[[ 	
VentanaPrincipal\\ 
.\\ 
CambiarPagina\\ *
(\\* +
new\\+ .

PaginaSala\\/ 9
(\\9 :
)\\: ;
)\\; <
;\\< =
}aa 	
privatecc 
voidcc !
SeleccionarDificultadcc *
(cc* +
objectcc+ 1
controlOrigencc2 ?
,cc? @%
SelectionChangedEventArgsdd %
eventodd& ,
)dd, -
{ee 	

dificultadff 
=ff 
(ff 

Dificultadff $
)ff$ %%
cuadroSeleccionDificultadff% >
.ff> ?
SelectedIndexff? L
;ffL M
}gg 	
privateii 
voidii 
IrAPaginaPartidaii %
(ii% &
objectii& ,
objetoOrigenii- 9
,ii9 :
RoutedEventArgsii; J
eventoiiK Q
)iiQ R
{jj 	
VentanaPrincipalkk 
.kk 
CambiarPaginakk *
(kk* +
newkk+ .
PaginaPartidakk/ <
(kk< =

dificultadkk= G
,kkG H
numeroImagenkkI U
)kkU V
)kkV W
;kkW X
}ll 	
}mm 
}nn �
|C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaUnirseSala.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class 
PaginaUnirseSala )
:* +
Page, 0
{ 
public		 
PaginaUnirseSala		 
(		  
)		  !
{

 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void $
IntentarUnirJugadorASala -
(- .
object. 4
objetoOrigen5 A
,A B
RoutedEventArgsC R
eventoS Y
)Y Z
{ 	

PaginaSala 

paginaSala !
=" #
new$ '

PaginaSala( 2
(2 3
)3 4
;4 5
if 
( 
	Servicios 
. 
ServicioSala &
.& ' 
ExisteSalaDisponible' ;
(; <!
cuadroTextoCodigoSala< Q
.Q R
TextR V
)V W
)W X
{ 

paginaSala 
. 

CodigoSala %
=& '!
cuadroTextoCodigoSala( =
.= >
Text> B
;B C

paginaSala 
. 
EsAnfitrion &
=' (
false) .
;. /

paginaSala 
. 
etiquetaCodigoSala -
.- .
Content. 5
=6 7!
cuadroTextoCodigoSala8 M
.M N
TextN R
;R S

paginaSala 
. 
UnirseASala &
(& '
)' (
;( )
VentanaPrincipal  
.  !
CambiarPagina! .
(. /

paginaSala/ 9
)9 :
;: ;
} 
} 	
private 
void "
IrAPaginaMenuPrincipal +
(+ ,
object, 2
objetoOrigen3 ?
,? @ 
MouseButtonEventArgsA U
eventoV \
)\ ]
{ 	
VentanaPrincipal 
. 
CambiarPagina *
(* +
new+ .
PaginaMenuPrincipal/ B
(B C
)C D
)D E
;E F
} 	
}   
}!! �V
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaVerificacionCorreo.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class $
PaginaVerificacionCorreo 1
:2 3
Page4 8
{ 
private 
readonly 
Dominio  
.  !
CuentaJugador! .
jugadorRegistro/ >
;> ?
public $
PaginaVerificacionCorreo '
(' (
Dominio( /
./ 0
CuentaJugador0 =
jugadorRegistro> M
)M N
{ 	
InitializeComponent 
(  
)  !
;! "
this 
. 
jugadorRegistro  
=! "
jugadorRegistro# 2
;2 3#
GestionadorCodigoCorreo #
.# $2
&EnviarNuevoCodigoDeVerificacionACorreo$ J
(J K
jugadorRegistro 
.  
Correo  &
,& '

Properties( 2
.2 3
	Resources3 <
.< =.
"ETIQUETA_VERIFICACIONCORREO_ASUNTO= _
,_ `

Properties 
. 
	Resources $
.$ %/
#ETIQUETA_VERIFICACIONCORREO_MENSAJE% H
+I J
$strK N
+O P#
GestionadorCodigoCorreo '
.' (
CodigoGenerado( 6
)6 7
;7 8
IniciarTemporizador 
(  
)  !
;! "
} 	
private 
void 
IniciarTemporizador (
(( )
)) *
{ 	(
DeshabilitarBotonEnvioCodigo (
(( )
)) *
;* +
Temporizador 
. 
temporizador %
.% &
Tick& *
+=+ -$
ActualizarTiempoRestante. F
;F G
Temporizador   
.   
IniciarTemporizador   ,
(  , -
)  - .
;  . /
}!! 	
public## 
void## $
ActualizarTiempoRestante## ,
(##, -
object##- 3
objetoOrigen##4 @
,##@ A
	EventArgs##B K
evento##L R
)##R S
{$$ 	
if%% 
(%% 
Temporizador%% 
.%% 
segundosRestantes%% .
>%%/ 0
Temporizador%%1 =
.%%= >#
MinimoSegundosRestantes%%> U
)%%U V
{&& 
Temporizador'' 
.'' 
segundosRestantes'' .
--''. 0
;''0 1
TimeSpan(( 
tiempoRestante(( '
=((( )
TimeSpan((* 2
.((2 3
FromSeconds((3 >
(((> ?
Temporizador((? K
.((K L
segundosRestantes((L ]
)((] ^
;((^ _"
etiquetaTiempoRestante)) &
.))& '
Content))' .
=))/ 0
$"))1 3
{))3 4
tiempoRestante))4 B
.))B C
Minutes))C J
:))J K
$str))K M
}))M N
$str))N O
"))O P
+))Q R
$"** 
{** 
tiempoRestante** %
.**% &
Seconds**& -
:**- .
$str**. 0
}**0 1
"**1 2
;**2 3
}++ 
else,, 
{-- 
Temporizador.. 
... 
DetenerTemporizador.. 0
(..0 1
)..1 2
;..2 3"
etiquetaTiempoRestante// &
.//& '
Content//' .
=/// 0
$str//1 8
;//8 9%
HabilitarBotonEnvioCodigo00 )
(00) *
)00* +
;00+ ,
}11 
}22 	
private44 
void44 *
ConcluirRegistroDeNuevoJugador44 3
(443 4
object444 :
objetoOrigen44; G
,44G H
RoutedEventArgs55 
evento55 "
)55" #
{66 	
string77 
codigoVerificacion77 %
=77& ')
cuadroTextoCodigoVerificacion77( E
.77E F
Text77F J
;77J K
if99 
(99 
!99 
ValidadorDatos99 
.99  
EsCadenaVacia99  -
(99- .
codigoVerificacion99. @
)99@ A
)99A B
{:: 
bool;; )
esElMismoCodigoDeVerificacion;; 2
=;;3 4
ValidadorDatos;;5 C
.;;C D'
ExisteCoincidenciaEnCadenas<< /
(<</ 0
codigoVerificacion<<0 B
,<<B C#
GestionadorCodigoCorreo== +
.==+ ,
CodigoGenerado==, :
)==: ;
;==; <
if?? 
(?? )
esElMismoCodigoDeVerificacion?? 1
)??1 2
{@@ 
stringAA 
contrasenaCifradaAA ,
=AA- .!
EncriptadorContrasenaAA/ D
.AAD E
CalcularHashSha512AAE W
(AAW X
jugadorRegistroBB '
.BB' (

ContrasenaBB( 2
)BB2 3
;BB3 4
CuentaJugadorCC !
nuevoJugadorCC" .
=CC/ 0
newCC1 4
CuentaJugadorCC5 B
{DD 
NombreJugadorEE %
=EE& '
jugadorRegistroEE( 7
.EE7 8
NombreJugadorEE8 E
,EEE F
NumeroAvatarFF $
=FF% &
jugadorRegistroFF' 6
.FF6 7
NumeroAvatarFF7 C
,FFC D

ContrasenaGG "
=GG# $
contrasenaCifradaGG% 6
,GG6 7
CorreoHH 
=HH  
jugadorRegistroHH! 0
.HH0 1
CorreoHH1 7
}II 
;II 
boolJJ 
registroRealizadoJJ *
=JJ+ ,
	ServiciosJJ- 6
.JJ6 7
ServicioJugadorJJ7 F
.JJF G
RegistrarJugadorJJG W
(JJW X
nuevoJugadorKK $
)KK$ %
;KK% &
ifMM 
(MM 
registroRealizadoMM )
)MM) *
{NN 
TemporizadorOO $
.OO$ %
DetenerTemporizadorOO% 8
(OO8 9
)OO9 :
;OO: ;

MessageBoxPP "
.PP" #
ShowPP# '
(PP' (

PropertiesPP( 2
.PP2 3
	ResourcesPP3 <
.PP< =@
4ETIQUETA_VERIFICACIONCORREO_MENSAJEUSUARIOREGISTRADOQQ P
,QQP Q

PropertiesQQR \
.QQ\ ]
	ResourcesRR %
.RR% &9
-ETIQUETA_VERIFICACIONCORREO_REGISTROREALIZADORR& S
,RRS T
MessageBoxButtonSS ,
.SS, -
OKSS- /
)SS/ 0
;SS0 1
VentanaPrincipalTT (
.TT( )
CambiarPaginaTT) 6
(TT6 7
newTT7 :
PaginaInicioSesionTT; M
(TTM N
)TTN O
)TTO P
;TTP Q
}UU 
elseVV 
{WW 

MessageBoxXX "
.XX" #
ShowXX# '
(XX' (

PropertiesXX( 2
.XX2 3
	ResourcesXX3 <
.XX< =B
6ETIQUETA_VERIFICACIONCORREO_MENSAJEREGISTRONOREALIZADOYY R
,YYR S

PropertiesZZ &
.ZZ& '
	ResourcesZZ' 0
.ZZ0 15
)ETIQUETA_VERIFICACIONCORREO_ERRORREGISTROZZ1 Z
,ZZZ [
MessageBoxButton[[ ,
.[[, -
OK[[- /
)[[/ 0
;[[0 1
}\\ 
}]] 
else^^ 
{__ 

MessageBox`` 
.`` 
Show`` #
(``# $

Properties``$ .
.``. /
	Resources``/ 8
.``8 9?
3ETIQUETA_VERIFICACIONCORREO_MENSAJECODIGOINCORRECTOaa K
,aaK L

Propertiesbb "
.bb" #
	Resourcesbb# ,
.bb, -8
,ETIQUETA_VERIFICACIONCORREO_CODIGOINCORRECTObb- Y
,bbY Z
MessageBoxButtoncc (
.cc( )
OKcc) +
)cc+ ,
;cc, -
}dd 
}ee 
}ff 	
privatehh 
voidhh *
AceptarSoloCaracteresNumericoshh 3
(hh3 4
objecthh4 :
objetoOrigenhh; G
,hhG H 
TextChangedEventArgsii  
eventoii! '
)ii' (
{jj 	
ifkk 
(kk 
objetoOrigenkk 
iskk 
TextBoxkk  ')
cuadroTextoCodigoVerificacionkk( E
)kkE F
{ll 
stringmm 
textomm 
=mm )
cuadroTextoCodigoVerificacionmm <
.mm< =
Textmm= A
=mmB C
newnn 
stringnn 
(nn )
cuadroTextoCodigoVerificacionnn <
.nn< =
Textnn= A
.nnA B
Whereoo 
(oo 
charoo 
.oo 
IsDigitoo &
)oo& '
.oo' (
ToArrayoo( /
(oo/ 0
)oo0 1
)oo1 2
;oo2 3)
cuadroTextoCodigoVerificacionpp -
.pp- .

CaretIndexpp. 8
=pp9 :)
cuadroTextoCodigoVerificacionqq 1
.qq1 2
Textqq2 6
.qq6 7
Lengthqq7 =
;qq= >)
cuadroTextoCodigoVerificacionrr -
.rr- .
Textrr. 2
=rr3 4
textorr5 :
;rr: ;
}ss 
}tt 	
publicvv 
voidvv 2
&EnviarNuevoCodigoDeConfirmacionACorreovv :
(vv: ;
objectvv; A
objetoOrigenvvB N
,vvN O
RoutedEventArgsww 
eventoww "
)ww" #
{xx 	#
GestionadorCodigoCorreoyy #
.yy# $2
&EnviarNuevoCodigoDeVerificacionACorreoyy$ J
(yyJ K
jugadorRegistrozz 
.zz  
Correozz  &
,zz& '

Propertieszz( 2
.zz2 3
	Resourceszz3 <
.zz< =.
"ETIQUETA_VERIFICACIONCORREO_ASUNTOzz= _
,zz_ `

Properties{{ 
.{{ 
	Resources{{ $
.{{$ %/
#ETIQUETA_VERIFICACIONCORREO_MENSAJE{{% H
+{{I J
$str{{K N
+{{O P#
GestionadorCodigoCorreo|| '
.||' (
CodigoGenerado||( 6
)||6 7
;||7 8
IniciarTemporizador}} 
(}}  
)}}  !
;}}! "
}~~ 	
private
�� 
void
�� '
HabilitarBotonEnvioCodigo
�� .
(
��. /
)
��/ 0
{
�� 	
BotonEnviarCodigo
�� 
.
�� 
	IsEnabled
�� '
=
��( )
true
��* .
;
��. /
BotonEnviarCodigo
�� 
.
�� 

Foreground
�� (
=
��) *
Brushes
��+ 2
.
��2 3
White
��3 8
;
��8 9
}
�� 	
private
�� 
void
�� *
DeshabilitarBotonEnvioCodigo
�� 1
(
��1 2
)
��2 3
{
�� 	
BotonEnviarCodigo
�� 
.
�� 
	IsEnabled
�� '
=
��( )
false
��* /
;
��/ 0
BotonEnviarCodigo
�� 
.
�� 

Foreground
�� (
=
��) *
Brushes
��+ 2
.
��2 3
Black
��3 8
;
��8 9
}
�� 	
}
�� 
}�� �
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Utilidades\GeneradorImagenes.cs
	namespace 	
RompecabezasFei
 
. 

Utilidades $
{ 
public 

class 
GeneradorImagenes "
{		 
public

 
static

 
BitmapImage

 !%
GenerarFuenteImagenAvatar

" ;
(

; <
int

< ?
numeroAvatar

@ L
)

L M
{ 	
string 

rutaImagen 
= 
$"  "
$str" 5
{5 6
numeroAvatar6 B
}B C
$strC G
"G H
;H I
BitmapImage 
fuenteImagenAvatar *
=+ ,
new- 0
BitmapImage1 <
(< =
)= >
;> ?
fuenteImagenAvatar 
. 
	BeginInit (
(( )
)) *
;* +
fuenteImagenAvatar 
. 
	UriSource (
=) *
new+ .
Uri/ 2
(2 3

rutaImagen3 =
,= >
UriKind? F
.F G
RelativeOrAbsoluteG Y
)Y Z
;Z [
fuenteImagenAvatar 
. 
EndInit &
(& '
)' (
;( )
return 
fuenteImagenAvatar %
;% &
} 	
public 
static 
BitmapImage !+
GenerarFuenteImagenRompecabezas" A
(A B
intB E$
numeroImagenRompecabezasF ^
)^ _
{ 	
string 
rutaDirectorioBase %
=& '
	AppDomain( 1
.1 2
CurrentDomain2 ?
.? @
BaseDirectory@ M
;M N
	Directory 
. 
SetCurrentDirectory )
() *
Path* .
.. /
Combine/ 6
(6 7
rutaDirectorioBase7 I
,I J
$strK U
)U V
)V W
;W X
string 
directorioActual #
=$ %
	Directory& /
./ 0
GetCurrentDirectory0 C
(C D
)D E
;E F
string 
rutaRelativaImagen %
=& '
$"( *
$str* B
{B C$
numeroImagenRompecabezasC [
}[ \
$str\ `
"` a
;a b
string 
rutaAbsoluta 
=  !
Path" &
.& '
Combine' .
(. /
directorioActual/ ?
,? @
rutaRelativaImagenA S
)S T
;T U
return 
new 
BitmapImage "
(" #
new# &
Uri' *
(* +
rutaAbsoluta+ 7
,7 8
UriKind9 @
.@ A
RelativeA I
)I J
)J K
;K L
} 	
} 
}   �
~C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Utilidades\Temporizador.cs
	namespace 	
RompecabezasFei
 
. 

Utilidades $
{ 
public 

class 
Temporizador 
{ 
public 
const 
int $
DuracionContadorSegundos 1
=2 3
$num4 6
;6 7
public		 
const		 
int		 #
MinimoSegundosRestantes		 0
=		1 2
$num		3 4
;		4 5
public

 
const

 
int

 
IntervaloDeSegundos

 ,
=

- .
$num

/ 0
;

0 1
public 
static 
int 
segundosRestantes +
;+ ,
public 
static 
DispatcherTimer %
temporizador& 2
;2 3
public 
static 
void 
IniciarTemporizador .
(. /
)/ 0
{ 	
segundosRestantes 
= $
DuracionContadorSegundos  8
;8 9
temporizador 
= 
new 
DispatcherTimer .
{ 
Interval 
= 
TimeSpan #
.# $
FromSeconds$ /
(/ 0
IntervaloDeSegundos0 C
)C D
} 
; 
temporizador 
. 
Start 
( 
)  
;  !
} 	
public 
static 
void 
DetenerTemporizador .
(. /
)/ 0
{ 	
segundosRestantes 
= 
$num  !
;! "
temporizador 
. 
Stop 
( 
) 
;  
} 	
} 
} �
�C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Utilidades\GestionadorCodigoCorreo.cs
	namespace 	
RompecabezasFei
 
. 

Utilidades $
{ 
public 

class #
GestionadorCodigoCorreo (
{ 
private 
const 
int !
MinimoNumeroAleatorio /
=0 1
$num2 8
;8 9
private 
const 
int !
MaximoNumeroAleatorio /
=0 1
$num2 9
;9 :
private		 
static		 
string		 
codigoGenerado		 ,
;		, -
public 
static 
string 
CodigoGenerado +
{ 	
get 
{ 
return 
codigoGenerado '
;' (
}) *
set 
{ 
codigoGenerado  
=! "
value# (
;( )
}* +
} 	
private 
static 
string *
GenerarNuevoCodigoConfirmacion <
(< =
)= >
{ 	
Random $
generadorNumeroAleatorio +
=, -
new. 1
Random2 8
(8 9
)9 :
;: ;
return $
generadorNumeroAleatorio +
.+ ,
Next, 0
(0 1!
MinimoNumeroAleatorio1 F
,F G!
MaximoNumeroAleatorio %
)% &
.& '
ToString' /
(/ 0
)0 1
;1 2
} 	
public 
static 
bool 2
&EnviarNuevoCodigoDeVerificacionACorreo A
(A B
stringB H
correoDestinoI V
,V W
string 
asunto 
, 
string !
mensaje" )
)) *
{ 	
codigoGenerado 
= *
GenerarNuevoCodigoConfirmacion ;
(; <
)< =
;= >
bool 
	resultado 
= 
	Servicios &
.& '
ServicioCorreo' 5
.5 6+
EnviarMensajeACorreoElectronico6 U
(U V

Properties 
. 
	Resources $
.$ %,
 ETIQUETA_GENERAL_ROMPECABEZASFEI% E
,E F
correoDestinoG T
,T U
asunto 
, 
mensaje 
)  
;  !
return!! 
	resultado!! 
;!! 
}"" 	
}## 
}$$ �
|C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\VentanaPrincipal.xaml.cs
	namespace 	
RompecabezasFei
 
{ 
public 

partial 
class 
VentanaPrincipal )
:* +
Window, 2
{ 
private		 
static		 
Page		 
paginaActual		 (
;		( )
private

 
static

 
Page

 
paginaAnterior

 *
;

* +
public 
static 
Page 
PaginaAnterior )
{ 	
get 
{ 
return 
paginaAnterior '
;' (
}) *
set 
{ 
paginaAnterior  
=! "
value# (
;( )
}* +
} 	
public 
VentanaPrincipal 
(  
)  !
{ 	
InitializeComponent 
(  
)  !
;! "
Closing 
+= 
CerrarSesionActual )
;) *
paginaActual 
= 
new 
PaginaInicioSesion 1
(1 2
)2 3
;3 4
marcoPaginaActual 
. 
Navigate &
(& '
paginaActual' 3
)3 4
;4 5
} 	
public 
static 
void 
CambiarPagina (
(( )
Page) -
nuevaPagina. 9
)9 :
{ 	
VentanaPrincipal 
ventanaPrincipal -
=. /
(0 1
VentanaPrincipal1 A
)A B
	GetWindowB K
(K L
paginaActualL X
)X Y
;Y Z
paginaActual 
= 
nuevaPagina &
;& '
ventanaPrincipal 
. 
marcoPaginaActual .
.. /
Navigate/ 7
(7 8
nuevaPagina8 C
)C D
;D E
} 	
public!! 
static!! 
void!! *
CambiarPaginaGuardandoAnterior!! 9
(!!9 :
Page!!: >
nuevaPagina!!? J
)!!J K
{"" 	
PaginaAnterior## 
=## 
paginaActual## )
;##) *
CambiarPagina$$ 
($$ 
nuevaPagina$$ %
)$$% &
;$$& '
}%% 	
private'' 
void'' 
CerrarSesionActual'' '
(''' (
object''( .
objetoOrigen''/ ;
,''; <
CancelEventArgs''= L
evento''M S
)''S T
{(( 	
if)) 
()) 
Dominio)) 
.)) 
CuentaJugador)) %
.))% &
Actual))& ,
!=))- /
null))0 4
)))4 5
{** 
	Servicios++ 
.++ 
ServicioJugador++ )
.++) *
CerrarSesion++* 6
(++6 7
Dominio++7 >
.++> ?
CuentaJugador++? L
.++L M
Actual,, 
.,, 
NombreJugador,, (
),,( )
;,,) *
}-- 
}.. 	
}// 
}00 �
~C:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Properties\AssemblyInfo.cs
[

 
assembly

 	
:

	 

AssemblyTitle

 
(

 
$str

 *
)

* +
]

+ ,
[ 
assembly 	
:	 

AssemblyDescription 
( 
$str !
)! "
]" #
[ 
assembly 	
:	 
!
AssemblyConfiguration  
(  !
$str! #
)# $
]$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str ,
), -
]- .
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
["" 
assembly"" 	
:""	 

	ThemeInfo"" 
("" &
ResourceDictionaryLocation## 
.## 
None## #
,### $&
ResourceDictionaryLocation&& 
.&& 
SourceAssembly&& -
))) 
])) 
[66 
assembly66 	
:66	 

AssemblyVersion66 
(66 
$str66 $
)66$ %
]66% &
[77 
assembly77 	
:77	 

AssemblyFileVersion77 
(77 
$str77 (
)77( )
]77) *
[88 
assembly88 	
:88	 

log4net88 
.88 
Config88 
.88 
XmlConfigurator88 )
(88) *
Watch88* /
=880 1
true881 5
)885 6
]886 7