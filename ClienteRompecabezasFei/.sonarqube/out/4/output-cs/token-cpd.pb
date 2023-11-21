¨
ÄC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaAjustesPartida.xaml.cs
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
} ûê
ÇC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioAmistades.cs
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
ÅÅ 
.
ÅÅ 
Show
ÅÅ 
(
ÅÅ  

Properties
ÅÅ  *
.
ÅÅ* +
	Resources
ÅÅ+ 4
.
ÅÅ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÇÇ :
,
ÇÇ: ;

Properties
ÇÇ< F
.
ÇÇF G
	Resources
ÇÇG P
.
ÇÇP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÉÉ 9
,
ÉÉ9 :
MessageBoxButton
ÑÑ $
.
ÑÑ$ %
OK
ÑÑ% '
,
ÑÑ' (
MessageBoxImage
ÑÑ) 8
.
ÑÑ8 9
Error
ÑÑ9 >
)
ÑÑ> ?
;
ÑÑ? @
cliente
ÖÖ 
.
ÖÖ 
Abort
ÖÖ 
(
ÖÖ 
)
ÖÖ 
;
ÖÖ  
}
ÜÜ 
return
àà $
existeSolicitudAmistad
àà )
;
àà) *
}
ââ 	
public
ãã 
static
ãã 
bool
ãã %
ExisteAmistadConJugador
ãã 2
(
ãã2 3
string
ãã3 9
nombreJugadorA
ãã: H
,
ããH I
string
ããJ P
nombreJugadorB
ããQ _
)
ãã_ `
{
åå 	%
ServicioAmistadesClient
çç #
cliente
çç$ +
=
çç, -
new
çç. 1%
ServicioAmistadesClient
çç2 I
(
ççI J
new
éé 
InstanceContext
éé #
(
éé# $
new
éé$ '
PaginaAmistades
éé( 7
(
éé7 8
false
éé8 =
)
éé= >
)
éé> ?
)
éé? @
;
éé@ A
bool
èè $
existeSolicitudAmistad
èè '
=
èè( )
false
èè* /
;
èè/ 0
try
ëë 
{
íí $
existeSolicitudAmistad
ìì &
=
ìì' (
cliente
ìì) 0
.
ìì0 1&
ExisteSolicitudDeAmistad
ìì1 I
(
ììI J
nombreJugadorA
îî "
,
îî" #
nombreJugadorB
îî$ 2
)
îî2 3
;
îî3 4
cliente
ïï 
.
ïï 
Close
ïï 
(
ïï 
)
ïï 
;
ïï  
}
ññ 
catch
óó 
(
óó '
EndpointNotFoundException
óó ,
	excepcion
óó- 6
)
óó6 7
{
òò 

MessageBox
öö 
.
öö 
Show
öö 
(
öö  

Properties
öö  *
.
öö* +
	Resources
öö+ 4
.
öö4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
õõ :
,
õõ: ;

Properties
õõ< F
.
õõF G
	Resources
õõG P
.
õõP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
úú 9
,
úú9 :
MessageBoxButton
ùù $
.
ùù$ %
OK
ùù% '
,
ùù' (
MessageBoxImage
ùù) 8
.
ùù8 9
Error
ùù9 >
)
ùù> ?
;
ùù? @
cliente
ûû 
.
ûû 
Abort
ûû 
(
ûû 
)
ûû 
;
ûû  
}
üü 
catch
†† 
(
†† 1
#CommunicationObjectFaultedException
†† 6
	excepcion
††7 @
)
††@ A
{
°° 

MessageBox
££ 
.
££ 
Show
££ 
(
££  

Properties
££  *
.
££* +
	Resources
££+ 4
.
££4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
§§ :
,
§§: ;

Properties
§§< F
.
§§F G
	Resources
§§G P
.
§§P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
•• 9
,
••9 :
MessageBoxButton
¶¶ $
.
¶¶$ %
OK
¶¶% '
,
¶¶' (
MessageBoxImage
¶¶) 8
.
¶¶8 9
Error
¶¶9 >
)
¶¶> ?
;
¶¶? @
cliente
ßß 
.
ßß 
Abort
ßß 
(
ßß 
)
ßß 
;
ßß  
}
®® 
catch
©© 
(
©© 
TimeoutException
©© #
	excepcion
©©$ -
)
©©- .
{
™™ 

MessageBox
¨¨ 
.
¨¨ 
Show
¨¨ 
(
¨¨  

Properties
¨¨  *
.
¨¨* +
	Resources
¨¨+ 4
.
¨¨4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
≠≠ :
,
≠≠: ;

Properties
≠≠< F
.
≠≠F G
	Resources
≠≠G P
.
≠≠P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÆÆ 9
,
ÆÆ9 :
MessageBoxButton
ØØ $
.
ØØ$ %
OK
ØØ% '
,
ØØ' (
MessageBoxImage
ØØ) 8
.
ØØ8 9
Error
ØØ9 >
)
ØØ> ?
;
ØØ? @
cliente
∞∞ 
.
∞∞ 
Abort
∞∞ 
(
∞∞ 
)
∞∞ 
;
∞∞  
}
±± 
return
≥≥ $
existeSolicitudAmistad
≥≥ )
;
≥≥) *
}
¥¥ 	
public
∂∂ 
static
∂∂ 
bool
∂∂ (
RechazarSolicitudDeAmistad
∂∂ 5
(
∂∂5 6
string
∂∂6 <!
nombreJugadorOrigen
∂∂= P
,
∂∂P Q
string
∑∑ "
nombreJugadorDestino
∑∑ '
)
∑∑' (
{
∏∏ 	%
ServicioAmistadesClient
ππ #
cliente
ππ$ +
=
ππ, -
new
ππ. 1%
ServicioAmistadesClient
ππ2 I
(
ππI J
new
∫∫ 
InstanceContext
∫∫ #
(
∫∫# $
new
∫∫$ '
PaginaAmistades
∫∫( 7
(
∫∫7 8
false
∫∫8 =
)
∫∫= >
)
∫∫> ?
)
∫∫? @
;
∫∫@ A
bool
ªª  
solicitudRechazada
ªª #
=
ªª$ %
false
ªª& +
;
ªª+ ,
try
ΩΩ 
{
ææ  
solicitudRechazada
øø "
=
øø# $
cliente
øø% ,
.
øø, -(
RechazarSolicitudDeAmistad
øø- G
(
øøG H!
nombreJugadorOrigen
¿¿ '
,
¿¿' ("
nombreJugadorDestino
¿¿) =
)
¿¿= >
;
¿¿> ?
cliente
¡¡ 
.
¡¡ 
Close
¡¡ 
(
¡¡ 
)
¡¡ 
;
¡¡  
}
¬¬ 
catch
√√ 
(
√√ '
EndpointNotFoundException
√√ ,
	excepcion
√√- 6
)
√√6 7
{
ƒƒ 

MessageBox
∆∆ 
.
∆∆ 
Show
∆∆ 
(
∆∆  

Properties
∆∆  *
.
∆∆* +
	Resources
∆∆+ 4
.
∆∆4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
«« :
,
««: ;

Properties
««< F
.
««F G
	Resources
««G P
.
««P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
»» 9
,
»»9 :
MessageBoxButton
…… $
.
……$ %
OK
……% '
,
……' (
MessageBoxImage
……) 8
.
……8 9
Error
……9 >
)
……> ?
;
……? @
cliente
   
.
   
Abort
   
(
   
)
   
;
    
}
ÀÀ 
catch
ÃÃ 
(
ÃÃ 1
#CommunicationObjectFaultedException
ÃÃ 6
	excepcion
ÃÃ7 @
)
ÃÃ@ A
{
ÕÕ 

MessageBox
œœ 
.
œœ 
Show
œœ 
(
œœ  

Properties
œœ  *
.
œœ* +
	Resources
œœ+ 4
.
œœ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
–– :
,
––: ;

Properties
––< F
.
––F G
	Resources
––G P
.
––P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
—— 9
,
——9 :
MessageBoxButton
““ $
.
““$ %
OK
““% '
,
““' (
MessageBoxImage
““) 8
.
““8 9
Error
““9 >
)
““> ?
;
““? @
cliente
”” 
.
”” 
Abort
”” 
(
”” 
)
”” 
;
””  
}
‘‘ 
catch
’’ 
(
’’ 
TimeoutException
’’ #
	excepcion
’’$ -
)
’’- .
{
÷÷ 

MessageBox
ÿÿ 
.
ÿÿ 
Show
ÿÿ 
(
ÿÿ  

Properties
ÿÿ  *
.
ÿÿ* +
	Resources
ÿÿ+ 4
.
ÿÿ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ŸŸ :
,
ŸŸ: ;

Properties
ŸŸ< F
.
ŸŸF G
	Resources
ŸŸG P
.
ŸŸP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
⁄⁄ 9
,
⁄⁄9 :
MessageBoxButton
€€ $
.
€€$ %
OK
€€% '
,
€€' (
MessageBoxImage
€€) 8
.
€€8 9
Error
€€9 >
)
€€> ?
;
€€? @
cliente
‹‹ 
.
‹‹ 
Abort
‹‹ 
(
‹‹ 
)
‹‹ 
;
‹‹  
}
›› 
return
ﬂﬂ  
solicitudRechazada
ﬂﬂ %
;
ﬂﬂ% &
}
‡‡ 	
}
·· 
}‚‚ ˆ5
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
}]] ◊Æ
ÄC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioJugador.cs
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
ÄÄ 
catch
ÅÅ 
(
ÅÅ 1
#CommunicationObjectFaultedException
ÅÅ 6
	excepcion
ÅÅ7 @
)
ÅÅ@ A
{
ÇÇ 

MessageBox
ÑÑ 
.
ÑÑ 
Show
ÑÑ 
(
ÑÑ  

Properties
ÑÑ  *
.
ÑÑ* +
	Resources
ÑÑ+ 4
.
ÑÑ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÖÖ :
,
ÖÖ: ;

Properties
ÖÖ< F
.
ÖÖF G
	Resources
ÖÖG P
.
ÖÖP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÜÜ 9
,
ÜÜ9 :
MessageBoxButton
áá $
.
áá$ %
OK
áá% '
,
áá' (
MessageBoxImage
áá) 8
.
áá8 9
Error
áá9 >
)
áá> ?
;
áá? @
cliente
àà 
.
àà 
Abort
àà 
(
àà 
)
àà 
;
àà  
}
ââ 
catch
ää 
(
ää 
TimeoutException
ää #
	excepcion
ää$ -
)
ää- .
{
ãã 

MessageBox
çç 
.
çç 
Show
çç 
(
çç  

Properties
çç  *
.
çç* +
	Resources
çç+ 4
.
çç4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
éé :
,
éé: ;

Properties
éé< F
.
ééF G
	Resources
ééG P
.
ééP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
èè 9
,
èè9 :
MessageBoxButton
êê $
.
êê$ %
OK
êê% '
,
êê' (
MessageBoxImage
êê) 8
.
êê8 9
Error
êê9 >
)
êê> ?
;
êê? @
cliente
ëë 
.
ëë 
Abort
ëë 
(
ëë 
)
ëë 
;
ëë  
}
íí 
return
îî 
	resultado
îî 
;
îî 
}
ïï 	
public
óó 
static
óó 
bool
óó "
ActualizarContrasena
óó /
(
óó/ 0
string
óó0 6
correo
óó7 =
,
óó= >
string
óó? E
nuevaContrasena
óóF U
)
óóU V
{
òò 	#
ServicioJugadorClient
ôô !
cliente
ôô" )
=
ôô* +
new
ôô, /#
ServicioJugadorClient
ôô0 E
(
ôôE F
)
ôôF G
;
ôôG H
bool
öö 
	resultado
öö 
=
öö 
false
öö "
;
öö" #
try
úú 
{
ùù 
	resultado
ûû 
=
ûû 
cliente
ûû #
.
ûû# $"
ActualizarContrasena
ûû$ 8
(
ûû8 9
correo
ûû9 ?
,
ûû? @
nuevaContrasena
ûûA P
)
ûûP Q
;
ûûQ R
cliente
üü 
.
üü 
Close
üü 
(
üü 
)
üü 
;
üü  
}
†† 
catch
°° 
(
°° '
EndpointNotFoundException
°° ,
	excepcion
°°- 6
)
°°6 7
{
¢¢ 

MessageBox
§§ 
.
§§ 
Show
§§ 
(
§§  

Properties
§§  *
.
§§* +
	Resources
§§+ 4
.
§§4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
•• :
,
••: ;

Properties
••< F
.
••F G
	Resources
••G P
.
••P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
¶¶ 9
,
¶¶9 :
MessageBoxButton
ßß $
.
ßß$ %
OK
ßß% '
,
ßß' (
MessageBoxImage
ßß) 8
.
ßß8 9
Error
ßß9 >
)
ßß> ?
;
ßß? @
cliente
®® 
.
®® 
Abort
®® 
(
®® 
)
®® 
;
®®  
}
©© 
catch
™™ 
(
™™ 1
#CommunicationObjectFaultedException
™™ 6
	excepcion
™™7 @
)
™™@ A
{
´´ 

MessageBox
≠≠ 
.
≠≠ 
Show
≠≠ 
(
≠≠  

Properties
≠≠  *
.
≠≠* +
	Resources
≠≠+ 4
.
≠≠4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÆÆ :
,
ÆÆ: ;

Properties
ÆÆ< F
.
ÆÆF G
	Resources
ÆÆG P
.
ÆÆP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ØØ 9
,
ØØ9 :
MessageBoxButton
∞∞ $
.
∞∞$ %
OK
∞∞% '
,
∞∞' (
MessageBoxImage
∞∞) 8
.
∞∞8 9
Error
∞∞9 >
)
∞∞> ?
;
∞∞? @
cliente
±± 
.
±± 
Abort
±± 
(
±± 
)
±± 
;
±±  
}
≤≤ 
catch
≥≥ 
(
≥≥ 
TimeoutException
≥≥ #
	excepcion
≥≥$ -
)
≥≥- .
{
¥¥ 

MessageBox
∂∂ 
.
∂∂ 
Show
∂∂ 
(
∂∂  

Properties
∂∂  *
.
∂∂* +
	Resources
∂∂+ 4
.
∂∂4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
∑∑ :
,
∑∑: ;

Properties
∑∑< F
.
∑∑F G
	Resources
∑∑G P
.
∑∑P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
∏∏ 9
,
∏∏9 :
MessageBoxButton
ππ $
.
ππ$ %
OK
ππ% '
,
ππ' (
MessageBoxImage
ππ) 8
.
ππ8 9
Error
ππ9 >
)
ππ> ?
;
ππ? @
cliente
∫∫ 
.
∫∫ 
Abort
∫∫ 
(
∫∫ 
)
∫∫ 
;
∫∫  
}
ªª 
return
ΩΩ 
	resultado
ΩΩ 
;
ΩΩ 
}
ææ 	
public
¿¿ 
static
¿¿ 
bool
¿¿ #
ActualizarInformacion
¿¿ 0
(
¿¿0 1
string
¿¿1 7
nombreAnterior
¿¿8 F
,
¿¿F G
string
¿¿H N
nuevoNombre
¿¿O Z
,
¿¿Z [
int
¡¡ 
nuevoNumeroAvatar
¡¡ !
)
¡¡! "
{
¬¬ 	
bool
√√ 
	resultado
√√ 
=
√√ 
false
√√ "
;
√√" ##
ServicioJugadorClient
ƒƒ !
cliente
ƒƒ" )
=
ƒƒ* +
new
ƒƒ, /#
ServicioJugadorClient
ƒƒ0 E
(
ƒƒE F
)
ƒƒF G
;
ƒƒG H
try
∆∆ 
{
«« 
	resultado
»» 
=
»» 
cliente
»» #
.
»»# $#
ActualizarInformacion
»»$ 9
(
»»9 :
nombreAnterior
»»: H
,
»»H I
nuevoNombre
…… 
,
……  
nuevoNumeroAvatar
……! 2
)
……2 3
;
……3 4
cliente
   
.
   
Close
   
(
   
)
   
;
    
}
ÀÀ 
catch
ÃÃ 
(
ÃÃ '
EndpointNotFoundException
ÃÃ ,
	excepcion
ÃÃ- 6
)
ÃÃ6 7
{
ÕÕ 

MessageBox
œœ 
.
œœ 
Show
œœ 
(
œœ  

Properties
œœ  *
.
œœ* +
	Resources
œœ+ 4
.
œœ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
–– :
,
––: ;

Properties
––< F
.
––F G
	Resources
––G P
.
––P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
—— 9
,
——9 :
MessageBoxButton
““ $
.
““$ %
OK
““% '
,
““' (
MessageBoxImage
““) 8
.
““8 9
Error
““9 >
)
““> ?
;
““? @
cliente
”” 
.
”” 
Abort
”” 
(
”” 
)
”” 
;
””  
}
‘‘ 
catch
’’ 
(
’’ 1
#CommunicationObjectFaultedException
’’ 6
	excepcion
’’7 @
)
’’@ A
{
÷÷ 

MessageBox
ÿÿ 
.
ÿÿ 
Show
ÿÿ 
(
ÿÿ  

Properties
ÿÿ  *
.
ÿÿ* +
	Resources
ÿÿ+ 4
.
ÿÿ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ŸŸ :
,
ŸŸ: ;

Properties
ŸŸ< F
.
ŸŸF G
	Resources
ŸŸG P
.
ŸŸP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
⁄⁄ 9
,
⁄⁄9 :
MessageBoxButton
€€ $
.
€€$ %
OK
€€% '
,
€€' (
MessageBoxImage
€€) 8
.
€€8 9
Error
€€9 >
)
€€> ?
;
€€? @
cliente
‹‹ 
.
‹‹ 
Abort
‹‹ 
(
‹‹ 
)
‹‹ 
;
‹‹  
}
›› 
catch
ﬁﬁ 
(
ﬁﬁ 
TimeoutException
ﬁﬁ #
	excepcion
ﬁﬁ$ -
)
ﬁﬁ- .
{
ﬂﬂ 

MessageBox
·· 
.
·· 
Show
·· 
(
··  

Properties
··  *
.
··* +
	Resources
··+ 4
.
··4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
‚‚ :
,
‚‚: ;

Properties
‚‚< F
.
‚‚F G
	Resources
‚‚G P
.
‚‚P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
„„ 9
,
„„9 :
MessageBoxButton
‰‰ $
.
‰‰$ %
OK
‰‰% '
,
‰‰' (
MessageBoxImage
‰‰) 8
.
‰‰8 9
Error
‰‰9 >
)
‰‰> ?
;
‰‰? @
cliente
ÂÂ 
.
ÂÂ 
Abort
ÂÂ 
(
ÂÂ 
)
ÂÂ 
;
ÂÂ  
}
ÊÊ 
return
ËË 
	resultado
ËË 
;
ËË 
}
ÈÈ 	
public
ÎÎ 
static
ÎÎ 
bool
ÎÎ !
ExisteNombreJugador
ÎÎ .
(
ÎÎ. /
string
ÎÎ/ 5
nombreJugador
ÎÎ6 C
)
ÎÎC D
{
ÏÏ 	#
ServicioJugadorClient
ÌÌ !
cliente
ÌÌ" )
=
ÌÌ* +
new
ÌÌ, /#
ServicioJugadorClient
ÌÌ0 E
(
ÌÌE F
)
ÌÌF G
;
ÌÌG H
bool
ÓÓ 
	resultado
ÓÓ 
=
ÓÓ 
false
ÓÓ "
;
ÓÓ" #
try
 
{
ÒÒ 
	resultado
ÚÚ 
=
ÚÚ 
cliente
ÚÚ #
.
ÚÚ# $!
ExisteNombreJugador
ÚÚ$ 7
(
ÚÚ7 8
nombreJugador
ÚÚ8 E
)
ÚÚE F
;
ÚÚF G
cliente
ÛÛ 
.
ÛÛ 
Close
ÛÛ 
(
ÛÛ 
)
ÛÛ 
;
ÛÛ  
}
ÙÙ 
catch
ıı 
(
ıı '
EndpointNotFoundException
ıı ,
	excepcion
ıı- 6
)
ıı6 7
{
ˆˆ 

MessageBox
¯¯ 
.
¯¯ 
Show
¯¯ 
(
¯¯  

Properties
¯¯  *
.
¯¯* +
	Resources
¯¯+ 4
.
¯¯4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
˘˘ :
,
˘˘: ;

Properties
˘˘< F
.
˘˘F G
	Resources
˘˘G P
.
˘˘P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
˙˙ 9
,
˙˙9 :
MessageBoxButton
˚˚ $
.
˚˚$ %
OK
˚˚% '
,
˚˚' (
MessageBoxImage
˚˚) 8
.
˚˚8 9
Error
˚˚9 >
)
˚˚> ?
;
˚˚? @
cliente
¸¸ 
.
¸¸ 
Abort
¸¸ 
(
¸¸ 
)
¸¸ 
;
¸¸  
}
˝˝ 
catch
˛˛ 
(
˛˛ 1
#CommunicationObjectFaultedException
˛˛ 6
	excepcion
˛˛7 @
)
˛˛@ A
{
ˇˇ 

MessageBox
ÅÅ 
.
ÅÅ 
Show
ÅÅ 
(
ÅÅ  

Properties
ÅÅ  *
.
ÅÅ* +
	Resources
ÅÅ+ 4
.
ÅÅ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÇÇ :
,
ÇÇ: ;

Properties
ÇÇ< F
.
ÇÇF G
	Resources
ÇÇG P
.
ÇÇP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÉÉ 9
,
ÉÉ9 :
MessageBoxButton
ÑÑ $
.
ÑÑ$ %
OK
ÑÑ% '
,
ÑÑ' (
MessageBoxImage
ÑÑ) 8
.
ÑÑ8 9
Error
ÑÑ9 >
)
ÑÑ> ?
;
ÑÑ? @
cliente
ÖÖ 
.
ÖÖ 
Abort
ÖÖ 
(
ÖÖ 
)
ÖÖ 
;
ÖÖ  
}
ÜÜ 
catch
áá 
(
áá 
TimeoutException
áá #
	excepcion
áá$ -
)
áá- .
{
àà 

MessageBox
ää 
.
ää 
Show
ää 
(
ää  

Properties
ää  *
.
ää* +
	Resources
ää+ 4
.
ää4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ãã :
,
ãã: ;

Properties
ãã< F
.
ããF G
	Resources
ããG P
.
ããP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
åå 9
,
åå9 :
MessageBoxButton
çç $
.
çç$ %
OK
çç% '
,
çç' (
MessageBoxImage
çç) 8
.
çç8 9
Error
çç9 >
)
çç> ?
;
çç? @
cliente
éé 
.
éé 
Abort
éé 
(
éé 
)
éé 
;
éé  
}
èè 
return
ëë 
	resultado
ëë 
;
ëë 
}
íí 	
}
ìì 
}îî ›c
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
ÄÄ 
static
ÄÄ 
CuentaJugador
ÄÄ #
[
ÄÄ# $
]
ÄÄ$ %.
 ObtenerJugadoresConectadosEnSala
ÄÄ& F
(
ÄÄF G
string
ÄÄG M

codigoSala
ÄÄN X
)
ÄÄX Y
{
ÅÅ 	 
ServicioSalaClient
ÇÇ 
cliente
ÇÇ &
=
ÇÇ' (
new
ÇÇ) , 
ServicioSalaClient
ÇÇ- ?
(
ÇÇ? @
new
ÇÇ@ C
InstanceContext
ÇÇD S
(
ÇÇS T
new
ÉÉ 

PaginaSala
ÉÉ 
(
ÉÉ 
)
ÉÉ  
)
ÉÉ  !
)
ÉÉ! "
;
ÉÉ" #
CuentaJugador
ÑÑ 
[
ÑÑ 
]
ÑÑ 
jugadoresEnSala
ÑÑ +
=
ÑÑ, -
null
ÑÑ. 2
;
ÑÑ2 3
try
ÜÜ 
{
áá 
jugadoresEnSala
àà 
=
àà  !
cliente
àà" )
.
àà) *.
 ObtenerJugadoresConectadosEnSala
àà* J
(
ààJ K

codigoSala
ààK U
)
ààU V
;
ààV W
cliente
ââ 
.
ââ 
Close
ââ 
(
ââ 
)
ââ 
;
ââ  
}
ää 
catch
ãã 
(
ãã '
EndpointNotFoundException
ãã ,
	excepcion
ãã- 6
)
ãã6 7
{
åå 

MessageBox
éé 
.
éé 
Show
éé 
(
éé  

Properties
éé  *
.
éé* +
	Resources
éé+ 4
.
éé4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
èè :
,
èè: ;

Properties
èè< F
.
èèF G
	Resources
èèG P
.
èèP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
êê 9
,
êê9 :
MessageBoxButton
ëë $
.
ëë$ %
OK
ëë% '
,
ëë' (
MessageBoxImage
ëë) 8
.
ëë8 9
Error
ëë9 >
)
ëë> ?
;
ëë? @
}
íí 
catch
ìì 
(
ìì 1
#CommunicationObjectFaultedException
ìì 6
	excepcion
ìì7 @
)
ìì@ A
{
îî 

MessageBox
ññ 
.
ññ 
Show
ññ 
(
ññ  

Properties
ññ  *
.
ññ* +
	Resources
ññ+ 4
.
ññ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
óó :
,
óó: ;

Properties
óó< F
.
óóF G
	Resources
óóG P
.
óóP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
òò 9
,
òò9 :
MessageBoxButton
ôô $
.
ôô$ %
OK
ôô% '
,
ôô' (
MessageBoxImage
ôô) 8
.
ôô8 9
Error
ôô9 >
)
ôô> ?
;
ôô? @
}
öö 
catch
õõ 
(
õõ 
TimeoutException
õõ #
	excepcion
õõ$ -
)
õõ- .
{
úú 

MessageBox
ûû 
.
ûû 
Show
ûû 
(
ûû  

Properties
ûû  *
.
ûû* +
	Resources
ûû+ 4
.
ûû4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
üü :
,
üü: ;

Properties
üü< F
.
üüF G
	Resources
üüG P
.
üüP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
†† 9
,
††9 :
MessageBoxButton
°° $
.
°°$ %
OK
°°% '
,
°°' (
MessageBoxImage
°°) 8
.
°°8 9
Error
°°9 >
)
°°> ?
;
°°? @
}
¢¢ 
return
§§ 
jugadoresEnSala
§§ "
;
§§" #
}
•• 	
}
¶¶ 
}ßß π6
ÄC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioPartida.cs
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
}^^ ±
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
}RR €E
âC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaActualizacionContrasena.xaml.cs
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
}ss Úb
äC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaActualizacionInformacion.xaml.cs
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
ÄÄ 
=
ÄÄ  
true
ÄÄ! %
;
ÄÄ% &

MessageBox
ÅÅ 
.
ÅÅ 
Show
ÅÅ 
(
ÅÅ  

Properties
ÅÅ  *
.
ÅÅ* +
	Resources
ÅÅ+ 4
.
ÅÅ4 55
'ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS
ÅÅ5 \
,
ÅÅ\ ]

Properties
ÇÇ 
.
ÇÇ 
	Resources
ÇÇ (
.
ÇÇ( ).
 ETIQUETA_VALIDACION_CAMPOSVACIOS
ÇÇ) I
,
ÇÇI J
MessageBoxButton
ÉÉ $
.
ÉÉ$ %
OK
ÉÉ% '
)
ÉÉ' (
;
ÉÉ( )
}
ÑÑ 
if
ÜÜ 
(
ÜÜ 
ValidadorDatos
ÜÜ 
.
ÜÜ 3
%ExisteLongitudExcedidaEnNombreJugador
ÜÜ D
(
ÜÜD E&
cuadroTextoNombreUsuario
áá (
.
áá( )
Text
áá) -
)
áá- .
)
áá. /
{
àà 
datosInvalidos
ââ 
=
ââ  
true
ââ! %
;
ââ% &

MessageBox
ää 
.
ää 
Show
ää 
(
ää  

Properties
ää  *
.
ää* +
	Resources
ää+ 4
.
ää4 58
*ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS
ää5 _
,
ää_ `

Properties
ãã 
.
ãã 
	Resources
ãã (
.
ãã( )1
#ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS
ãã) L
,
ããL M
MessageBoxButton
åå $
.
åå$ %
OK
åå% '
)
åå' (
;
åå( )
}
çç 
if
èè 
(
èè 
ValidadorDatos
èè 
.
èè 9
+ExistenCaracteresInvalidosParaNombreJugador
èè J
(
èèJ K&
cuadroTextoNombreUsuario
êê (
.
êê( )
Text
êê) -
)
êê- .
)
êê. /
{
ëë 
datosInvalidos
íí 
=
íí  
true
íí! %
;
íí% &

MessageBox
ìì 
.
ìì 
Show
ìì 
(
ìì  

Properties
îî 
.
îî 
	Resources
îî (
.
îî( )>
0ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO
îî) Y
,
îîY Z

Properties
ïï 
.
ïï 
	Resources
ïï (
.
ïï( )7
)ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO
ïï) R
,
ïïR S
MessageBoxButton
ññ $
.
ññ$ %
OK
ññ% '
)
ññ' (
;
ññ( )
}
óó 
return
ôô 
datosInvalidos
ôô !
;
ôô! "
}
öö 	
}
ÿÿ 
}ŸŸ ü2
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
}ee È
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
ÅÅ 
SolidColorBrush
ÅÅ 1
#ObtenerColorSegunEstadoConectividad
ÅÅ  C
(
ÅÅC D'
EstadoConectividadJugador
ÇÇ %
estado
ÇÇ& ,
)
ÇÇ, -
{
ÉÉ 	
SolidColorBrush
ÑÑ 
color
ÑÑ !
;
ÑÑ! "
switch
ÜÜ 
(
ÜÜ 
estado
ÜÜ 
)
ÜÜ 
{
áá 
case
àà '
EstadoConectividadJugador
àà .
.
àà. /
	Conectado
àà/ 8
:
àà8 9
color
ââ 
=
ââ 
Brushes
ââ #
.
ââ# $
Green
ââ$ )
;
ââ) *
break
ää 
;
ää 
case
ãã '
EstadoConectividadJugador
ãã .
.
ãã. /
	EnPartida
ãã/ 8
:
ãã8 9
color
åå 
=
åå 
Brushes
åå #
.
åå# $
Red
åå$ '
;
åå' (
break
çç 
;
çç 
default
éé 
:
éé 
color
èè 
=
èè 
Brushes
èè #
.
èè# $
Gray
èè$ (
;
èè( )
break
êê 
;
êê 
}
ëë 
return
ìì 
color
ìì 
;
ìì 
}
îî 	
private
ññ 
bool
ññ (
EsElNombreDelJugadorActual
ññ /
(
ññ/ 0
)
ññ0 1
{
óó 	
bool
òò 
	resultado
òò 
=
òò 
false
òò "
;
òò" #
string
ôô "
nombreJugadorDestino
ôô '
=
ôô( )0
"cuadroTextoNombreUsuarioInvitacion
ôô* L
.
ôôL M
Text
ôôM Q
;
ôôQ R
if
õõ 
(
õõ 
Dominio
õõ 
.
õõ 
CuentaJugador
õõ %
.
õõ% &
Actual
õõ& ,
.
õõ, -
NombreJugador
õõ- :
.
õõ: ;
Equals
õõ; A
(
õõA B"
nombreJugadorDestino
õõB V
)
õõV W
)
õõW X
{
úú 
	resultado
ùù 
=
ùù 
true
ùù  
;
ùù  !

MessageBox
ûû 
.
ûû 
Show
ûû 
(
ûû  
$str
ûû  O
+
ûûP Q
$str
üü I
,
üüI J
$str
†† :
,
††: ;
MessageBoxButton
°° $
.
°°$ %
OK
°°% '
,
°°' (
MessageBoxImage
°°) 8
.
°°8 9
Error
°°9 >
)
°°> ?
;
°°? @
}
¢¢ 
return
§§ 
	resultado
§§ 
;
§§ 
}
•• 	
private
ßß 
bool
ßß &
ExisteSolicitudDeAmistad
ßß -
(
ßß- .
)
ßß. /
{
®® 	
string
©© !
nombreJugadorOrigen
©© &
=
©©' (
Dominio
©©) 0
.
©©0 1
CuentaJugador
©©1 >
.
©©> ?
Actual
©©? E
.
©©E F
NombreJugador
©©F S
;
©©S T
string
™™ "
nombreJugadorDestino
™™ '
=
™™( )0
"cuadroTextoNombreUsuarioInvitacion
™™* L
.
™™L M
Text
™™M Q
;
™™Q R
bool
´´ '
existeSolicitudSinAceptar
´´ *
=
´´+ ,
	Servicios
´´- 6
.
´´6 7
ServicioAmistades
´´7 H
.
´´H I$
ExisteSolicitudAmistad
¨¨ &
(
¨¨& '!
nombreJugadorOrigen
¨¨' :
,
¨¨: ;"
nombreJugadorDestino
¨¨< P
)
¨¨P Q
;
¨¨Q R
if
ÆÆ 
(
ÆÆ '
existeSolicitudSinAceptar
ÆÆ )
)
ÆÆ) *
{
ØØ 

MessageBox
∞∞ 
.
∞∞ 
Show
∞∞ 
(
∞∞  
$str
∞∞  S
+
∞∞T U
$str
±± Y
,
±±Y Z
$str
≤≤ :
,
≤≤: ;
MessageBoxButton
≥≥ $
.
≥≥$ %
OK
≥≥% '
,
≥≥' (
MessageBoxImage
≥≥) 8
.
≥≥8 9
Error
≥≥9 >
)
≥≥> ?
;
≥≥? @
}
¥¥ 
return
∂∂ '
existeSolicitudSinAceptar
∂∂ ,
;
∂∂, -
}
∑∑ 	
private
ππ 
bool
ππ %
ExisteAmistadConJugador
ππ ,
(
ππ, -
)
ππ- .
{
∫∫ 	
string
ªª !
nombreJugadorOrigen
ªª &
=
ªª' (
Dominio
ªª) 0
.
ªª0 1
CuentaJugador
ªª1 >
.
ªª> ?
Actual
ªª? E
.
ªªE F
NombreJugador
ªªF S
;
ªªS T
string
ºº "
nombreJugadorDestino
ºº '
=
ºº( )0
"cuadroTextoNombreUsuarioInvitacion
ºº* L
.
ººL M
Text
ººM Q
;
ººQ R
bool
ΩΩ 
existeAmistad
ΩΩ 
=
ΩΩ  
	Servicios
ΩΩ! *
.
ΩΩ* +
ServicioAmistades
ΩΩ+ <
.
ΩΩ< =%
ExisteAmistadConJugador
ΩΩ= T
(
ΩΩT U!
nombreJugadorOrigen
ææ #
,
ææ# $"
nombreJugadorDestino
ææ% 9
)
ææ9 :
;
ææ: ;
if
¿¿ 
(
¿¿ 
existeAmistad
¿¿ 
)
¿¿ 
{
¡¡ 

MessageBox
¬¬ 
.
¬¬ 
Show
¬¬ 
(
¬¬  
$str
¬¬  S
+
¬¬T U
$str
√√ /
,
√√/ 0
$str
√√1 W
,
√√W X
MessageBoxButton
ƒƒ $
.
ƒƒ$ %
OK
ƒƒ% '
,
ƒƒ' (
MessageBoxImage
ƒƒ) 8
.
ƒƒ8 9
Error
ƒƒ9 >
)
ƒƒ> ?
;
ƒƒ? @
}
≈≈ 
return
«« 
existeAmistad
««  
;
««  !
}
»» 	
private
   
void
   $
IrAPaginaMenuPrincipal
   +
(
  + ,
object
  , 2
objetoOrigen
  3 ?
,
  ? @"
MouseButtonEventArgs
  A U
evento
  V \
)
  \ ]
{
ÀÀ 	
VentanaPrincipal
ÃÃ 
.
ÃÃ 
CambiarPagina
ÃÃ *
(
ÃÃ* +
new
ÃÃ+ .!
PaginaMenuPrincipal
ÃÃ/ B
(
ÃÃB C
)
ÃÃC D
)
ÃÃD E
;
ÃÃE F
}
ÕÕ 	
private
œœ 
void
œœ &
EnviarSolicitudDeAmistad
œœ -
(
œœ- .
object
œœ. 4
objetoOrigen
œœ5 A
,
œœA B
RoutedEventArgs
œœC R
evento
œœS Y
)
œœY Z
{
–– 	
if
—— 
(
—— 
!
—— (
EsElNombreDelJugadorActual
—— +
(
——+ ,
)
——, -
&&
——. 0
	Servicios
——1 :
.
——: ;
ServicioJugador
——; J
.
——J K!
ExisteNombreJugador
““ #
(
““# $0
"cuadroTextoNombreUsuarioInvitacion
““$ F
.
““F G
Text
““G K
)
““K L
&&
““M O
!
”” &
ExisteSolicitudDeAmistad
”” )
(
””) *
)
””* +
&&
””, .
!
””/ 0%
ExisteAmistadConJugador
””0 G
(
””G H
)
””H I
)
””I J
{
‘‘ 
string
’’ !
nombreJugadorOrigen
’’ *
=
’’+ ,
Dominio
’’- 4
.
’’4 5
CuentaJugador
’’5 B
.
’’B C
Actual
’’C I
.
’’I J
NombreJugador
’’J W
;
’’W X
string
÷÷ "
nombreJugadorDestino
÷÷ +
=
÷÷, -0
"cuadroTextoNombreUsuarioInvitacion
÷÷. P
.
÷÷P Q
Text
÷÷Q U
;
÷÷U V
bool
◊◊ %
envioSolicitudRealizado
◊◊ ,
=
◊◊- .
false
◊◊/ 4
;
◊◊4 5
try
ŸŸ 
{
⁄⁄ %
envioSolicitudRealizado
€€ +
=
€€, -&
clienteServicioAmistades
€€. F
.
€€F G&
EnviarSolicitudDeAmistad
‹‹ 0
(
‹‹0 1!
nombreJugadorOrigen
‹‹1 D
,
‹‹D E"
nombreJugadorDestino
‹‹F Z
)
‹‹Z [
;
‹‹[ \
}
›› 
catch
ﬁﬁ 
(
ﬁﬁ '
EndpointNotFoundException
ﬁﬁ 0
	excepcion
ﬁﬁ1 :
)
ﬁﬁ: ;
{
ﬂﬂ 

MessageBox
·· 
.
·· 
Show
·· #
(
··# $

Properties
··$ .
.
··. /
	Resources
··/ 8
.
··8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
‚‚ >
,
‚‚> ?

Properties
‚‚@ J
.
‚‚J K
	Resources
‚‚K T
.
‚‚T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
„„ =
,
„„= >
MessageBoxButton
‰‰ (
.
‰‰( )
OK
‰‰) +
,
‰‰+ ,
MessageBoxImage
‰‰- <
.
‰‰< =
Error
‰‰= B
)
‰‰B C
;
‰‰C D&
clienteServicioAmistades
ÂÂ ,
.
ÂÂ, -
Abort
ÂÂ- 2
(
ÂÂ2 3
)
ÂÂ3 4
;
ÂÂ4 5
}
ÊÊ 
catch
ÁÁ 
(
ÁÁ 1
#CommunicationObjectFaultedException
ÁÁ :
	excepcion
ÁÁ; D
)
ÁÁD E
{
ËË 

MessageBox
ÍÍ 
.
ÍÍ 
Show
ÍÍ #
(
ÍÍ# $

Properties
ÍÍ$ .
.
ÍÍ. /
	Resources
ÍÍ/ 8
.
ÍÍ8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÎÎ >
,
ÎÎ> ?

Properties
ÎÎ@ J
.
ÎÎJ K
	Resources
ÎÎK T
.
ÎÎT U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÏÏ =
,
ÏÏ= >
MessageBoxButton
ÌÌ (
.
ÌÌ( )
OK
ÌÌ) +
,
ÌÌ+ ,
MessageBoxImage
ÌÌ- <
.
ÌÌ< =
Error
ÌÌ= B
)
ÌÌB C
;
ÌÌC D&
clienteServicioAmistades
ÓÓ ,
.
ÓÓ, -
Abort
ÓÓ- 2
(
ÓÓ2 3
)
ÓÓ3 4
;
ÓÓ4 5
}
ÔÔ 
catch
 
(
 
TimeoutException
 '
	excepcion
( 1
)
1 2
{
ÒÒ 

MessageBox
ÛÛ 
.
ÛÛ 
Show
ÛÛ #
(
ÛÛ# $

Properties
ÛÛ$ .
.
ÛÛ. /
	Resources
ÛÛ/ 8
.
ÛÛ8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÙÙ >
,
ÙÙ> ?

Properties
ÙÙ@ J
.
ÙÙJ K
	Resources
ÙÙK T
.
ÙÙT U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ıı =
,
ıı= >
MessageBoxButton
ˆˆ (
.
ˆˆ( )
OK
ˆˆ) +
,
ˆˆ+ ,
MessageBoxImage
ˆˆ- <
.
ˆˆ< =
Error
ˆˆ= B
)
ˆˆB C
;
ˆˆC D&
clienteServicioAmistades
˜˜ ,
.
˜˜, -
Abort
˜˜- 2
(
˜˜2 3
)
˜˜3 4
;
˜˜4 5
}
¯¯ 
if
˙˙ 
(
˙˙ %
envioSolicitudRealizado
˙˙ +
)
˙˙+ ,
{
˚˚ 

MessageBox
¸¸ 
.
¸¸ 
Show
¸¸ #
(
¸¸# $
$str
¸¸$ Y
,
¸¸Y Z
$str
˝˝ 6
,
˝˝6 7
MessageBoxButton
˛˛ (
.
˛˛( )
OK
˛˛) +
,
˛˛+ ,
MessageBoxImage
˛˛- <
.
˛˛< =
Information
˛˛= H
)
˛˛H I
;
˛˛I J
}
ˇˇ 
else
ÄÄ 
{
ÅÅ 

MessageBox
ÇÇ 
.
ÇÇ 
Show
ÇÇ #
(
ÇÇ# $
$str
ÇÇ$ Y
,
ÇÇY Z
$str
ÉÉ >
,
ÉÉ> ?
MessageBoxButton
ÑÑ (
.
ÑÑ( )
OK
ÑÑ) +
,
ÑÑ+ ,
MessageBoxImage
ÑÑ- <
.
ÑÑ< =
Error
ÑÑ= B
)
ÑÑB C
;
ÑÑC D
}
ÖÖ 
}
ÜÜ 
}
áá 	
private
ââ 
void
ââ 
EliminarAmigo
ââ "
(
ââ" #
object
ââ# )
objetoOrigen
ââ* 6
,
ââ6 7
RoutedEventArgs
ââ8 G
evento
ââH N
)
ââN O
{
ää 	
var
ãã 

filaActual
ãã 
=
ãã 
(
ãã 
ListBoxItem
ãã )
)
ãã) *
listaAmigos
ãã* 5
.
ãã5 6"
ContainerFromElement
ãã6 J
(
ããJ K
(
åå 
Button
åå 
)
åå 
objetoOrigen
åå $
)
åå$ %
;
åå% &

filaActual
çç 
.
çç 

IsSelected
çç !
=
çç" #
true
çç$ (
;
çç( )
var
éé !
jugadorSeleccionado
éé #
=
éé$ %
(
éé& '
Dominio
éé' .
.
éé. /
CuentaJugador
éé/ <
)
éé< =
listaAmigos
éé= H
.
ééH I
SelectedItem
ééI U
;
ééU V
string
èè 
nombreJugadorA
èè !
=
èè" #
Dominio
èè$ +
.
èè+ ,
CuentaJugador
èè, 9
.
èè9 :
Actual
èè: @
.
èè@ A
NombreJugador
èèA N
;
èèN O
string
êê 
nombreJugadorB
êê !
=
êê" #!
jugadorSeleccionado
êê$ 7
.
êê7 8
NombreJugador
êê8 E
;
êêE F
bool
ëë "
eliminacionRealizada
ëë %
=
ëë& '
false
ëë( -
;
ëë- .
try
ìì 
{
îî "
eliminacionRealizada
ïï $
=
ïï% &&
clienteServicioAmistades
ïï' ?
.
ïï? @+
EliminarAmistadEntreJugadores
ññ 1
(
ññ1 2
nombreJugadorA
ññ2 @
,
ññ@ A
nombreJugadorB
ññB P
)
ññP Q
;
ññQ R
}
óó 
catch
òò 
(
òò '
EndpointNotFoundException
òò ,
	excepcion
òò- 6
)
òò6 7
{
ôô 

MessageBox
õõ 
.
õõ 
Show
õõ 
(
õõ  

Properties
õõ  *
.
õõ* +
	Resources
õõ+ 4
.
õõ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
úú :
,
úú: ;

Properties
úú< F
.
úúF G
	Resources
úúG P
.
úúP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ùù 9
,
ùù9 :
MessageBoxButton
ûû $
.
ûû$ %
OK
ûû% '
,
ûû' (
MessageBoxImage
ûû) 8
.
ûû8 9
Error
ûû9 >
)
ûû> ?
;
ûû? @&
clienteServicioAmistades
üü (
.
üü( )
Abort
üü) .
(
üü. /
)
üü/ 0
;
üü0 1
}
†† 
catch
°° 
(
°° 1
#CommunicationObjectFaultedException
°° 6
	excepcion
°°7 @
)
°°@ A
{
¢¢ 

MessageBox
§§ 
.
§§ 
Show
§§ 
(
§§  

Properties
§§  *
.
§§* +
	Resources
§§+ 4
.
§§4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
•• :
,
••: ;

Properties
••< F
.
••F G
	Resources
••G P
.
••P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
¶¶ 9
,
¶¶9 :
MessageBoxButton
ßß $
.
ßß$ %
OK
ßß% '
,
ßß' (
MessageBoxImage
ßß) 8
.
ßß8 9
Error
ßß9 >
)
ßß> ?
;
ßß? @&
clienteServicioAmistades
®® (
.
®®( )
Abort
®®) .
(
®®. /
)
®®/ 0
;
®®0 1
}
©© 
catch
™™ 
(
™™ 
TimeoutException
™™ #
	excepcion
™™$ -
)
™™- .
{
´´ 

MessageBox
≠≠ 
.
≠≠ 
Show
≠≠ 
(
≠≠  

Properties
≠≠  *
.
≠≠* +
	Resources
≠≠+ 4
.
≠≠4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÆÆ :
,
ÆÆ: ;

Properties
ÆÆ< F
.
ÆÆF G
	Resources
ÆÆG P
.
ÆÆP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ØØ 9
,
ØØ9 :
MessageBoxButton
∞∞ $
.
∞∞$ %
OK
∞∞% '
,
∞∞' (
MessageBoxImage
∞∞) 8
.
∞∞8 9
Error
∞∞9 >
)
∞∞> ?
;
∞∞? @&
clienteServicioAmistades
±± (
.
±±( )
Abort
±±) .
(
±±. /
)
±±/ 0
;
±±0 1
}
≤≤ 
if
¥¥ 
(
¥¥ "
eliminacionRealizada
¥¥ $
)
¥¥$ %
{
µµ 
cuentasDeAmigos
∂∂ 
.
∂∂  
Remove
∂∂  &
(
∂∂& '!
jugadorSeleccionado
∂∂' :
)
∂∂: ;
;
∂∂; <
}
∑∑ 
else
∏∏ 
{
ππ 

MessageBox
∫∫ 
.
∫∫ 
Show
∫∫ 
(
∫∫  
$str
∫∫  Y
,
∫∫Y Z
$str
ªª -
,
ªª- .
MessageBoxButton
ºº $
.
ºº$ %
OK
ºº% '
,
ºº' (
MessageBoxImage
ºº) 8
.
ºº8 9
Error
ºº9 >
)
ºº> ?
;
ºº? @
}
ΩΩ 
}
ææ 	
private
¿¿ 
void
¿¿ '
AceptarSolicitudDeAmistad
¿¿ .
(
¿¿. /
object
¿¿/ 5
objetoOrigen
¿¿6 B
,
¿¿B C
RoutedEventArgs
¡¡ 
evento
¡¡ "
)
¡¡" #
{
¬¬ 	
var
√√ 

filaActual
√√ 
=
√√ 
(
√√ 
ListBoxItem
√√ )
)
√√) *
listaSolicitudes
√√* :
.
√√: ;"
ContainerFromElement
√√; O
(
√√O P
(
ƒƒ 
Button
ƒƒ 
)
ƒƒ 
objetoOrigen
ƒƒ $
)
ƒƒ$ %
;
ƒƒ% &

filaActual
≈≈ 
.
≈≈ 

IsSelected
≈≈ !
=
≈≈" #
true
≈≈$ (
;
≈≈( )
var
∆∆ !
jugadorSeleccionado
∆∆ #
=
∆∆$ %
(
∆∆& '
Dominio
∆∆' .
.
∆∆. /
CuentaJugador
∆∆/ <
)
∆∆< =
listaSolicitudes
∆∆= M
.
∆∆M N
SelectedItem
∆∆N Z
;
∆∆Z [
bool
«« 
solicitudAceptada
«« "
=
««# $
false
««% *
;
««* +
if
…… 
(
…… !
jugadorSeleccionado
…… #
!=
……$ &
null
……' +
)
……+ ,
{
   
string
ÀÀ !
nombreJugadorOrigen
ÀÀ *
=
ÀÀ+ ,!
jugadorSeleccionado
ÀÀ- @
.
ÀÀ@ A
NombreJugador
ÀÀA N
;
ÀÀN O
string
ÃÃ "
nombreJugadorDestino
ÃÃ +
=
ÃÃ, -
Dominio
ÃÃ. 5
.
ÃÃ5 6
CuentaJugador
ÃÃ6 C
.
ÃÃC D
Actual
ÃÃD J
.
ÃÃJ K
NombreJugador
ÃÃK X
;
ÃÃX Y
try
ŒŒ 
{
œœ 
solicitudAceptada
–– %
=
––& '&
clienteServicioAmistades
––( @
.
––@ A'
AceptarSolicitudDeAmistad
––A Z
(
––Z [!
nombreJugadorOrigen
—— +
,
——+ ,"
nombreJugadorDestino
——- A
)
——A B
;
——B C
}
““ 
catch
”” 
(
”” '
EndpointNotFoundException
”” 0
	excepcion
””1 :
)
””: ;
{
‘‘ 

MessageBox
÷÷ 
.
÷÷ 
Show
÷÷ #
(
÷÷# $

Properties
÷÷$ .
.
÷÷. /
	Resources
÷÷/ 8
.
÷÷8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
◊◊ >
,
◊◊> ?

Properties
◊◊@ J
.
◊◊J K
	Resources
◊◊K T
.
◊◊T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÿÿ =
,
ÿÿ= >
MessageBoxButton
ŸŸ (
.
ŸŸ( )
OK
ŸŸ) +
,
ŸŸ+ ,
MessageBoxImage
ŸŸ- <
.
ŸŸ< =
Error
ŸŸ= B
)
ŸŸB C
;
ŸŸC D&
clienteServicioAmistades
⁄⁄ ,
.
⁄⁄, -
Abort
⁄⁄- 2
(
⁄⁄2 3
)
⁄⁄3 4
;
⁄⁄4 5
}
€€ 
catch
‹‹ 
(
‹‹ 1
#CommunicationObjectFaultedException
‹‹ :
	excepcion
‹‹; D
)
‹‹D E
{
›› 

MessageBox
ﬂﬂ 
.
ﬂﬂ 
Show
ﬂﬂ #
(
ﬂﬂ# $

Properties
ﬂﬂ$ .
.
ﬂﬂ. /
	Resources
ﬂﬂ/ 8
.
ﬂﬂ8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
‡‡ >
,
‡‡> ?

Properties
‡‡@ J
.
‡‡J K
	Resources
‡‡K T
.
‡‡T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
·· =
,
··= >
MessageBoxButton
‚‚ (
.
‚‚( )
OK
‚‚) +
,
‚‚+ ,
MessageBoxImage
‚‚- <
.
‚‚< =
Error
‚‚= B
)
‚‚B C
;
‚‚C D&
clienteServicioAmistades
„„ ,
.
„„, -
Abort
„„- 2
(
„„2 3
)
„„3 4
;
„„4 5
}
‰‰ 
catch
ÂÂ 
(
ÂÂ 
TimeoutException
ÂÂ '
	excepcion
ÂÂ( 1
)
ÂÂ1 2
{
ÊÊ 

MessageBox
ËË 
.
ËË 
Show
ËË #
(
ËË# $

Properties
ËË$ .
.
ËË. /
	Resources
ËË/ 8
.
ËË8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÈÈ >
,
ÈÈ> ?

Properties
ÈÈ@ J
.
ÈÈJ K
	Resources
ÈÈK T
.
ÈÈT U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÍÍ =
,
ÍÍ= >
MessageBoxButton
ÎÎ (
.
ÎÎ( )
OK
ÎÎ) +
,
ÎÎ+ ,
MessageBoxImage
ÎÎ- <
.
ÎÎ< =
Error
ÎÎ= B
)
ÎÎB C
;
ÎÎC D&
clienteServicioAmistades
ÏÏ ,
.
ÏÏ, -
Abort
ÏÏ- 2
(
ÏÏ2 3
)
ÏÏ3 4
;
ÏÏ4 5
}
ÌÌ 
}
ÓÓ 
if
 
(
 
solicitudAceptada
 !
)
! "
{
ÒÒ "
cuentasDeSolicitudes
ÚÚ $
.
ÚÚ$ %
Remove
ÚÚ% +
(
ÚÚ+ ,!
jugadorSeleccionado
ÚÚ, ?
)
ÚÚ? @
;
ÚÚ@ A
cuentasDeAmigos
ÛÛ 
.
ÛÛ  
Add
ÛÛ  #
(
ÛÛ# $!
jugadorSeleccionado
ÛÛ$ 7
)
ÛÛ7 8
;
ÛÛ8 9
}
ÙÙ 
else
ıı 
{
ˆˆ 

MessageBox
˜˜ 
.
˜˜ 
Show
˜˜ 
(
˜˜  
$str
˜˜  ^
,
˜˜^ _
$str
¯¯ ;
,
¯¯; <
MessageBoxButton
˘˘ $
.
˘˘$ %
OK
˘˘% '
,
˘˘' (
MessageBoxImage
˘˘) 8
.
˘˘8 9
Error
˘˘9 >
)
˘˘> ?
;
˘˘? @
}
˙˙ 
}
˚˚ 	
private
˝˝ 
void
˝˝ (
RechazarSolicitudDeAmistad
˝˝ /
(
˝˝/ 0
object
˝˝0 6
objetoOrigen
˝˝7 C
,
˝˝C D
RoutedEventArgs
˝˝E T
evento
˝˝U [
)
˝˝[ \
{
˛˛ 	
var
ˇˇ 

filaActual
ˇˇ 
=
ˇˇ 
(
ˇˇ 
ListBoxItem
ˇˇ )
)
ˇˇ) *
listaSolicitudes
ˇˇ* :
.
ˇˇ: ;"
ContainerFromElement
ˇˇ; O
(
ˇˇO P
(
ÄÄ 
Button
ÄÄ 
)
ÄÄ 
objetoOrigen
ÄÄ $
)
ÄÄ$ %
;
ÄÄ% &

filaActual
ÅÅ 
.
ÅÅ 

IsSelected
ÅÅ !
=
ÅÅ" #
true
ÅÅ$ (
;
ÅÅ( )
var
ÇÇ !
jugadorSeleccionado
ÇÇ #
=
ÇÇ$ %
(
ÇÇ& '
Dominio
ÇÇ' .
.
ÇÇ. /
CuentaJugador
ÇÇ/ <
)
ÇÇ< =
listaSolicitudes
ÇÇ= M
.
ÇÇM N
SelectedItem
ÇÇN Z
;
ÇÇZ [
string
ÉÉ !
nombreJugadorOrigen
ÉÉ &
=
ÉÉ' (!
jugadorSeleccionado
ÉÉ) <
.
ÉÉ< =
NombreJugador
ÉÉ= J
;
ÉÉJ K
string
ÑÑ "
nombreJugadorDestino
ÑÑ '
=
ÑÑ( )
Dominio
ÑÑ* 1
.
ÑÑ1 2
CuentaJugador
ÑÑ2 ?
.
ÑÑ? @
Actual
ÑÑ@ F
.
ÑÑF G
NombreJugador
ÑÑG T
;
ÑÑT U
bool
ÖÖ  
solicitudRechazada
ÖÖ #
=
ÖÖ$ %
false
ÖÖ& +
;
ÖÖ+ ,
try
áá 
{
àà  
solicitudRechazada
ââ "
=
ââ# $&
clienteServicioAmistades
ââ% =
.
ââ= >(
RechazarSolicitudDeAmistad
ââ> X
(
ââX Y!
nombreJugadorOrigen
ää '
,
ää' ("
nombreJugadorDestino
ää) =
)
ää= >
;
ää> ?
}
ãã 
catch
åå 
(
åå '
EndpointNotFoundException
åå ,
	excepcion
åå- 6
)
åå6 7
{
çç 

MessageBox
èè 
.
èè 
Show
èè 
(
èè  

Properties
èè  *
.
èè* +
	Resources
èè+ 4
.
èè4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
êê :
,
êê: ;

Properties
êê< F
.
êêF G
	Resources
êêG P
.
êêP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ëë 9
,
ëë9 :
MessageBoxButton
íí $
.
íí$ %
OK
íí% '
,
íí' (
MessageBoxImage
íí) 8
.
íí8 9
Error
íí9 >
)
íí> ?
;
íí? @&
clienteServicioAmistades
ìì (
.
ìì( )
Abort
ìì) .
(
ìì. /
)
ìì/ 0
;
ìì0 1
}
îî 
catch
ïï 
(
ïï 1
#CommunicationObjectFaultedException
ïï 6
	excepcion
ïï7 @
)
ïï@ A
{
ññ 

MessageBox
òò 
.
òò 
Show
òò 
(
òò  

Properties
òò  *
.
òò* +
	Resources
òò+ 4
.
òò4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ôô :
,
ôô: ;

Properties
ôô< F
.
ôôF G
	Resources
ôôG P
.
ôôP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
öö 9
,
öö9 :
MessageBoxButton
õõ $
.
õõ$ %
OK
õõ% '
,
õõ' (
MessageBoxImage
õõ) 8
.
õõ8 9
Error
õõ9 >
)
õõ> ?
;
õõ? @&
clienteServicioAmistades
úú (
.
úú( )
Abort
úú) .
(
úú. /
)
úú/ 0
;
úú0 1
}
ùù 
catch
ûû 
(
ûû 
TimeoutException
ûû #
	excepcion
ûû$ -
)
ûû- .
{
üü 

MessageBox
°° 
.
°° 
Show
°° 
(
°°  

Properties
°°  *
.
°°* +
	Resources
°°+ 4
.
°°4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
¢¢ :
,
¢¢: ;

Properties
¢¢< F
.
¢¢F G
	Resources
¢¢G P
.
¢¢P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
££ 9
,
££9 :
MessageBoxButton
§§ $
.
§§$ %
OK
§§% '
,
§§' (
MessageBoxImage
§§) 8
.
§§8 9
Error
§§9 >
)
§§> ?
;
§§? @&
clienteServicioAmistades
•• (
.
••( )
Abort
••) .
(
••. /
)
••/ 0
;
••0 1
}
¶¶ 
if
®® 
(
®®  
solicitudRechazada
®® "
)
®®" #
{
©© "
cuentasDeSolicitudes
™™ $
.
™™$ %
Remove
™™% +
(
™™+ ,!
jugadorSeleccionado
™™, ?
)
™™? @
;
™™@ A
}
´´ 
else
¨¨ 
{
≠≠ 

MessageBox
ÆÆ 
.
ÆÆ 
Show
ÆÆ 
(
ÆÆ  
$str
ÆÆ  _
,
ÆÆ_ `
$str
ØØ <
,
ØØ< =
MessageBoxButton
∞∞ %
.
∞∞% &
OK
∞∞& (
,
∞∞( )
MessageBoxImage
∞∞* 9
.
∞∞9 :
Error
∞∞: ?
)
∞∞? @
;
∞∞@ A
}
±± 
}
≤≤ 	
public
¥¥ 
void
¥¥ 2
$NotificarEstadoConectividadDeJugador
¥¥ 8
(
¥¥8 9
string
¥¥9 ?
nombreJugador
¥¥@ M
,
¥¥M N'
EstadoConectividadJugador
µµ %
estado
µµ& ,
)
µµ, -
{
∂∂ 	
if
∑∑ 
(
∑∑ 
cuentasDeAmigos
∑∑ 
!=
∑∑  "
null
∑∑# '
)
∑∑' (
{
∏∏ 
var
ππ %
cuentaAmigoModificacion
ππ +
=
ππ, -
cuentasDeAmigos
ππ. =
.
ππ= >
Where
ππ> C
(
ππC D
amigo
ππD I
=>
ππJ L
amigo
∫∫ 
.
∫∫ 
NombreJugador
∫∫ '
==
∫∫( *
nombreJugador
∫∫+ 8
)
∫∫8 9
.
∫∫9 :
FirstOrDefault
∫∫: H
(
∫∫H I
)
∫∫I J
;
∫∫J K
cuentasDeAmigos
ªª 
.
ªª  
Remove
ªª  &
(
ªª& '%
cuentaAmigoModificacion
ªª' >
)
ªª> ?
;
ªª? @
if
ΩΩ 
(
ΩΩ %
cuentaAmigoModificacion
ΩΩ +
!=
ΩΩ, .
null
ΩΩ/ 3
)
ΩΩ3 4
{
ææ %
cuentaAmigoModificacion
øø +
.
øø+ ,%
ColorEstadoConectividad
øø, C
=
øøD E1
#ObtenerColorSegunEstadoConectividad
¿¿ ;
(
¿¿; <
estado
¿¿< B
)
¿¿B C
;
¿¿C D
}
¡¡ 
cuentasDeAmigos
√√ 
.
√√  
Insert
√√  &
(
√√& '
$num
√√' (
,
√√( )%
cuentaAmigoModificacion
√√* A
)
√√A B
;
√√B C
}
ƒƒ 
}
≈≈ 	
public
«« 
void
«« .
 NotificarSolicitudAmistadEnviada
«« 4
(
««4 5
CuentaJugador
««5 B"
cuentaNuevaSolicitud
««C W
)
««W X
{
»» 	
if
…… 
(
…… "
cuentasDeSolicitudes
…… $
!=
……% '
null
……( ,
)
……, -
{
   "
cuentasDeSolicitudes
ÀÀ $
.
ÀÀ$ %
Add
ÀÀ% (
(
ÀÀ( )
new
ÀÀ) ,
Dominio
ÀÀ- 4
.
ÀÀ4 5
CuentaJugador
ÀÀ5 B
{
ÃÃ 
NombreJugador
ÕÕ !
=
ÕÕ" #"
cuentaNuevaSolicitud
ÕÕ$ 8
.
ÕÕ8 9
NombreJugador
ÕÕ9 F
,
ÕÕF G
NumeroAvatar
ŒŒ  
=
ŒŒ! ""
cuentaNuevaSolicitud
ŒŒ# 7
.
ŒŒ7 8
NumeroAvatar
ŒŒ8 D
,
ŒŒD E 
FuenteImagenAvatar
œœ &
=
œœ' (

Utilidades
œœ) 3
.
œœ3 4
GeneradorImagenes
œœ4 E
.
œœE F'
GenerarFuenteImagenAvatar
–– 1
(
––1 2"
cuentaNuevaSolicitud
––2 F
.
––F G
NumeroAvatar
––G S
)
––S T
,
––T U%
ColorEstadoConectividad
—— +
=
——, -1
#ObtenerColorSegunEstadoConectividad
——. Q
(
——Q R"
cuentaNuevaSolicitud
““ ,
.
““, - 
EstadoConectividad
““- ?
)
““? @
}
”” 
)
”” 
;
”” 
}
‘‘ 
}
’’ 	
public
◊◊ 
void
◊◊ /
!NotificarSolicitudAmistadAceptada
◊◊ 5
(
◊◊5 6
CuentaJugador
◊◊6 C
cuentaNuevoAmigo
◊◊D T
)
◊◊T U
{
ÿÿ 	
if
ŸŸ 
(
ŸŸ 
cuentasDeAmigos
ŸŸ 
!=
ŸŸ  "
null
ŸŸ# '
)
ŸŸ' (
{
⁄⁄ 
var
€€ &
solicitudAmistadResidual
€€ ,
=
€€- ."
cuentasDeSolicitudes
€€/ C
.
€€C D
Where
€€D I
(
€€I J
cuentaSolicitud
€€J Y
=>
€€Z \
cuentaSolicitud
‹‹ #
.
‹‹# $
NombreJugador
‹‹$ 1
==
‹‹2 4
cuentaNuevoAmigo
›› $
.
››$ %
NombreJugador
››% 2
)
››2 3
.
››3 4
FirstOrDefault
››4 B
(
››B C
)
››C D
;
››D E
if
ﬂﬂ 
(
ﬂﬂ &
solicitudAmistadResidual
ﬂﬂ ,
!=
ﬂﬂ- /
null
ﬂﬂ0 4
)
ﬂﬂ4 5
{
‡‡ "
cuentasDeSolicitudes
·· (
.
··( )
Remove
··) /
(
··/ 0&
solicitudAmistadResidual
··0 H
)
··H I
;
··I J
}
‚‚ 
cuentasDeAmigos
‰‰ 
.
‰‰  
Add
‰‰  #
(
‰‰# $
new
‰‰$ '
Dominio
‰‰( /
.
‰‰/ 0
CuentaJugador
‰‰0 =
{
ÂÂ 
NombreJugador
ÊÊ !
=
ÊÊ" #
cuentaNuevoAmigo
ÊÊ$ 4
.
ÊÊ4 5
NombreJugador
ÊÊ5 B
,
ÊÊB C
NumeroAvatar
ÁÁ  
=
ÁÁ! "
cuentaNuevoAmigo
ÁÁ# 3
.
ÁÁ3 4
NumeroAvatar
ÁÁ4 @
,
ÁÁ@ A 
FuenteImagenAvatar
ËË &
=
ËË' (

Utilidades
ËË) 3
.
ËË3 4
GeneradorImagenes
ËË4 E
.
ËËE F'
GenerarFuenteImagenAvatar
ÈÈ 1
(
ÈÈ1 2
cuentaNuevoAmigo
ÈÈ2 B
.
ÈÈB C
NumeroAvatar
ÈÈC O
)
ÈÈO P
,
ÈÈP Q%
ColorEstadoConectividad
ÍÍ +
=
ÍÍ, -1
#ObtenerColorSegunEstadoConectividad
ÍÍ. Q
(
ÍÍQ R
cuentaNuevoAmigo
ÎÎ (
.
ÎÎ( ) 
EstadoConectividad
ÎÎ) ;
)
ÎÎ; <
}
ÏÏ 
)
ÏÏ 
;
ÏÏ 
}
ÌÌ 
}
ÓÓ 	
public
 
void
 '
NotificarAmistadEliminada
 -
(
- .
string
. 4$
nombreAmigoEliminacion
5 K
)
K L
{
ÒÒ 	
if
ÚÚ 
(
ÚÚ 
cuentasDeAmigos
ÚÚ 
!=
ÚÚ  "
null
ÚÚ# '
)
ÚÚ' (
{
ÛÛ 
var
ÙÙ $
cuentaAmigoEliminacion
ÙÙ *
=
ÙÙ+ ,
cuentasDeAmigos
ÙÙ- <
.
ÙÙ< =
Where
ÙÙ= B
(
ÙÙB C
amigo
ÙÙC H
=>
ÙÙI K
amigo
ıı 
.
ıı 
NombreJugador
ıı '
==
ıı( *$
nombreAmigoEliminacion
ıı+ A
)
ııA B
.
ııB C
FirstOrDefault
ııC Q
(
ııQ R
)
ııR S
;
ııS T
if
˜˜ 
(
˜˜ $
cuentaAmigoEliminacion
˜˜ *
!=
˜˜+ -
null
˜˜. 2
)
˜˜2 3
{
¯¯ 
cuentasDeAmigos
˘˘ #
.
˘˘# $
Remove
˘˘$ *
(
˘˘* +$
cuentaAmigoEliminacion
˘˘+ A
)
˘˘A B
;
˘˘B C
}
˙˙ 
}
˚˚ 
}
¸¸ 	
private
˛˛ 
void
˛˛ 0
"DesuscribirJugadorDeNotificaciones
˛˛ 7
(
˛˛7 8
object
˛˛8 >
objetoOrigen
˛˛? K
,
˛˛K L
RoutedEventArgs
ˇˇ 
evento
ˇˇ "
)
ˇˇ" #
{
ÄÄ 	
try
ÅÅ 
{
ÇÇ &
clienteServicioAmistades
ÉÉ (
.
ÉÉ( )9
+DesuscribirJugadorDeNotificacionesAmistades
ÉÉ) T
(
ÉÉT U
Dominio
ÑÑ 
.
ÑÑ 
CuentaJugador
ÑÑ )
.
ÑÑ) *
Actual
ÑÑ* 0
.
ÑÑ0 1
NombreJugador
ÑÑ1 >
)
ÑÑ> ?
;
ÑÑ? @&
clienteServicioAmistades
ÖÖ (
.
ÖÖ( )
Close
ÖÖ) .
(
ÖÖ. /
)
ÖÖ/ 0
;
ÖÖ0 1
}
ÜÜ 
catch
áá 
(
áá '
EndpointNotFoundException
áá ,
	excepcion
áá- 6
)
áá6 7
{
àà 

MessageBox
ää 
.
ää 
Show
ää 
(
ää  

Properties
ää  *
.
ää* +
	Resources
ää+ 4
.
ää4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ãã :
,
ãã: ;

Properties
ãã< F
.
ããF G
	Resources
ããG P
.
ããP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
åå 9
,
åå9 :
MessageBoxButton
çç $
.
çç$ %
OK
çç% '
,
çç' (
MessageBoxImage
çç) 8
.
çç8 9
Error
çç9 >
)
çç> ?
;
çç? @&
clienteServicioAmistades
éé (
.
éé( )
Abort
éé) .
(
éé. /
)
éé/ 0
;
éé0 1
}
èè 
catch
êê 
(
êê 1
#CommunicationObjectFaultedException
êê 6
	excepcion
êê7 @
)
êê@ A
{
ëë 

MessageBox
ìì 
.
ìì 
Show
ìì 
(
ìì  

Properties
ìì  *
.
ìì* +
	Resources
ìì+ 4
.
ìì4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
îî :
,
îî: ;

Properties
îî< F
.
îîF G
	Resources
îîG P
.
îîP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ïï 9
,
ïï9 :
MessageBoxButton
ññ $
.
ññ$ %
OK
ññ% '
,
ññ' (
MessageBoxImage
ññ) 8
.
ññ8 9
Error
ññ9 >
)
ññ> ?
;
ññ? @&
clienteServicioAmistades
óó (
.
óó( )
Abort
óó) .
(
óó. /
)
óó/ 0
;
óó0 1
}
òò 
catch
ôô 
(
ôô 
TimeoutException
ôô #
	excepcion
ôô$ -
)
ôô- .
{
öö 

MessageBox
úú 
.
úú 
Show
úú 
(
úú  

Properties
úú  *
.
úú* +
	Resources
úú+ 4
.
úú4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ùù :
,
ùù: ;

Properties
ùù< F
.
ùùF G
	Resources
ùùG P
.
ùùP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ûû 9
,
ûû9 :
MessageBoxButton
üü $
.
üü$ %
OK
üü% '
,
üü' (
MessageBoxImage
üü) 8
.
üü8 9
Error
üü9 >
)
üü> ?
;
üü? @&
clienteServicioAmistades
†† (
.
††( )
Abort
††) .
(
††. /
)
††/ 0
;
††0 1
}
°° 
}
¢¢ 	
}
££ 
}§§ Õ
ãC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaModificacionJugadoresSala.xaml.cs
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
} ÷.
íC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaCodigoRestablecimientoContrasena.xaml.cs
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
}NN Ë!
ÑC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaInformacionJugador.xaml.cs
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
}55 ªY
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
ÄÄ 
.
ÄÄ 
	Resources
ÄÄ '
.
ÄÄ' (1
#ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS
ÄÄ( K
,
ÄÄK L
MessageBoxButton
ÄÄM ]
.
ÄÄ] ^
OK
ÄÄ^ `
)
ÄÄ` a
;
ÄÄa b
}
ÅÅ 
return
ÉÉ  
hayCamposInvalidos
ÉÉ %
;
ÉÉ% &
}
ÑÑ 	
private
ÜÜ 
bool
ÜÜ (
ExistenLongitudesExcedidas
ÜÜ /
(
ÜÜ/ 0
string
ÜÜ0 6
nombreJugador
ÜÜ7 D
,
ÜÜD E
string
ÜÜF L

contrasena
ÜÜM W
)
ÜÜW X
{
áá 	
bool
àà 
	resultado
àà 
=
àà 
false
àà "
;
àà" #
if
ää 
(
ää 
ValidadorDatos
ää 
.
ää 3
%ExisteLongitudExcedidaEnNombreJugador
ää D
(
ääD E
nombreJugador
ääE R
)
ääR S
||
ääT V
ValidadorDatos
ãã 
.
ãã 0
"ExisteLongitudExcedidaEnContrasena
ãã A
(
ããA B

contrasena
ããB L
)
ããL M
)
ããM N
{
åå 
	resultado
çç 
=
çç 
true
çç  
;
çç  !
}
éé 
return
êê 
	resultado
êê 
;
êê 
}
ëë 	
}
íí 
}ìì ≤/
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
}II äÇ
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
ÄÄ )
=
ÄÄ* +
false
ÄÄ, 1
,
ÄÄ1 2
FilaCorrecta
ÅÅ $
=
ÅÅ% &
fila
ÅÅ' +
,
ÅÅ+ ,
ColumnaCorrecta
ÇÇ '
=
ÇÇ( )
columna
ÇÇ* 1
}
ÉÉ 
;
ÉÉ 

nuevaPieza
ÑÑ 
.
ÑÑ $
EstablecerFuenteImagen
ÑÑ 5
(
ÑÑ5 6"
fuenteImagenOriginal
ÑÑ6 J
,
ÑÑJ K
areaRecorte
ÑÑL W
)
ÑÑW X
;
ÑÑX Y

nuevaPieza
ÖÖ 
.
ÖÖ 
Borde
ÖÖ $
=
ÖÖ% &(
GenerarNuevoBordeParaPieza
ÖÖ' A
(
ÖÖA B
)
ÖÖB C
;
ÖÖC D

nuevaPieza
ÜÜ 
.
ÜÜ 3
%EstablecerEstiloDePiezaSinSeleccionar
ÜÜ D
(
ÜÜD E
)
ÜÜE F
;
ÜÜF G
tablero
áá 
.
áá 
Piezas
áá "
.
áá" #
Add
áá# &
(
áá& '

nuevaPieza
áá' 1
)
áá1 2
;
áá2 3
}
àà 
}
ââ 
}
ää 	
private
åå 
Border
åå (
GenerarNuevoBordeParaPieza
åå 1
(
åå1 2
)
åå2 3
{
çç 	
Border
éé 
bordeImagen
éé 
=
éé  
new
éé! $
Border
éé% +
(
éé+ ,
)
éé, -
;
éé- .
bordeImagen
èè 
.
èè !
MouseLeftButtonDown
èè +
+=
èè, .
SeleccionarPieza
èè/ ?
;
èè? @
bordeImagen
êê 
.
êê 
	MouseMove
êê !
+=
êê" $

MoverPieza
êê% /
;
êê/ 0
bordeImagen
ëë 
.
ëë 
MouseLeftButtonUp
ëë )
+=
ëë* ,
SoltarPieza
ëë- 8
;
ëë8 9
return
ìì 
bordeImagen
ìì 
;
ìì 
}
îî 	
private
ññ 
void
ññ )
MostrarPiezasAleatoriamente
ññ 0
(
ññ0 1
)
ññ1 2
{
óó 	
Random
òò 
	aleatorio
òò 
=
òò 
new
òò "
Random
òò# )
(
òò) *
)
òò* +
;
òò+ ,
foreach
öö 
(
öö 
Pieza
öö 
pieza
öö  
in
öö! #
tablero
öö$ +
.
öö+ ,
Piezas
öö, 2
)
öö2 3
{
õõ 
double
úú 
anchoTablero
úú #
=
úú$ %!
tableroRompecabezas
úú& 9
.
úú9 :
ActualWidth
úú: E
;
úúE F
double
ùù 
alturaTablero
ùù $
=
ùù% &!
tableroRompecabezas
ùù' :
.
ùù: ;
ActualHeight
ùù; G
;
ùùG H
double
ûû 
	posicionX
ûû  
=
ûû! "
	aleatorio
ûû# ,
.
ûû, -

NextDouble
ûû- 7
(
ûû7 8
)
ûû8 9
*
ûû: ;
(
üü 
anchoTablero
üü !
-
üü" #
pieza
üü$ )
.
üü) *
Imagen
üü* 0
.
üü0 1
Width
üü1 6
)
üü6 7
;
üü7 8
double
†† 
	posicionY
††  
=
††! "
	aleatorio
††# ,
.
††, -

NextDouble
††- 7
(
††7 8
)
††8 9
*
††: ;
(
°° 
alturaTablero
°° "
-
°°# $
pieza
°°% *
.
°°* +
Imagen
°°+ 1
.
°°1 2
Height
°°2 8
)
°°8 9
;
°°9 :
Canvas
¢¢ 
.
¢¢ 
SetLeft
¢¢ 
(
¢¢ 
pieza
¢¢ $
.
¢¢$ %
Borde
¢¢% *
,
¢¢* +
	posicionX
¢¢, 5
)
¢¢5 6
;
¢¢6 7
Canvas
££ 
.
££ 
SetTop
££ 
(
££ 
pieza
££ #
.
££# $
Borde
££$ )
,
££) *
	posicionY
££+ 4
)
££4 5
;
££5 6!
tableroRompecabezas
§§ #
.
§§# $
Children
§§$ ,
.
§§, -
Add
§§- 0
(
§§0 1
pieza
§§1 6
.
§§6 7
Borde
§§7 <
)
§§< =
;
§§= >
}
•• 
}
¶¶ 	
private
®® 
void
®® <
.SobreponerEnTableroPiezasFaltantesDePosicionar
®® C
(
®®C D
)
®®D E
{
©© 	
foreach
™™ 
(
™™ 
Pieza
™™ 
pieza
™™  
in
™™! #
tablero
™™$ +
.
™™+ ,
Piezas
™™, 2
)
™™2 3
{
´´ 
if
¨¨ 
(
¨¨ 
!
¨¨ 
pieza
¨¨ 
.
¨¨ 
EstaDentroDeCelda
¨¨ ,
)
¨¨, -
{
≠≠ !
tableroRompecabezas
ÆÆ '
.
ÆÆ' (
Children
ÆÆ( 0
.
ÆÆ0 1
Remove
ÆÆ1 7
(
ÆÆ7 8
pieza
ÆÆ8 =
.
ÆÆ= >
Borde
ÆÆ> C
)
ÆÆC D
;
ÆÆD E!
tableroRompecabezas
ØØ '
.
ØØ' (
Children
ØØ( 0
.
ØØ0 1
Add
ØØ1 4
(
ØØ4 5
pieza
ØØ5 :
.
ØØ: ;
Borde
ØØ; @
)
ØØ@ A
;
ØØA B
}
∞∞ 
}
±± 
}
≤≤ 	
private
¥¥ 
bool
¥¥ -
EsPosicionValidaParaPiezaActual
¥¥ 4
(
¥¥4 5
double
¥¥5 ;
nuevaPosicionX
¥¥< J
,
¥¥J K
double
µµ 
nuevaPosicionY
µµ !
)
µµ! "
{
∂∂ 	
bool
∑∑ 
esPosicionValida
∑∑ !
=
∑∑" #
false
∑∑$ )
;
∑∑) *
if
ππ 
(
ππ 
(
ππ 
nuevaPosicionX
ππ 
+
ππ  !
piezaActual
ππ" -
.
ππ- .5
'ObtenerDiferenciaAnchoEntreImagenYBorde
ππ. U
(
ππU V
)
ππV W
)
ππW X
>=
ππY [
$num
ππ\ ]
&&
ππ^ `
(
∫∫ 
nuevaPosicionY
∫∫ 
+
∫∫  !
piezaActual
∫∫" -
.
∫∫- .6
(ObtenerDiferenciaAlturaEntreImagenYBorde
∫∫. V
(
∫∫V W
)
∫∫W X
)
∫∫X Y
>=
∫∫Z \
$num
∫∫] ^
&&
∫∫_ a
(
ªª 
piezaActual
ªª 
.
ªª 
Ancho
ªª "
+
ªª# $
nuevaPosicionX
ªª% 3
<=
ªª4 6!
tableroRompecabezas
ªª7 J
.
ªªJ K
ActualWidth
ªªK V
)
ªªV W
&&
ªªX Z
(
ºº 
piezaActual
ºº 
.
ºº 
Alto
ºº !
+
ºº" #
nuevaPosicionY
ºº$ 2
<=
ºº3 5!
tableroRompecabezas
ºº6 I
.
ººI J
ActualHeight
ººJ V
)
ººV W
)
ººW X
{
ΩΩ 
esPosicionValida
ææ  
=
ææ! "
true
ææ# '
;
ææ' (
}
øø 
return
¡¡ 
esPosicionValida
¡¡ #
;
¡¡# $
}
¬¬ 	
private
ƒƒ 
Pieza
ƒƒ ,
BuscarPiezaPertenecienteABorde
ƒƒ 4
(
ƒƒ4 5
Border
ƒƒ5 ;
borde
ƒƒ< A
)
ƒƒA B
{
≈≈ 	
var
∆∆ 
piezasEncontradas
∆∆ !
=
∆∆" #
tablero
∆∆$ +
.
∆∆+ ,
Piezas
∆∆, 2
.
∆∆2 3
Where
∆∆3 8
(
∆∆8 9
pieza
∆∆9 >
=>
∆∆? A
pieza
∆∆B G
.
∆∆G H
Borde
∆∆H M
.
∆∆M N
Equals
∆∆N T
(
∆∆T U
borde
∆∆U Z
)
∆∆Z [
)
∆∆[ \
;
∆∆\ ]
Pieza
«« 
piezaEncontrada
«« !
=
««" #
new
««$ '
Pieza
««( -
(
««- .
)
««. /
;
««/ 0
if
…… 
(
…… 
piezasEncontradas
…… !
.
……! "
Any
……" %
(
……% &
)
……& '
)
……' (
{
   
piezaEncontrada
ÀÀ 
=
ÀÀ  !
piezasEncontradas
ÀÀ" 3
.
ÀÀ3 4
First
ÀÀ4 9
(
ÀÀ9 :
)
ÀÀ: ;
;
ÀÀ; <
}
ÃÃ 
return
ŒŒ 
piezaEncontrada
ŒŒ "
;
ŒŒ" #
}
œœ 	
private
—— 
Celda
—— +
BuscarCeldaPertenecienteAArea
—— 3
(
——3 4
	Rectangle
——4 =
	areaCelda
——> G
)
——G H
{
““ 	
var
”” 
celdasEncontradas
”” !
=
””" #
tablero
””$ +
.
””+ ,
Celdas
””, 2
.
””2 3
Where
””3 8
(
””8 9
celda
””9 >
=>
””? A
celda
””B G
.
””G H
Area
””H L
.
””L M
Equals
””M S
(
””S T
	areaCelda
””T ]
)
””] ^
)
””^ _
;
””_ `
Celda
‘‘ 
celdaEncontrada
‘‘ !
=
‘‘" #
new
‘‘$ '
Celda
‘‘( -
(
‘‘- .
)
‘‘. /
;
‘‘/ 0
if
÷÷ 
(
÷÷ 
celdasEncontradas
÷÷ !
.
÷÷! "
Any
÷÷" %
(
÷÷% &
)
÷÷& '
)
÷÷' (
{
◊◊ 
celdaEncontrada
ÿÿ 
=
ÿÿ  !
celdasEncontradas
ÿÿ" 3
.
ÿÿ3 4
First
ÿÿ4 9
(
ÿÿ9 :
)
ÿÿ: ;
;
ÿÿ; <
}
ŸŸ 
return
€€ 
celdaEncontrada
€€ "
;
€€" #
}
‹‹ 	
private
ﬁﬁ 
void
ﬁﬁ 3
%PosicionarPiezaEnCeldaCorrespondiente
ﬁﬁ :
(
ﬁﬁ: ;
Point
ﬁﬁ; @
posicion
ﬁﬁA I
)
ﬁﬁI J
{
ﬂﬂ 	
foreach
‡‡ 
(
‡‡ 
	UIElement
‡‡ 
control
‡‡ &
in
‡‡' )!
tableroRompecabezas
‡‡* =
.
‡‡= >
Children
‡‡> F
)
‡‡F G
{
·· 
if
‚‚ 
(
‚‚ 
control
‚‚ 
is
‚‚ 
	Rectangle
‚‚ (
	areaCelda
‚‚) 2
)
‚‚2 3
{
„„ 
double
‰‰ 
posicionXMinima
‰‰ *
=
‰‰+ ,
Canvas
‰‰- 3
.
‰‰3 4
GetLeft
‰‰4 ;
(
‰‰; <
	areaCelda
‰‰< E
)
‰‰E F
;
‰‰F G
double
ÂÂ 
posicionYMinima
ÂÂ *
=
ÂÂ+ ,
Canvas
ÂÂ- 3
.
ÂÂ3 4
GetTop
ÂÂ4 :
(
ÂÂ: ;
	areaCelda
ÂÂ; D
)
ÂÂD E
;
ÂÂE F
double
ÊÊ 
posicionXMaxima
ÊÊ *
=
ÊÊ+ ,
posicionXMinima
ÊÊ- <
+
ÊÊ= >
	areaCelda
ÊÊ? H
.
ÊÊH I
Width
ÊÊI N
;
ÊÊN O
double
ÁÁ 
posicionYMaxima
ÁÁ *
=
ÁÁ+ ,
posicionYMinima
ÁÁ- <
+
ÁÁ= >
	areaCelda
ÁÁ? H
.
ÁÁH I
Height
ÁÁI O
;
ÁÁO P
if
ÈÈ 
(
ÈÈ 
posicion
ÈÈ  
.
ÈÈ  !
X
ÈÈ! "
>=
ÈÈ# %
posicionXMinima
ÈÈ& 5
&&
ÈÈ6 8
posicion
ÍÍ  
.
ÍÍ  !
X
ÍÍ! "
<=
ÍÍ# %
posicionXMaxima
ÍÍ& 5
&&
ÍÍ6 8
posicion
ÎÎ  
.
ÎÎ  !
Y
ÎÎ! "
>=
ÎÎ# %
posicionYMinima
ÎÎ& 5
&&
ÎÎ6 8
posicion
ÏÏ  
.
ÏÏ  !
Y
ÏÏ! "
<=
ÏÏ# %
posicionYMaxima
ÏÏ& 5
)
ÏÏ5 6
{
ÌÌ 
Celda
ÓÓ 
celda
ÓÓ #
=
ÓÓ$ %+
BuscarCeldaPertenecienteAArea
ÓÓ& C
(
ÓÓC D
	areaCelda
ÓÓD M
)
ÓÓM N
;
ÓÓN O
if
 
(
 
celda
 !
.
! "
Fila
" &
==
' )
piezaActual
* 5
.
5 6
FilaCorrecta
6 B
&&
C E
celda
ÒÒ !
.
ÒÒ! "
Columna
ÒÒ" )
==
ÒÒ* ,
piezaActual
ÒÒ- 8
.
ÒÒ8 9
ColumnaCorrecta
ÒÒ9 H
)
ÒÒH I
{
ÚÚ 
Canvas
ÛÛ "
.
ÛÛ" #
SetLeft
ÛÛ# *
(
ÛÛ* +
piezaActual
ÛÛ+ 6
.
ÛÛ6 7
Borde
ÛÛ7 <
,
ÛÛ< =
posicionXMinima
ÛÛ> M
)
ÛÛM N
;
ÛÛN O
Canvas
ÙÙ "
.
ÙÙ" #
SetTop
ÙÙ# )
(
ÙÙ) *
piezaActual
ÙÙ* 5
.
ÙÙ5 6
Borde
ÙÙ6 ;
,
ÙÙ; <
posicionYMinima
ÙÙ= L
)
ÙÙL M
;
ÙÙM N
piezaActual
ıı '
.
ıı' (
EstaDentroDeCelda
ıı( 9
=
ıı: ;
true
ıı< @
;
ıı@ A<
.SobreponerEnTableroPiezasFaltantesDePosicionar
ˆˆ J
(
ˆˆJ K
)
ˆˆK L
;
ˆˆL M
break
˜˜ !
;
˜˜! "
}
¯¯ 
}
˘˘ 
}
˙˙ 
}
˚˚ 
}
¸¸ 	
private
˛˛ 
void
˛˛ -
RemoverEventoVentanaDesactivada
˛˛ 4
(
˛˛4 5
)
˛˛5 6
{
ˇˇ 	
VentanaPrincipal
ÄÄ 
ventanaPrincipal
ÄÄ -
=
ÄÄ. /
(
ÄÄ0 1
VentanaPrincipal
ÄÄ1 A
)
ÄÄA B
Window
ÄÄB H
.
ÄÄH I
	GetWindow
ÄÄI R
(
ÄÄR S
this
ÄÄS W
)
ÄÄW X
;
ÄÄX Y
ventanaPrincipal
ÅÅ 
.
ÅÅ 
Deactivated
ÅÅ (
-=
ÅÅ) +,
SoltarPiezaAlDesactivarVentana
ÅÅ, J
;
ÅÅJ K
}
ÇÇ 	
private
ÑÑ 
void
ÑÑ  
CargarDatosPartida
ÑÑ '
(
ÑÑ' (
object
ÑÑ( .
objetoOrigen
ÑÑ/ ;
,
ÑÑ; <
RoutedEventArgs
ÑÑ= L
evento
ÑÑM S
)
ÑÑS T
{
ÖÖ 	
VentanaPrincipal
ÜÜ 
ventanaPrincipal
ÜÜ -
=
ÜÜ. /
(
ÜÜ0 1
VentanaPrincipal
ÜÜ1 A
)
ÜÜA B
Window
ÜÜB H
.
ÜÜH I
	GetWindow
ÜÜI R
(
ÜÜR S
this
ÜÜS W
)
ÜÜW X
;
ÜÜX Y
ventanaPrincipal
áá 
.
áá 
Deactivated
áá (
+=
áá) +,
SoltarPiezaAlDesactivarVentana
áá, J
;
ááJ K
CrearTablero
àà 
(
àà 
)
àà 
;
àà 
}
ââ 	
private
ãã 
void
ãã ,
SoltarPiezaAlDesactivarVentana
ãã 3
(
ãã3 4
object
ãã4 :
objetoOrigen
ãã; G
,
ããG H
	EventArgs
ããI R
evento
ããS Y
)
ããY Z
{
åå 	!
cursorSostienePieza
çç 
=
çç  !
false
çç" '
;
çç' (
if
èè 
(
èè 
piezaActual
èè 
!=
èè 
null
èè #
&&
èè$ &
!
èè' (
piezaActual
èè( 3
.
èè3 4
EstaDentroDeCelda
èè4 E
)
èèE F
{
êê 
piezaActual
ëë 
.
ëë 3
%EstablecerEstiloDePiezaSinSeleccionar
ëë A
(
ëëA B
)
ëëB C
;
ëëC D
}
íí 
}
ìì 	
private
ïï 
void
ïï $
IrPaginaAjustesPartida
ïï +
(
ïï+ ,
object
ïï, 2
objetoOrigen
ïï3 ?
,
ïï? @"
MouseButtonEventArgs
ïïA U
evento
ïïV \
)
ïï\ ]
{
ññ 	
}
òò 	
private
öö 
void
öö 
IniciarJuego
öö !
(
öö! "
object
öö" (
objetoOrigen
öö) 5
,
öö5 6
RoutedEventArgs
öö7 F
evento
ööG M
)
ööM N
{
õõ 	
botonIniciar
úú 
.
úú 
	IsEnabled
úú "
=
úú# $
false
úú% *
;
úú* +
BitmapImage
ùù "
fuenteImagenOriginal
ùù ,
=
ùù- .

Utilidades
ùù/ 9
.
ùù9 :
GeneradorImagenes
ùù: K
.
ùùK L-
GenerarFuenteImagenRompecabezas
ûû /
(
ûû/ 0
tablero
ûû0 7
.
ûû7 8&
NumeroImagenRompecabezas
ûû8 P
)
ûûP Q
;
ûûQ R$
RecortarImagenEnPiezas
üü "
(
üü" #"
fuenteImagenOriginal
üü# 7
)
üü7 8
;
üü8 9)
MostrarPiezasAleatoriamente
†† '
(
††' (
)
††( )
;
††) *
}
°° 	
private
££ 
void
££ 
SeleccionarPieza
££ %
(
££% &
object
££& ,
objetoOrigen
££- 9
,
££9 :"
MouseButtonEventArgs
££; O
evento
££P V
)
££V W
{
§§ 	
piezaActual
•• 
=
•• ,
BuscarPiezaPertenecienteABorde
•• 8
(
••8 9
(
••9 :
Border
••: @
)
••@ A
objetoOrigen
••A M
)
••M N
;
••N O
if
ßß 
(
ßß 
!
ßß 
piezaActual
ßß 
.
ßß 
EstaDentroDeCelda
ßß .
)
ßß. /
{
®® !
tableroRompecabezas
©© #
.
©©# $
Children
©©$ ,
.
©©, -
Remove
©©- 3
(
©©3 4
piezaActual
©©4 ?
.
©©? @
Borde
©©@ E
)
©©E F
;
©©F G!
tableroRompecabezas
™™ #
.
™™# $
Children
™™$ ,
.
™™, -
Add
™™- 0
(
™™0 1
piezaActual
™™1 <
.
™™< =
Borde
™™= B
)
™™B C
;
™™C D
piezaActual
´´ 
.
´´ 1
#EstablecerEstiloDePiezaSeleccionada
´´ ?
(
´´? @
)
´´@ A
;
´´A B#
posicionInicialCursor
¨¨ %
=
¨¨& '
evento
¨¨( .
.
¨¨. /
GetPosition
¨¨/ :
(
¨¨: ;!
tableroRompecabezas
¨¨; N
)
¨¨N O
;
¨¨O P
piezaActual
≠≠ 
.
≠≠ 
Borde
≠≠ !
.
≠≠! "
CaptureMouse
≠≠" .
(
≠≠. /
)
≠≠/ 0
;
≠≠0 1!
cursorSostienePieza
ÆÆ #
=
ÆÆ$ %
true
ÆÆ& *
;
ÆÆ* +
}
ØØ 
}
∞∞ 	
private
≤≤ 
void
≤≤ 

MoverPieza
≤≤ 
(
≤≤  
object
≤≤  &
objetoOrigen
≤≤' 3
,
≤≤3 4
MouseEventArgs
≤≤5 C
evento
≤≤D J
)
≤≤J K
{
≥≥ 	
if
¥¥ 
(
¥¥ !
cursorSostienePieza
¥¥ #
)
¥¥# $
{
µµ 
piezaActual
∂∂ 
=
∂∂ ,
BuscarPiezaPertenecienteABorde
∂∂ <
(
∂∂< =
(
∂∂= >
Border
∂∂> D
)
∂∂D E
objetoOrigen
∂∂E Q
)
∂∂Q R
;
∂∂R S
Point
∑∑ "
posicionActualCursor
∑∑ *
=
∑∑+ ,
evento
∑∑- 3
.
∑∑3 4
GetPosition
∑∑4 ?
(
∑∑? @!
tableroRompecabezas
∑∑@ S
)
∑∑S T
;
∑∑T U
double
∏∏ !
diferenciaPosicionX
∏∏ *
=
∏∏+ ,"
posicionActualCursor
∏∏- A
.
∏∏A B
X
∏∏B C
-
∏∏D E#
posicionInicialCursor
∏∏F [
.
∏∏[ \
X
∏∏\ ]
;
∏∏] ^
double
ππ !
diferenciaPosicionY
ππ *
=
ππ+ ,"
posicionActualCursor
ππ- A
.
ππA B
Y
ππB C
-
ππD E#
posicionInicialCursor
ππF [
.
ππ[ \
Y
ππ\ ]
;
ππ] ^
double
∫∫ 
nuevaPosicionX
∫∫ %
=
∫∫& '
Canvas
∫∫( .
.
∫∫. /
GetLeft
∫∫/ 6
(
∫∫6 7
piezaActual
∫∫7 B
.
∫∫B C
Borde
∫∫C H
)
∫∫H I
+
∫∫J K!
diferenciaPosicionX
∫∫L _
;
∫∫_ `
double
ªª 
nuevaPosicionY
ªª %
=
ªª& '
Canvas
ªª( .
.
ªª. /
GetTop
ªª/ 5
(
ªª5 6
piezaActual
ªª6 A
.
ªªA B
Borde
ªªB G
)
ªªG H
+
ªªI J!
diferenciaPosicionY
ªªK ^
;
ªª^ _
if
ΩΩ 
(
ΩΩ -
EsPosicionValidaParaPiezaActual
ΩΩ 3
(
ΩΩ3 4
nuevaPosicionX
ΩΩ4 B
,
ΩΩB C
nuevaPosicionY
ΩΩD R
)
ΩΩR S
)
ΩΩS T
{
ææ 
Canvas
øø 
.
øø 
SetLeft
øø "
(
øø" #
piezaActual
øø# .
.
øø. /
Borde
øø/ 4
,
øø4 5
Canvas
¿¿ 
.
¿¿ 
GetLeft
¿¿ &
(
¿¿& '
piezaActual
¿¿' 2
.
¿¿2 3
Borde
¿¿3 8
)
¿¿8 9
+
¿¿: ;!
diferenciaPosicionX
¿¿< O
)
¿¿O P
;
¿¿P Q
Canvas
¡¡ 
.
¡¡ 
SetTop
¡¡ !
(
¡¡! "
piezaActual
¡¡" -
.
¡¡- .
Borde
¡¡. 3
,
¡¡3 4
Canvas
¬¬ 
.
¬¬ 
GetTop
¬¬ %
(
¬¬% &
piezaActual
¬¬& 1
.
¬¬1 2
Borde
¬¬2 7
)
¬¬7 8
+
¬¬9 :!
diferenciaPosicionY
¬¬; N
)
¬¬N O
;
¬¬O P#
posicionInicialCursor
√√ )
=
√√* +"
posicionActualCursor
√√, @
;
√√@ A
}
ƒƒ 
}
≈≈ 
}
∆∆ 	
private
»» 
void
»» 
SoltarPieza
»»  
(
»»  !
object
»»! '
objetoOrigen
»»( 4
,
»»4 5"
MouseButtonEventArgs
»»6 J
evento
»»K Q
)
»»Q R
{
…… 	
if
   
(
   !
cursorSostienePieza
   #
)
  # $
{
ÀÀ 
piezaActual
ÃÃ 
.
ÃÃ 
Borde
ÃÃ !
.
ÃÃ! "!
ReleaseMouseCapture
ÃÃ" 5
(
ÃÃ5 6
)
ÃÃ6 7
;
ÃÃ7 8!
cursorSostienePieza
ÕÕ #
=
ÕÕ$ %
false
ÕÕ& +
;
ÕÕ+ ,
piezaActual
ŒŒ 
=
ŒŒ ,
BuscarPiezaPertenecienteABorde
ŒŒ <
(
ŒŒ< =
(
ŒŒ= >
Border
ŒŒ> D
)
ŒŒD E
objetoOrigen
ŒŒE Q
)
ŒŒQ R
;
ŒŒR S
piezaActual
œœ 
.
œœ 
Borde
œœ !
.
œœ! "
BorderBrush
œœ" -
=
œœ. /
Brushes
œœ0 7
.
œœ7 8
Transparent
œœ8 C
;
œœC D
Point
–– 
posicionActual
–– $
=
––% &
evento
––' -
.
––- .
GetPosition
––. 9
(
––9 :!
tableroRompecabezas
––: M
)
––M N
;
––N O
piezaActual
—— 
.
—— 3
%EstablecerEstiloDePiezaSinSeleccionar
—— A
(
——A B
)
——B C
;
——C D3
%PosicionarPiezaEnCeldaCorrespondiente
““ 5
(
““5 6
posicionActual
““6 D
)
““D E
;
““E F
if
”” 
(
”” 
tablero
”” 
.
”” &
EsRompecabezasCompletado
”” 4
(
””4 5
)
””5 6
)
””6 7
{
‘‘ 

MessageBox
’’ 
.
’’ 
Show
’’ #
(
’’# $

Properties
’’$ .
.
’’. /
	Resources
’’/ 8
.
’’8 9.
 ETIQUETA_PARTIDA_JUEGOFINALIZADO
’’9 Y
)
’’Y Z
;
’’Z [-
RemoverEventoVentanaDesactivada
÷÷ 3
(
÷÷3 4
)
÷÷4 5
;
÷÷5 6
VentanaPrincipal
◊◊ $
.
◊◊$ %
CambiarPagina
◊◊% 2
(
◊◊2 3
new
◊◊3 6
PaginaResultados
◊◊7 G
(
◊◊G H
)
◊◊H I
)
◊◊I J
;
◊◊J K
}
ÿÿ 
}
ŸŸ 
}
⁄⁄ 	
public
‹‹ 
void
‹‹ ,
ActualizarNuevaPosicionDePieza
‹‹ 2
(
‹‹2 3
double
‹‹3 9
	posicionX
‹‹: C
,
‹‹C D
double
‹‹E K
	posicionY
‹‹L U
)
‹‹U V
{
›› 	
throw
ﬁﬁ 
new
ﬁﬁ %
NotImplementedException
ﬁﬁ -
(
ﬁﬁ- .
)
ﬁﬁ. /
;
ﬁﬁ/ 0
}
ﬂﬂ 	
}
‡‡ 
}·· é
àC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRecuperacionContrasena.xaml.cs
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
}11 ‹o
ÅC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRegistroJugador.xaml.cs
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
ÄÄ "
=
ÄÄ# $
true
ÄÄ% )
;
ÄÄ) *
}
ÅÅ 
if
ÉÉ 
(
ÉÉ 
!
ÉÉ 
ValidadorDatos
ÉÉ 
.
ÉÉ  )
ExisteCoincidenciaEnCadenas
ÉÉ  ;
(
ÉÉ; <(
cuadroContrasenaContrasena
ÉÉ< V
.
ÉÉV W
Password
ÉÉW _
,
ÉÉ_ `4
&cuadroContrasenaConfirmacionContrasena
ÑÑ 6
.
ÑÑ6 7
Password
ÑÑ7 ?
)
ÑÑ? @
)
ÑÑ@ A
{
ÖÖ 

MessageBox
ÜÜ 
.
ÜÜ 
Show
ÜÜ 
(
ÜÜ  

Properties
ÜÜ  *
.
ÜÜ* +
	Resources
ÜÜ+ 4
.
ÜÜ4 5<
.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE
áá B
,
ááB C

Properties
ááD N
.
ááN O
	Resources
ááO X
.
ááX Y5
'ETIQUETA_VALIDACION_CONTRASENADIFERENTE
àà ;
,
àà; <
MessageBoxButton
àà= M
.
ààM N
OK
ààN P
)
ààP Q
;
ààQ R 
hayCamposInvalidos
ââ "
=
ââ# $
true
ââ% )
;
ââ) *
}
ää 
return
åå  
hayCamposInvalidos
åå %
;
åå% &
}
çç 	
private
èè 
bool
èè !
ExistenCamposVacios
èè (
(
èè( )
)
èè) *
{
êê 	
bool
ëë 
	resultado
ëë 
=
ëë 
false
ëë "
;
ëë" #
if
ìì 
(
ìì 
ValidadorDatos
ìì 
.
ìì 
EsCadenaVacia
ìì ,
(
ìì, -&
cuadroTextoNombreJugador
ìì- E
.
ììE F
Text
ììF J
)
ììJ K
||
îî 
ValidadorDatos
îî !
.
îî! "
EsCadenaVacia
îî" /
(
îî/ 0*
cuadroTextoCorreoElectronico
îî0 L
.
îîL M
Text
îîM Q
)
îîQ R
||
ïï 
ValidadorDatos
ïï !
.
ïï! "
EsCadenaVacia
ïï" /
(
ïï/ 0(
cuadroContrasenaContrasena
ïï0 J
.
ïïJ K
Password
ïïK S
)
ïïS T
||
ññ 
ValidadorDatos
ññ !
.
ññ! "
EsCadenaVacia
ññ" /
(
ññ/ 04
&cuadroContrasenaConfirmacionContrasena
ññ0 V
.
ññV W
Password
ññW _
)
ññ_ `
)
ññ` a
{
óó 
	resultado
òò 
=
òò 
true
òò  
;
òò  !
}
ôô 
return
õõ 
	resultado
õõ 
;
õõ 
}
úú 	
private
ûû 
bool
ûû (
ExistenLongitudesExcedidas
ûû /
(
ûû/ 0
)
ûû0 1
{
üü 	
bool
†† 
	resultado
†† 
=
†† 
false
†† "
;
††" #
if
¢¢ 
(
¢¢ 
ValidadorDatos
¢¢ 
.
¢¢ 3
%ExisteLongitudExcedidaEnNombreJugador
¢¢ D
(
¢¢D E&
cuadroTextoNombreJugador
££ (
.
££( )
Text
££) -
)
££- .
||
££/ 1
ValidadorDatos
§§ 
.
§§ ,
ExisteLongitudExcedidaEnCorreo
§§ =
(
§§= >*
cuadroTextoCorreoElectronico
•• ,
.
••, -
Text
••- 1
)
••1 2
||
••3 5
ValidadorDatos
¶¶ 
.
¶¶ 0
"ExisteLongitudExcedidaEnContrasena
¶¶ A
(
¶¶A B(
cuadroContrasenaContrasena
ßß *
.
ßß* +
Password
ßß+ 3
)
ßß3 4
)
ßß4 5
{
®® 
	resultado
©© 
=
©© 
true
©©  
;
©©  !
}
™™ 
return
¨¨ 
	resultado
¨¨ 
;
¨¨ 
}
≠≠ 	
}
ÆÆ 
}ØØ ≠
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
}   ‰&
åC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRestablecimientoContrasena.xaml.cs
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
}GG ¥ë
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
ÄÄ $
.
ÄÄ$ %
Abort
ÄÄ% *
(
ÄÄ* +
)
ÄÄ+ ,
;
ÄÄ, -
}
ÅÅ 
}
ÇÇ 	
private
ÑÑ 
void
ÑÑ #
CargarJugadoresEnSala
ÑÑ *
(
ÑÑ* +
)
ÑÑ+ ,
{
ÖÖ 	
CuentaJugador
ÜÜ 
[
ÜÜ 
]
ÜÜ "
jugadoresRecuperados
ÜÜ 0
=
ÜÜ1 2
	Servicios
ÜÜ3 <
.
ÜÜ< =
ServicioSala
ÜÜ= I
.
ÜÜI J.
 ObtenerJugadoresConectadosEnSala
áá 0
(
áá0 1

codigoSala
áá1 ;
)
áá; <
;
áá< =
foreach
ââ 
(
ââ 
CuentaJugador
ââ "
jugador
ââ# *
in
ââ+ -"
jugadoresRecuperados
ââ. B
)
ââB C
{
ää 
jugadoresEnSala
ãã 
.
ãã  
Add
ãã  #
(
ãã# $
new
ãã$ '
Dominio
ãã( /
.
ãã/ 0
CuentaJugador
ãã0 =
{
åå 
NombreJugador
çç !
=
çç" #
jugador
çç$ +
.
çç+ ,
NombreJugador
çç, 9
,
çç9 : 
FuenteImagenAvatar
éé &
=
éé' (

Utilidades
éé) 3
.
éé3 4
GeneradorImagenes
éé4 E
.
ééE F'
GenerarFuenteImagenAvatar
èè 1
(
èè1 2
jugador
èè2 9
.
èè9 :
NumeroAvatar
èè: F
)
èèF G
}
êê 
)
êê 
;
êê 
}
ëë 
}
íí 	
private
îî 
void
îî 
CrearNuevaSala
îî #
(
îî# $
)
îî$ %
{
ïï 	

codigoSala
ññ 
=
ññ 
	Servicios
ññ "
.
ññ" #
ServicioSala
ññ# /
.
ññ/ 0(
GenerarCodigoParaNuevaSala
ññ0 J
(
ññJ K
)
ññK L
;
ññL M
if
òò 
(
òò 

codigoSala
òò 
!=
òò 
null
òò "
)
òò" #
{
ôô 
	Servicios
öö 
.
öö 
ServicioSala
öö &
.
öö& '
CrearNuevaSala
öö' 5
(
öö5 6
Dominio
öö6 =
.
öö= >
CuentaJugador
öö> K
.
ööK L
Actual
õõ 
.
õõ 
NombreJugador
õõ (
,
õõ( )

codigoSala
õõ* 4
)
õõ4 5
;
õõ5 6
}
úú 
}
ùù 	
private
üü 
void
üü &
FinalizarConexionConSala
üü -
(
üü- .
)
üü. /
{
†† 	
try
°° 
{
¢¢ "
clienteServicioJuego
££ $
.
££$ %,
DesconectarCuentaJugadorDeSala
££% C
(
££C D
Dominio
££D K
.
££K L
CuentaJugador
§§ !
.
§§! "
Actual
§§" (
.
§§( )
NombreJugador
§§) 6
,
§§6 7

codigoSala
§§8 B
,
§§B C

Properties
•• 
.
•• 
	Resources
•• (
.
••( ),
ETIQUETA_MENSAJESALA_DESPEDIDA
••) G
)
••G H
;
••H I"
clienteServicioJuego
¶¶ $
.
¶¶$ %
Close
¶¶% *
(
¶¶* +
)
¶¶+ ,
;
¶¶, -
}
ßß 
catch
®® 
(
®® '
EndpointNotFoundException
®® ,
	excepcion
®®- 6
)
®®6 7
{
©© 

MessageBox
´´ 
.
´´ 
Show
´´ 
(
´´  

Properties
´´  *
.
´´* +
	Resources
´´+ 4
.
´´4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
¨¨ :
,
¨¨: ;

Properties
¨¨< F
.
¨¨F G
	Resources
¨¨G P
.
¨¨P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
≠≠ 9
,
≠≠9 :
MessageBoxButton
ÆÆ $
.
ÆÆ$ %
OK
ÆÆ% '
,
ÆÆ' (
MessageBoxImage
ÆÆ) 8
.
ÆÆ8 9
Error
ÆÆ9 >
)
ÆÆ> ?
;
ÆÆ? @"
clienteServicioJuego
ØØ $
.
ØØ$ %
Abort
ØØ% *
(
ØØ* +
)
ØØ+ ,
;
ØØ, -
}
∞∞ 
catch
±± 
(
±± 1
#CommunicationObjectFaultedException
±± 6
	excepcion
±±7 @
)
±±@ A
{
≤≤ 

MessageBox
¥¥ 
.
¥¥ 
Show
¥¥ 
(
¥¥  

Properties
¥¥  *
.
¥¥* +
	Resources
¥¥+ 4
.
¥¥4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
µµ :
,
µµ: ;

Properties
µµ< F
.
µµF G
	Resources
µµG P
.
µµP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
∂∂ 9
,
∂∂9 :
MessageBoxButton
∑∑ $
.
∑∑$ %
OK
∑∑% '
,
∑∑' (
MessageBoxImage
∑∑) 8
.
∑∑8 9
Error
∑∑9 >
)
∑∑> ?
;
∑∑? @"
clienteServicioJuego
∏∏ $
.
∏∏$ %
Abort
∏∏% *
(
∏∏* +
)
∏∏+ ,
;
∏∏, -
}
ππ 
catch
∫∫ 
(
∫∫ 
TimeoutException
∫∫ #
	excepcion
∫∫$ -
)
∫∫- .
{
ªª 

MessageBox
ΩΩ 
.
ΩΩ 
Show
ΩΩ 
(
ΩΩ  

Properties
ΩΩ  *
.
ΩΩ* +
	Resources
ΩΩ+ 4
.
ΩΩ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ææ :
,
ææ: ;

Properties
ææ< F
.
ææF G
	Resources
ææG P
.
ææP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
øø 9
,
øø9 :
MessageBoxButton
¿¿ $
.
¿¿$ %
OK
¿¿% '
,
¿¿' (
MessageBoxImage
¿¿) 8
.
¿¿8 9
Error
¿¿9 >
)
¿¿> ?
;
¿¿? @"
clienteServicioJuego
¡¡ $
.
¡¡$ %
Abort
¡¡% *
(
¡¡* +
)
¡¡+ ,
;
¡¡, -
}
¬¬ "
clienteServicioJuego
ƒƒ  
=
ƒƒ! "
null
ƒƒ# '
;
ƒƒ' (
}
≈≈ 	
private
«« 
void
«« &
ModificarJugadoresEnSala
«« -
(
««- .
object
««. 4
objetoOrigen
««5 A
,
««A B"
MouseButtonEventArgs
»»  
evento
»»! '
)
»»' (
{
…… 	
}
ÀÀ 	
public
ŒŒ 
void
ŒŒ "
MostrarMensajeDeSala
ŒŒ (
(
ŒŒ( )
string
ŒŒ) /
mensaje
ŒŒ0 7
)
ŒŒ7 8
{
œœ 	!
cuadroTextoMensajes
–– 
.
––  

AppendText
––  *
(
––* +
mensaje
––+ 2
+
––3 4
$str
––5 9
)
––9 :
;
––: ;
}
—— 	
public
”” 
void
”” 2
$NotificarNuevoJugadorConectadoEnSala
”” 8
(
””8 9
CuentaJugador
””9 F
nuevoJugador
””G S
)
””S T
{
‘‘ 	
if
’’ 
(
’’ 
jugadoresEnSala
’’ 
!=
’’  "
null
’’# '
)
’’' (
{
÷÷ 
Dominio
◊◊ 
.
◊◊ 
CuentaJugador
◊◊ % 
nuevaCuentaJugador
◊◊& 8
=
◊◊9 :
new
◊◊; >
Dominio
◊◊? F
.
◊◊F G
CuentaJugador
◊◊G T
{
ÿÿ  
FuenteImagenAvatar
ŸŸ &
=
ŸŸ' (

Utilidades
ŸŸ) 3
.
ŸŸ3 4
GeneradorImagenes
ŸŸ4 E
.
ŸŸE F'
GenerarFuenteImagenAvatar
⁄⁄ 1
(
⁄⁄1 2
nuevoJugador
⁄⁄2 >
.
⁄⁄> ?
NumeroAvatar
⁄⁄? K
)
⁄⁄K L
,
⁄⁄L M
NombreJugador
€€ !
=
€€" #
nuevoJugador
€€$ 0
.
€€0 1
NombreJugador
€€1 >
}
‹‹ 
;
‹‹ 
jugadoresEnSala
›› 
.
››  
Add
››  #
(
››# $ 
nuevaCuentaJugador
››$ 6
)
››6 7
;
››7 8
}
ﬁﬁ 
}
ﬂﬂ 	
public
·· 
void
·· 0
"NotificarJugadorDesconectadoDeSala
·· 6
(
··6 7
string
··7 =
nombreJugador
··> K
)
··K L
{
‚‚ 	
if
„„ 
(
„„ 
jugadoresEnSala
„„ 
!=
„„  "
null
„„# '
)
„„' (
{
‰‰ 
Dominio
ÂÂ 
.
ÂÂ 
CuentaJugador
ÂÂ %%
cuentaJugadorEncontrada
ÂÂ& =
=
ÂÂ> ?
jugadoresEnSala
ÊÊ #
.
ÊÊ# $
Where
ÊÊ$ )
(
ÊÊ) *
jugador
ÊÊ* 1
=>
ÊÊ2 4
jugador
ÊÊ5 <
.
ÊÊ< =
NombreJugador
ÊÊ= J
==
ÊÊK M
nombreJugador
ÁÁ !
)
ÁÁ! "
.
ÁÁ" #
FirstOrDefault
ÁÁ# 1
(
ÁÁ1 2
)
ÁÁ2 3
;
ÁÁ3 4
if
ÈÈ 
(
ÈÈ %
cuentaJugadorEncontrada
ÈÈ +
!=
ÈÈ, .
null
ÈÈ/ 3
)
ÈÈ3 4
{
ÍÍ 
jugadoresEnSala
ÎÎ #
.
ÎÎ# $
Remove
ÎÎ$ *
(
ÎÎ* +%
cuentaJugadorEncontrada
ÎÎ+ B
)
ÎÎB C
;
ÎÎC D
}
ÏÏ 
}
ÌÌ 
}
ÓÓ 	
}
 
}ÒÒ î+
ÅC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaSeleccionAvatar.xaml.cs
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
}CC ﬁ=
ÜC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaCreacionNuevaPartida.xaml.cs
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
}nn ‚
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
}!! ≠V
ÑC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaVerificacionCorreo.xaml.cs
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
ÄÄ 
void
ÄÄ '
HabilitarBotonEnvioCodigo
ÄÄ .
(
ÄÄ. /
)
ÄÄ/ 0
{
ÅÅ 	
BotonEnviarCodigo
ÇÇ 
.
ÇÇ 
	IsEnabled
ÇÇ '
=
ÇÇ( )
true
ÇÇ* .
;
ÇÇ. /
BotonEnviarCodigo
ÉÉ 
.
ÉÉ 

Foreground
ÉÉ (
=
ÉÉ) *
Brushes
ÉÉ+ 2
.
ÉÉ2 3
White
ÉÉ3 8
;
ÉÉ8 9
}
ÑÑ 	
private
ÜÜ 
void
ÜÜ *
DeshabilitarBotonEnvioCodigo
ÜÜ 1
(
ÜÜ1 2
)
ÜÜ2 3
{
áá 	
BotonEnviarCodigo
àà 
.
àà 
	IsEnabled
àà '
=
àà( )
false
àà* /
;
àà/ 0
BotonEnviarCodigo
ââ 
.
ââ 

Foreground
ââ (
=
ââ) *
Brushes
ââ+ 2
.
ââ2 3
Black
ââ3 8
;
ââ8 9
}
ää 	
}
ãã 
}åå ˆ
ÉC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Utilidades\GeneradorImagenes.cs
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
}   ¢
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
} ˛
âC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Utilidades\GestionadorCodigoCorreo.cs
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
}$$ ¿
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
}00 º
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