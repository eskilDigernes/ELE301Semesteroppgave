**********************************************************************************************************************
Programmet SENTRAL
**********************************************************************************************************************
SENTRAL skal ha følgende funksjoner:
• Administrasjon (legge til / slette / endre) av brukerinformasjon i systemet (personer med 
adgangskort) og for kortleserne
• For hver bruker skal det lagres følgende informasjon:
• Etternavn 
• Fornavn 
• Epost-adresse 
• KortID [4 siffer] 
• Gyldighetsperiode for kort [dato og klokkeslett] (start og slutt) – default er "alltid gyldig". 
• PIN [4 tegn, brukerdefinert eller generert som tilfeldig sekvens]
• For hver kortleser lagres:
• Nummer [4 siffer]
• Plassering - et romnummer (rom det gis tilgang til) oppgis (du kan selv bestemme 
romnummerformat)
• Mottak av forespørsler fra en KORTLESER-prosess om validering av et kortID / PINkodekombinasjon, dvs. at den skal:
• plukke ut de nødvendige data fra meldingen, 
• undersøke om denne kombinasjonen er en registrert bruker med gyldig kort- og PIN-kode, 
• samt sende en kvittering tilbake med resultatet.
Det skal lagres informasjon om alle innpasserings-forespørsler, både godkjente og ikkegodkjente.
• Mottak av eventuelle alarmer fra kortleserne:
• dør brutt opp
• dør åpen for lenge
Ved mottak av en alarm skal det skrives ut en melding på skjermen med alarmtype, hvilken dør 
den kom fra (se nedenfor), tidspunkt for mottaket og kortID som sist ble brukt (før eller når alarmen 
ble utløst). Informasjon om dette skal også lagres.
• SENTRAL-prosessen skal kunne generere ulike rapporter:
• liste brukerdata på grunnlag av brukernavn
• liste adgangslogg (inkludert forsøk på adgang) på grunnlag av brukernavn og datoer fra – til
• liste alle innpasseringsforsøk for en dør med ikke-godkjent adgang (uansett bruker)
• liste av alarmer mellom to datoer
• for et rom: første og siste adgang («brukstid») (for dager det har vært i bruk)
Av hensyn til testbarhet skal SENTRAL leveres med fire forhåndsregistrerte brukere:
KortID. PINkode
0000 0000
1111 0001
2222 0010
3333 0011


**********************************************************************************************************************
Programmet KORTLESER
**********************************************************************************************************************
Prosessen KORTLESER skal simulere brukeraktiviteter i adgangskontrollsystemet (sammen med 
«SimSim»). Den skal:
• ha brukergrensesnitt der det kan registreres et kortlesernummer når prosessen starter
• ha brukergrensesnitt som viser dørstatus informasjon (dør låst/ulåst, dør åpen/lukket, alarmer, 
…). Den skal være konsistent med passende indikatorer på sensorkortet som er koblet til 
prosessen 
• kunne motta meldingene fra kortet
• kunne sende meldinger til kortet for å slå passende digital inn/utgang på og av (se avsnittet om 
simulering for mer detaljer) på sensorkortet
• kommunisere adgangsforespørsler til og motta svar fra prosessen SENTRAL
• ha brukergrensesnitt som gir mulighet til å se den siste adgangsforespørselen og (SENTRALens)
svar på den 
• aktivere/stoppe «dør åpen for lenge» alarmer når det oppstår behov for det (blant annet må 
prosessen passe på at døren ikke står åpen for lenge)
• kommunisere alarmrelatert informasjon til sentralen
• låse døren etter at den er lukket
SimSim programmet:
Følgende skal simuleres ved hjelp av sensorkortsimulator (SimSim) - se kortdokumentasjon (vedlegg 
for SimSim) for mer info (digitale utganger er felt e i SimSim melding, de kan oppdateres via GUI og 
ved å sende kommandoer fra kortleser):
• digital utgang e4 skal brukes for å simulere adgangsforsøk. Når e4 settes i tilstand «på», har 
brukeren 45 sekunder til å oppgi kort-id og PIN. Prosessen KORTLESER skal etter 45 sekunder 
sette e4 i tilstand «av».
• digitale utganger e0 – e3 skal simulere tastaturpanel med fire siffer (’0’ – ’3’). Et tastetrykk skal 
simuleres ved at brukeren setter en digitalutgang i tilstand «på» og prosessen KORTLESER setter 
den tilbake i tilstand «av» (etter en mottatt melding)
o Av praktiske grunner skal vi ikke simulere andre sifre, men merk at denne begrensningen 
ikke skal gjelde for SENTRAL-prosessen
Alternativt (i stedet for forrige to punkt) kan du implementere mulighet for inntasting av kort-id og 
PIN i (for eksempel to tekstfelt i) kortleserprosessen.
• digital utgang e5 skal indikere at døren låst (tilstand «på») eller at og døren ulåst (tilstand «av»)
• digital utgang e6 skal indikere døren åpen (tilstand «på»), og døren lukket (tilstand «av»)
• digital utgang e7 skal indikere alarm – uansett grunn (tilstand «på» for «alarm på», tilstand «av»
for normaltilstand)
• potensiometer «F» med verdi over 500 skal representere «dør brutt opp»-signalet
