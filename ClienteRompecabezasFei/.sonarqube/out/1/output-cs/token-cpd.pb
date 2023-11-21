‹#
lC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Registros\Registrador.cs
	namespace 	
	Registros
 
{		 
public

 

class

 
Registrador

 
{ 
public 
static 
ILog 
	GetLogger $
($ %
[% &
CallerFilePath& 4
]4 5
string6 <
nombreArchivo= J
=K L
$strM O
)O P
{ 	
return 

LogManager 
. 
	GetLogger '
(' (
nombreArchivo( 5
)5 6
;6 7
} 	
public 
static 
void 
EscribirRegistro +
(+ ,
	Exception, 5
ex6 8
)8 9
{ 	
string 
rutaArchivo 
=   
ConfigurationManager! 5
.5 6
AppSettings6 A
[A B
$strB M
]M N
;N O
string 
path 
=  
ConfigurationManager .
.. /
AppSettings/ :
[: ;
$str; G
]G H
;H I
try 
{ 
if 
( 
! 
	Directory 
. 
Exists %
(% &
path& *
)* +
)+ ,
	Directory 
. 
CreateDirectory -
(- .
path. 2
)2 3
;3 4

StackTrace 
seguimientoDePila ,
=- .
new/ 2

StackTrace3 =
(= >
)> ?
;? @

StackFrame $
marcoDeSeguimientoDePila 3
=4 5
seguimientoDePila6 G
.G H
GetFrameH P
(P Q
$numQ R
)R S
;S T
string 
metodo 
= $
marcoDeSeguimientoDePila  8
.8 9
	GetMethod9 B
(B C
)C D
.D E
NameE I
;I J
string 
clase 
= $
marcoDeSeguimientoDePila 7
.7 8
	GetMethod8 A
(A B
)B C
.C D
DeclaringTypeD Q
.Q R
FullNameR Z
;Z [
string 
rutaArchivoActual (
=) *
Path+ /
./ 0
Combine0 7
(7 8
Environment8 C
.C D
CurrentDirectoryD T
,T U
$"V X
{X Y
claseY ^
}^ _
$str_ `
{` a
metodoa g
}g h
$strh k
"k l
)l m
;m n
string 
nombreExcepcion &
=' (
ex) +
.+ ,
GetType, 3
(3 4
)4 5
.5 6
Name6 :
;: ;
using   
(   
StreamWriter   #
escritorTextoPlano  $ 6
=  7 8
new  9 <
StreamWriter  = I
(  I J
rutaArchivo  J U
,  U V
true  W [
)  [ \
)  \ ]
{!! 
string"" 
mensajeFinal"" '
=""( )
$"""* ,
{"", -
Environment""- 8
.""8 9
NewLine""9 @
}""@ A
{""A B
DateTime""B J
.""J K
Now""K N
}""N O
$str""O P
"""P Q
+""R S
$"## 
$str## %
{##% &
rutaArchivoActual##& 7
}##7 8
$str##8 :
"##: ;
+##< =
$"$$ 
$str$$ %
{$$% &
nombreExcepcion$$& 5
}$$5 6
$str$$6 A
{$$A B
ex$$B D
.$$D E
Message$$E L
}$$L M
"$$M N
;$$N O
escritorTextoPlano%% &
.%%& '
	WriteLine%%' 0
(%%0 1
mensajeFinal%%1 =
)%%= >
;%%> ?
}&& 
}'' 
catch(( 
((( &
DirectoryNotFoundException(( -&
directoryNotFoundException((. H
)((H I
{)) 
throw** 
new** 
	Exception** #
(**# $&
directoryNotFoundException**$ >
.**> ?
Message**? F
)**F G
;**G H
}++ 
},, 	
}.. 
}// š
xC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Registros\Properties\AssemblyInfo.cs
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
]$$) *
[%% 
assembly%% 	
:%%	 

log4net%% 
.%% 
Config%% 
.%% 
XmlConfigurator%% )
(%%) *
Watch%%* /
=%%0 1
true%%1 5
)%%5 6
]%%6 7