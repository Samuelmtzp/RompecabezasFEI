�
xC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Servidor\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 


( 
$str #
)# $
]$ %
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
$str %
)% &
]& '
[
assembly
:

AssemblyCopyright
(
$str
)
]
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
]$$) *�
iC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Servidor\Servidor.cs
	namespace 	
Servidor
 
{ 
public 

class 
Servidor 
{ 
public		 
static		 
void		 
Main		 
(		  
string		  &
[		& '
]		' (
args		) -
)		- .
{

 	
using 
( 
ServiceHost #
servidorRompecabezasFei 6
=7 8
new 
ServiceHost 
(  
typeof  &
(& '#
ServicioRompecabezasFei' >
)> ?
)? @
)@ A
{
try 
{ #
servidorRompecabezasFei +
.+ ,
Open, 0
(0 1
)1 2
;2 3
Console 
. 
	WriteLine %
(% &
$str& 9
)9 :
;: ;
} 
catch 
( (
AddressAccessDeniedException 3
)3 4
{ 
Console 
. 
	WriteLine %
(% &
$str& <
)< =
;= >
} 
Console 
. 
ReadLine  
(  !
)! "
;" #
} 
} 	
} 
} 