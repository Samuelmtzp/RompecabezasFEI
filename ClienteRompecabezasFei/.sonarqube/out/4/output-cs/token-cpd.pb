°
vC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaAjustesPartida.xaml.cs
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
} ßê
xC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioAmistades.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

static 
class 
ServicioAmistades )
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
}‚‚ Ä6
uC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioCorreo.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

static 
class 
ServicioCorreo &
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
}]] ‡Æ
vC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioJugador.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

static 
class 
ServicioJugador '
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
}îî Ác
sC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioSala.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

static 
class 
ServicioSala $
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
}ßß ¬6
vC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Servicios\ServicioPartida.cs
	namespace 	
RompecabezasFei
 
. 
	Servicios #
{ 
public 

static 
class 
ServicioPartida '
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
}^^ ∞
eC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\App.xaml.cs
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
;# $
SoundPlayer 
reproductorMusica %
;% &
public 
string 
IdiomaActual "
{ 	
get 
{ 
return 
idiomaActual %
;% &
}' (
private 
set 
{ 
Thread 
. 
CurrentThread $
.$ %
CurrentUICulture% 5
=6 7
new8 ;
System< B
.B C
Globalization !
.! "
CultureInfo" -
(- .
value. 3
)3 4
;4 5
idiomaActual 
= 
value $
;$ %
} 
} 	
public 
bool 
MusicaActiva  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
static 
new 
App 
Current %
{ 	
get 
{ 
return 
( 
App 
) 
Application '
.' (
Current( /
;/ 0
}   
}!! 	
App## 
(## 
)## 
{$$ 	
const%% 
int%% 
NumeroIdiomaInicial%% )
=%%* +
$num%%, -
;%%- .
idiomasDisponibles&& 
=&&  
new&&! $
List&&% )
<&&) *
string&&* 0
>&&0 1
(&&1 2
)&&2 3
{'' 
$str(( 
,(( 
$str)) 
}** 
;** 
IdiomaActual++ 
=++ 
idiomasDisponibles++ -
[++- .
NumeroIdiomaInicial++. A
]++A B
;++B C
},, 	
public.. 
void.. 
CambiarIdioma.. !
(..! "
string.." (
nuevoIdioma..) 4
)..4 5
{// 	
IdiomaActual00 
=00 
nuevoIdioma00 &
;00& '
}11 	
public33 
void33 
EstadoMusica33  
(33  !
bool33! %
musicaActivada33& 4
)334 5
{44 	
if55 
(55 
musicaActivada55 
)55 
{66 
reproductorMusica77 !
.77! "
PlayLooping77" -
(77- .
)77. /
;77/ 0
MusicaActiva88 
=88 
true88 #
;88# $
}99 
else:: 
{;; 
reproductorMusica<< !
.<<! "
Stop<<" &
(<<& '
)<<' (
;<<( )
MusicaActiva== 
=== 
false== $
;==$ %
}>> 
}?? 	
	protectedAA 
overrideAA 
voidAA 
	OnStartupAA  )
(AA) *
StartupEventArgsAA* :
eAA; <
)AA< =
{BB 	
reproductorMusicaCC 
=CC 
newCC  #
SoundPlayerCC$ /
(CC/ 0
RompecabezasFeiCC0 ?
.CC? @

PropertiesCC@ J
.CCJ K
ResourceSonidosDD 
.DD  !
MusicaRompecabezasFeiDD  5
)DD5 6
;DD6 7
EstadoMusicaEE 
(EE 
falseEE 
)EE 
;EE  
}FF 	
}GG 
}HH ÿD
C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaActualizacionContrasena.xaml.cs
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
)_ `
&&a c
! 
ValidadorDatos 
.  '
ExisteCoincidenciaEnCadenas  ;
(; <
contrasenaAnterior< N
,N O
nuevaContrasenaP _
)_ `
&&a c
! !
ExistenDatosInvalidos &
(& '
nuevaContrasena' 6
,6 7"
confirmacionContrasena8 N
)N O
)O P
{ 
string   
correoJugador   $
=  % &
Dominio  ' .
.  . /
CuentaJugador  / <
.  < =
Actual  = C
.  C D
Correo  D J
;  J K
string!! "
nuevaContrasenaCifrada!! -
=!!. /!
EncriptadorContrasena!!0 E
.!!E F
CalcularHashSha512"" &
(""& '
nuevaContrasena""' 6
)""6 7
;""7 8
bool## "
actualizacionRealizada## +
=##, -
	Servicios##. 7
.##7 8
ServicioJugador##8 G
.##G H 
ActualizarContrasena$$ (
($$( )
correoJugador$$) 6
,$$6 7"
nuevaContrasenaCifrada$$8 N
)$$N O
;$$O P
if&& 
(&& "
actualizacionRealizada&& *
)&&* +
{'' 

MessageBox(( 
.(( 
Show(( #
(((# $
$str(($ H
+((I J
$str)) 7
,))7 8
$str** ?
,**? @
MessageBoxButton++ (
.++( )
OK++) +
)+++ ,
;++, -
Dominio,, 
.,, 
CuentaJugador,, )
.,,) *
Actual,,* 0
.,,0 1

Contrasena,,1 ;
=,,< =
nuevaContrasena,,> M
;,,M N
VentanaPrincipal-- $
.--$ %
CambiarPagina--% 2
(--2 3
new--3 6$
PaginaInformacionJugador--7 O
(--O P
)--P Q
)--Q R
;--R S
}.. 
else// 
{00 

MessageBox11 
.11 
Show11 #
(11# $
$str11$ Z
,11Z [
$str22 9
,229 :
MessageBoxButton22; K
.22K L
OK22L N
)22N O
;22O P
}33 
}44 
}55 	
private77 
bool77 !
ExistenDatosInvalidos77 *
(77* +
string77+ 1
nuevaContrasena772 A
,77A B
string88 "
confirmacionContrasena88 )
)88) *
{99 	
bool:: 
hayDatosInvalidos:: "
=::# $
false::% *
;::* +
if<< 
(<< 
ValidadorDatos<< 
.<< 4
(ExistenCaracteresInvalidosParaContrasena<< G
(<<G H
nuevaContrasena<<H W
)<<W X
)<<X Y
{== 

MessageBox>> 
.>> 
Show>> 
(>>  

Properties>>  *
.>>* +
	Resources>>+ 4
.>>4 56
*ETIQUETA_VALIDACION_MENSAJECONTRASENANUEVA>>5 _
,>>_ `

Properties?? 
.?? 
	Resources?? (
.??( )2
&ETIQUETA_VALIDACION_CONTRASENAINVALIDA??) O
,??O P
MessageBoxButton@@ $
.@@$ %
OK@@% '
)@@' (
;@@( )
hayDatosInvalidosAA !
=AA" #
trueAA$ (
;AA( )
}BB 
ifDD 
(DD 
ValidadorDatosDD 
.DD .
"ExisteLongitudExcedidaEnContrasenaDD A
(DDA B"
cuadroContrasenaActualEE &
.EE& '
PasswordEE' /
)EE/ 0
)EE0 1
{FF 

MessageBoxGG 
.GG 
ShowGG 
(GG  

PropertiesGG  *
.GG* +
	ResourcesGG+ 4
.GG4 52
&ETIQUETA_VALIDACION_CONTRASENAEXCEDIDAGG5 [
,GG[ \

PropertiesHH 
.HH  
	ResourcesHH  )
.HH) *0
$ETIQUETA_VALIDACION_LONGITUDEXCEDIDAHH* N
,HHN O
MessageBoxButtonII %
.II% &
OKII& (
)II( )
;II) *
hayDatosInvalidosJJ !
=JJ" #
trueJJ$ (
;JJ( )
}KK 
ifMM 
(MM 
ExistenCamposVaciosMM #
(MM# $
)MM$ %
)MM% &
{NN 

MessageBoxOO 
.OO 
ShowOO 
(OO  

PropertiesOO  *
.OO* +
	ResourcesOO+ 4
.OO4 53
'ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOSOO5 \
,OO\ ]

PropertiesPP 
.PP 
	ResourcesPP '
.PP' (,
 ETIQUETA_VALIDACION_CAMPOSVACIOSPP( H
,PPH I
MessageBoxButtonQQ #
.QQ# $
OKQQ$ &
)QQ& '
;QQ' (
hayDatosInvalidosRR !
=RR" #
trueRR$ (
;RR( )
}SS 
ifUU 
(UU 
!UU 
ValidadorDatosUU 
.UU  '
ExisteCoincidenciaEnCadenasUU  ;
(UU; <
nuevaContrasenaUU< K
,UUK L"
confirmacionContrasenaVV &
)VV& '
)VV' (
{WW 

MessageBoxXX 
.XX 
ShowXX 
(XX  

PropertiesXX  *
.XX* +
	ResourcesXX+ 4
.XX4 5:
.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTEYY B
,YYB C

PropertiesYYD N
.YYN O
	ResourcesYYO X
.YYX Y3
'ETIQUETA_VALIDACION_CONTRASENADIFERENTEZZ ;
,ZZ; <
MessageBoxButtonZZ= M
.ZZM N
OKZZN P
)ZZP Q
;ZZQ R
}[[ 
return]] 
hayDatosInvalidos]] $
;]]$ %
}^^ 	
private`` 
bool`` 
ExistenCamposVacios`` (
(``( )
)``) *
{aa 	
boolbb 
	resultadobb 
=bb 
falsebb "
;bb" #
ifdd 
(dd 
ValidadorDatosdd 
.dd 
EsCadenaVaciadd ,
(dd, -"
cuadroContrasenaActualdd- C
.ddC D
PasswordddD L
)ddL M
||ddN P
ValidadorDatosee 
.ee 
EsCadenaVaciaee ,
(ee, -!
cuadroNuevaContrasenaee- B
.eeB C
PasswordeeC K
)eeK L
||eeM O
ValidadorDatosff 
.ff 
EsCadenaVaciaff ,
(ff, -(
cuadroConfirmacionContrasenaff- I
.ffI J
PasswordffJ R
)ffR S
)ffS T
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
}nn êb
ÄC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaActualizacionInformacion.xaml.cs
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
esAvatarDiferente//% 6
&&//7 9
!00 2
&ExistenDatosInvalidosParaActualizacion00 7
(007 8
)008 9
)009 :
{11 
if22 
(22 
!22 
	Servicios22 
.22 
ServicioJugador22 .
.22. /
ExisteNombreJugador22/ B
(22B C
nuevoNombre22C N
)22N O
)22O P
{33 
bool44 "
actualizacionRealizada44 /
=440 1
	Servicios442 ;
.44; <
ServicioJugador44< K
.44K L!
ActualizarInformacion55 -
(55- .
nombreAnterior55. <
,55< =
nuevoNombre55> I
,55I J
nuevoNumeroAvatar55K \
)55\ ]
;55] ^
if77 
(77 "
actualizacionRealizada77 .
)77. /
{88 

MessageBox99 "
.99" #
Show99# '
(99' (

Properties99( 2
.992 3
	Resources993 <
.99< =B
6ETIQUETA_ACTUALIZACIONINFORMACION_MENSAJEACTUALIZACION:: R
,::R S

Properties;; &
.;;& '
	Resources;;' 0
.;;0 1D
8ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONREALIZADA<< T
,<<T U
MessageBoxButton== ,
.==, -
OK==- /
)==/ 0
;==0 1
Dominio>> 
.>>  
CuentaJugador>>  -
.>>- .
Actual>>. 4
.>>4 5
NumeroAvatar>>5 A
=>>B C
nuevoNumeroAvatar>>D U
;>>U V
Dominio?? 
.??  
CuentaJugador??  -
.??- .
Actual??. 4
.??4 5
NombreJugador??5 B
=??C D
nuevoNombre??E P
;??P Q
Dominio@@ 
.@@  
CuentaJugador@@  -
.@@- .
Actual@@. 4
.@@4 5
FuenteImagenAvatar@@5 G
=@@H I

Utilidades@@J T
.@@T U
GeneradorImagenesAA -
.AA- .%
GenerarFuenteImagenAvatarAA. G
(AAG H
nuevoNumeroAvatarAAH Y
)AAY Z
;AAZ [
VentanaPrincipalBB (
.BB( )
CambiarPaginaBB) 6
(BB6 7
newBB7 :$
PaginaInformacionJugadorBB; S
(BBS T
)BBT U
)BBU V
;BBV W
}CC 
elseDD 
{EE 

MessageBoxFF "
.FF" #
ShowFF# '
(FF' (

PropertiesFF( 2
.FF2 3
	ResourcesFF3 <
.FF< =F
:ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONNOREALIZADAGG V
,GGV W

PropertiesHH &
.HH& '
	ResourcesHH' 0
.HH0 1@
4ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACIONII P
,IIP Q
MessageBoxButtonJJ ,
.JJ, -
OKJJ- /
)JJ/ 0
;JJ0 1
}KK 
}LL 
elseMM 
{NN 

MessageBoxOO 
.OO 
ShowOO #
(OO# $

PropertiesPP "
.PP" #
	ResourcesPP# ,
.PP, -@
4ETIQUETA_ACTUALIZACIONINFORMACION_NOMBRENODISPONIBLEQQ L
,QQL M

PropertiesRR "
.RR" #
	ResourcesRR# ,
.RR, -@
4ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACIONSS L
,SSL M
MessageBoxButtonTT (
.TT( )
OKTT) +
)TT+ ,
;TT, -
}UU 
}VV 
}WW 	
privateYY 
voidYY )
NavegarAPaginaSeleccionAvatarYY 2
(YY2 3
objectYY3 9
objetoOrigenYY: F
,YYF G
RoutedEventArgsYYH W
eventoYYX ^
)YY^ _
{ZZ 	!
PaginaSeleccionAvatar[[ !!
paginaSeleccionAvatar[[" 7
=[[8 9
new[[: =!
PaginaSeleccionAvatar[[> S
([[S T
Convert\\ 
.\\ 
ToInt32\\ 
(\\  
imagenAvatarActual\\  2
.\\2 3
Tag\\3 6
)\\6 7
,\\7 8$
cuadroTextoNombreUsuario\\9 Q
.\\Q R
Text\\R V
)\\V W
;\\W X
VentanaPrincipal]] 
.]] *
CambiarPaginaGuardandoAnterior]] ;
(]]; <!
paginaSeleccionAvatar]]< Q
)]]Q R
;]]R S
}^^ 	
private`` 
bool`` /
#ExistenModificacionesEnNumeroAvatar`` 8
(``8 9
int``9 <
nuevoNumeroAvatar``= N
)``N O
{aa 	
boolbb 
	resultadobb 
=bb 
truebb !
;bb! "
ifdd 
(dd 
Dominiodd 
.dd 
CuentaJugadordd %
.dd% &
Actualdd& ,
.dd, -
NumeroAvatardd- 9
.dd9 :
Equalsdd: @
(dd@ A
nuevoNumeroAvatarddA R
)ddR S
)ddS T
{ee 
	resultadoff 
=ff 
falseff !
;ff! "
}gg 
returnii 
	resultadoii 
;ii 
}jj 	
privatell 
boolll 0
$ExistenModificacionesEnNombreJugadorll 9
(ll9 :
stringll: @
nuevoNombreJugadorllA S
)llS T
{mm 	
nombreModificadonn 
=nn 
truenn #
;nn# $
ifpp 
(pp 
Dominiopp 
.pp 
CuentaJugadorpp %
.pp% &
Actualpp& ,
.pp, -
NombreJugadorpp- :
.pp: ;
Equalspp; A
(ppA B
nuevoNombreJugadorppB T
)ppT U
)ppU V
{qq 
nombreModificadorr  
=rr! "
falserr# (
;rr( )
}ss 
returnuu 
nombreModificadouu #
;uu# $
}vv 	
privatexx 
boolxx 2
&ExistenDatosInvalidosParaActualizacionxx ;
(xx; <
)xx< =
{yy 	
boolzz 
datosInvalidoszz 
=zz  !
falsezz" '
;zz' (
if|| 
(|| 
ValidadorDatos|| 
.|| 
EsCadenaVacia|| ,
(||, -$
cuadroTextoNombreUsuario||- E
.||E F
Text||F J
)||J K
)||K L
{}} 
datosInvalidos~~ 
=~~  
true~~! %
;~~% &

MessageBox 
. 
Show 
(  

Properties  *
.* +
	Resources+ 4
.4 53
'ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS5 \
,\ ]

Properties
ÄÄ 
.
ÄÄ 
	Resources
ÄÄ (
.
ÄÄ( ).
 ETIQUETA_VALIDACION_CAMPOSVACIOS
ÄÄ) I
,
ÄÄI J
MessageBoxButton
ÅÅ $
.
ÅÅ$ %
OK
ÅÅ% '
)
ÅÅ' (
;
ÅÅ( )
}
ÇÇ 
if
ÑÑ 
(
ÑÑ 
ValidadorDatos
ÑÑ 
.
ÑÑ 3
%ExisteLongitudExcedidaEnNombreJugador
ÑÑ D
(
ÑÑD E&
cuadroTextoNombreUsuario
ÖÖ (
.
ÖÖ( )
Text
ÖÖ) -
)
ÖÖ- .
)
ÖÖ. /
{
ÜÜ 
datosInvalidos
áá 
=
áá  
true
áá! %
;
áá% &

MessageBox
àà 
.
àà 
Show
àà 
(
àà  

Properties
àà  *
.
àà* +
	Resources
àà+ 4
.
àà4 58
*ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS
àà5 _
,
àà_ `

Properties
ââ 
.
ââ 
	Resources
ââ (
.
ââ( )1
#ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS
ââ) L
,
ââL M
MessageBoxButton
ää $
.
ää$ %
OK
ää% '
)
ää' (
;
ää( )
}
ãã 
if
çç 
(
çç 
ValidadorDatos
çç 
.
çç 9
+ExistenCaracteresInvalidosParaNombreJugador
çç J
(
ççJ K&
cuadroTextoNombreUsuario
éé (
.
éé( )
Text
éé) -
)
éé- .
)
éé. /
{
èè 
datosInvalidos
êê 
=
êê  
true
êê! %
;
êê% &

MessageBox
ëë 
.
ëë 
Show
ëë 
(
ëë  

Properties
íí 
.
íí 
	Resources
íí (
.
íí( )>
0ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO
íí) Y
,
ííY Z

Properties
ìì 
.
ìì 
	Resources
ìì (
.
ìì( )7
)ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO
ìì) R
,
ììR S
MessageBoxButton
îî $
.
îî$ %
OK
îî% '
)
îî' (
;
îî( )
}
ïï 
return
óó 
datosInvalidos
óó !
;
óó! "
}
òò 	
}
ôô 
}öö ®1
oC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaAjustes.xaml.cs
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
 
PaginaAjustes

 &
:

' (
Page

) -
{ 
private 
string 
idioma 
; 
private 
bool )
hayMusicaActivadaInicialmente 2
;2 3
private 
const 
string 
IdiomaIngles )
=* +
$str, 3
;3 4
private 
const 
string 
IdiomaEspanol *
=+ ,
$str- 4
;4 5
public 
PaginaAjustes 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void &
InicializarSeleccionIdioma /
(/ 0
)0 1
{ 	
if 
( 
App 
. 
Current 
. 
IdiomaActual (
==) +
IdiomaIngles, 8
)8 9
{ 
cajaOpcionesIdioma "
." #
SelectedIndex# 0
=1 2
(3 4
int4 7
)7 8
Idioma8 >
.> ?
Ingles? E
;E F
} 
else 
{ 
cajaOpcionesIdioma "
." #
SelectedIndex# 0
=1 2
(3 4
int4 7
)7 8
Idioma8 >
.> ?
Espanol? F
;F G
} 
}   	
private"" 
void"" &
InicializarSeleccionMusica"" /
(""/ 0
)""0 1
{## 	
if$$ 
($$ 
App$$ 
.$$ 
Current$$ 
.$$ 
MusicaActiva$$ (
)$$( )
{%% )
hayMusicaActivadaInicialmente&& -
=&&. /
true&&0 4
;&&4 5
botonCambioMusica'' !
.''! "
	IsChecked''" +
='', -
true''. 2
;''2 3
}(( 
else)) 
{** )
hayMusicaActivadaInicialmente++ -
=++. /
false++0 5
;++5 6
botonCambioMusica,, !
.,,! "
	IsChecked,," +
=,,, -
false,,. 3
;,,3 4
}-- 
}.. 	
private00 
void00 !
RefrescarPaginaActual00 *
(00* +
)00+ ,
{11 	
VentanaPrincipal22 
.22 
CambiarPagina22 *
(22* +
new22+ .
PaginaAjustes22/ <
(22< =
)22= >
)22> ?
;22? @
}33 	
private55 
void55 (
InicializarOpcionesDeAjustes55 1
(551 2
object552 8
objetoOrigen559 E
,55E F
RoutedEventArgs55G V
evento55W ]
)55] ^
{66 	&
InicializarSeleccionIdioma77 &
(77& '
)77' (
;77( )&
InicializarSeleccionMusica88 &
(88& '
)88' (
;88( )
}99 	
private;; 
void;; 
SeleccionarIdioma;; &
(;;& '
object;;' -
controlOrigen;;. ;
,;;; <%
SelectionChangedEventArgs;;= V
evento;;W ]
);;] ^
{<< 	
if== 
(== 
cajaOpcionesIdioma== "
.==" #
SelectedIndex==# 0
====1 3
(==4 5
int==5 8
)==8 9
Idioma==9 ?
.==? @
Ingles==@ F
)==F G
{>> 
idioma?? 
=?? 
IdiomaIngles?? %
;??% &
}@@ 
elseAA 
{BB 
idiomaCC 
=CC 
IdiomaEspanolCC &
;CC& '
}DD 
}EE 	
privateGG 
voidGG 
IrAPaginaAnteriorGG &
(GG& '
objectGG' -
objetoOrigenGG. :
,GG: ; 
MouseButtonEventArgsGG< P
eventoGGQ W
)GGW X
{HH 	
ifII 
(II 
VentanaPrincipalII  
.II  !
PaginaAnteriorII! /
isII0 2
PaginaInicioSesionII3 E
)IIE F
{JJ 
VentanaPrincipalKK  
.KK  !
CambiarPaginaKK! .
(KK. /
newKK/ 2
PaginaInicioSesionKK3 E
(KKE F
)KKF G
)KKG H
;KKH I
}LL 
elseMM 
{NN 
VentanaPrincipalOO  
.OO  !
CambiarPaginaOO! .
(OO. /
newOO/ 2
PaginaMenuPrincipalOO3 F
(OOF G
)OOG H
)OOH I
;OOI J
}PP 
}QQ 	
privateSS 
voidSS )
CajaDeOpcionesDeIdiomaCerradaSS 2
(SS2 3
objectSS3 9
objetoOrigenSS: F
,SSF G
	EventArgsSSH Q
eventoSSR X
)SSX Y
{TT 	
AppUU 
.UU 
CurrentUU 
.UU 
CambiarIdiomaUU %
(UU% &
idiomaUU& ,
)UU, -
;UU- .!
RefrescarPaginaActualVV !
(VV! "
)VV" #
;VV# $
}WW 	
privateYY 
voidYY 
ActivarMusicaYY "
(YY" #
objectYY# )
objetoOrigenYY* 6
,YY6 7
RoutedEventArgsYY8 G
eventoYYH N
)YYN O
{ZZ 	
if[[ 
([[ 
![[ )
hayMusicaActivadaInicialmente[[ .
)[[. /
{\\ 
App]] 
.]] 
Current]] 
.]] 
EstadoMusica]] (
(]]( )
true]]) -
)]]- .
;]]. /
}^^ 
}__ 	
privateaa 
voidaa 
DesactivarMusicaaa %
(aa% &
objectaa& ,
objetoOrigenaa- 9
,aa9 :
RoutedEventArgsaa; J
eventoaaK Q
)aaQ R
{bb 	
Appcc 
.cc 
Currentcc 
.cc 
EstadoMusicacc $
(cc$ %
falsecc% *
)cc* +
;cc+ ,
}dd 	
}ee 
}ff §Ë
qC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaAmistades.xaml.cs
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
private #
ServicioAmistadesClient '$
clienteServicioAmistades( @
;@ A
public  
ObservableCollection #
<# $
Dominio$ +
.+ ,
CuentaJugador, 9
>9 :
CuentasDeAmigos; J
{K L
getM P
;P Q
setR U
;U V
}W X
public  
ObservableCollection #
<# $
Dominio$ +
.+ ,
CuentaJugador, 9
>9 : 
CuentasDeSolicitudes; O
{P Q
getR U
;U V
setW Z
;Z [
}\ ]
public 
PaginaAmistades 
( 
bool #
inicializarDatos$ 4
)4 5
{ 	
if 
( 
inicializarDatos  
)  !
{ 
InitializeComponent #
(# $
)$ %
;% &
listaAmigos 
. 
DataContext '
=( )
this* .
;. /
listaSolicitudes  
.  !
DataContext! ,
=- .
this/ 3
;3 4$
clienteServicioAmistades (
=) *
new+ .#
ServicioAmistadesClient/ F
(F G
newG J
InstanceContextK Z
(Z [
this[ _
)_ `
)` a
;a b
CargarAmigosJugador #
(# $
)$ %
;% &0
$CargarJugadoresConSolicitudPendiente 4
(4 5
)5 6
;6 7+
SuscribirJugadorANotificaciones /
(/ 0
)0 1
;1 2
}   
}!! 	
private## 
void## 
CargarAmigosJugador## (
(##( )
)##) *
{$$ 	
CuentasDeAmigos%% 
=%% 
new%% ! 
ObservableCollection%%" 6
<%%6 7
Dominio%%7 >
.%%> ?
CuentaJugador%%? L
>%%L M
(%%M N
)%%N O
;%%O P
CuentaJugador&& 
[&& 
]&& 
amigosObtenidos&& +
=&&, -
	Servicios&&. 7
.&&7 8
ServicioAmistades&&8 I
.&&I J"
ObtenerAmigosDeJugador'' &
(''& '
Dominio''' .
.''. /
CuentaJugador''/ <
.''< =
Actual''= C
.''C D
NombreJugador''D Q
)''Q R
;''R S
if)) 
()) 
amigosObtenidos)) 
!=))  "
null))# '
&&))( *
amigosObtenidos))+ :
.)): ;
Any)); >
())> ?
)))? @
)))@ A
{** 
foreach++ 
(++ 
CuentaJugador++ &
amigo++' ,
in++- /
amigosObtenidos++0 ?
)++? @
{,, 
Dominio-- 
.-- 
CuentaJugador-- )
cuentaAmigo--* 5
=--6 7
new--8 ;
Dominio--< C
.--C D
CuentaJugador--D Q
{.. 
NombreJugador// %
=//& '
amigo//( -
.//- .
NombreJugador//. ;
,//; <
NumeroAvatar00 $
=00% &
amigo00' ,
.00, -
NumeroAvatar00- 9
,009 :
FuenteImagenAvatar11 *
=11+ ,

Utilidades11- 7
.117 8
GeneradorImagenes118 I
.11I J%
GenerarFuenteImagenAvatar22 5
(225 6
amigo226 ;
.22; <
NumeroAvatar22< H
)22H I
,22I J#
ColorEstadoConectividad33 /
=330 1/
#ObtenerColorSegunEstadoConectividad332 U
(33U V
amigo44 !
.44! "
EstadoConectividad44" 4
)444 5
,445 6
}55 
;55 
CuentasDeAmigos66 #
.66# $
Add66$ '
(66' (
cuentaAmigo66( 3
)663 4
;664 5
}77 
}88 
}99 	
private;; 
void;; 0
$CargarJugadoresConSolicitudPendiente;; 9
(;;9 :
);;: ;
{<< 	 
CuentasDeSolicitudes==  
===! "
new==# & 
ObservableCollection==' ;
<==; <
Dominio==< C
.==C D
CuentaJugador==D Q
>==Q R
(==R S
)==S T
;==T U
CuentaJugador>> 
[>> 
]>> 
jugadoresObtenidos>> .
=>>/ 0
	Servicios>>1 :
.>>: ;
ServicioAmistades>>; L
.>>L M1
%ObtenerJugadoresConSolicitudPendiente?? 5
(??5 6
Dominio??6 =
.??= >
CuentaJugador??> K
.??K L
Actual??L R
.??R S
NombreJugador??S `
)??` a
;??a b
ifAA 
(AA 
jugadoresObtenidosAA "
!=AA# %
nullAA& *
&&AA+ -
jugadoresObtenidosAA. @
.AA@ A
AnyAAA D
(AAD E
)AAE F
)AAF G
{BB 
foreachCC 
(CC 
CuentaJugadorCC &
jugadorCC' .
inCC/ 1
jugadoresObtenidosCC2 D
)CCD E
{DD 
DominioEE 
.EE 
CuentaJugadorEE )
cuentaSolicitudEE* 9
=EE: ;
newEE< ?
DominioEE@ G
.EEG H
CuentaJugadorEEH U
{FF 
NombreJugadorGG %
=GG& '
jugadorGG( /
.GG/ 0
NombreJugadorGG0 =
,GG= >
NumeroAvatarHH $
=HH% &
jugadorHH' .
.HH. /
NumeroAvatarHH/ ;
,HH; <
FuenteImagenAvatarII *
=II+ ,

UtilidadesII- 7
.II7 8
GeneradorImagenesII8 I
.III J%
GenerarFuenteImagenAvatarJJ 5
(JJ5 6
jugadorJJ6 =
.JJ= >
NumeroAvatarJJ> J
)JJJ K
,JJK L#
ColorEstadoConectividadKK /
=KK0 1/
#ObtenerColorSegunEstadoConectividadKK2 U
(KKU V
jugadorLL #
.LL# $
EstadoConectividadLL$ 6
)LL6 7
,LL7 8
}MM 
;MM  
CuentasDeSolicitudesNN (
.NN( )
AddNN) ,
(NN, -
cuentaSolicitudNN- <
)NN< =
;NN= >
}OO 
}PP 
}QQ 	
privateSS 
voidSS +
SuscribirJugadorANotificacionesSS 4
(SS4 5
)SS5 6
{TT 	
tryUU 
{VV $
clienteServicioAmistadesWW (
.WW( )4
(SuscribirJugadorANotificacionesAmistadesWW) Q
(WWQ R
DominioXX 
.XX 
CuentaJugadorXX (
.XX( )
ActualXX) /
.XX/ 0
NombreJugadorXX0 =
)XX= >
;XX> ?
}YY 
catchZZ 
(ZZ %
EndpointNotFoundExceptionZZ ,
	excepcionZZ- 6
)ZZ6 7
{[[ 

MessageBox]] 
.]] 
Show]] 
(]]  

Properties]]  *
.]]* +
	Resources]]+ 4
.]]4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE^^ :
,^^: ;

Properties^^< F
.^^F G
	Resources^^G P
.^^P Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO__ 9
,__9 :
MessageBoxButton`` $
.``$ %
OK``% '
,``' (
MessageBoxImage``) 8
.``8 9
Error``9 >
)``> ?
;``? @$
clienteServicioAmistadesaa (
.aa( )
Abortaa) .
(aa. /
)aa/ 0
;aa0 1
}bb 
catchcc 
(cc /
#CommunicationObjectFaultedExceptioncc 6
	excepcioncc7 @
)cc@ A
{dd 

MessageBoxff 
.ff 
Showff 
(ff  

Propertiesff  *
.ff* +
	Resourcesff+ 4
.ff4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEgg :
,gg: ;

Propertiesgg< F
.ggF G
	ResourcesggG P
.ggP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOhh 9
,hh9 :
MessageBoxButtonii $
.ii$ %
OKii% '
,ii' (
MessageBoxImageii) 8
.ii8 9
Errorii9 >
)ii> ?
;ii? @$
clienteServicioAmistadesjj (
.jj( )
Abortjj) .
(jj. /
)jj/ 0
;jj0 1
}kk 
catchll 
(ll 
TimeoutExceptionll #
	excepcionll$ -
)ll- .
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
;rr? @$
clienteServicioAmistadesss (
.ss( )
Abortss) .
(ss. /
)ss/ 0
;ss0 1
}tt 
}uu 	
privateww 
SolidColorBrushww /
#ObtenerColorSegunEstadoConectividadww  C
(wwC D%
EstadoConectividadJugadorxx %
estadoxx& ,
)xx, -
{yy 	
SolidColorBrushzz 
colorzz !
;zz! "
switch|| 
(|| 
estado|| 
)|| 
{}} 
case~~ %
EstadoConectividadJugador~~ .
.~~. /
	Conectado~~/ 8
:~~8 9
color 
= 
Brushes #
.# $
Green$ )
;) *
break
ÄÄ 
;
ÄÄ 
case
ÅÅ '
EstadoConectividadJugador
ÅÅ .
.
ÅÅ. /
	EnPartida
ÅÅ/ 8
:
ÅÅ8 9
color
ÇÇ 
=
ÇÇ 
Brushes
ÇÇ #
.
ÇÇ# $
Red
ÇÇ$ '
;
ÇÇ' (
break
ÉÉ 
;
ÉÉ 
default
ÑÑ 
:
ÑÑ 
color
ÖÖ 
=
ÖÖ 
Brushes
ÖÖ #
.
ÖÖ# $
Gray
ÖÖ$ (
;
ÖÖ( )
break
ÜÜ 
;
ÜÜ 
}
áá 
return
ââ 
color
ââ 
;
ââ 
}
ää 	
private
åå 
bool
åå (
EsElNombreDelJugadorActual
åå /
(
åå/ 0
)
åå0 1
{
çç 	
bool
éé 
	resultado
éé 
=
éé 
false
éé "
;
éé" #
string
èè "
nombreJugadorDestino
èè '
=
èè( )0
"cuadroTextoNombreUsuarioInvitacion
èè* L
.
èèL M
Text
èèM Q
;
èèQ R
if
ëë 
(
ëë 
Dominio
ëë 
.
ëë 
CuentaJugador
ëë %
.
ëë% &
Actual
ëë& ,
.
ëë, -
NombreJugador
ëë- :
.
ëë: ;
Equals
ëë; A
(
ëëA B"
nombreJugadorDestino
ëëB V
)
ëëV W
)
ëëW X
{
íí 
	resultado
ìì 
=
ìì 
true
ìì  
;
ìì  !

MessageBox
îî 
.
îî 
Show
îî 
(
îî  
$str
îî  O
+
îîP Q
$str
ïï I
,
ïïI J
$str
ññ :
,
ññ: ;
MessageBoxButton
óó $
.
óó$ %
OK
óó% '
,
óó' (
MessageBoxImage
óó) 8
.
óó8 9
Error
óó9 >
)
óó> ?
;
óó? @
}
òò 
return
öö 
	resultado
öö 
;
öö 
}
õõ 	
private
ùù 
bool
ùù &
ExisteSolicitudDeAmistad
ùù -
(
ùù- .
)
ùù. /
{
ûû 	
string
üü !
nombreJugadorOrigen
üü &
=
üü' (
Dominio
üü) 0
.
üü0 1
CuentaJugador
üü1 >
.
üü> ?
Actual
üü? E
.
üüE F
NombreJugador
üüF S
;
üüS T
string
†† "
nombreJugadorDestino
†† '
=
††( )0
"cuadroTextoNombreUsuarioInvitacion
††* L
.
††L M
Text
††M Q
;
††Q R
bool
°° '
existeSolicitudSinAceptar
°° *
=
°°+ ,
	Servicios
°°- 6
.
°°6 7
ServicioAmistades
°°7 H
.
°°H I$
ExisteSolicitudAmistad
¢¢ &
(
¢¢& '!
nombreJugadorOrigen
¢¢' :
,
¢¢: ;"
nombreJugadorDestino
¢¢< P
)
¢¢P Q
;
¢¢Q R
if
§§ 
(
§§ '
existeSolicitudSinAceptar
§§ )
)
§§) *
{
•• 

MessageBox
¶¶ 
.
¶¶ 
Show
¶¶ 
(
¶¶  
$str
¶¶  S
+
¶¶T U
$str
ßß Y
,
ßßY Z
$str
®® :
,
®®: ;
MessageBoxButton
©© $
.
©©$ %
OK
©©% '
,
©©' (
MessageBoxImage
©©) 8
.
©©8 9
Error
©©9 >
)
©©> ?
;
©©? @
}
™™ 
return
¨¨ '
existeSolicitudSinAceptar
¨¨ ,
;
¨¨, -
}
≠≠ 	
private
ØØ 
bool
ØØ %
ExisteAmistadConJugador
ØØ ,
(
ØØ, -
)
ØØ- .
{
∞∞ 	
string
±± !
nombreJugadorOrigen
±± &
=
±±' (
Dominio
±±) 0
.
±±0 1
CuentaJugador
±±1 >
.
±±> ?
Actual
±±? E
.
±±E F
NombreJugador
±±F S
;
±±S T
string
≤≤ "
nombreJugadorDestino
≤≤ '
=
≤≤( )0
"cuadroTextoNombreUsuarioInvitacion
≤≤* L
.
≤≤L M
Text
≤≤M Q
;
≤≤Q R
bool
≥≥ 
existeAmistad
≥≥ 
=
≥≥  
	Servicios
≥≥! *
.
≥≥* +
ServicioAmistades
≥≥+ <
.
≥≥< =%
ExisteAmistadConJugador
≥≥= T
(
≥≥T U!
nombreJugadorOrigen
¥¥ #
,
¥¥# $"
nombreJugadorDestino
¥¥% 9
)
¥¥9 :
;
¥¥: ;
if
∂∂ 
(
∂∂ 
existeAmistad
∂∂ 
)
∂∂ 
{
∑∑ 

MessageBox
∏∏ 
.
∏∏ 
Show
∏∏ 
(
∏∏  
$str
∏∏  S
+
∏∏T U
$str
ππ /
,
ππ/ 0
$str
ππ1 W
,
ππW X
MessageBoxButton
∫∫ $
.
∫∫$ %
OK
∫∫% '
,
∫∫' (
MessageBoxImage
∫∫) 8
.
∫∫8 9
Error
∫∫9 >
)
∫∫> ?
;
∫∫? @
}
ªª 
return
ΩΩ 
existeAmistad
ΩΩ  
;
ΩΩ  !
}
ææ 	
private
¿¿ 
void
¿¿ $
IrAPaginaMenuPrincipal
¿¿ +
(
¿¿+ ,
object
¿¿, 2
objetoOrigen
¿¿3 ?
,
¿¿? @"
MouseButtonEventArgs
¿¿A U
evento
¿¿V \
)
¿¿\ ]
{
¡¡ 	
VentanaPrincipal
¬¬ 
.
¬¬ 
CambiarPagina
¬¬ *
(
¬¬* +
new
¬¬+ .!
PaginaMenuPrincipal
¬¬/ B
(
¬¬B C
)
¬¬C D
)
¬¬D E
;
¬¬E F
}
√√ 	
private
≈≈ 
void
≈≈ &
EnviarSolicitudDeAmistad
≈≈ -
(
≈≈- .
object
≈≈. 4
objetoOrigen
≈≈5 A
,
≈≈A B
RoutedEventArgs
≈≈C R
evento
≈≈S Y
)
≈≈Y Z
{
∆∆ 	
if
«« 
(
«« 
!
«« (
EsElNombreDelJugadorActual
«« +
(
««+ ,
)
««, -
&&
««. 0
	Servicios
««1 :
.
««: ;
ServicioJugador
««; J
.
««J K!
ExisteNombreJugador
»» #
(
»»# $0
"cuadroTextoNombreUsuarioInvitacion
»»$ F
.
»»F G
Text
»»G K
)
»»K L
&&
»»M O
!
…… &
ExisteSolicitudDeAmistad
…… )
(
……) *
)
……* +
&&
……, .
!
……/ 0%
ExisteAmistadConJugador
……0 G
(
……G H
)
……H I
)
……I J
{
   
string
ÀÀ !
nombreJugadorOrigen
ÀÀ *
=
ÀÀ+ ,
Dominio
ÀÀ- 4
.
ÀÀ4 5
CuentaJugador
ÀÀ5 B
.
ÀÀB C
Actual
ÀÀC I
.
ÀÀI J
NombreJugador
ÀÀJ W
;
ÀÀW X
string
ÃÃ "
nombreJugadorDestino
ÃÃ +
=
ÃÃ, -0
"cuadroTextoNombreUsuarioInvitacion
ÃÃ. P
.
ÃÃP Q
Text
ÃÃQ U
;
ÃÃU V
bool
ÕÕ %
envioSolicitudRealizado
ÕÕ ,
=
ÕÕ- .
false
ÕÕ/ 4
;
ÕÕ4 5
try
œœ 
{
–– %
envioSolicitudRealizado
—— +
=
——, -&
clienteServicioAmistades
——. F
.
——F G&
EnviarSolicitudDeAmistad
““ 0
(
““0 1!
nombreJugadorOrigen
““1 D
,
““D E"
nombreJugadorDestino
““F Z
)
““Z [
;
““[ \
}
”” 
catch
‘‘ 
(
‘‘ '
EndpointNotFoundException
‘‘ 0
	excepcion
‘‘1 :
)
‘‘: ;
{
’’ 

MessageBox
◊◊ 
.
◊◊ 
Show
◊◊ #
(
◊◊# $

Properties
◊◊$ .
.
◊◊. /
	Resources
◊◊/ 8
.
◊◊8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÿÿ >
,
ÿÿ> ?

Properties
ÿÿ@ J
.
ÿÿJ K
	Resources
ÿÿK T
.
ÿÿT U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ŸŸ =
,
ŸŸ= >
MessageBoxButton
⁄⁄ (
.
⁄⁄( )
OK
⁄⁄) +
,
⁄⁄+ ,
MessageBoxImage
⁄⁄- <
.
⁄⁄< =
Error
⁄⁄= B
)
⁄⁄B C
;
⁄⁄C D&
clienteServicioAmistades
€€ ,
.
€€, -
Abort
€€- 2
(
€€2 3
)
€€3 4
;
€€4 5
}
‹‹ 
catch
›› 
(
›› 1
#CommunicationObjectFaultedException
›› :
	excepcion
››; D
)
››D E
{
ﬁﬁ 

MessageBox
‡‡ 
.
‡‡ 
Show
‡‡ #
(
‡‡# $

Properties
‡‡$ .
.
‡‡. /
	Resources
‡‡/ 8
.
‡‡8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
·· >
,
··> ?

Properties
··@ J
.
··J K
	Resources
··K T
.
··T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
‚‚ =
,
‚‚= >
MessageBoxButton
„„ (
.
„„( )
OK
„„) +
,
„„+ ,
MessageBoxImage
„„- <
.
„„< =
Error
„„= B
)
„„B C
;
„„C D&
clienteServicioAmistades
‰‰ ,
.
‰‰, -
Abort
‰‰- 2
(
‰‰2 3
)
‰‰3 4
;
‰‰4 5
}
ÂÂ 
catch
ÊÊ 
(
ÊÊ 
TimeoutException
ÊÊ '
	excepcion
ÊÊ( 1
)
ÊÊ1 2
{
ÁÁ 

MessageBox
ÈÈ 
.
ÈÈ 
Show
ÈÈ #
(
ÈÈ# $

Properties
ÈÈ$ .
.
ÈÈ. /
	Resources
ÈÈ/ 8
.
ÈÈ8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÍÍ >
,
ÍÍ> ?

Properties
ÍÍ@ J
.
ÍÍJ K
	Resources
ÍÍK T
.
ÍÍT U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÎÎ =
,
ÎÎ= >
MessageBoxButton
ÏÏ (
.
ÏÏ( )
OK
ÏÏ) +
,
ÏÏ+ ,
MessageBoxImage
ÏÏ- <
.
ÏÏ< =
Error
ÏÏ= B
)
ÏÏB C
;
ÏÏC D&
clienteServicioAmistades
ÌÌ ,
.
ÌÌ, -
Abort
ÌÌ- 2
(
ÌÌ2 3
)
ÌÌ3 4
;
ÌÌ4 5
}
ÓÓ 
if
 
(
 %
envioSolicitudRealizado
 +
)
+ ,
{
ÒÒ 

MessageBox
ÚÚ 
.
ÚÚ 
Show
ÚÚ #
(
ÚÚ# $
$str
ÚÚ$ Y
,
ÚÚY Z
$str
ÛÛ 6
,
ÛÛ6 7
MessageBoxButton
ÙÙ (
.
ÙÙ( )
OK
ÙÙ) +
,
ÙÙ+ ,
MessageBoxImage
ÙÙ- <
.
ÙÙ< =
Information
ÙÙ= H
)
ÙÙH I
;
ÙÙI J
}
ıı 
else
ˆˆ 
{
˜˜ 

MessageBox
¯¯ 
.
¯¯ 
Show
¯¯ #
(
¯¯# $
$str
¯¯$ Y
,
¯¯Y Z
$str
˘˘ >
,
˘˘> ?
MessageBoxButton
˙˙ (
.
˙˙( )
OK
˙˙) +
,
˙˙+ ,
MessageBoxImage
˙˙- <
.
˙˙< =
Error
˙˙= B
)
˙˙B C
;
˙˙C D
}
˚˚ 
}
¸¸ 
}
˝˝ 	
private
ˇˇ 
void
ˇˇ 
EliminarAmigo
ˇˇ "
(
ˇˇ" #
object
ˇˇ# )
objetoOrigen
ˇˇ* 6
,
ˇˇ6 7
RoutedEventArgs
ˇˇ8 G
evento
ˇˇH N
)
ˇˇN O
{
ÄÄ 	
var
ÅÅ 

filaActual
ÅÅ 
=
ÅÅ 
(
ÅÅ 
ListBoxItem
ÅÅ )
)
ÅÅ) *
listaAmigos
ÅÅ* 5
.
ÅÅ5 6"
ContainerFromElement
ÅÅ6 J
(
ÅÅJ K
(
ÇÇ 
Button
ÇÇ 
)
ÇÇ 
objetoOrigen
ÇÇ $
)
ÇÇ$ %
;
ÇÇ% &

filaActual
ÉÉ 
.
ÉÉ 

IsSelected
ÉÉ !
=
ÉÉ" #
true
ÉÉ$ (
;
ÉÉ( )
var
ÑÑ !
jugadorSeleccionado
ÑÑ #
=
ÑÑ$ %
(
ÑÑ& '
Dominio
ÑÑ' .
.
ÑÑ. /
CuentaJugador
ÑÑ/ <
)
ÑÑ< =
listaAmigos
ÑÑ= H
.
ÑÑH I
SelectedItem
ÑÑI U
;
ÑÑU V
string
ÖÖ 
nombreJugadorA
ÖÖ !
=
ÖÖ" #
Dominio
ÖÖ$ +
.
ÖÖ+ ,
CuentaJugador
ÖÖ, 9
.
ÖÖ9 :
Actual
ÖÖ: @
.
ÖÖ@ A
NombreJugador
ÖÖA N
;
ÖÖN O
string
ÜÜ 
nombreJugadorB
ÜÜ !
=
ÜÜ" #!
jugadorSeleccionado
ÜÜ$ 7
.
ÜÜ7 8
NombreJugador
ÜÜ8 E
;
ÜÜE F
bool
áá "
eliminacionRealizada
áá %
=
áá& '
false
áá( -
;
áá- .
try
ââ 
{
ää "
eliminacionRealizada
ãã $
=
ãã% &&
clienteServicioAmistades
ãã' ?
.
ãã? @+
EliminarAmistadEntreJugadores
åå 1
(
åå1 2
nombreJugadorA
åå2 @
,
åå@ A
nombreJugadorB
ååB P
)
ååP Q
;
ååQ R
}
çç 
catch
éé 
(
éé '
EndpointNotFoundException
éé ,
	excepcion
éé- 6
)
éé6 7
{
èè 

MessageBox
ëë 
.
ëë 
Show
ëë 
(
ëë  

Properties
ëë  *
.
ëë* +
	Resources
ëë+ 4
.
ëë4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
íí :
,
íí: ;

Properties
íí< F
.
ííF G
	Resources
ííG P
.
ííP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ìì 9
,
ìì9 :
MessageBoxButton
îî $
.
îî$ %
OK
îî% '
,
îî' (
MessageBoxImage
îî) 8
.
îî8 9
Error
îî9 >
)
îî> ?
;
îî? @&
clienteServicioAmistades
ïï (
.
ïï( )
Abort
ïï) .
(
ïï. /
)
ïï/ 0
;
ïï0 1
}
ññ 
catch
óó 
(
óó 1
#CommunicationObjectFaultedException
óó 6
	excepcion
óó7 @
)
óó@ A
{
òò 

MessageBox
öö 
.
öö 
Show
öö 
(
öö  

Properties
öö  *
.
öö* +
	Resources
öö+ 4
.
öö4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
õõ :
,
õõ: ;

Properties
õõ< F
.
õõF G
	Resources
õõG P
.
õõP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
úú 9
,
úú9 :
MessageBoxButton
ùù $
.
ùù$ %
OK
ùù% '
,
ùù' (
MessageBoxImage
ùù) 8
.
ùù8 9
Error
ùù9 >
)
ùù> ?
;
ùù? @&
clienteServicioAmistades
ûû (
.
ûû( )
Abort
ûû) .
(
ûû. /
)
ûû/ 0
;
ûû0 1
}
üü 
catch
†† 
(
†† 
TimeoutException
†† #
	excepcion
††$ -
)
††- .
{
°° 

MessageBox
££ 
.
££ 
Show
££ 
(
££  

Properties
££  *
.
££* +
	Resources
££+ 4
.
££4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
§§ :
,
§§: ;

Properties
§§< F
.
§§F G
	Resources
§§G P
.
§§P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
•• 9
,
••9 :
MessageBoxButton
¶¶ $
.
¶¶$ %
OK
¶¶% '
,
¶¶' (
MessageBoxImage
¶¶) 8
.
¶¶8 9
Error
¶¶9 >
)
¶¶> ?
;
¶¶? @&
clienteServicioAmistades
ßß (
.
ßß( )
Abort
ßß) .
(
ßß. /
)
ßß/ 0
;
ßß0 1
}
®® 
if
™™ 
(
™™ "
eliminacionRealizada
™™ $
)
™™$ %
{
´´ 
CuentasDeAmigos
¨¨ 
.
¨¨  
Remove
¨¨  &
(
¨¨& '!
jugadorSeleccionado
¨¨' :
)
¨¨: ;
;
¨¨; <
}
≠≠ 
else
ÆÆ 
{
ØØ 

MessageBox
∞∞ 
.
∞∞ 
Show
∞∞ 
(
∞∞  
$str
∞∞  Y
,
∞∞Y Z
$str
±± -
,
±±- .
MessageBoxButton
≤≤ $
.
≤≤$ %
OK
≤≤% '
,
≤≤' (
MessageBoxImage
≤≤) 8
.
≤≤8 9
Error
≤≤9 >
)
≤≤> ?
;
≤≤? @
}
≥≥ 
}
¥¥ 	
private
∂∂ 
void
∂∂ '
AceptarSolicitudDeAmistad
∂∂ .
(
∂∂. /
object
∂∂/ 5
objetoOrigen
∂∂6 B
,
∂∂B C
RoutedEventArgs
∑∑ 
evento
∑∑ "
)
∑∑" #
{
∏∏ 	
var
ππ 

filaActual
ππ 
=
ππ 
(
ππ 
ListBoxItem
ππ )
)
ππ) *
listaSolicitudes
ππ* :
.
ππ: ;"
ContainerFromElement
ππ; O
(
ππO P
(
∫∫ 
Button
∫∫ 
)
∫∫ 
objetoOrigen
∫∫ $
)
∫∫$ %
;
∫∫% &

filaActual
ªª 
.
ªª 

IsSelected
ªª !
=
ªª" #
true
ªª$ (
;
ªª( )
var
ºº !
jugadorSeleccionado
ºº #
=
ºº$ %
(
ºº& '
Dominio
ºº' .
.
ºº. /
CuentaJugador
ºº/ <
)
ºº< =
listaSolicitudes
ºº= M
.
ººM N
SelectedItem
ººN Z
;
ººZ [
bool
ΩΩ 
solicitudAceptada
ΩΩ "
=
ΩΩ# $
false
ΩΩ% *
;
ΩΩ* +
if
øø 
(
øø !
jugadorSeleccionado
øø #
!=
øø$ &
null
øø' +
)
øø+ ,
{
¿¿ 
string
¡¡ !
nombreJugadorOrigen
¡¡ *
=
¡¡+ ,!
jugadorSeleccionado
¡¡- @
.
¡¡@ A
NombreJugador
¡¡A N
;
¡¡N O
string
¬¬ "
nombreJugadorDestino
¬¬ +
=
¬¬, -
Dominio
¬¬. 5
.
¬¬5 6
CuentaJugador
¬¬6 C
.
¬¬C D
Actual
¬¬D J
.
¬¬J K
NombreJugador
¬¬K X
;
¬¬X Y
try
ƒƒ 
{
≈≈ 
solicitudAceptada
∆∆ %
=
∆∆& '&
clienteServicioAmistades
∆∆( @
.
∆∆@ A'
AceptarSolicitudDeAmistad
∆∆A Z
(
∆∆Z [!
nombreJugadorOrigen
«« +
,
««+ ,"
nombreJugadorDestino
««- A
)
««A B
;
««B C
}
»» 
catch
…… 
(
…… '
EndpointNotFoundException
…… 0
	excepcion
……1 :
)
……: ;
{
   

MessageBox
ÃÃ 
.
ÃÃ 
Show
ÃÃ #
(
ÃÃ# $

Properties
ÃÃ$ .
.
ÃÃ. /
	Resources
ÃÃ/ 8
.
ÃÃ8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÕÕ >
,
ÕÕ> ?

Properties
ÕÕ@ J
.
ÕÕJ K
	Resources
ÕÕK T
.
ÕÕT U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ŒŒ =
,
ŒŒ= >
MessageBoxButton
œœ (
.
œœ( )
OK
œœ) +
,
œœ+ ,
MessageBoxImage
œœ- <
.
œœ< =
Error
œœ= B
)
œœB C
;
œœC D&
clienteServicioAmistades
–– ,
.
––, -
Abort
––- 2
(
––2 3
)
––3 4
;
––4 5
}
—— 
catch
““ 
(
““ 1
#CommunicationObjectFaultedException
““ :
	excepcion
““; D
)
““D E
{
”” 

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
’’8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
÷÷ >
,
÷÷> ?

Properties
÷÷@ J
.
÷÷J K
	Resources
÷÷K T
.
÷÷T U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
◊◊ =
,
◊◊= >
MessageBoxButton
ÿÿ (
.
ÿÿ( )
OK
ÿÿ) +
,
ÿÿ+ ,
MessageBoxImage
ÿÿ- <
.
ÿÿ< =
Error
ÿÿ= B
)
ÿÿB C
;
ÿÿC D&
clienteServicioAmistades
ŸŸ ,
.
ŸŸ, -
Abort
ŸŸ- 2
(
ŸŸ2 3
)
ŸŸ3 4
;
ŸŸ4 5
}
⁄⁄ 
catch
€€ 
(
€€ 
TimeoutException
€€ '
	excepcion
€€( 1
)
€€1 2
{
‹‹ 

MessageBox
ﬁﬁ 
.
ﬁﬁ 
Show
ﬁﬁ #
(
ﬁﬁ# $

Properties
ﬁﬁ$ .
.
ﬁﬁ. /
	Resources
ﬁﬁ/ 8
.
ﬁﬁ8 94
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ﬂﬂ >
,
ﬂﬂ> ?

Properties
ﬂﬂ@ J
.
ﬂﬂJ K
	Resources
ﬂﬂK T
.
ﬂﬂT U3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
‡‡ =
,
‡‡= >
MessageBoxButton
·· (
.
··( )
OK
··) +
,
··+ ,
MessageBoxImage
··- <
.
··< =
Error
··= B
)
··B C
;
··C D&
clienteServicioAmistades
‚‚ ,
.
‚‚, -
Abort
‚‚- 2
(
‚‚2 3
)
‚‚3 4
;
‚‚4 5
}
„„ 
}
‰‰ 
if
ÊÊ 
(
ÊÊ 
solicitudAceptada
ÊÊ !
)
ÊÊ! "
{
ÁÁ "
CuentasDeSolicitudes
ËË $
.
ËË$ %
Remove
ËË% +
(
ËË+ ,!
jugadorSeleccionado
ËË, ?
)
ËË? @
;
ËË@ A
CuentasDeAmigos
ÈÈ 
.
ÈÈ  
Add
ÈÈ  #
(
ÈÈ# $!
jugadorSeleccionado
ÈÈ$ 7
)
ÈÈ7 8
;
ÈÈ8 9
}
ÍÍ 
else
ÎÎ 
{
ÏÏ 

MessageBox
ÌÌ 
.
ÌÌ 
Show
ÌÌ 
(
ÌÌ  
$str
ÌÌ  ^
,
ÌÌ^ _
$str
ÓÓ ;
,
ÓÓ; <
MessageBoxButton
ÔÔ $
.
ÔÔ$ %
OK
ÔÔ% '
,
ÔÔ' (
MessageBoxImage
ÔÔ) 8
.
ÔÔ8 9
Error
ÔÔ9 >
)
ÔÔ> ?
;
ÔÔ? @
}
 
}
ÒÒ 	
private
ÛÛ 
void
ÛÛ (
RechazarSolicitudDeAmistad
ÛÛ /
(
ÛÛ/ 0
object
ÛÛ0 6
objetoOrigen
ÛÛ7 C
,
ÛÛC D
RoutedEventArgs
ÛÛE T
evento
ÛÛU [
)
ÛÛ[ \
{
ÙÙ 	
var
ıı 

filaActual
ıı 
=
ıı 
(
ıı 
ListBoxItem
ıı )
)
ıı) *
listaSolicitudes
ıı* :
.
ıı: ;"
ContainerFromElement
ıı; O
(
ııO P
(
ˆˆ 
Button
ˆˆ 
)
ˆˆ 
objetoOrigen
ˆˆ $
)
ˆˆ$ %
;
ˆˆ% &

filaActual
˜˜ 
.
˜˜ 

IsSelected
˜˜ !
=
˜˜" #
true
˜˜$ (
;
˜˜( )
var
¯¯ !
jugadorSeleccionado
¯¯ #
=
¯¯$ %
(
¯¯& '
Dominio
¯¯' .
.
¯¯. /
CuentaJugador
¯¯/ <
)
¯¯< =
listaSolicitudes
¯¯= M
.
¯¯M N
SelectedItem
¯¯N Z
;
¯¯Z [
string
˘˘ !
nombreJugadorOrigen
˘˘ &
=
˘˘' (!
jugadorSeleccionado
˘˘) <
.
˘˘< =
NombreJugador
˘˘= J
;
˘˘J K
string
˙˙ "
nombreJugadorDestino
˙˙ '
=
˙˙( )
Dominio
˙˙* 1
.
˙˙1 2
CuentaJugador
˙˙2 ?
.
˙˙? @
Actual
˙˙@ F
.
˙˙F G
NombreJugador
˙˙G T
;
˙˙T U
bool
˚˚  
solicitudRechazada
˚˚ #
=
˚˚$ %
false
˚˚& +
;
˚˚+ ,
try
˝˝ 
{
˛˛  
solicitudRechazada
ˇˇ "
=
ˇˇ# $&
clienteServicioAmistades
ˇˇ% =
.
ˇˇ= >(
RechazarSolicitudDeAmistad
ˇˇ> X
(
ˇˇX Y!
nombreJugadorOrigen
ÄÄ '
,
ÄÄ' ("
nombreJugadorDestino
ÄÄ) =
)
ÄÄ= >
;
ÄÄ> ?
}
ÅÅ 
catch
ÇÇ 
(
ÇÇ '
EndpointNotFoundException
ÇÇ ,
	excepcion
ÇÇ- 6
)
ÇÇ6 7
{
ÉÉ 

MessageBox
ÖÖ 
.
ÖÖ 
Show
ÖÖ 
(
ÖÖ  

Properties
ÖÖ  *
.
ÖÖ* +
	Resources
ÖÖ+ 4
.
ÖÖ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÜÜ :
,
ÜÜ: ;

Properties
ÜÜ< F
.
ÜÜF G
	Resources
ÜÜG P
.
ÜÜP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
áá 9
,
áá9 :
MessageBoxButton
àà $
.
àà$ %
OK
àà% '
,
àà' (
MessageBoxImage
àà) 8
.
àà8 9
Error
àà9 >
)
àà> ?
;
àà? @&
clienteServicioAmistades
ââ (
.
ââ( )
Abort
ââ) .
(
ââ. /
)
ââ/ 0
;
ââ0 1
}
ää 
catch
ãã 
(
ãã 1
#CommunicationObjectFaultedException
ãã 6
	excepcion
ãã7 @
)
ãã@ A
{
åå 

MessageBox
éé 
.
éé 
Show
éé 
(
éé  

Properties
éé  *
.
éé* +
	Resources
éé+ 4
.
éé4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
èè :
,
èè: ;

Properties
èè< F
.
èèF G
	Resources
èèG P
.
èèP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
êê 9
,
êê9 :
MessageBoxButton
ëë $
.
ëë$ %
OK
ëë% '
,
ëë' (
MessageBoxImage
ëë) 8
.
ëë8 9
Error
ëë9 >
)
ëë> ?
;
ëë? @&
clienteServicioAmistades
íí (
.
íí( )
Abort
íí) .
(
íí. /
)
íí/ 0
;
íí0 1
}
ìì 
catch
îî 
(
îî 
TimeoutException
îî #
	excepcion
îî$ -
)
îî- .
{
ïï 

MessageBox
óó 
.
óó 
Show
óó 
(
óó  

Properties
óó  *
.
óó* +
	Resources
óó+ 4
.
óó4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
òò :
,
òò: ;

Properties
òò< F
.
òòF G
	Resources
òòG P
.
òòP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ôô 9
,
ôô9 :
MessageBoxButton
öö $
.
öö$ %
OK
öö% '
,
öö' (
MessageBoxImage
öö) 8
.
öö8 9
Error
öö9 >
)
öö> ?
;
öö? @&
clienteServicioAmistades
õõ (
.
õõ( )
Abort
õõ) .
(
õõ. /
)
õõ/ 0
;
õõ0 1
}
úú 
if
ûû 
(
ûû  
solicitudRechazada
ûû "
)
ûû" #
{
üü "
CuentasDeSolicitudes
†† $
.
††$ %
Remove
††% +
(
††+ ,!
jugadorSeleccionado
††, ?
)
††? @
;
††@ A
}
°° 
else
¢¢ 
{
££ 

MessageBox
§§ 
.
§§ 
Show
§§ 
(
§§  
$str
§§  _
,
§§_ `
$str
•• <
,
••< =
MessageBoxButton
¶¶ %
.
¶¶% &
OK
¶¶& (
,
¶¶( )
MessageBoxImage
¶¶* 9
.
¶¶9 :
Error
¶¶: ?
)
¶¶? @
;
¶¶@ A
}
ßß 
}
®® 	
public
™™ 
void
™™ 2
$NotificarEstadoConectividadDeJugador
™™ 8
(
™™8 9
string
™™9 ?
nombreJugador
™™@ M
,
™™M N'
EstadoConectividadJugador
´´ %
estado
´´& ,
)
´´, -
{
¨¨ 	
if
≠≠ 
(
≠≠ 
CuentasDeAmigos
≠≠ 
!=
≠≠  "
null
≠≠# '
)
≠≠' (
{
ÆÆ 
var
ØØ %
cuentaAmigoModificacion
ØØ +
=
ØØ, -
CuentasDeAmigos
ØØ. =
.
ØØ= >
FirstOrDefault
ØØ> L
(
ØØL M
amigo
ØØM R
=>
ØØS U
amigo
∞∞ 
.
∞∞ 
NombreJugador
∞∞ '
==
∞∞( *
nombreJugador
∞∞+ 8
)
∞∞8 9
;
∞∞9 :
CuentasDeAmigos
±± 
.
±±  
Remove
±±  &
(
±±& '%
cuentaAmigoModificacion
±±' >
)
±±> ?
;
±±? @
if
≥≥ 
(
≥≥ %
cuentaAmigoModificacion
≥≥ +
!=
≥≥, .
null
≥≥/ 3
)
≥≥3 4
{
¥¥ %
cuentaAmigoModificacion
µµ +
.
µµ+ ,%
ColorEstadoConectividad
µµ, C
=
µµD E1
#ObtenerColorSegunEstadoConectividad
∂∂ ;
(
∂∂; <
estado
∂∂< B
)
∂∂B C
;
∂∂C D
}
∑∑ 
CuentasDeAmigos
ππ 
.
ππ  
Insert
ππ  &
(
ππ& '
$num
ππ' (
,
ππ( )%
cuentaAmigoModificacion
ππ* A
)
ππA B
;
ππB C
}
∫∫ 
}
ªª 	
public
ΩΩ 
void
ΩΩ .
 NotificarSolicitudAmistadEnviada
ΩΩ 4
(
ΩΩ4 5
CuentaJugador
ΩΩ5 B"
cuentaNuevaSolicitud
ΩΩC W
)
ΩΩW X
{
ææ 	
if
øø 
(
øø "
CuentasDeSolicitudes
øø $
!=
øø% '
null
øø( ,
)
øø, -
{
¿¿ "
CuentasDeSolicitudes
¡¡ $
.
¡¡$ %
Add
¡¡% (
(
¡¡( )
new
¡¡) ,
Dominio
¡¡- 4
.
¡¡4 5
CuentaJugador
¡¡5 B
{
¬¬ 
NombreJugador
√√ !
=
√√" #"
cuentaNuevaSolicitud
√√$ 8
.
√√8 9
NombreJugador
√√9 F
,
√√F G
NumeroAvatar
ƒƒ  
=
ƒƒ! ""
cuentaNuevaSolicitud
ƒƒ# 7
.
ƒƒ7 8
NumeroAvatar
ƒƒ8 D
,
ƒƒD E 
FuenteImagenAvatar
≈≈ &
=
≈≈' (

Utilidades
≈≈) 3
.
≈≈3 4
GeneradorImagenes
≈≈4 E
.
≈≈E F'
GenerarFuenteImagenAvatar
∆∆ 1
(
∆∆1 2"
cuentaNuevaSolicitud
∆∆2 F
.
∆∆F G
NumeroAvatar
∆∆G S
)
∆∆S T
,
∆∆T U%
ColorEstadoConectividad
«« +
=
««, -1
#ObtenerColorSegunEstadoConectividad
««. Q
(
««Q R"
cuentaNuevaSolicitud
»» ,
.
»», - 
EstadoConectividad
»»- ?
)
»»? @
}
…… 
)
…… 
;
…… 
}
   
}
ÀÀ 	
public
ÕÕ 
void
ÕÕ /
!NotificarSolicitudAmistadAceptada
ÕÕ 5
(
ÕÕ5 6
CuentaJugador
ÕÕ6 C
cuentaNuevoAmigo
ÕÕD T
)
ÕÕT U
{
ŒŒ 	
if
œœ 
(
œœ 
CuentasDeAmigos
œœ 
!=
œœ  "
null
œœ# '
)
œœ' (
{
–– 
var
—— &
solicitudAmistadResidual
—— ,
=
——- ."
CuentasDeSolicitudes
——/ C
.
——C D
FirstOrDefault
——D R
(
——R S
cuentaSolicitud
——S b
=>
——c e
cuentaSolicitud
““ #
.
““# $
NombreJugador
““$ 1
==
““2 4
cuentaNuevoAmigo
”” $
.
””$ %
NombreJugador
””% 2
)
””2 3
;
””3 4
if
’’ 
(
’’ &
solicitudAmistadResidual
’’ ,
!=
’’- /
null
’’0 4
)
’’4 5
{
÷÷ "
CuentasDeSolicitudes
◊◊ (
.
◊◊( )
Remove
◊◊) /
(
◊◊/ 0&
solicitudAmistadResidual
◊◊0 H
)
◊◊H I
;
◊◊I J
}
ÿÿ 
CuentasDeAmigos
⁄⁄ 
.
⁄⁄  
Add
⁄⁄  #
(
⁄⁄# $
new
⁄⁄$ '
Dominio
⁄⁄( /
.
⁄⁄/ 0
CuentaJugador
⁄⁄0 =
{
€€ 
NombreJugador
‹‹ !
=
‹‹" #
cuentaNuevoAmigo
‹‹$ 4
.
‹‹4 5
NombreJugador
‹‹5 B
,
‹‹B C
NumeroAvatar
››  
=
››! "
cuentaNuevoAmigo
››# 3
.
››3 4
NumeroAvatar
››4 @
,
››@ A 
FuenteImagenAvatar
ﬁﬁ &
=
ﬁﬁ' (

Utilidades
ﬁﬁ) 3
.
ﬁﬁ3 4
GeneradorImagenes
ﬁﬁ4 E
.
ﬁﬁE F'
GenerarFuenteImagenAvatar
ﬂﬂ 1
(
ﬂﬂ1 2
cuentaNuevoAmigo
ﬂﬂ2 B
.
ﬂﬂB C
NumeroAvatar
ﬂﬂC O
)
ﬂﬂO P
,
ﬂﬂP Q%
ColorEstadoConectividad
‡‡ +
=
‡‡, -1
#ObtenerColorSegunEstadoConectividad
‡‡. Q
(
‡‡Q R
cuentaNuevoAmigo
·· (
.
··( ) 
EstadoConectividad
··) ;
)
··; <
}
‚‚ 
)
‚‚ 
;
‚‚ 
}
„„ 
}
‰‰ 	
public
ÊÊ 
void
ÊÊ '
NotificarAmistadEliminada
ÊÊ -
(
ÊÊ- .
string
ÊÊ. 4$
nombreAmigoEliminacion
ÊÊ5 K
)
ÊÊK L
{
ÁÁ 	
if
ËË 
(
ËË 
CuentasDeAmigos
ËË 
!=
ËË  "
null
ËË# '
)
ËË' (
{
ÈÈ 
var
ÍÍ $
cuentaAmigoEliminacion
ÍÍ *
=
ÍÍ+ ,
CuentasDeAmigos
ÍÍ- <
.
ÍÍ< =
FirstOrDefault
ÍÍ= K
(
ÍÍK L
amigo
ÍÍL Q
=>
ÍÍR T
amigo
ÎÎ 
.
ÎÎ 
NombreJugador
ÎÎ '
==
ÎÎ( *$
nombreAmigoEliminacion
ÎÎ+ A
)
ÎÎA B
;
ÎÎB C
if
ÌÌ 
(
ÌÌ $
cuentaAmigoEliminacion
ÌÌ *
!=
ÌÌ+ -
null
ÌÌ. 2
)
ÌÌ2 3
{
ÓÓ 
CuentasDeAmigos
ÔÔ #
.
ÔÔ# $
Remove
ÔÔ$ *
(
ÔÔ* +$
cuentaAmigoEliminacion
ÔÔ+ A
)
ÔÔA B
;
ÔÔB C
}
 
}
ÒÒ 
}
ÚÚ 	
private
ÙÙ 
void
ÙÙ 0
"DesuscribirJugadorDeNotificaciones
ÙÙ 7
(
ÙÙ7 8
object
ÙÙ8 >
objetoOrigen
ÙÙ? K
,
ÙÙK L
RoutedEventArgs
ıı 
evento
ıı "
)
ıı" #
{
ˆˆ 	
try
˜˜ 
{
¯¯ &
clienteServicioAmistades
˘˘ (
.
˘˘( )9
+DesuscribirJugadorDeNotificacionesAmistades
˘˘) T
(
˘˘T U
Dominio
˙˙ 
.
˙˙ 
CuentaJugador
˙˙ )
.
˙˙) *
Actual
˙˙* 0
.
˙˙0 1
NombreJugador
˙˙1 >
)
˙˙> ?
;
˙˙? @&
clienteServicioAmistades
˚˚ (
.
˚˚( )
Close
˚˚) .
(
˚˚. /
)
˚˚/ 0
;
˚˚0 1
}
¸¸ 
catch
˝˝ 
(
˝˝ '
EndpointNotFoundException
˝˝ ,
	excepcion
˝˝- 6
)
˝˝6 7
{
˛˛ 

MessageBox
ÄÄ 
.
ÄÄ 
Show
ÄÄ 
(
ÄÄ  

Properties
ÄÄ  *
.
ÄÄ* +
	Resources
ÄÄ+ 4
.
ÄÄ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ÅÅ :
,
ÅÅ: ;

Properties
ÅÅ< F
.
ÅÅF G
	Resources
ÅÅG P
.
ÅÅP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ÇÇ 9
,
ÇÇ9 :
MessageBoxButton
ÉÉ $
.
ÉÉ$ %
OK
ÉÉ% '
,
ÉÉ' (
MessageBoxImage
ÉÉ) 8
.
ÉÉ8 9
Error
ÉÉ9 >
)
ÉÉ> ?
;
ÉÉ? @&
clienteServicioAmistades
ÑÑ (
.
ÑÑ( )
Abort
ÑÑ) .
(
ÑÑ. /
)
ÑÑ/ 0
;
ÑÑ0 1
}
ÖÖ 
catch
ÜÜ 
(
ÜÜ 1
#CommunicationObjectFaultedException
ÜÜ 6
	excepcion
ÜÜ7 @
)
ÜÜ@ A
{
áá 

MessageBox
ââ 
.
ââ 
Show
ââ 
(
ââ  

Properties
ââ  *
.
ââ* +
	Resources
ââ+ 4
.
ââ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ää :
,
ää: ;

Properties
ää< F
.
ääF G
	Resources
ääG P
.
ääP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ãã 9
,
ãã9 :
MessageBoxButton
åå $
.
åå$ %
OK
åå% '
,
åå' (
MessageBoxImage
åå) 8
.
åå8 9
Error
åå9 >
)
åå> ?
;
åå? @&
clienteServicioAmistades
çç (
.
çç( )
Abort
çç) .
(
çç. /
)
çç/ 0
;
çç0 1
}
éé 
catch
èè 
(
èè 
TimeoutException
èè #
	excepcion
èè$ -
)
èè- .
{
êê 

MessageBox
íí 
.
íí 
Show
íí 
(
íí  

Properties
íí  *
.
íí* +
	Resources
íí+ 4
.
íí4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ìì :
,
ìì: ;

Properties
ìì< F
.
ììF G
	Resources
ììG P
.
ììP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
îî 9
,
îî9 :
MessageBoxButton
ïï $
.
ïï$ %
OK
ïï% '
,
ïï' (
MessageBoxImage
ïï) 8
.
ïï8 9
Error
ïï9 >
)
ïï> ?
;
ïï? @&
clienteServicioAmistades
ññ (
.
ññ( )
Abort
ññ) .
(
ññ. /
)
ññ/ 0
;
ññ0 1
}
óó 
}
òò 	
}
ôô 
}öö √
ÅC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaModificacionJugadoresSala.xaml.cs
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
} ».
àC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaCodigoRestablecimientoContrasena.xaml.cs
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
TextBoxDD  '
)DD' (
{EE 
TextBoxFF 
cuadroTextoFF #
=FF$ %
(FF& '
TextBoxFF' .
)FF. /
objetoOrigenFF0 <
;FF< =
stringGG 
textoGG 
=GG 
cuadroTextoGG *
.GG* +
TextGG+ /
=GG0 1
newGG2 5
stringGG6 <
(GG< =
cuadroTextoGG= H
.GGH I
TextGGI M
.GGM N
WhereGGN S
(GGS T
charHH 
.HH 
IsDigitHH  
)HH  !
.HH! "
ToArrayHH" )
(HH) *
)HH* +
)HH+ ,
;HH, -
cuadroTextoII 
.II 

CaretIndexII &
=II' (
cuadroTextoII) 4
.II4 5
TextII5 9
.II9 :
LengthII: @
;II@ A
cuadroTextoJJ 
.JJ 
TextJJ  
=JJ! "
textoJJ# (
;JJ( )
}KK 
}LL 	
}MM 
}NN ›!
zC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaInformacionJugador.xaml.cs
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
}55 ±Y
tC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaInicioSesion.xaml.cs
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
}ìì ®/
uC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaMenuPrincipal.xaml.cs
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
}II »ˇ
oC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaPartida.xaml.cs
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
;! "
public  
ObservableCollection #
<# $
Dominio$ +
.+ ,
CuentaJugador, 9
>9 :
JugadoresPartida; K
{L M
getN Q
;Q R
setS V
;V W
}X Y
public 
PaginaPartida 
( 
) 
{ 	
} 	
public 
PaginaPartida 
( 

Dificultad '

dificultad( 2
,2 3
int4 7$
numeroImagenRompecabezas8 P
)P Q
{   	
InitializeComponent!! 
(!!  
)!!  !
;!!! "
tablero"" 
="" 
new"" 
Tablero"" !
{## 

Dificultad$$ 
=$$ 

dificultad$$ '
,$$' (
Piezas%% 
=%% 
new%% 
List%% !
<%%! "
Pieza%%" '
>%%' (
(%%( )
)%%) *
,%%* +
Celdas&& 
=&& 
new&& 
List&& !
<&&! "
Celda&&" '
>&&' (
(&&( )
)&&) *
,&&* +$
NumeroImagenRompecabezas'' (
='') *$
numeroImagenRompecabezas''+ C
}(( 
;(( 
JugadoresPartida)) 
=)) 
new)) " 
ObservableCollection))# 7
<))7 8
Dominio))8 ?
.))? @
CuentaJugador))@ M
>))M N
())N O
)))O P
;))P Q!
listaJugadoresPartida** !
.**! "
DataContext**" -
=**. /
this**0 4
;**4 5"
CargarJugadoresPartida++ "
(++" #
)++# $
;++$ %
},, 	
private.. 
void.. "
CargarJugadoresPartida.. +
(..+ ,
).., -
{// 	
}11 	
private33 
void33 
CrearTablero33 !
(33! "
)33" #
{44 	
tablero55 
.55 
AnchoDeCelda55  
=55! "
tableroRompecabezas55# 6
.556 7
ActualWidth557 B
/55C D
tablero55E L
.55L M
TotalColumnas55M Z
;55Z [
tablero66 
.66 
AlturaDeCelda66 !
=66" #
tableroRompecabezas66$ 7
.667 8
ActualHeight668 D
/66E F
tablero66G N
.66N O

TotalFilas66O Y
;66Y Z
bool77 #
pintarCeldaConColorGris77 (
;77( )
bool88 0
$pintarCeldaConColorGrisAlIniciarFila88 5
=886 7
true888 <
;88< =
for:: 
(:: 
int:: 
fila:: 
=:: 
$num:: 
;:: 
fila:: #
<::$ %
tablero::& -
.::- .

TotalFilas::. 8
;::8 9
fila::: >
++::> @
)::@ A
{;; #
pintarCeldaConColorGris<< '
=<<( )0
$pintarCeldaConColorGrisAlIniciarFila<<* N
;<<N O
for== 
(== 
int== 
columna==  
===! "
$num==# $
;==$ %
columna==& -
<==. /
tablero==0 7
.==7 8
TotalColumnas==8 E
;==E F
columna==G N
++==N P
)==P Q
{>> 
Celda?? 
celda?? 
=??  !
new??" %
Celda??& +
{@@ 
FilaAA 
=AA 
filaAA #
,AA# $
ColumnaBB 
=BB  !
columnaBB" )
,BB) *
AreaCC 
=CC 
newCC "
	RectangleCC# ,
{DD 
WidthEE !
=EE" #
tableroEE$ +
.EE+ ,
AnchoDeCeldaEE, 8
,EE8 9
HeightFF "
=FF# $
tableroFF% ,
.FF, -
AlturaDeCeldaFF- :
,FF: ;
StrokeGG "
=GG# $
BrushesGG% ,
.GG, -
BlackGG- 2
,GG2 3
StrokeThicknessHH +
=HH, -
$numHH. 1
}II 
}JJ 
;JJ 
ifLL 
(LL #
pintarCeldaConColorGrisLL /
)LL/ 0
{MM 
celdaNN 
.NN 
AreaNN "
.NN" #
FillNN# '
=NN( )
BrushesNN* 1
.NN1 2
	LightGrayNN2 ;
;NN; <#
pintarCeldaConColorGrisOO /
=OO0 1
falseOO2 7
;OO7 8
}PP 
elseQQ 
{RR 
celdaSS 
.SS 
AreaSS "
.SS" #
FillSS# '
=SS( )
BrushesSS* 1
.SS1 2
	AliceBlueSS2 ;
;SS; <#
pintarCeldaConColorGrisTT /
=TT0 1
trueTT2 6
;TT6 7
}UU 
ifWW 
(WW 
columnaWW 
+WW  !
$numWW" #
==WW$ &
tableroWW' .
.WW. /
TotalColumnasWW/ <
)WW< =
{XX 
ifYY 
(YY 0
$pintarCeldaConColorGrisAlIniciarFilaYY @
)YY@ A
{ZZ 0
$pintarCeldaConColorGrisAlIniciarFila[[ @
=[[A B
false[[C H
;[[H I
}\\ 
else]] 
{^^ 0
$pintarCeldaConColorGrisAlIniciarFila__ @
=__A B
true__C G
;__G H
}`` 
}aa 
doublecc 
	posicionXcc $
=cc% &
columnacc' .
*cc/ 0
tablerocc1 8
.cc8 9
AnchoDeCeldacc9 E
;ccE F
doubledd 
	posicionYdd $
=dd% &
filadd' +
*dd, -
tablerodd. 5
.dd5 6
AlturaDeCeldadd6 C
;ddC D
Canvasee 
.ee 
SetLeftee "
(ee" #
celdaee# (
.ee( )
Areaee) -
,ee- .
	posicionXee/ 8
)ee8 9
;ee9 :
Canvasff 
.ff 
SetTopff !
(ff! "
celdaff" '
.ff' (
Areaff( ,
,ff, -
	posicionYff. 7
)ff7 8
;ff8 9
tableroRompecabezasgg '
.gg' (
Childrengg( 0
.gg0 1
Addgg1 4
(gg4 5
celdagg5 :
.gg: ;
Areagg; ?
)gg? @
;gg@ A
tablerohh 
.hh 
Celdashh "
.hh" #
Addhh# &
(hh& '
celdahh' ,
)hh, -
;hh- .
}ii 
}jj 
}kk 	
privatemm 
voidmm "
RecortarImagenEnPiezasmm +
(mm+ ,
BitmapImagemm, 7 
fuenteImagenOriginalmm8 L
)mmL M
{nn 	
intoo 
anchoRecorteoo 
=oo 
(oo  
intoo  #
)oo# $
(oo$ % 
fuenteImagenOriginaloo% 9
.oo9 :
Widthoo: ?
/oo@ A
tableroooB I
.ooI J
TotalColumnasooJ W
)ooW X
;ooX Y
intpp 
alturaRecortepp 
=pp 
(pp  !
intpp! $
)pp$ %
(pp% & 
fuenteImagenOriginalpp& :
.pp: ;
Heightpp; A
/ppB C
tableroppD K
.ppK L

TotalFilasppL V
)ppV W
;ppW X
forrr 
(rr 
intrr 
filarr 
=rr 
$numrr 
;rr 
filarr #
<rr$ %
tablerorr& -
.rr- .

TotalFilasrr. 8
;rr8 9
filarr: >
++rr> @
)rr@ A
{ss 
fortt 
(tt 
inttt 
columnatt  
=tt! "
$numtt# $
;tt$ %
columnatt& -
<tt. /
tablerott0 7
.tt7 8
TotalColumnastt8 E
;ttE F
columnattG N
++ttN P
)ttP Q
{uu 
	Int32Rectvv 
areaRecortevv )
=vv* +
newvv, /
	Int32Rectvv0 9
(vv9 :
columnavv: A
*vvB C
anchoRecortevvD P
,vvP Q
filavvR V
*vvW X
alturaRecorteww %
,ww% &
anchoRecorteww' 3
,ww3 4
alturaRecorteww5 B
)wwB C
;wwC D
Piezaxx 

nuevaPiezaxx $
=xx% &
newxx' *
Piezaxx+ 0
{yy 
Anchozz 
=zz 
tablerozz  '
.zz' (
AnchoDeCeldazz( 4
,zz4 5
Alto{{ 
={{ 
tablero{{ &
.{{& '
AlturaDeCelda{{' 4
,{{4 5
EstaDentroDeCelda|| )
=||* +
false||, 1
,||1 2
FilaCorrecta}} $
=}}% &
fila}}' +
,}}+ ,
ColumnaCorrecta~~ '
=~~( )
columna~~* 1
} 
; 

nuevaPieza
ÄÄ 
.
ÄÄ $
EstablecerFuenteImagen
ÄÄ 5
(
ÄÄ5 6"
fuenteImagenOriginal
ÄÄ6 J
,
ÄÄJ K
areaRecorte
ÄÄL W
)
ÄÄW X
;
ÄÄX Y

nuevaPieza
ÅÅ 
.
ÅÅ 
Borde
ÅÅ $
=
ÅÅ% &(
GenerarNuevoBordeParaPieza
ÅÅ' A
(
ÅÅA B
)
ÅÅB C
;
ÅÅC D

nuevaPieza
ÇÇ 
.
ÇÇ 3
%EstablecerEstiloDePiezaSinSeleccionar
ÇÇ D
(
ÇÇD E
)
ÇÇE F
;
ÇÇF G
tablero
ÉÉ 
.
ÉÉ 
Piezas
ÉÉ "
.
ÉÉ" #
Add
ÉÉ# &
(
ÉÉ& '

nuevaPieza
ÉÉ' 1
)
ÉÉ1 2
;
ÉÉ2 3
}
ÑÑ 
}
ÖÖ 
}
ÜÜ 	
private
àà 
Border
àà (
GenerarNuevoBordeParaPieza
àà 1
(
àà1 2
)
àà2 3
{
ââ 	
Border
ää 
bordeImagen
ää 
=
ää  
new
ää! $
Border
ää% +
(
ää+ ,
)
ää, -
;
ää- .
bordeImagen
ãã 
.
ãã !
MouseLeftButtonDown
ãã +
+=
ãã, .
SeleccionarPieza
ãã/ ?
;
ãã? @
bordeImagen
åå 
.
åå 
	MouseMove
åå !
+=
åå" $

MoverPieza
åå% /
;
åå/ 0
bordeImagen
çç 
.
çç 
MouseLeftButtonUp
çç )
+=
çç* ,
SoltarPieza
çç- 8
;
çç8 9
return
èè 
bordeImagen
èè 
;
èè 
}
êê 	
private
íí 
void
íí )
MostrarPiezasAleatoriamente
íí 0
(
íí0 1
)
íí1 2
{
ìì 	
Random
îî 
	aleatorio
îî 
=
îî 
new
îî "
Random
îî# )
(
îî) *
)
îî* +
;
îî+ ,
foreach
ññ 
(
ññ 
Pieza
ññ 
pieza
ññ  
in
ññ! #
tablero
ññ$ +
.
ññ+ ,
Piezas
ññ, 2
)
ññ2 3
{
óó 
double
òò 
anchoTablero
òò #
=
òò$ %!
tableroRompecabezas
òò& 9
.
òò9 :
ActualWidth
òò: E
;
òòE F
double
ôô 
alturaTablero
ôô $
=
ôô% &!
tableroRompecabezas
ôô' :
.
ôô: ;
ActualHeight
ôô; G
;
ôôG H
double
öö 
	posicionX
öö  
=
öö! "
	aleatorio
öö# ,
.
öö, -

NextDouble
öö- 7
(
öö7 8
)
öö8 9
*
öö: ;
(
õõ 
anchoTablero
õõ !
-
õõ" #
pieza
õõ$ )
.
õõ) *
Imagen
õõ* 0
.
õõ0 1
Width
õõ1 6
)
õõ6 7
;
õõ7 8
double
úú 
	posicionY
úú  
=
úú! "
	aleatorio
úú# ,
.
úú, -

NextDouble
úú- 7
(
úú7 8
)
úú8 9
*
úú: ;
(
ùù 
alturaTablero
ùù "
-
ùù# $
pieza
ùù% *
.
ùù* +
Imagen
ùù+ 1
.
ùù1 2
Height
ùù2 8
)
ùù8 9
;
ùù9 :
Canvas
ûû 
.
ûû 
SetLeft
ûû 
(
ûû 
pieza
ûû $
.
ûû$ %
Borde
ûû% *
,
ûû* +
	posicionX
ûû, 5
)
ûû5 6
;
ûû6 7
Canvas
üü 
.
üü 
SetTop
üü 
(
üü 
pieza
üü #
.
üü# $
Borde
üü$ )
,
üü) *
	posicionY
üü+ 4
)
üü4 5
;
üü5 6!
tableroRompecabezas
†† #
.
††# $
Children
††$ ,
.
††, -
Add
††- 0
(
††0 1
pieza
††1 6
.
††6 7
Borde
††7 <
)
††< =
;
††= >
}
°° 
}
¢¢ 	
private
§§ 
void
§§ <
.SobreponerEnTableroPiezasFaltantesDePosicionar
§§ C
(
§§C D
)
§§D E
{
•• 	
foreach
¶¶ 
(
¶¶ 
Pieza
¶¶ 
pieza
¶¶  
in
¶¶! #
tablero
¶¶$ +
.
¶¶+ ,
Piezas
¶¶, 2
)
¶¶2 3
{
ßß 
if
®® 
(
®® 
!
®® 
pieza
®® 
.
®® 
EstaDentroDeCelda
®® ,
)
®®, -
{
©© !
tableroRompecabezas
™™ '
.
™™' (
Children
™™( 0
.
™™0 1
Remove
™™1 7
(
™™7 8
pieza
™™8 =
.
™™= >
Borde
™™> C
)
™™C D
;
™™D E!
tableroRompecabezas
´´ '
.
´´' (
Children
´´( 0
.
´´0 1
Add
´´1 4
(
´´4 5
pieza
´´5 :
.
´´: ;
Borde
´´; @
)
´´@ A
;
´´A B
}
¨¨ 
}
≠≠ 
}
ÆÆ 	
private
∞∞ 
bool
∞∞ -
EsPosicionValidaParaPiezaActual
∞∞ 4
(
∞∞4 5
double
∞∞5 ;
nuevaPosicionX
∞∞< J
,
∞∞J K
double
±± 
nuevaPosicionY
±± !
)
±±! "
{
≤≤ 	
bool
≥≥ 
esPosicionValida
≥≥ !
=
≥≥" #
false
≥≥$ )
;
≥≥) *
if
µµ 
(
µµ 
(
µµ 
nuevaPosicionX
µµ 
+
µµ  !
piezaActual
µµ" -
.
µµ- .5
'ObtenerDiferenciaAnchoEntreImagenYBorde
µµ. U
(
µµU V
)
µµV W
)
µµW X
>=
µµY [
$num
µµ\ ]
&&
µµ^ `
(
∂∂ 
nuevaPosicionY
∂∂ 
+
∂∂  !
piezaActual
∂∂" -
.
∂∂- .6
(ObtenerDiferenciaAlturaEntreImagenYBorde
∂∂. V
(
∂∂V W
)
∂∂W X
)
∂∂X Y
>=
∂∂Z \
$num
∂∂] ^
&&
∂∂_ a
(
∑∑ 
piezaActual
∑∑ 
.
∑∑ 
Ancho
∑∑ "
+
∑∑# $
nuevaPosicionX
∑∑% 3
<=
∑∑4 6!
tableroRompecabezas
∑∑7 J
.
∑∑J K
ActualWidth
∑∑K V
)
∑∑V W
&&
∑∑X Z
(
∏∏ 
piezaActual
∏∏ 
.
∏∏ 
Alto
∏∏ !
+
∏∏" #
nuevaPosicionY
∏∏$ 2
<=
∏∏3 5!
tableroRompecabezas
∏∏6 I
.
∏∏I J
ActualHeight
∏∏J V
)
∏∏V W
)
∏∏W X
{
ππ 
esPosicionValida
∫∫  
=
∫∫! "
true
∫∫# '
;
∫∫' (
}
ªª 
return
ΩΩ 
esPosicionValida
ΩΩ #
;
ΩΩ# $
}
ææ 	
private
¿¿ 
Pieza
¿¿ ,
BuscarPiezaPertenecienteABorde
¿¿ 4
(
¿¿4 5
Border
¿¿5 ;
borde
¿¿< A
)
¿¿A B
{
¡¡ 	
var
¬¬ 
piezasEncontradas
¬¬ !
=
¬¬" #
tablero
¬¬$ +
.
¬¬+ ,
Piezas
¬¬, 2
.
¬¬2 3
Where
¬¬3 8
(
¬¬8 9
pieza
¬¬9 >
=>
¬¬? A
pieza
¬¬B G
.
¬¬G H
Borde
¬¬H M
.
¬¬M N
Equals
¬¬N T
(
¬¬T U
borde
¬¬U Z
)
¬¬Z [
)
¬¬[ \
;
¬¬\ ]
Pieza
√√ 
piezaEncontrada
√√ !
=
√√" #
new
√√$ '
Pieza
√√( -
(
√√- .
)
√√. /
;
√√/ 0
if
≈≈ 
(
≈≈ 
piezasEncontradas
≈≈ !
.
≈≈! "
Any
≈≈" %
(
≈≈% &
)
≈≈& '
)
≈≈' (
{
∆∆ 
piezaEncontrada
«« 
=
««  !
piezasEncontradas
««" 3
.
««3 4
First
««4 9
(
««9 :
)
««: ;
;
««; <
}
»» 
return
   
piezaEncontrada
   "
;
  " #
}
ÀÀ 	
private
ÕÕ 
Celda
ÕÕ +
BuscarCeldaPertenecienteAArea
ÕÕ 3
(
ÕÕ3 4
	Rectangle
ÕÕ4 =
	areaCelda
ÕÕ> G
)
ÕÕG H
{
ŒŒ 	
var
œœ 
celdasEncontradas
œœ !
=
œœ" #
tablero
œœ$ +
.
œœ+ ,
Celdas
œœ, 2
.
œœ2 3
Where
œœ3 8
(
œœ8 9
celda
œœ9 >
=>
œœ? A
celda
œœB G
.
œœG H
Area
œœH L
.
œœL M
Equals
œœM S
(
œœS T
	areaCelda
œœT ]
)
œœ] ^
)
œœ^ _
;
œœ_ `
Celda
–– 
celdaEncontrada
–– !
=
––" #
new
––$ '
Celda
––( -
(
––- .
)
––. /
;
––/ 0
if
““ 
(
““ 
celdasEncontradas
““ !
.
““! "
Any
““" %
(
““% &
)
““& '
)
““' (
{
”” 
celdaEncontrada
‘‘ 
=
‘‘  !
celdasEncontradas
‘‘" 3
.
‘‘3 4
First
‘‘4 9
(
‘‘9 :
)
‘‘: ;
;
‘‘; <
}
’’ 
return
◊◊ 
celdaEncontrada
◊◊ "
;
◊◊" #
}
ÿÿ 	
private
⁄⁄ 
void
⁄⁄ 3
%PosicionarPiezaEnCeldaCorrespondiente
⁄⁄ :
(
⁄⁄: ;
Point
⁄⁄; @
posicion
⁄⁄A I
)
⁄⁄I J
{
€€ 	
foreach
‹‹ 
(
‹‹ 
	UIElement
‹‹ 
control
‹‹ &
in
‹‹' )!
tableroRompecabezas
‹‹* =
.
‹‹= >
Children
‹‹> F
)
‹‹F G
{
›› 
if
ﬁﬁ 
(
ﬁﬁ 
control
ﬁﬁ 
is
ﬁﬁ 
	Rectangle
ﬁﬁ (
	areaCelda
ﬁﬁ) 2
)
ﬁﬁ2 3
{
ﬂﬂ 
double
‡‡ 
posicionXMinima
‡‡ *
=
‡‡+ ,
Canvas
‡‡- 3
.
‡‡3 4
GetLeft
‡‡4 ;
(
‡‡; <
	areaCelda
‡‡< E
)
‡‡E F
;
‡‡F G
double
·· 
posicionYMinima
·· *
=
··+ ,
Canvas
··- 3
.
··3 4
GetTop
··4 :
(
··: ;
	areaCelda
··; D
)
··D E
;
··E F
double
‚‚ 
posicionXMaxima
‚‚ *
=
‚‚+ ,
posicionXMinima
‚‚- <
+
‚‚= >
	areaCelda
‚‚? H
.
‚‚H I
Width
‚‚I N
;
‚‚N O
double
„„ 
posicionYMaxima
„„ *
=
„„+ ,
posicionYMinima
„„- <
+
„„= >
	areaCelda
„„? H
.
„„H I
Height
„„I O
;
„„O P
if
ÂÂ 
(
ÂÂ 
posicion
ÂÂ  
.
ÂÂ  !
X
ÂÂ! "
>=
ÂÂ# %
posicionXMinima
ÂÂ& 5
&&
ÂÂ6 8
posicion
ÊÊ  
.
ÊÊ  !
X
ÊÊ! "
<=
ÊÊ# %
posicionXMaxima
ÊÊ& 5
&&
ÊÊ6 8
posicion
ÁÁ  
.
ÁÁ  !
Y
ÁÁ! "
>=
ÁÁ# %
posicionYMinima
ÁÁ& 5
&&
ÁÁ6 8
posicion
ËË  
.
ËË  !
Y
ËË! "
<=
ËË# %
posicionYMaxima
ËË& 5
)
ËË5 6
{
ÈÈ 
Celda
ÍÍ 
celda
ÍÍ #
=
ÍÍ$ %+
BuscarCeldaPertenecienteAArea
ÍÍ& C
(
ÍÍC D
	areaCelda
ÍÍD M
)
ÍÍM N
;
ÍÍN O
if
ÏÏ 
(
ÏÏ 
celda
ÏÏ !
.
ÏÏ! "
Fila
ÏÏ" &
==
ÏÏ' )
piezaActual
ÏÏ* 5
.
ÏÏ5 6
FilaCorrecta
ÏÏ6 B
&&
ÏÏC E
celda
ÌÌ !
.
ÌÌ! "
Columna
ÌÌ" )
==
ÌÌ* ,
piezaActual
ÌÌ- 8
.
ÌÌ8 9
ColumnaCorrecta
ÌÌ9 H
)
ÌÌH I
{
ÓÓ 
Canvas
ÔÔ "
.
ÔÔ" #
SetLeft
ÔÔ# *
(
ÔÔ* +
piezaActual
ÔÔ+ 6
.
ÔÔ6 7
Borde
ÔÔ7 <
,
ÔÔ< =
posicionXMinima
ÔÔ> M
)
ÔÔM N
;
ÔÔN O
Canvas
 "
.
" #
SetTop
# )
(
) *
piezaActual
* 5
.
5 6
Borde
6 ;
,
; <
posicionYMinima
= L
)
L M
;
M N
piezaActual
ÒÒ '
.
ÒÒ' (
EstaDentroDeCelda
ÒÒ( 9
=
ÒÒ: ;
true
ÒÒ< @
;
ÒÒ@ A<
.SobreponerEnTableroPiezasFaltantesDePosicionar
ÚÚ J
(
ÚÚJ K
)
ÚÚK L
;
ÚÚL M
break
ÛÛ !
;
ÛÛ! "
}
ÙÙ 
}
ıı 
}
ˆˆ 
}
˜˜ 
}
¯¯ 	
private
˙˙ 
void
˙˙ -
RemoverEventoVentanaDesactivada
˙˙ 4
(
˙˙4 5
)
˙˙5 6
{
˚˚ 	
VentanaPrincipal
¸¸ 
ventanaPrincipal
¸¸ -
=
¸¸. /
(
¸¸0 1
VentanaPrincipal
¸¸1 A
)
¸¸A B
Window
¸¸B H
.
¸¸H I
	GetWindow
¸¸I R
(
¸¸R S
this
¸¸S W
)
¸¸W X
;
¸¸X Y
ventanaPrincipal
˝˝ 
.
˝˝ 
Deactivated
˝˝ (
-=
˝˝) +,
SoltarPiezaAlDesactivarVentana
˝˝, J
;
˝˝J K
}
˛˛ 	
private
ÄÄ 
void
ÄÄ  
CargarDatosPartida
ÄÄ '
(
ÄÄ' (
object
ÄÄ( .
objetoOrigen
ÄÄ/ ;
,
ÄÄ; <
RoutedEventArgs
ÄÄ= L
evento
ÄÄM S
)
ÄÄS T
{
ÅÅ 	
VentanaPrincipal
ÇÇ 
ventanaPrincipal
ÇÇ -
=
ÇÇ. /
(
ÇÇ0 1
VentanaPrincipal
ÇÇ1 A
)
ÇÇA B
Window
ÇÇB H
.
ÇÇH I
	GetWindow
ÇÇI R
(
ÇÇR S
this
ÇÇS W
)
ÇÇW X
;
ÇÇX Y
ventanaPrincipal
ÉÉ 
.
ÉÉ 
Deactivated
ÉÉ (
+=
ÉÉ) +,
SoltarPiezaAlDesactivarVentana
ÉÉ, J
;
ÉÉJ K
CrearTablero
ÑÑ 
(
ÑÑ 
)
ÑÑ 
;
ÑÑ 
}
ÖÖ 	
private
áá 
void
áá ,
SoltarPiezaAlDesactivarVentana
áá 3
(
áá3 4
object
áá4 :
objetoOrigen
áá; G
,
ááG H
	EventArgs
ááI R
evento
ááS Y
)
ááY Z
{
àà 	!
cursorSostienePieza
ââ 
=
ââ  !
false
ââ" '
;
ââ' (
if
ãã 
(
ãã 
piezaActual
ãã 
!=
ãã 
null
ãã #
&&
ãã$ &
!
ãã' (
piezaActual
ãã( 3
.
ãã3 4
EstaDentroDeCelda
ãã4 E
)
ããE F
{
åå 
piezaActual
çç 
.
çç 3
%EstablecerEstiloDePiezaSinSeleccionar
çç A
(
ççA B
)
ççB C
;
ççC D
}
éé 
}
èè 	
private
ëë 
void
ëë $
IrPaginaAjustesPartida
ëë +
(
ëë+ ,
object
ëë, 2
objetoOrigen
ëë3 ?
,
ëë? @"
MouseButtonEventArgs
ëëA U
evento
ëëV \
)
ëë\ ]
{
íí 	
}
îî 	
private
ññ 
void
ññ 
IniciarJuego
ññ !
(
ññ! "
object
ññ" (
objetoOrigen
ññ) 5
,
ññ5 6
RoutedEventArgs
ññ7 F
evento
ññG M
)
ññM N
{
óó 	
botonIniciar
òò 
.
òò 
	IsEnabled
òò "
=
òò# $
false
òò% *
;
òò* +
BitmapImage
ôô "
fuenteImagenOriginal
ôô ,
=
ôô- .

Utilidades
ôô/ 9
.
ôô9 :
GeneradorImagenes
ôô: K
.
ôôK L-
GenerarFuenteImagenRompecabezas
öö /
(
öö/ 0
tablero
öö0 7
.
öö7 8&
NumeroImagenRompecabezas
öö8 P
)
ööP Q
;
ööQ R$
RecortarImagenEnPiezas
õõ "
(
õõ" #"
fuenteImagenOriginal
õõ# 7
)
õõ7 8
;
õõ8 9)
MostrarPiezasAleatoriamente
úú '
(
úú' (
)
úú( )
;
úú) *
}
ùù 	
private
üü 
void
üü 
SeleccionarPieza
üü %
(
üü% &
object
üü& ,
objetoOrigen
üü- 9
,
üü9 :"
MouseButtonEventArgs
üü; O
evento
üüP V
)
üüV W
{
†† 	
piezaActual
°° 
=
°° ,
BuscarPiezaPertenecienteABorde
°° 8
(
°°8 9
(
°°9 :
Border
°°: @
)
°°@ A
objetoOrigen
°°A M
)
°°M N
;
°°N O
if
££ 
(
££ 
!
££ 
piezaActual
££ 
.
££ 
EstaDentroDeCelda
££ .
)
££. /
{
§§ !
tableroRompecabezas
•• #
.
••# $
Children
••$ ,
.
••, -
Remove
••- 3
(
••3 4
piezaActual
••4 ?
.
••? @
Borde
••@ E
)
••E F
;
••F G!
tableroRompecabezas
¶¶ #
.
¶¶# $
Children
¶¶$ ,
.
¶¶, -
Add
¶¶- 0
(
¶¶0 1
piezaActual
¶¶1 <
.
¶¶< =
Borde
¶¶= B
)
¶¶B C
;
¶¶C D
piezaActual
ßß 
.
ßß 1
#EstablecerEstiloDePiezaSeleccionada
ßß ?
(
ßß? @
)
ßß@ A
;
ßßA B#
posicionInicialCursor
®® %
=
®®& '
evento
®®( .
.
®®. /
GetPosition
®®/ :
(
®®: ;!
tableroRompecabezas
®®; N
)
®®N O
;
®®O P
piezaActual
©© 
.
©© 
Borde
©© !
.
©©! "
CaptureMouse
©©" .
(
©©. /
)
©©/ 0
;
©©0 1!
cursorSostienePieza
™™ #
=
™™$ %
true
™™& *
;
™™* +
}
´´ 
}
¨¨ 	
private
ÆÆ 
void
ÆÆ 

MoverPieza
ÆÆ 
(
ÆÆ  
object
ÆÆ  &
objetoOrigen
ÆÆ' 3
,
ÆÆ3 4
MouseEventArgs
ÆÆ5 C
evento
ÆÆD J
)
ÆÆJ K
{
ØØ 	
if
∞∞ 
(
∞∞ !
cursorSostienePieza
∞∞ #
)
∞∞# $
{
±± 
piezaActual
≤≤ 
=
≤≤ ,
BuscarPiezaPertenecienteABorde
≤≤ <
(
≤≤< =
(
≤≤= >
Border
≤≤> D
)
≤≤D E
objetoOrigen
≤≤E Q
)
≤≤Q R
;
≤≤R S
Point
≥≥ "
posicionActualCursor
≥≥ *
=
≥≥+ ,
evento
≥≥- 3
.
≥≥3 4
GetPosition
≥≥4 ?
(
≥≥? @!
tableroRompecabezas
≥≥@ S
)
≥≥S T
;
≥≥T U
double
¥¥ !
diferenciaPosicionX
¥¥ *
=
¥¥+ ,"
posicionActualCursor
¥¥- A
.
¥¥A B
X
¥¥B C
-
¥¥D E#
posicionInicialCursor
¥¥F [
.
¥¥[ \
X
¥¥\ ]
;
¥¥] ^
double
µµ !
diferenciaPosicionY
µµ *
=
µµ+ ,"
posicionActualCursor
µµ- A
.
µµA B
Y
µµB C
-
µµD E#
posicionInicialCursor
µµF [
.
µµ[ \
Y
µµ\ ]
;
µµ] ^
double
∂∂ 
nuevaPosicionX
∂∂ %
=
∂∂& '
Canvas
∂∂( .
.
∂∂. /
GetLeft
∂∂/ 6
(
∂∂6 7
piezaActual
∂∂7 B
.
∂∂B C
Borde
∂∂C H
)
∂∂H I
+
∂∂J K!
diferenciaPosicionX
∂∂L _
;
∂∂_ `
double
∑∑ 
nuevaPosicionY
∑∑ %
=
∑∑& '
Canvas
∑∑( .
.
∑∑. /
GetTop
∑∑/ 5
(
∑∑5 6
piezaActual
∑∑6 A
.
∑∑A B
Borde
∑∑B G
)
∑∑G H
+
∑∑I J!
diferenciaPosicionY
∑∑K ^
;
∑∑^ _
if
ππ 
(
ππ -
EsPosicionValidaParaPiezaActual
ππ 3
(
ππ3 4
nuevaPosicionX
ππ4 B
,
ππB C
nuevaPosicionY
ππD R
)
ππR S
)
ππS T
{
∫∫ 
Canvas
ªª 
.
ªª 
SetLeft
ªª "
(
ªª" #
piezaActual
ªª# .
.
ªª. /
Borde
ªª/ 4
,
ªª4 5
Canvas
ºº 
.
ºº 
GetLeft
ºº &
(
ºº& '
piezaActual
ºº' 2
.
ºº2 3
Borde
ºº3 8
)
ºº8 9
+
ºº: ;!
diferenciaPosicionX
ºº< O
)
ººO P
;
ººP Q
Canvas
ΩΩ 
.
ΩΩ 
SetTop
ΩΩ !
(
ΩΩ! "
piezaActual
ΩΩ" -
.
ΩΩ- .
Borde
ΩΩ. 3
,
ΩΩ3 4
Canvas
ææ 
.
ææ 
GetTop
ææ %
(
ææ% &
piezaActual
ææ& 1
.
ææ1 2
Borde
ææ2 7
)
ææ7 8
+
ææ9 :!
diferenciaPosicionY
ææ; N
)
ææN O
;
ææO P#
posicionInicialCursor
øø )
=
øø* +"
posicionActualCursor
øø, @
;
øø@ A
}
¿¿ 
}
¡¡ 
}
¬¬ 	
private
ƒƒ 
void
ƒƒ 
SoltarPieza
ƒƒ  
(
ƒƒ  !
object
ƒƒ! '
objetoOrigen
ƒƒ( 4
,
ƒƒ4 5"
MouseButtonEventArgs
ƒƒ6 J
evento
ƒƒK Q
)
ƒƒQ R
{
≈≈ 	
if
∆∆ 
(
∆∆ !
cursorSostienePieza
∆∆ #
)
∆∆# $
{
«« 
piezaActual
»» 
.
»» 
Borde
»» !
.
»»! "!
ReleaseMouseCapture
»»" 5
(
»»5 6
)
»»6 7
;
»»7 8!
cursorSostienePieza
…… #
=
……$ %
false
……& +
;
……+ ,
piezaActual
   
=
   ,
BuscarPiezaPertenecienteABorde
   <
(
  < =
(
  = >
Border
  > D
)
  D E
objetoOrigen
  E Q
)
  Q R
;
  R S
piezaActual
ÀÀ 
.
ÀÀ 
Borde
ÀÀ !
.
ÀÀ! "
BorderBrush
ÀÀ" -
=
ÀÀ. /
Brushes
ÀÀ0 7
.
ÀÀ7 8
Transparent
ÀÀ8 C
;
ÀÀC D
Point
ÃÃ 
posicionActual
ÃÃ $
=
ÃÃ% &
evento
ÃÃ' -
.
ÃÃ- .
GetPosition
ÃÃ. 9
(
ÃÃ9 :!
tableroRompecabezas
ÃÃ: M
)
ÃÃM N
;
ÃÃN O
piezaActual
ÕÕ 
.
ÕÕ 3
%EstablecerEstiloDePiezaSinSeleccionar
ÕÕ A
(
ÕÕA B
)
ÕÕB C
;
ÕÕC D3
%PosicionarPiezaEnCeldaCorrespondiente
ŒŒ 5
(
ŒŒ5 6
posicionActual
ŒŒ6 D
)
ŒŒD E
;
ŒŒE F
if
œœ 
(
œœ 
tablero
œœ 
.
œœ &
EsRompecabezasCompletado
œœ 4
(
œœ4 5
)
œœ5 6
)
œœ6 7
{
–– 

MessageBox
—— 
.
—— 
Show
—— #
(
——# $

Properties
——$ .
.
——. /
	Resources
——/ 8
.
——8 9.
 ETIQUETA_PARTIDA_JUEGOFINALIZADO
——9 Y
)
——Y Z
;
——Z [-
RemoverEventoVentanaDesactivada
““ 3
(
““3 4
)
““4 5
;
““5 6
VentanaPrincipal
”” $
.
””$ %
CambiarPagina
””% 2
(
””2 3
new
””3 6
PaginaResultados
””7 G
(
””G H
)
””H I
)
””I J
;
””J K
}
‘‘ 
}
’’ 
}
÷÷ 	
public
ÿÿ 
void
ÿÿ ,
ActualizarNuevaPosicionDePieza
ÿÿ 2
(
ÿÿ2 3
double
ÿÿ3 9
	posicionX
ÿÿ: C
,
ÿÿC D
double
ÿÿE K
	posicionY
ÿÿL U
)
ÿÿU V
{
ŸŸ 	
throw
⁄⁄ 
new
⁄⁄ %
NotImplementedException
⁄⁄ -
(
⁄⁄- .
)
⁄⁄. /
;
⁄⁄/ 0
}
€€ 	
}
‹‹ 
}›› É
~C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRecuperacionContrasena.xaml.cs
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
}11 —o
wC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRegistroJugador.xaml.cs
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
}ØØ £
rC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaResultados.xaml.cs
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
public		 
PaginaResultados		 
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
void 
IrAPaginaSala "
(" #
object# )
objetoOrigen* 6
,6 7
RoutedEventArgs8 G
eventoH N
)N O
{ 	

PaginaSala 

paginaSala !
=" #
new$ '

PaginaSala( 2
(2 3
)3 4
;4 5
VentanaPrincipal 
. 
CambiarPagina *
(* +

paginaSala+ 5
)5 6
;6 7
} 	
} 
} ⁄&
ÇC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaRestablecimientoContrasena.xaml.cs
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
}GG üâ
lC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaSala.xaml.cs
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
private 
ServicioSalaClient " 
clienteServicioJuego# 7
;7 8
public 
string 

CodigoSala  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 
EsAnfitrion 
{  !
get" %
;% &
set' *
;* +
}, -
public  
ObservableCollection #
<# $
Dominio$ +
.+ ,
CuentaJugador, 9
>9 :
JugadoresEnSala; J
{K L
getM P
;P Q
setR U
;U V
}W X
public 

PaginaSala 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
JugadoresEnSala 
= 
new ! 
ObservableCollection" 6
<6 7
Dominio7 >
.> ?
CuentaJugador? L
>L M
(M N
)N O
;O P
listaJugadoresSala 
. 
DataContext *
=+ ,
this- 1
;1 2
} 	
private 
void "
IrAPaginaMenuPrincipal +
(+ ,
object, 2
objetoOrigen3 ?
,? @ 
MouseButtonEventArgsA U
eventoV \
)\ ]
{   	$
FinalizarConexionConSala!! $
(!!$ %
)!!% &
;!!& '
VentanaPrincipal"" 
."" 
CambiarPagina"" *
(""* +
new""+ .
PaginaMenuPrincipal""/ B
(""B C
)""C D
)""D E
;""E F
}## 	
private%% 
void%% ,
 CopiarCodigoDeSalaEnPortapapeles%% 5
(%%5 6
object%%6 <
objetoOrigen%%= I
,%%I J
RoutedEventArgs&& 
evento&& "
)&&" #
{'' 	
	Clipboard(( 
.(( 
SetText(( 
((( 

CodigoSala(( (
)((( )
;(() *
})) 	
private++ 
void++ %
EnviarMensajeEnChatDeSala++ .
(++. /
object++/ 5
objetoOrigen++6 B
,++B C
RoutedEventArgs++D S
evento++T Z
)++Z [
{,, 	
if-- 
(-- 
!-- 
ValidadorDatos-- 
.--  
EsCadenaVacia--  -
(--- .%
cuadroTextoMensajeUsuario--. G
.--G H
Text--H L
.--L M
Trim--M Q
(--Q R
)--R S
)--S T
)--T U
{..  
clienteServicioJuego// $
.//$ %
EnviarMensajeDeSala//% 8
(//8 9
Dominio//9 @
.//@ A
CuentaJugador//A N
.//N O
Actual00 
.00 
NombreJugador00 (
,00( )

CodigoSala00* 4
,004 5%
cuadroTextoMensajeUsuario006 O
.00O P
Text00P T
)00T U
;00U V%
cuadroTextoMensajeUsuario11 )
.11) *
Clear11* /
(11/ 0
)110 1
;111 2
}22 
}33 	
private55 
void55 )
IrAPaginaCreacionNuevaPartida55 2
(552 3
object553 9
objetoOrigen55: F
,55F G
RoutedEventArgs55H W
evento55X ^
)55^ _
{66 	&
PaginaCreacionNuevaPartida77 &&
paginaCreacionNuevaPartida77' A
=77B C
new88 &
PaginaCreacionNuevaPartida88 .
(88. /
)88/ 0
;880 1&
paginaCreacionNuevaPartida99 &
.99& '

CodigoSala99' 1
=992 3

CodigoSala994 >
;99> ?
VentanaPrincipal:: 
.:: 
CambiarPagina:: *
(::* +&
paginaCreacionNuevaPartida::+ E
)::E F
;::F G
};; 	
public== 
void== 
UnirseASala== 
(==  
)==  !
{>> 	 
clienteServicioJuego??  
=??! "
new??# &
ServicioSalaClient??' 9
(??9 :
new??: =
InstanceContext??> M
(??M N
this??N R
)??R S
)??S T
;??T U
ifAA 
(AA 
EsAnfitrionAA 
)AA 
{BB 
botonNuevaPartidaCC !
.CC! "

VisibilityCC" ,
=CC- .

VisibilityCC/ 9
.CC9 :
VisibleCC: A
;CCA B
CrearNuevaSalaDD 
(DD 
)DD  
;DD  !
}EE 
elseFF 
{GG 
botonNuevaPartidaHH !
.HH! "

VisibilityHH" ,
=HH- .

VisibilityHH/ 9
.HH9 :
HiddenHH: @
;HH@ A!
CargarJugadoresEnSalaII %
(II% &
)II& '
;II' (
}JJ 
etiquetaCodigoSalaLL 
.LL 
ContentLL &
=LL' (

CodigoSalaLL) 3
;LL3 4&
ConectarCuentaJugadorASalaMM &
(MM& '
DominioMM' .
.MM. /
CuentaJugadorMM/ <
.MM< =
ActualMM= C
.MMC D
NombreJugadorMMD Q
)MMQ R
;MMR S
JugadoresEnSalaNN 
.NN 
AddNN 
(NN  
DominioNN  '
.NN' (
CuentaJugadorNN( 5
.NN5 6
ActualNN6 <
)NN< =
;NN= >
}OO 	
privateQQ 
voidQQ &
ConectarCuentaJugadorASalaQQ /
(QQ/ 0
stringQQ0 6
nombreJugadorQQ7 D
)QQD E
{RR 	
trySS 
{TT  
clienteServicioJuegoUU $
.UU$ %&
ConectarCuentaJugadorASalaUU% ?
(UU? @
nombreJugadorUU@ M
,UUM N

CodigoSalaVV 
,VV 

PropertiesVV  *
.VV* +
	ResourcesVV+ 4
.VV4 5+
ETIQUETA_MENSAJESALA_BIENVENIDAVV5 T
)VVT U
;VVU V
}WW 
catchXX 
(XX %
EndpointNotFoundExceptionXX ,
	excepcionXX- 6
)XX6 7
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
;^^? @ 
clienteServicioJuego__ $
.__$ %
Abort__% *
(__* +
)__+ ,
;__, -
}`` 
catchaa 
(aa /
#CommunicationObjectFaultedExceptionaa 6
	excepcionaa7 @
)aa@ A
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
;gg? @ 
clienteServicioJuegohh $
.hh$ %
Aborthh% *
(hh* +
)hh+ ,
;hh, -
}ii 
catchjj 
(jj 
TimeoutExceptionjj #
	excepcionjj$ -
)jj- .
{kk 

MessageBoxmm 
.mm 
Showmm 
(mm  

Propertiesmm  *
.mm* +
	Resourcesmm+ 4
.mm4 52
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJEnn :
,nn: ;

Propertiesnn< F
.nnF G
	ResourcesnnG P
.nnP Q1
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULOoo 9
,oo9 :
MessageBoxButtonpp $
.pp$ %
OKpp% '
,pp' (
MessageBoxImagepp) 8
.pp8 9
Errorpp9 >
)pp> ?
;pp? @ 
clienteServicioJuegoqq $
.qq$ %
Abortqq% *
(qq* +
)qq+ ,
;qq, -
}rr 
}ss 	
privateuu 
voiduu !
CargarJugadoresEnSalauu *
(uu* +
)uu+ ,
{vv 	
CuentaJugadorww 
[ww 
]ww  
jugadoresRecuperadosww 0
=ww1 2
	Serviciosww3 <
.ww< =
ServicioSalaww= I
.wwI J,
 ObtenerJugadoresConectadosEnSalaxx 0
(xx0 1

CodigoSalaxx1 ;
)xx; <
;xx< =
foreachzz 
(zz 
CuentaJugadorzz "
jugadorzz# *
inzz+ - 
jugadoresRecuperadoszz. B
)zzB C
{{{ 
JugadoresEnSala|| 
.||  
Add||  #
(||# $
new||$ '
Dominio||( /
.||/ 0
CuentaJugador||0 =
{}} 
NombreJugador~~ !
=~~" #
jugador~~$ +
.~~+ ,
NombreJugador~~, 9
,~~9 :
FuenteImagenAvatar &
=' (

Utilidades) 3
.3 4
GeneradorImagenes4 E
.E F'
GenerarFuenteImagenAvatar
ÄÄ 1
(
ÄÄ1 2
jugador
ÄÄ2 9
.
ÄÄ9 :
NumeroAvatar
ÄÄ: F
)
ÄÄF G
}
ÅÅ 
)
ÅÅ 
;
ÅÅ 
}
ÇÇ 
}
ÉÉ 	
private
ÖÖ 
void
ÖÖ 
CrearNuevaSala
ÖÖ #
(
ÖÖ# $
)
ÖÖ$ %
{
ÜÜ 	

CodigoSala
áá 
=
áá 
	Servicios
áá "
.
áá" #
ServicioSala
áá# /
.
áá/ 0(
GenerarCodigoParaNuevaSala
áá0 J
(
ááJ K
)
ááK L
;
ááL M
if
ââ 
(
ââ 

CodigoSala
ââ 
!=
ââ 
null
ââ "
)
ââ" #
{
ää 
	Servicios
ãã 
.
ãã 
ServicioSala
ãã &
.
ãã& '
CrearNuevaSala
ãã' 5
(
ãã5 6
Dominio
ãã6 =
.
ãã= >
CuentaJugador
ãã> K
.
ããK L
Actual
åå 
.
åå 
NombreJugador
åå (
,
åå( )

CodigoSala
åå* 4
)
åå4 5
;
åå5 6
}
çç 
}
éé 	
private
êê 
void
êê &
FinalizarConexionConSala
êê -
(
êê- .
)
êê. /
{
ëë 	
try
íí 
{
ìì "
clienteServicioJuego
îî $
.
îî$ %,
DesconectarCuentaJugadorDeSala
îî% C
(
îîC D
Dominio
îîD K
.
îîK L
CuentaJugador
ïï !
.
ïï! "
Actual
ïï" (
.
ïï( )
NombreJugador
ïï) 6
,
ïï6 7

CodigoSala
ïï8 B
,
ïïB C

Properties
ññ 
.
ññ 
	Resources
ññ (
.
ññ( ),
ETIQUETA_MENSAJESALA_DESPEDIDA
ññ) G
)
ññG H
;
ññH I"
clienteServicioJuego
óó $
.
óó$ %
Close
óó% *
(
óó* +
)
óó+ ,
;
óó, -
}
òò 
catch
ôô 
(
ôô '
EndpointNotFoundException
ôô ,
	excepcion
ôô- 6
)
ôô6 7
{
öö 

MessageBox
úú 
.
úú 
Show
úú 
(
úú  

Properties
úú  *
.
úú* +
	Resources
úú+ 4
.
úú4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ùù :
,
ùù: ;

Properties
ùù< F
.
ùùF G
	Resources
ùùG P
.
ùùP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ûû 9
,
ûû9 :
MessageBoxButton
üü $
.
üü$ %
OK
üü% '
,
üü' (
MessageBoxImage
üü) 8
.
üü8 9
Error
üü9 >
)
üü> ?
;
üü? @"
clienteServicioJuego
†† $
.
††$ %
Abort
††% *
(
††* +
)
††+ ,
;
††, -
}
°° 
catch
¢¢ 
(
¢¢ 1
#CommunicationObjectFaultedException
¢¢ 6
	excepcion
¢¢7 @
)
¢¢@ A
{
££ 

MessageBox
•• 
.
•• 
Show
•• 
(
••  

Properties
••  *
.
••* +
	Resources
••+ 4
.
••4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
¶¶ :
,
¶¶: ;

Properties
¶¶< F
.
¶¶F G
	Resources
¶¶G P
.
¶¶P Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
ßß 9
,
ßß9 :
MessageBoxButton
®® $
.
®®$ %
OK
®®% '
,
®®' (
MessageBoxImage
®®) 8
.
®®8 9
Error
®®9 >
)
®®> ?
;
®®? @"
clienteServicioJuego
©© $
.
©©$ %
Abort
©©% *
(
©©* +
)
©©+ ,
;
©©, -
}
™™ 
catch
´´ 
(
´´ 
TimeoutException
´´ #
	excepcion
´´$ -
)
´´- .
{
¨¨ 

MessageBox
ÆÆ 
.
ÆÆ 
Show
ÆÆ 
(
ÆÆ  

Properties
ÆÆ  *
.
ÆÆ* +
	Resources
ÆÆ+ 4
.
ÆÆ4 54
&ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE
ØØ :
,
ØØ: ;

Properties
ØØ< F
.
ØØF G
	Resources
ØØG P
.
ØØP Q3
%ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO
∞∞ 9
,
∞∞9 :
MessageBoxButton
±± $
.
±±$ %
OK
±±% '
,
±±' (
MessageBoxImage
±±) 8
.
±±8 9
Error
±±9 >
)
±±> ?
;
±±? @"
clienteServicioJuego
≤≤ $
.
≤≤$ %
Abort
≤≤% *
(
≤≤* +
)
≤≤+ ,
;
≤≤, -
}
≥≥ "
clienteServicioJuego
µµ  
=
µµ! "
null
µµ# '
;
µµ' (
}
∂∂ 	
private
∏∏ 
void
∏∏ &
ModificarJugadoresEnSala
∏∏ -
(
∏∏- .
object
∏∏. 4
objetoOrigen
∏∏5 A
,
∏∏A B"
MouseButtonEventArgs
ππ  
evento
ππ! '
)
ππ' (
{
∫∫ 	
}
ºº 	
public
øø 
void
øø "
MostrarMensajeDeSala
øø (
(
øø( )
string
øø) /
mensaje
øø0 7
)
øø7 8
{
¿¿ 	!
cuadroTextoMensajes
¡¡ 
.
¡¡  

AppendText
¡¡  *
(
¡¡* +
mensaje
¡¡+ 2
+
¡¡3 4
$str
¡¡5 9
)
¡¡9 :
;
¡¡: ;
}
¬¬ 	
public
ƒƒ 
void
ƒƒ 2
$NotificarNuevoJugadorConectadoEnSala
ƒƒ 8
(
ƒƒ8 9
CuentaJugador
ƒƒ9 F
nuevoJugador
ƒƒG S
)
ƒƒS T
{
≈≈ 	
if
∆∆ 
(
∆∆ 
JugadoresEnSala
∆∆ 
!=
∆∆  "
null
∆∆# '
)
∆∆' (
{
«« 
Dominio
»» 
.
»» 
CuentaJugador
»» % 
nuevaCuentaJugador
»»& 8
=
»»9 :
new
»»; >
Dominio
»»? F
.
»»F G
CuentaJugador
»»G T
{
……  
FuenteImagenAvatar
   &
=
  ' (

Utilidades
  ) 3
.
  3 4
GeneradorImagenes
  4 E
.
  E F'
GenerarFuenteImagenAvatar
ÀÀ 1
(
ÀÀ1 2
nuevoJugador
ÀÀ2 >
.
ÀÀ> ?
NumeroAvatar
ÀÀ? K
)
ÀÀK L
,
ÀÀL M
NombreJugador
ÃÃ !
=
ÃÃ" #
nuevoJugador
ÃÃ$ 0
.
ÃÃ0 1
NombreJugador
ÃÃ1 >
}
ÕÕ 
;
ÕÕ 
JugadoresEnSala
ŒŒ 
.
ŒŒ  
Add
ŒŒ  #
(
ŒŒ# $ 
nuevaCuentaJugador
ŒŒ$ 6
)
ŒŒ6 7
;
ŒŒ7 8
}
œœ 
}
–– 	
public
““ 
void
““ 0
"NotificarJugadorDesconectadoDeSala
““ 6
(
““6 7
string
““7 =
nombreJugador
““> K
)
““K L
{
”” 	
if
‘‘ 
(
‘‘ 
JugadoresEnSala
‘‘ 
!=
‘‘  "
null
‘‘# '
)
‘‘' (
{
’’ 
Dominio
÷÷ 
.
÷÷ 
CuentaJugador
÷÷ %%
cuentaJugadorEncontrada
÷÷& =
=
÷÷> ?
JugadoresEnSala
◊◊ #
.
◊◊# $
FirstOrDefault
◊◊$ 2
(
◊◊2 3
jugador
◊◊3 :
=>
◊◊; =
jugador
◊◊> E
.
◊◊E F
NombreJugador
◊◊F S
==
◊◊T V
nombreJugador
ÿÿ !
)
ÿÿ! "
;
ÿÿ" #
if
⁄⁄ 
(
⁄⁄ %
cuentaJugadorEncontrada
⁄⁄ +
!=
⁄⁄, .
null
⁄⁄/ 3
)
⁄⁄3 4
{
€€ 
JugadoresEnSala
‹‹ #
.
‹‹# $
Remove
‹‹$ *
(
‹‹* +%
cuentaJugadorEncontrada
‹‹+ B
)
‹‹B C
;
‹‹C D
}
›› 
}
ﬁﬁ 
}
ﬂﬂ 	
}
·· 
}‚‚ ú*
wC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaSeleccionAvatar.xaml.cs
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
(55 
VentanaPrincipal55  
.55  !
PaginaAnterior55! /
is550 2!
PaginaRegistroJugador553 H
)55H I
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
}CC í:
|C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaCreacionNuevaPartida.xaml.cs
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
private 
Border #
bordeImagenSeleccionada .
;. /
private 

Dificultad 

dificultad %
;% &
private 
int 
numeroImagen  
;  !
private 
const 
int 
TotalImagenes '
=( )
$num* ,
;, -
public  
ObservableCollection #
<# $
ImagenRompecabezas$ 6
>6 7 
ImagenesRompecabezas8 L
{M N
getO R
;R S
setT W
;W X
}Y Z
public 
string 

CodigoSala  
{! "
get# &
;& '
set( +
;+ ,
}- .
public &
PaginaCreacionNuevaPartida )
() *
)* +
{ 	
InitializeComponent 
(  
)  !
;! ")
MostrarImagenesDeRompecabezas )
() *
)* +
;+ ,

dificultad 
= 

Dificultad #
.# $
Facil$ )
;) *%
cuadroSeleccionDificultad %
.% &
SelectedIndex& 3
=4 5
(6 7
int7 :
): ;

dificultad; E
;E F
numeroImagen 
= 
$num 
; '
galeriaImagenesRompecabezas '
.' (
DataContext( 3
=4 5
this6 :
;: ;
} 	
private 
void )
MostrarImagenesDeRompecabezas 2
(2 3
)3 4
{   	 
ImagenesRompecabezas!!  
=!!! "
new!!# & 
ObservableCollection!!' ;
<!!; <
ImagenRompecabezas!!< N
>!!N O
(!!O P
)!!P Q
;!!Q R
for## 
(## 
int## 
indiceImagen## !
=##" #
$num##$ %
;##% &
indiceImagen##' 3
<=##4 6
TotalImagenes##7 D
;##D E
indiceImagen##G S
++##S U
)##U V
{$$  
ImagenesRompecabezas%% $
.%%$ %
Add%%% (
(%%( )
new%%) ,
ImagenRompecabezas%%- ?
{&& 
Ruta'' 
='' 
$"'' 
$str'' 5
{''5 6
indiceImagen''6 B
}''B C
$str''C G
"''G H
,''H I
NumeroImagen((  
=((! "
indiceImagen((# /
})) 
))) 
;)) 
}** 
}++ 	
private-- 
void-- '
MostrarPreseleccionDeImagen-- 0
(--0 1
object--1 7
objetoOrigen--8 D
,--D E
MouseEventArgs--F T
evento--U [
)--[ \
{.. 	
Border// 
borde// 
=// 
objetoOrigen// '
as//( *
Border//+ 1
;//1 2
if11 
(11 
borde11 
!=11 #
bordeImagenSeleccionada11 0
)110 1
{22 
borde33 
.33 
BorderBrush33 !
=33" #
new33$ '
SolidColorBrush33( 7
(337 8
Colors338 >
.33> ?
Red33? B
)33B C
;33C D
}44 
}55 	
private77 
void77 '
OcultarPreseleccionDeImagen77 0
(770 1
object771 7
objetoOrigen778 D
,77D E
MouseEventArgs77F T
evento77U [
)77[ \
{88 	
Border99 
borde99 
=99 
objetoOrigen99 '
as99( *
Border99+ 1
;991 2
if;; 
(;; 
borde;; 
!=;; #
bordeImagenSeleccionada;; 0
);;0 1
{<< 
ImagenRompecabezas== "
imagen==# )
===* +
borde==, 1
.==1 2
DataContext==2 =
as==> @
ImagenRompecabezas==A S
;==S T
borde>> 
.>> 
BorderBrush>> !
=>>" #
new>>$ '
SolidColorBrush>>( 7
(>>7 8
imagen>>8 >
.>>> ?
ColorDeBorde>>? K
)>>K L
;>>L M
}?? 
}@@ 	
privateBB 
voidBB 
SeleccionarImagenBB &
(BB& '
objectBB' -
objetoOrigenBB. :
,BB: ; 
MouseButtonEventArgsBB< P
eventoBBQ W
)BBW X
{CC 	
BorderDD 
bordeDD 
=DD 
objetoOrigenDD '
asDD( *
BorderDD+ 1
;DD1 2
ifFF 
(FF #
bordeImagenSeleccionadaFF '
!=FF( *
nullFF+ /
)FF/ 0
{GG #
bordeImagenSeleccionadaHH '
.HH' (
BorderBrushHH( 3
=HH4 5
newHH6 9
SolidColorBrushHH: I
(HHI J
ColorsHHJ P
.HHP Q
TransparentHHQ \
)HH\ ]
;HH] ^
}II 
ImagenRompecabezasKK 
imagenKK %
=KK& '
bordeKK( -
.KK- .
DataContextKK. 9
asKK: <
ImagenRompecabezasKK= O
;KKO P
numeroImagenLL 
=LL 
imagenLL !
.LL! "
NumeroImagenLL" .
;LL. /#
bordeImagenSeleccionadaMM #
=MM$ %
bordeMM& +
;MM+ ,
bordeNN 
.NN 
BorderBrushNN 
=NN 
newNN  #
SolidColorBrushNN$ 3
(NN3 4
ColorsNN4 :
.NN: ;
GreenNN; @
)NN@ A
;NNA B
}OO 	
privateQQ 
voidQQ 
IrAPaginaSalaQQ "
(QQ" #
objectQQ# )
objetoOrigenQQ* 6
,QQ6 7 
MouseButtonEventArgsQQ8 L
eventoQQM S
)QQS T
{RR 	
VentanaPrincipalSS 
.SS 
CambiarPaginaSS *
(SS* +
newSS+ .

PaginaSalaSS/ 9
(SS9 :
)SS: ;
)SS; <
;SS< =
}XX 	
privateZZ 
voidZZ !
SeleccionarDificultadZZ *
(ZZ* +
objectZZ+ 1
controlOrigenZZ2 ?
,ZZ? @%
SelectionChangedEventArgs[[ %
evento[[& ,
)[[, -
{\\ 	

dificultad]] 
=]] 
(]] 

Dificultad]] $
)]]$ %%
cuadroSeleccionDificultad]]% >
.]]> ?
SelectedIndex]]? L
;]]L M
}^^ 	
private`` 
void`` 
IrAPaginaPartida`` %
(``% &
object``& ,
objetoOrigen``- 9
,``9 :
RoutedEventArgs``; J
evento``K Q
)``Q R
{aa 	
VentanaPrincipalbb 
.bb 
CambiarPaginabb *
(bb* +
newbb+ .
PaginaPartidabb/ <
(bb< =

dificultadbb= G
,bbG H
numeroImagenbbI U
)bbU V
)bbV W
;bbW X
}cc 	
}dd 
}ee ÿ
rC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaUnirseSala.xaml.cs
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
}!! èX
zC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\PaginaVerificacionCorreo.xaml.cs
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
;> ?
private 
Temporizador 
temporizador )
;) *
public $
PaginaVerificacionCorreo '
(' (
Dominio( /
./ 0
CuentaJugador0 =
jugadorRegistro> M
)M N
{ 	
InitializeComponent 
(  
)  !
;! "
this 
. 
jugadorRegistro  
=! "
jugadorRegistro# 2
;2 3#
GestionadorCodigoCorreo #
.# $2
&EnviarNuevoCodigoDeVerificacionACorreo$ J
(J K
jugadorRegistro 
.  
Correo  &
,& '

Properties( 2
.2 3
	Resources3 <
.< =.
"ETIQUETA_VERIFICACIONCORREO_ASUNTO= _
,_ `

Properties 
. 
	Resources $
.$ %/
#ETIQUETA_VERIFICACIONCORREO_MENSAJE% H
+I J
$strK N
+O P#
GestionadorCodigoCorreo '
.' (
CodigoGenerado( 6
)6 7
;7 8
IniciarTemporizador 
(  
)  !
;! "
} 	
private 
void 
IniciarTemporizador (
(( )
)) *
{ 	(
DeshabilitarBotonEnvioCodigo (
(( )
)) *
;* +
temporizador   
=   
new   
Temporizador   +
(  + ,
)  , -
;  - .
temporizador!! 
.!! 
temporizador!! %
.!!% &
Tick!!& *
+=!!+ -$
ActualizarTiempoRestante!!. F
;!!F G
temporizador"" 
."" 
IniciarTemporizador"" ,
("", -
)""- .
;"". /
}## 	
public%% 
void%% $
ActualizarTiempoRestante%% ,
(%%, -
object%%- 3
objetoOrigen%%4 @
,%%@ A
	EventArgs%%B K
evento%%L R
)%%R S
{&& 	
if'' 
('' 
temporizador'' 
.'' 
segundosRestantes'' .
>''/ 0
Temporizador''1 =
.''= >#
MinimoSegundosRestantes''> U
)''U V
{(( 
temporizador)) 
.)) 
segundosRestantes)) .
--)). 0
;))0 1
TimeSpan** 
tiempoRestante** '
=**( )
TimeSpan*** 2
.**2 3
FromSeconds**3 >
(**> ?
temporizador**? K
.**K L
segundosRestantes**L ]
)**] ^
;**^ _"
etiquetaTiempoRestante++ &
.++& '
Content++' .
=++/ 0
$"++1 3
{++3 4
tiempoRestante++4 B
.++B C
Minutes++C J
:++J K
$str++K M
}++M N
$str++N O
"++O P
+++Q R
$",, 
{,, 
tiempoRestante,, %
.,,% &
Seconds,,& -
:,,- .
$str,,. 0
},,0 1
",,1 2
;,,2 3
}-- 
else.. 
{// 
temporizador00 
.00 
DetenerTemporizador00 0
(000 1
)001 2
;002 3"
etiquetaTiempoRestante11 &
.11& '
Content11' .
=11/ 0
$str111 8
;118 9%
HabilitarBotonEnvioCodigo22 )
(22) *
)22* +
;22+ ,
}33 
}44 	
private66 
void66 *
ConcluirRegistroDeNuevoJugador66 3
(663 4
object664 :
objetoOrigen66; G
,66G H
RoutedEventArgs77 
evento77 "
)77" #
{88 	
string99 
codigoVerificacion99 %
=99& ')
cuadroTextoCodigoVerificacion99( E
.99E F
Text99F J
;99J K
if;; 
(;; 
!;; 
ValidadorDatos;; 
.;;  
EsCadenaVacia;;  -
(;;- .
codigoVerificacion;;. @
);;@ A
);;A B
{<< 
bool== )
esElMismoCodigoDeVerificacion== 2
===3 4
ValidadorDatos==5 C
.==C D'
ExisteCoincidenciaEnCadenas>> /
(>>/ 0
codigoVerificacion>>0 B
,>>B C#
GestionadorCodigoCorreo?? +
.??+ ,
CodigoGenerado??, :
)??: ;
;??; <
ifAA 
(AA )
esElMismoCodigoDeVerificacionAA 1
)AA1 2
{BB 
stringCC 
contrasenaCifradaCC ,
=CC- .!
EncriptadorContrasenaCC/ D
.CCD E
CalcularHashSha512CCE W
(CCW X
jugadorRegistroDD '
.DD' (

ContrasenaDD( 2
)DD2 3
;DD3 4
CuentaJugadorEE !
nuevoJugadorEE" .
=EE/ 0
newEE1 4
CuentaJugadorEE5 B
{FF 
NombreJugadorGG %
=GG& '
jugadorRegistroGG( 7
.GG7 8
NombreJugadorGG8 E
,GGE F
NumeroAvatarHH $
=HH% &
jugadorRegistroHH' 6
.HH6 7
NumeroAvatarHH7 C
,HHC D

ContrasenaII "
=II# $
contrasenaCifradaII% 6
,II6 7
CorreoJJ 
=JJ  
jugadorRegistroJJ! 0
.JJ0 1
CorreoJJ1 7
}KK 
;KK 
boolLL 
registroRealizadoLL *
=LL+ ,
	ServiciosLL- 6
.LL6 7
ServicioJugadorLL7 F
.LLF G
RegistrarJugadorLLG W
(LLW X
nuevoJugadorMM $
)MM$ %
;MM% &
ifOO 
(OO 
registroRealizadoOO )
)OO) *
{PP 
temporizadorQQ $
.QQ$ %
DetenerTemporizadorQQ% 8
(QQ8 9
)QQ9 :
;QQ: ;

MessageBoxRR "
.RR" #
ShowRR# '
(RR' (

PropertiesRR( 2
.RR2 3
	ResourcesRR3 <
.RR< =@
4ETIQUETA_VERIFICACIONCORREO_MENSAJEUSUARIOREGISTRADOSS P
,SSP Q

PropertiesSSR \
.SS\ ]
	ResourcesTT %
.TT% &9
-ETIQUETA_VERIFICACIONCORREO_REGISTROREALIZADOTT& S
,TTS T
MessageBoxButtonUU ,
.UU, -
OKUU- /
)UU/ 0
;UU0 1
VentanaPrincipalVV (
.VV( )
CambiarPaginaVV) 6
(VV6 7
newVV7 :
PaginaInicioSesionVV; M
(VVM N
)VVN O
)VVO P
;VVP Q
}WW 
elseXX 
{YY 

MessageBoxZZ "
.ZZ" #
ShowZZ# '
(ZZ' (

PropertiesZZ( 2
.ZZ2 3
	ResourcesZZ3 <
.ZZ< =B
6ETIQUETA_VERIFICACIONCORREO_MENSAJEREGISTRONOREALIZADO[[ R
,[[R S

Properties\\ &
.\\& '
	Resources\\' 0
.\\0 15
)ETIQUETA_VERIFICACIONCORREO_ERRORREGISTRO\\1 Z
,\\Z [
MessageBoxButton]] ,
.]], -
OK]]- /
)]]/ 0
;]]0 1
}^^ 
}__ 
else`` 
{aa 

MessageBoxbb 
.bb 
Showbb #
(bb# $

Propertiesbb$ .
.bb. /
	Resourcesbb/ 8
.bb8 9?
3ETIQUETA_VERIFICACIONCORREO_MENSAJECODIGOINCORRECTOcc K
,ccK L

Propertiesdd "
.dd" #
	Resourcesdd# ,
.dd, -8
,ETIQUETA_VERIFICACIONCORREO_CODIGOINCORRECTOdd- Y
,ddY Z
MessageBoxButtonee (
.ee( )
OKee) +
)ee+ ,
;ee, -
}ff 
}gg 
}hh 	
privatejj 
voidjj *
AceptarSoloCaracteresNumericosjj 3
(jj3 4
objectjj4 :
objetoOrigenjj; G
,jjG H 
TextChangedEventArgskk  
eventokk! '
)kk' (
{ll 	
ifmm 
(mm 
objetoOrigenmm 
ismm 
TextBoxmm  '
)mm' (
{nn 
TextBoxoo 
cuadroTextooo #
=oo$ %
(oo& '
TextBoxoo' .
)oo. /
objetoOrigenoo/ ;
;oo; <
stringpp 
textopp 
=pp 
cuadroTextopp *
.pp* +
Textpp+ /
=pp0 1
newpp2 5
stringpp6 <
(pp< =
cuadroTextopp= H
.ppH I
TextppI M
.ppM N
WhereppN S
(ppS T
charqq 
.qq 
IsDigitqq  
)qq  !
.qq! "
ToArrayqq" )
(qq) *
)qq* +
)qq+ ,
;qq, -
cuadroTextorr 
.rr 

CaretIndexrr &
=rr' (
cuadroTextorr) 4
.rr4 5
Textrr5 9
.rr9 :
Lengthrr: @
;rr@ A
cuadroTextoss 
.ss 
Textss  
=ss! "
textoss# (
;ss( )
}tt 
}uu 	
publicww 
voidww 2
&EnviarNuevoCodigoDeConfirmacionACorreoww :
(ww: ;
objectww; A
objetoOrigenwwB N
,wwN O
RoutedEventArgsxx 
eventoxx "
)xx" #
{yy 	#
GestionadorCodigoCorreozz #
.zz# $2
&EnviarNuevoCodigoDeVerificacionACorreozz$ J
(zzJ K
jugadorRegistro{{ 
.{{  
Correo{{  &
,{{& '

Properties{{( 2
.{{2 3
	Resources{{3 <
.{{< =.
"ETIQUETA_VERIFICACIONCORREO_ASUNTO{{= _
,{{_ `

Properties|| 
.|| 
	Resources|| $
.||$ %/
#ETIQUETA_VERIFICACIONCORREO_MENSAJE||% H
+||I J
$str||K N
+||O P#
GestionadorCodigoCorreo}} '
.}}' (
CodigoGenerado}}( 6
)}}6 7
;}}7 8
IniciarTemporizador~~ 
(~~  
)~~  !
;~~! "
} 	
private
ÅÅ 
void
ÅÅ '
HabilitarBotonEnvioCodigo
ÅÅ .
(
ÅÅ. /
)
ÅÅ/ 0
{
ÇÇ 	
BotonEnviarCodigo
ÉÉ 
.
ÉÉ 
	IsEnabled
ÉÉ '
=
ÉÉ( )
true
ÉÉ* .
;
ÉÉ. /
BotonEnviarCodigo
ÑÑ 
.
ÑÑ 

Foreground
ÑÑ (
=
ÑÑ) *
Brushes
ÑÑ+ 2
.
ÑÑ2 3
White
ÑÑ3 8
;
ÑÑ8 9
}
ÖÖ 	
private
áá 
void
áá *
DeshabilitarBotonEnvioCodigo
áá 1
(
áá1 2
)
áá2 3
{
àà 	
BotonEnviarCodigo
ââ 
.
ââ 
	IsEnabled
ââ '
=
ââ( )
false
ââ* /
;
ââ/ 0
BotonEnviarCodigo
ää 
.
ää 

Foreground
ää (
=
ää) *
Brushes
ää+ 2
.
ää2 3
Black
ää3 8
;
ää8 9
}
ãã 	
}
åå 
}çç Î
yC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Utilidades\GeneradorImagenes.cs
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
}   »
tC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Utilidades\Temporizador.cs
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
public 
int 
segundosRestantes $
;$ %
public 
DispatcherTimer 
temporizador +
;+ ,
public 
void 
IniciarTemporizador '
(' (
)( )
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
public 
void 
DetenerTemporizador '
(' (
)( )
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
} Û
C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Utilidades\GestionadorCodigoCorreo.cs
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
}$$ ∂
rC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\VentanaPrincipal.xaml.cs
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
}00 ≤
tC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\RompecabezasFei\Properties\AssemblyInfo.cs
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