Det här är det viktigaste. Finns massor mer på: http://en.wikibooks.org/wiki/LaTeX

## Moduler ##
Stora projekt delas med fördel upp i flera .tex-filer. Dessa kan sen inkluderas i huvuddokumentet med:
```
\input{filnamn}
```

Hela pdf:er kan inkluderas med:
```
\includepdf{filnamn}
```

Kompilera helst dokumentet med pdflatex.

## Dokumentstruktur ##
Dokument kan struktureras i massor med olika rubriker. Vanligtvis:
```
\section{En avsnittsrubrik}
\subsection{En underavsnittsrubrik}
\subsubsection{En liten rubrik}
```

Stora dokument använder också kapitel:
```
\chapter{Ett kapitel}
```

Använd \\ för new line och \\\\ för nytt stycke:
```
Det här är ett stycke.\\\\

Det här är nästa stycke...
```

## Formatering ##
Vanlig textformatering:
```
\emph{emphasize this}
\textit{in italics}
\textbf{this is bold}

Creates a nice ``quote" in Latex

\begin{verbatim}
//För stycken med källkod.
\end{verbatim}
```

## Kommentarer ##
```
% Det här är en latex-kommentar

\begin{comment}
Det här är också en latex-kommentar
som kan vara flera rader lång.
\end{comment}
```

## Referenser - Källor ##
Man kan med fördel använda BIBTex för att hantera referenser. Man lägger in alla referenser i en fil (.bib) enligt: http://en.wikibooks.org/wiki/LaTeX/Bibliography_Management#BibTeX och använder sen:
```
\cite{sugiyama}
```

med inlagt namn på referensen för att referera i löpande text.

## Ekvationer ##
Latex utvecklades för att typsätta matematiska texter. Mitt i en text $\eta=5$. Som en ekvation:
```
\begin{equation}
\label{apa}
   apa = \frac{bepa}{cepa}
\end{equation}
```

Ekvationssystem:
```
\begin{equation}
\label{a1}
\begin{cases}
    u=0\\
    u=1\\
    u=\frac{v+b}{a} \implies v=u a-b
\end{cases}
\end{equation}
```

För symboler och massor annat om math i latex: http://en.wikibooks.org/wiki/LaTeX/Mathematics#List_of_Mathematical_Symbols

## Referenser - Internt ##
Latex är bra på interna referenser. Enklast lägger man in en label i vad som helst (bilder, ekvationer, stycken, kapitel) och kan sen referera till den. Exempel med ekvation:
```
\begin{equation}
\label{einstein}
E = m c^2
\end{equation}

"Enligt (\ref{einstein}) är..."
```

## Bilder ##
Pdflatex hanterar png och pdf (ej jpg). Infoga bild med:

```
\begin{figure}[h]
    \begin{center}
    \includegraphics[width=0.75\textwidth]{ex4a.png}
    \caption{\label{ap1}
Nullclines for our model given by (\ref{a1}). And by
(\ref{a2}) - dashed lines.}
    \end{center}
\end{figure}
```

Använd H istället för h för att tvinga bilden att dyka upp där den är inlagd i texten.