﻿using BinaryFog.NameParser;
using NameParser;
using System;
using System.Collections.Generic;

namespace SimpleForDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "RICHARD M HARMON JR"
                ,"RICHARD M"
                ,"HARMON JR"
                ,"Charles Tiberi, Jr"
,"Jose Jimenez"
,"Olga Blanco"
,"Edwin Brown"
,"MARIA-MIREYA M LEDUC"
,"Richard Carroll"
,"MARGARITA VELASQUEZ"
,"WILBERT MELVIN"
,"Irene Sikora"
,"WILLIO JOSEPH"
,"JENNY M CERUZZI"
,"TAMMY SMITH"
,"TRACY NAGELHOUT"
,"CHRISTOPHER COLEMAN"
,"Hector Tovar"
,"Forest Nelson"
,"MARIO CASTILLO"
,"CLIFFORD WRIGHT"
,"JAMES ABRAMSON"
,"LYMARIS PABELLON"
,"GEORGE LEWIS"
,"JAMES NOVAK"
,"SILAS N AUSTIN"
,"Lester Shaffer"
,"Irineo Garay"
,"GERARDO FERREIRA"
,"Sebna Hernandez"
,"Bernadine Parker"
,"Jacqueline Ryan"
,"Timothy Stowes"
,"GLORIA MERA"
,"CHARLES EDWARDS JR"
,"HERNAN D CASTANO"
,"DAVID REPOLGLE"
,"KERI BAUGH"
,"Yordani Pedraza"
,"Jonathan Hernandez-Gonzalez"
,"Spencer Johnson"
,"Kathlene L Bentley"
,"Ryan Schultz"
,"SEBASTIANO GUZZARDI"
,"WILLIAM HENDREN"
,"RAFAEL ESPELETA JR"
,"Benjamin Molenaar"
,"Barbara Geronimo"
,"Donald Crews"
,"DAWN BONETA"
,"Traci Bahr"
,"BARBARA A SHIVERS"
,"Brian Mack"
,"VITO POLERA"
,"INDRY HERNANDEZ MEDINA"
,"DOMINIQUE CORNWELL"
,"ANDRA WALTERS"
,"TREVOR LENZMEIER"
,"DANIEL MACELROY"
,"Milton R Blount"
,"Osmel Fonseca"
,"Antonio Hernandez"
,"Maria Espinoza"
,"Adrian Temali"
,"John Beall"
,"FABIO PAEZ"
,"TERRY DANIEL"
,"Willard Rodgers"
,"JIMMY JONES"
,"WILBUR BUCHANAN"
,"Eric Johnson"
,"Raquel Armendariz"
,"Belinda Borge"
,"Donna Streavel"
,"CARMEN OYUELA"
,"MAURICIO MISCO"
,"AMY REINKE"
,"WILLIAM KARDAS"
,"Cathryn Milby"
,"Pierre Phanor"
,"Eric R Russell"
,"Jennifer L Kasman"
,"BRIAN BECERRA"
,"ANDREA DYAL"
,"LEONNE LOUIS-CHARLES"
,"COREY LANDRUM"
,"JOSEPH PATNELLA"
,"AHILLIA PERMANAN"
,"Francisco Gimenez"
,"Juan R De Leon"
,"Adrian Saez"
,"MARTIN F GONZALEZ"
,"Elizet Cardona"
,"Elaine Hunter"
,"MANUEL MENDEZ"
,"VILMA EDWARDS"
,"IKESHA ROPER"
,"LAVERN RENEA MINTZ"
,"RONESHIA L SWAIN"
,"LUIZ F EBENAU"
,"JACEK MLYNARSKI"
,"ZACHARY GRANT"
,"GREGORY MESSICK"
,"Krystyna Klemba"
,"TRENAY M JEFFERSON"
,"LISA M DRESBACK"
,"Michal Gora"
,"Davina Kinney"
,"GREGORY ROBBINS"
,"JOSEPH TURNER"
,"JAMES HARDENDORF"
,"LUIS RIVERO"
,"AMANDA AYCOCK"
,"Nancy McConnell"
,"Philomene Daniel"
,"Donald J Martin"
,"Delores Campbell"
,"Tresia Baker"
,"Anna K Harrison"
,"JAMES MIMS"
,"JEREMY MURPHREE"
,"EUDELIA RIVERA"
,"CALVIN CHRISTIAN"
,"RUSLAN OLIVERA"
,"MARITZA CABRERA"
,"LAWRENCE J GUYNUP"
,"WARREN HALL"
,"ANGEL RODRIGUEZ"
,"Gary R Orns"
,"John Mort"
,"Montana Loredo"
,"Allison Focht"
,"ROSSANA I GARCIA DE CECA"
,"TINA C GERSTEIN"
,"RICHARD GILL"
,"APRIL GOINS"
,"STEVEN SCHNEIDER"
,"GAIL MULLANEY"
,"Amy Baxter"
,"Jason Barrett"
,"Kelly Ferguson"
,"Shelly M Wise"
,"Davey Andino"
,"Altagracia Rohttis Villaman"
,"JAMES J LANHAM"
,"MYRA DIAZ"
,"KEYONTE BAXTER"
,"Efrain S Mercado"
,"ROBERT STRADER"
,"SANDRA REINER"
,"LESLIE BAVONE"
,"DERRICK BUXTON"
,"MICHAEL R BROWN"
,"Candace Sundby"
,"John Stark"
,"Gilberto Arguelles"
,"David Guzman Jr"
,"Scott Brush"
,"Amanda Deeds"
,"DEBRA POLLETT"
,"ERIC HOLLAN"
,"Jose Alva"
,"JUAN CORTES"
,"STRACY BROWN"
,"EDWARD WEEKS"
,"MARY ZAPATA"
,"GROVER SHELTON"
,"Martin Noblit"
,"Gregory Russell"
,"Kenneth Dye"
,"Vicki L Wilson"
,"TYRONE S GRIFFITHS"
,"Gladis Lopez"
,"TERESA SCHERTZER"
,"TIMOTHY Oconnell"
,"GARY BRESNICK"
,"MICHAEL SAWIN"
,"VICTORIA KOSTER"
,"YOMARY OLIVA"
,"VIKI JACKSON"
,"ANTHONY DOCKERY"
,"RAMONA SUKHANDAN"
,"Jorge Reina"
,"Rigoberto Arteaga"
,"Rapahel G Valdes"
,"Jeremy Colson"
,"Corey Lovett"
,"SCOTT E STEPHENSON"
,"ROSITA A BROOKS"
,"ALEXIS VARGAS"
,"BRIDGETTE HOPKINS"
,"Michael Sizemore"
,"CHANTELE OGLE"
,"YVETTE S GRANNUM"
,"VILMA FLORES"
,"BENNY MENDEZ"
,"GREGORY MATHERLY"
,"Padmore D Samuels"
,"David j Maslanka"
,"Richard Auskalnis"
,"Colleen Urlton"
,"Wilber Frometa"
,"Beth Reed"
,"MAUREEN ANDERSON"
,"WELTON R FRAZER"
,"Lisa A Alwine"
,"DORIS E BECK"
,"PAUL A GLASS"
,"William Nahorodny"
,"EDGARDO VELEZ"
,"DOMENIC KINDBERG"
,"Andrew J Schechinger"
,"Karlene Douglas"
,"Trica L Dickerson"
,"Gloria P Pucher"
,"Roger Lee Edwards"
,"THOMAS A CRAFT"
,"MELISSA CAVENDER"
,"COREEN BROWN"
,"Kaitlin Marshall"
,"Tina Davis"
,"NATALIA SANABRIA"
,"CHRISTINE MARIE MAULE"
,"JASON ROBISON"
,"ANDREW EIFERT"
,"Karin Kirchner"
,"Robert Bergner"
,"Viviana Llanes"
,"Catherine Gage"
,"William Darby"
,"STEPHANIE LOCKHART"
,"COLE DOVER"
,"DENNIS TAJAH"
,"RICARDO ESTEVEZ"
,"JAMES L MONROE"
,"ALAN MOYER"
,"CARLOS JIMENEZ"
,"ERIN SLEEPER"
,"ESMERALDA LUGO"
,"KAMERON BROOK"
,"ANNA W MEDRZYCKI"
,"ALICIA STERLING-TORRES"
,"Maikel Batista"
,"Melius Farncois"
,"Hector Rivera"
,"DONALD GANSNER"
,"AMIRA KORAJKIC"
,"MANUEL BENTON"
,"KIM MCDONALD-MICHEL"
,"TIA EVANS"
,"ERIC CARPENTER"
,"JORGE RIVERA"
,"EDWARD QUINONES"
,"Terri Moak"
,"Dustin Clark"
,"Jose Sifuentes"
,"Christal Cummings"
,"Edwin Lugo Santiago"
,"RICARDO JORDON"
,"ASHLEY HART"
,"BRUCE PELHAM"
,"ARELY RODAS"
,"CELIA CAMPOS RAMIREZ DE CARRERO"
,"VICTOR M COTTO"
,"SHAQUILLA ROSS"
,"ERVIN LIZANO-LOPEZ"
,"Rhonda Tucker"
,"RONALD D GRUBBS"
,"Marquita Helton"
,"ZORAIDA MEDINA"
,"R.B MILLER"
,"MLADENA STOJANOVIC"
,"WILLIAM FRALEIGH"
,"OSHITA TOMOYOSHI"
,"Diana L LaJeunesse"
,"Farides Cantillo"
,"Macorel Exarius"
,"Margaret Nation Cooper"
,"Anthony Blanc"
,"KELA V SIMPSON"
,"VANCE WEST"
,"KATHLEEN DRAPER"
,"FELIX MITCHELL"
,"ROBERT CHERRY"
,"Virginia Sarno"
,"Mindy Skaggs-Sage"
,"MAURICE L ROMERO"
,"MATTHEW RUMPLE"
,"PAMELA TURNER"
,"Renee Pomante"
,"John J Strickland"
,"James Elders"
,"JAMES E BRYANT"
,"Nancy, J Bleytghing Crews"
,"BELEN PAPP"
,"Fazli Fazlija"
,"SHEILA SHERMAN"
,"TESSA ROBERTSON"
,"RYAN VILLAFRANCO"
,"TAMYRA LAHSANGAH"
,"CAROLE KANTOR"
,"CHRISTINE WELCH"
,"TAMMY DOUGLAS"
,"Delayna Blain"
,"DONALD G TARR"
,"Michael B Bennett"
,"CARL BASTIAN"
,"BRITTANY COTRONEO"
,"ALFRED EVANS"
,"Janet Scott"
,"Jesus Tamez"
,"Greg Caldwell"
,"Asha Y Smith"
,"Mark Ellis"
,"Tammy M Crouse"
,"PETER SCHMID"
,"AMY ABRAHAM"
,"JONATHAN STEPHENS"
,"DARLENE HERRICK"
,"Gregory Cooper"
,"Jose Cruz"
,"Vidal Valdiva"
,"Dan Younger"
,"Wendy Bartley"
,"Cande Martinez"
,"Scott Bovee"
,"RONNY YOUNG"
,"JULIO FIGUEROA"
,"TARA EARNS"
,"JAMES JOHNSON"
,"ZAMIR GUNN"
,"RENE MENENDEZ"
,"SUMANA ISLAM"
,"TYLAR WILLIAMS"
,"JAVIER RIVERA RUIZ"
,"James E Shifflett"
,"Kathryn Benson"
,"Daniel F Ryder"
,"MARTHA C GONZALEZ"
,"Elliott Shifman"
,"EUGENIO AGUILAR"
,"Maura Cecilia Jurado"
,"MEGAN PERSONG"
,"JULIE KELLY"
,"BERTO MATA"
,"Delia Fuentes"
,"Steve Imboden"
,"Tyla Covington"
,"Andrew Legg"
,"Rachel Wood"
,"DORA AVILA"
,"CHARLES SIMPSON"
,"HENRY CRUZ"
,"JENNIFER DAWSON"
,"JASON M EMERY"
,"KEITH SPERNAK"
,"Pedro Torres"
,"Armando Valtierra"
,"Deborah L Atrozskin"
,"Victor C Mateo"
,"Patrick Reilley"
,"JENNIFER GOODRICH"
,"Carl Nelson"
,"CLAIRE GAMBALE"
,"CLINTON DEVAULT"
,"ALLISON GARBETT"
,"JASON CUCCHI"
,"ANGELA PANDOLFO"
,"MILDRED T HICKS"
,"Keith Tyler"
,"Joseph Boone"
,"Confesor Garcia Rijo"
,"Amanda Test"
,"Stacy M Blue"
,"JAIME BARAJAS"
,"LILIVETTE PLANTEN"
,"Brandon Santiago"
,"Laura D Hefner"
,"Yara Gomez"
,"Omar Mercado Aguilar"
,"Monica Pesantes"
,"Anabel Delangel"
,"Milious Saint Louis"
,"Cindy Stewart"
,"RAMSES A SILVA"
,"Tara K Toppino"
,"Dennis Rodenhofer"
,"Maria Toledo-Herrera"
,"Deborah Adams"
,"Iara Bonatto Caldeira"
,"Lynn A Munno"
,"Louisi Joseph"
,"RYAN FISCH"
,"DAMON DANESI"
,"DANIEL ROWE"
,"Stephen M Staudt"
,"Gretchen Cook"
,"Gary Romano"
,"ROBERT WOODLAND"
,"JAMES KITTS"
,"BRADLEY COON"
,"MARIA URDANETA-GONZALEZ"
,"Jack Difresco"
,"JALISA RIVERS"
,"Lynda Biegaj"
,"BRITTANY CLEVELAND"
,"Tiffany Sheely"
,"Alan Klingensmith"
,"Jeremiah Huggins"
,"Donna Jennings"
,"Denise Corsetti"
,"Samuel Blasini"
,"Katia Chuleva"
,"JUDY ZUK"
,"RAY CHAPA"
,"Danny Fiber"
,"Pedro Rivera"
,"LINDA STROHM"
,"Keith Stamp"
,"Melius Francois"
,"Maydelin Mesa"
,"Jessica Johnson"
,"David S Kelley"
,"Richard L Long"
,"KIMBERLY SONNENSCHEIN"
,"John Millican"
,"Reynaldo Salinas"
,"JULIO MARTINEZ"
,"ELREY C COLES"
,"MIGUEL CAMACHO"
,"PAUL BABINEAU"
,"Harold Castel"
,"Tamara M Zboril"
,"David Nelson"
,"Meaghan E Towne"
,"Holly Vaughn"
,"Timothy Maietta"
,"JUSTINE FOURNIER"
,"MICHAEL BELL"
,"KEILA SANTIAGO"
,"NORA LEWARK"
,"Claudia Cadena Perez"
,"Marietta Bibbs"
,"OSVALDO PADILLA-MARTINEZ"
,"BEKIRA KURTOVIC"
,"TIM HARPER"
,"JUAN GOMEZ"
,"SAMUEL HILSON"
,"JOSE CARRILLO"
,"Hector Munoz"
,"TEMPEST THOMPSON"
,"EVERTON C MCLEAN"
,"CLAUDIA TABORDA"
,"Bonnie Sandy"
,"CLARENCE OWEN"
,"Richard L Werner"
,"Nancy C Olson"
,"CHRIS O MONTERO"
,"Michael Brown"
,"Elizabeth Stephen"
,"BRIANNA WHITTINGTON"
,"BONNIE S GIULIANI"
,"BLADIMIRO BARRIOS"
,"Ruben Lopez"
,"Daniel Duarte"
,"Christopher J Wood"
,"Patricia Spatcher"
,"Milissa M Morley"
,"Cathy F Bulgar"
,"Miguel Q Paz"
,"XIOMARA LORIE"
,"CORA MCGALLIARD"
,"EUNICE VIDALES"
,"HANS LAFONTANT"
,"Mirella Ramos"
,"Candyce Bearley"
,"WILLIAM E JOHNSTON"
,"Ericka Brown"
,"Ashley Kozlowski"
,"ANTONIA AUSED"
,"KRISTIN STAPLETON"
,"HERVE GRESSY"
,"CRAIG MOORE"
,"Linda Davis"
,"JAMES MARSHBURN"
,"Brooks Cantlay"
,"ANDRES VALLEJO"
,"Ana Carrasco"
,"Arthur Mott Jr"
,"John Ruffner"
,"JOSE FAMANIA"
,"Thermidor Minock"
,"Sharmon Phelps"
,"CLARENCE ODUMS"
,"MICHAEL BRADSHAW"
,"JOHN ROTH"
,"Kelle Dixon"
,"Fernando Aleman"
,"Patrick Stevick"
,"Donald Pierpoint"
,"ROSANNY LAZO VARGAS"
,"ALEJANDRO FERNANDEZ"
,"Ricky A Yarnell"
,"Zulma Golden"
,"Reina Aguilera"
,"Ed Dibeler"
,"Gerardino Figueroa"
,"JESUS D GUEVARA"
,"LOUIS WELLS"
,"VICTOR ORTIZ JR"
,"FRANCISCO GUERRA"
,"Paul D Bober"
,"Michelle L Hewson"
,"Monica Henderson"
,"David Throesch"
,"Elizabeth Owen"
,"MARCELLINE M MESIDOR"
,"GABRIEL OYOQUE"
,"MUGE CENGIL"
,"SUSAN MENNING"
,"Jack Heckman"
,"Marlene Leggett"
,"YELVA LOUISSAINT"
,"ERINE ERIUS"
,"SHRI SATAWAN SHIWPRASAD"
,"JESUS SANTANA"
,"Robert W Rickert"
,"Sharon McGorry"
,"Diane Martini"
,"Julie Harmon"
,"SACARIUS A RAGIN"
,"AMY SALOMONE"
,"Arturo Ruiz"
,"TRAVIS CHAPPEL"
,"REGINA CRANGI"
,"Rashawn L Jones"
,"Doug Smith"
,"Jeffrey Sullivan"
,"Timothy Mitchell"
,"Raymond Soucy"
,"Mary M Newton"
,"Olivia Coleman"
,"MARIO AGUIRRE"
,"BILLY THOMAS"
,"CATINA STINE-SAMPSON"
,"Louis Negron"
,"ALAIN ALVAREZ"
,"Elaine Bishop"
,"Barbara Reyes"
,"Robert Lipford"
,"Jack Hart"
,"Kristie Lavigne"
,"Jeffrey Shreiner"
,"WILLIAM SPANN"
,"JAMES PROUDFOOT"
,"IAN KEMP"
,"CHRISTOPHER HOUSTON"
,"JOSE PACHECO"
,"BRENDA PURSEL"
,"GEORGE SEPCIC"
,"DAVID BERNSTEIN"
,"Abel Perez"
,"William C Hubbs"
,"Matthew Sherman"
,"ROBERT S MCLARTY"
,"VANESSA URREA BUSTOS"
,"ALISHA D HARVEY"
,"Delores Goethe"
,"Sonia Lopez"
,"Jeanne Arnette"
,"Jonathan Gentle"
,"Gary Schoonmaker"
,"EDGAR ORTEGA"
,"ELIZABETH BROWN"
,"TRAMAIN TARVER"
,"DOMINIC S PYZYNSKI"
,"MARK A FAELLA"
,"LAURISTON SAMUEL"
,"RICHARD HURLEY"
,"JENNIFER DERI"
,"MIGUEL PASTRANA"
,"Bernard Keenan"
,"Linda Earley"
,"Kathleen L Cardyn"
,"Adela Lopez"
,"Jacqueline Anderson"
,"Olga Irianty Mcgreevy"
,"WILLARD J MCCULLEN"
,"AMY SOTO"
,"Rafael G Valdes"
,"DAMARIS VARGAS"
,"YANETH A FLORES"
,"ROBERT NICKERAUER"
,"CHRISTOPHER REDDING"
,"JOHN HOLT"
,"John Cannady"
,"TATIANA MACRINSCAIA"
,"Eric Miller"
,"Angela Houdesheldt"
,"Judith Oleary"
,"David Yusupov"
,"KYLE DAVIS"
,"ANN WAIN"
,"RUNGAROON SINGHPRASERT"
,"ZOEY FOOS"
,"Ivelyne Estimond"
,"DAYNA CARTER"
,"RAINA SCOTT"
,"LEONARD TERRY"
,"BRIAN FLOYD"
,"MARYANN TRANSKI"
,"Israel Sierra"
,"Joseph Fordham"
,"Leyda Martinez"
,"Mariela V Aguila"
,"LUCILIA DEFREITAS"
,"JACQUELYN VIBBERT"
,"STEVEN COOK"
,"Patricia Petrov"
,"Richard Brown"
,"Kaytrine Atkins"
,"Candace C Cooney"
,"Steve Berenguer"
,"Gerald Lalanne"
,"ALKA K KHANNA"
,"SUSAN MARINELLI"
,"Thomas A Machie"
,"ERIKA HERNADEZ"
,"STEVEN D REIFEIS"
,"Daniel W Steward"
,"MICHAEL DAVIS"
,"HOWARD NORTHROP"
,"Dontee M Hedger"
,"Eda Jones"
,"Jason Skjordal"
,"ROELOF VAN NIEKERK"
,"Robert T Dunn"
,"Patrick Chervoni"
,"John R Anderson"
,"ANTONIO GARCIA"
,"JEREMY HERNANDEZ"
,"Mary J Johnson"
,"Ann Dougherty"
,"JUAN C PEREZ"
,"WHITNEY WALDEN"
,"JHOAN TZINA"
,"LILIOSA MABAQUIAO"
,"Terri Chase"
,"Charlene M Broa"
,"Christine Seymour"
,"Maribel Ramos"
,"JOSE L SANCHEZ"
,"RICHARD A BARRETT"
,"JACQUELYN COOPER"
,"JOSE VALAZQUEZ"
,"ISRAEL GARCIA-REGALADO"
,"Elaine P Ponzio"
,"Shannon Slaughter"
,"Jose Francisco Flores"
,"Matt Sherman"
,"JOSE E SIBRIAN"
,"Tamara Webster"
,"MIRTA MERRTTE"
,"BRENDA A LEE"
,"ZACARIAS PENA"
,"DANIEL MESA"
,"STEVEN BOLES"
,"TALMADGE WALL"
,"TROY PIPER"
,"Rosaria Trevino"
,"Casey Baughman"
,"German Lopez"
,"Catherine Murphy"
,"Patricia Alvarez"
,"Pamela A Strong"
,"Rani J Chiudina"
,"Lee W Llewellyn"
,"REBECCA FOSTER"
,"KAREN DECKER"
,"TERESA A NORRIS"
,"Manuel Lara Orbeal"
,"Reynaldo Navarro"
,"Leon Bullock"
,"Cesar Contreras"
,"Briania Jenkins"
,"Linda, C Murray"
,"CHRIS CAZAZOS"
,"NATHALIE LAJEUNESSE"
,"JOSEFINA TORRES"
,"Robert Lemere"
,"LINDA DESMARAIS"
,"Julio Gilart"
,"STEVEN LEE"
,"HASANI JACKSON"
,"Tamberla M Ruhlman"
,"JEANNE BATCHELDER"
,"RAMIZA PILAV"
,"DAVID M MAXWELL"
,"TONI PAGAN"
,"Kody Cox"
,"Armando Rodriguez"
,"Carlos E Herrera-Hernandez"
,"Larry F Tiner"
,"Bythine Laster"
,"Juan C Alvarez"
,"Carlos Borrego"
,"MICHELLE WALKER"
,"AARON MYSLINSKI"
,"DERRICK LEWIS"
,"Clifton Green"
,"BLANCA MAS"
,"OSVALDO GONZALEZ"
,"Phillip E Sawyer"
,"Chad Turnbeaugh"
,"VANESSA BYAS"
,"Grant R McCullough"
,"Tiffany Brinlow"
,"Rigoberto Pena"
,"Mayra Valentin"
,"CURTIS ABBOTT"
,"NANCY CARMONA"
,"NOREEN P MAHEU"
,"BEATRICE ZURITA HERNANDEZ"
,"VICTOR COBAS PEREZ"
,"CHRISTIAN ROMAN"
,"BRANDY PISCIUNERI"
,"Jesus Cruz-Flores"
,"Rosita Turrubiartez"
,"Sherri Hubbard"
,"RODRIGO CARMONA"
,"LUIS STELLA-RODRIGUEZ"
,"ALICIA ARGUETA"
,"Leticia Aquino"
,"JOSE CENTENO"
,"PATRICIA HYLTON"
,"MAXIME DEZUME"
,"JOSEPH ULMAN"
,"JOSEPH GUCCIARCO"
            };

            foreach (var item in list)
            {
                Console.WriteLine($"Full name = {item}");
                //NameParserSharp
                var person = new HumanName(item); //("president john 'jack' f kennedy");
                Console.WriteLine($"First {person.First}, Middle {person.Middle} , Last { person.Last}");


                //FOG NameParser
                //string fullName = item; // "Mr. Jack Johnson";
                //FullNameParser target = FullNameParser.Parse(fullName);
                //Console.WriteLine($"First {target.FirstName}, Middle {target.MiddleName} , Last { target.LastName}");

                Console.WriteLine("=================================================");
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
